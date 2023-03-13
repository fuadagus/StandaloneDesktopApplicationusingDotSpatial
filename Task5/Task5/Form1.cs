//Required namespaces
using DotSpatial.Symbology;
using DotSpatial.Controls;
using DotSpatial.Data;
using DotSpatial.Topology;
using NetTopologySuite;
namespace Task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            appManager1.LoadExtensions();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadRaster_Click(object sender, EventArgs e)
        {
            //AddRasterLayer() method is used to load the raster layers on the map
            map1.AddRasterLayer();
            map1.ZoomToMaxExtent();
            
        }

        private void btnHillshade_Click(object sender, EventArgs e)
        {
            if (map1.Layers.Count > 0)
            {
                //typecast the first layer to IMapRasterLayer
                IMapRasterLayer layer = (IMapRasterLayer)map1.Layers[0];
                if (layer == null)
                {
                    MessageBox.Show("Please select a raster layer.");
                    return;
                }
                //set the hillshade properties
                layer.Symbolizer.ShadedRelief.ElevationFactor = 1;
                layer.Symbolizer.ShadedRelief.IsUsed = true;
                //refresh the layer display in the map
                layer.WriteBitmap();
            }
            else
            {
                MessageBox.Show("Please add a layer to the map.");
            }
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            if (map1.Layers.Count > 0)
            {
                //change the color of raster
                //typecast the first layer to MapRasterLayer
                IMapRasterLayer layer = (IMapRasterLayer)map1.Layers[0];
                if (layer == null)
                {
                    MessageBox.Show("Please add a raster layer.");
                    return;
                }
                //set the color scheme
                //create an instance for a colorscheme
                ColorScheme scheme = new ColorScheme();
                //create a new category
                ColorCategory category1 = new ColorCategory(2500, 3000, Color.Red, Color.Yellow);
                category1.LegendText = "Elevation 2500 - 3000";
                //add the category to the color scheme
                scheme.AddCategory(category1);
                //create another category
                ColorCategory category2 = new ColorCategory(1000, 2500, Color.Blue, Color.Green);
                category2.LegendText = "Elevation 1000 - 2500";
                scheme.AddCategory(category2);
                //assign new color scheme
                layer.Symbolizer.Scheme = scheme;
                //refresh the layer display in the map
                layer.WriteBitmap();
            }
            else
            {
                MessageBox.Show("Please add a layer to the map.");
            }
        }

        private void btnMultiplyRaster_Click(object sender, EventArgs e)
        {
            //check the number of layers on the map
            if (map1.Layers.Count > 0)
            {
                //typecast the first layer to MapRasterLayer
                IMapRasterLayer layer = (IMapRasterLayer)map1.Layers[0];
                if (layer == null)
                {
                    MessageBox.Show("Please select a raster layer.");
                    return;
                }
                //get the raster dataset
                IRaster demRaster = layer.DataSet;
                //create a new raster with the same dimensions as the original raster
                //rasterOptions is only used by special raster formats. For most rasters it should be array of empty string
                string[] rasterOptions = new string[1];
                //Create a raster layer
                IRaster newRaster = Raster.CreateRaster("multiply.bgd", null, demRaster.NumColumns, demRaster.NumRows, 1, demRaster.DataType, rasterOptions);
                //Bounds specify the cellsize and the coordinates of raster corner
                newRaster.Bounds = demRaster.Bounds.Copy();
                newRaster.NoDataValue = demRaster.NoDataValue;
                newRaster.Projection = demRaster.Projection;
                //multiplication
                for (int i = 0; i <= demRaster.NumRows - 1; i++)
                {
                    for (int j = 0; j <= demRaster.NumColumns - 1; j++)
                    {
                        if (demRaster.Value[i, j] != demRaster.NoDataValue)
                        {
                            newRaster.Value[i, j] = demRaster.Value[i, j] * 2;
                        }
                    }
                }
                //save the new raster to the file
                newRaster.Save();
                //add the new raster to the map
                map1.Layers.Add(newRaster);
            }
            else
            {
                MessageBox.Show("Please add a layer to the map.");
            }
        }

        private void btnReclassify_Click(object sender, EventArgs e)
        {
            //typecast the selected layer to IMapRasterLayer
            IMapRasterLayer layer = (IMapRasterLayer)map1.Layers.SelectedLayer;
            if (layer == null)
            {
                MessageBox.Show("Please select a raster layer.");
            }
            else
            {
                //get the raster dataset
                IRaster demRaster = layer.DataSet;
                //create a new empty raster with same dimension as original raster
                string[] rasterOptions = new string[1];
                IRaster newRaster = Raster.CreateRaster("reclassify.bgd", null, demRaster.NumColumns, demRaster.NumRows, 1, demRaster.DataType, rasterOptions);
                newRaster.Bounds = demRaster.Bounds.Copy();
                newRaster.NoDataValue = demRaster.NoDataValue;
                newRaster.Projection = demRaster.Projection;
                //reclassify raster.
                //values >= specified value will have new value 1
                //values < specified value will have new value 0
                double oldValue = 0;
                //get the specified value from the textbox
                double specifiedValue = Convert.ToDouble(txtElevation.Text);
                for (int i = 0; i <= demRaster.NumRows - 1; i++)
                {
                    for (int j = 0; j <= demRaster.NumColumns - 1; j++)
                    {
                        //get the value of original raster
                        oldValue = demRaster.Value[i, j];
                        if (oldValue >= specifiedValue)
                        {
                            newRaster.Value[i, j] = 1;
                        }
                        else
                        {
                            newRaster.Value[i, j] = 0;
                        }
                    }
                }
                newRaster.Save();
                map1.Layers.Add(newRaster);
            }
        }

        private void chbRaterValue_CheckedChanged(object sender, EventArgs e)
        {
            if (chbRasterValue.Checked)
            {
                IMapRasterLayer rasterLayer = (IMapRasterLayer)map1.Layers.SelectedLayer;
                if ((rasterLayer != null))
                {
                    //set the map cursor to cross
                    map1.Cursor = Cursors.Cross;
                }
                else
                {
                    //if no raster layer is selected, uncheck the checkbox
                    MessageBox.Show("Please select a raster layer.");
                    chbRasterValue.Checked = false;
                }
            }
            else
            {
                //change map cursor back to arrow
                map1.Cursor = Cursors.Arrow;
            }
        }

        private void map1_MouseUp(object sender, MouseEventArgs e)
        {
            if (chbRasterValue.Checked)
            {
                //get the layer selected in the legend
                IMapRasterLayer rasterLayer = (IMapRasterLayer)map1.Layers.SelectedLayer;
                if ((rasterLayer != null))
                {
                    //get the raster data object
                    IRaster raster = rasterLayer.DataSet;
                    //convert mouse position to map coordinate
                    NetTopologySuite.Geometries.Coordinate coord = map1.PixelToProj(e.Location);

                    //convert map coordinate to raster row and column
                    RcIndex rc = raster.Bounds.ProjToCell(coord);
                    int row = rc.Row;
                    int column = rc.Column;
                    //check if clicked point is inside of raster
                    if ((column > 0 & column < raster.NumColumns & row > 0 & row < raster.NumRows))
                    {
                        //get the raster value at row and column
                        double value = raster.Value[row, column];
                        //show the row, column and value in the label
                        lblRasterValue.Text = string.Format("row: {0} column: {1} value: {2}", row, column, value);
                    }
                    else
                    {
                        lblRasterValue.Text = "outside of raster";
                    }
                }
            }
        }
    }
}