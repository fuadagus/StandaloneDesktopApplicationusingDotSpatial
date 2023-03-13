using DotSpatial.Controls;
using DotSpatial.Symbology;
using System.Data;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splcDataOperation_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void map1_Load(object sender, EventArgs e)
        {

            //AddLayer() method is used to add a shape file in the MapControl.
            map1.AddLayer();

        }

        private void clearMapToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Clear() method is used to clear the layers from the map control.
            map1.Layers.Clear();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close this application?", "Admin", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //Close() method is used to close the application.
                this.Close();
            }
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map1.ZoomIn();
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map1.ZoomOut();
        }

        private void zoomExtentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map1.ZoomToMaxExtent();
        }

        private Map GetMap1()
        {
            return map1;
        }

        private void btnDisplayStateName_Click(object sender, EventArgs e, Map map1)
        {
            //Check the number of layers from MapControl
            if (map1.Layers.Count > 0)
            {
                //Declare a MapPolygonLayer
                MapPolygonLayer stateLayer = default(MapPolygonLayer);
                //TypeCast the first layer from MapControl to MapPolygonLayer.
                //Layers are 0 based, therefore 0 is going to grab the first layer from the MapControl
                stateLayer = (MapPolygonLayer)map1.Layers[0];
                //Check whether stateLayer is polygon layer or not
                if (stateLayer == null)
                {
                    MessageBox.Show("The layer is not a polygon layer.");
                }
                else
                {
                    IFeatureLayerExtensions.AddLabels(stateLayer, "[STATE_NAME]", new Font("Tahoma", (float)8.0), Color.Black);
                }
            }
            else
            {
                MessageBox.Show("Please add a layer to the map.");
            }
        }

        private void btnDisplayStateName_Click(object sender, EventArgs e)
        {
            //Check the number of layers from MapControl
            if (map1.Layers.Count > 0)
            {
                //Declare a MapPolygonLayer
                MapPolygonLayer stateLayer = default(MapPolygonLayer);
                //TypeCast the first layer from MapControl to MapPolygonLayer.
                //Layers are 0 based, therefore 0 is going to grab the first layer from the MapControl
                stateLayer = (MapPolygonLayer)map1.Layers[0];
                //Check whether stateLayer is polygon layer or not
                if (stateLayer == null)
                {
                    MessageBox.Show("The layer is not a polygon layer.");
                }
                else
                {
                    //add StateName as labels on the stateLayer
                    //[STATE_NAME] is an attribute from the given example US States shape file.
                    IFeatureLayerExtensions.AddLabels(stateLayer, "[STATE_NAME]", new Font("Tahoma", (float)8.0), Color.Black);
                }
            }
            else
            {
                MessageBox.Show("Please add a layer to the map.");
            }
        }

        private void btnFilterByStateName_Click(object sender, EventArgs e)
        {
            //Check the number of layers from MapControl
            if (map1.Layers.Count > 0)
            {
                //Declare a MapPolygonLayer
                MapPolygonLayer stateLayer = default(MapPolygonLayer);
                //TypeCast the first layer from MapControl to MapPolygonLayer.
                //Layers are 0 based, therefore 0 is going to grab the first layer from the MapControl
                stateLayer = (MapPolygonLayer)map1.Layers[0];
                //Check whether stateLayer is polygon layer or not
                if (stateLayer == null)
                {
                    MessageBox.Show("The layer is not a polygon layer.");
                }
                else
                {
                    //SelectByAttribute method is used to implement the filter operations.
                    //In this example, STATE_NAME is used implement the filter operation
                    //We can see the IdhoSate on the map
                    stateLayer.SelectByAttribute("[STATE_NAME] = 'Idaho'");
                }
            }
            else
            {
                MessageBox.Show("Please add a layer to the map.");
            }
        }

        private void btnFilterByPopUpState_Click(object sender, EventArgs e)
        {

            //check the number of layers from map control
            if (map1.Layers.Count > 0)
            {
                //Delacre a MapPolygonLayer
                MapPolygonLayer stateLayer = default(MapPolygonLayer);
                //Type cast the FirstLayer of MapControl to MapPolygonLayer
                stateLayer = (MapPolygonLayer)map1.Layers[0];
                //Check the MapPolygonLayer ( Make sure that it has a polygon layer)
                if (stateLayer == null)
                {
                    MessageBox.Show("The layer is not a polygon layer.");
                }
                else
                {
                    //this will load the attribute table of the layer into memory.
                    stateLayer.DataSet.FillAttributes();
                    //Create a new PolygonScheme
                    PolygonScheme scheme = new PolygonScheme();
                    //Create a new PolygonCategory
                    PolygonCategory category = new PolygonCategory(Color.Yellow, Color.Red, 1);
                    //Declare a filter string
                    //[POP1990],[STATE_NAME] are attributes from the attribute table of the given shape file.
                    string filter = "[POP1990] > 10000000 OR [STATE_NAME] = 'Idaho'";
                    //Set/Assign the filter expression to PolygonCategory
                    category.FilterExpression = filter;
                    //Set the Legend Text
                    category.LegendText = "population > 10 Million";
                    //Add the PolygonCategory in to the PolygonScheme
                    scheme.AddCategory(category);
                    //Set the scheme in to the MapPolygonLayer's symbology
                    stateLayer.Symbology = scheme;
                }
            }
            else
            {
                MessageBox.Show("Please add a layer to the map.");
            }
        }

        private void btnRandomColors_Click(object sender, EventArgs e)
        {
            //check the number of layers from map control
            if (map1.Layers.Count > 0)
            {
                //Delacre a MapPolygonLayer
                MapPolygonLayer stateLayer = default(MapPolygonLayer);
                //Type cast the FirstLayer of MapControl to MapPolygonLayer
                stateLayer = (MapPolygonLayer)map1.Layers[0];
                //Check the MapPolygonLayer ( Make sure that it has a polygon layer)
                if (stateLayer == null)
                {
                    MessageBox.Show("The layer is not a polygon layer.");
                }
                else
                {
                    //Create a new PolygonScheme
                    PolygonScheme scheme = new PolygonScheme();
                    //Set the ClassificationType for the PolygonScheme via EditorSettings
                    scheme.EditorSettings.ClassificationType = ClassificationType.UniqueValues;
                    //Set the UniqueValue field name
                    //Here STATE_NAME would be the Unique value field
                    scheme.EditorSettings.FieldName = "STATE_NAME";
                    //create categories on the scheme based on the attributes table and field name
                    //In this case field name is STATE_NAME
                    scheme.CreateCategories(stateLayer.DataSet.DataTable);
                    //Set the scheme to stateLayer's symbology
                    stateLayer.Symbology = scheme;
                }
            }
            else
            {
                MessageBox.Show("Please add a layer to the map.");
            }
        }

        private void btnFilterByPopulation_Click(object sender, EventArgs e)
        {
            double number;
            //Validating the textbox input.
            if (string.IsNullOrEmpty(txtPopulation.Text) || !double.TryParse(txtPopulation.Text, out number))
            {
                MessageBox.Show("Please enter a valid value", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPopulation.Text = "";
            }
            else
            {

                //Call the filterbyPopulation method.
                //We need to pass an interger intput paramter,
                // Therefore, I just implemented integer typecasting.
                //filterbyPopulation(Convert.ToInt32(txtPopulation.Text.ToString()));
            }
        }

        private void btnViewAttributes_Click(object sender, EventArgs e)
        {
            //Declare a datatable
            DataTable dt = null;
            if (map1.Layers.Count > 0)
            {
                MapPolygonLayer stateLayer = default(MapPolygonLayer);
                stateLayer = (MapPolygonLayer)map1.Layers[0];
                if (stateLayer == null)
                {
                    MessageBox.Show("The layer is not a polygon layer.");
                }
                else
                {
                    //Get the shapefile's attribute table to our datatable dt
                    dt = stateLayer.DataSet.DataTable;
                    dgvAttributeTable.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Please add a layer to the map");
            }

        }

        private void dgvAttributeTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                foreach (DataGridViewRow row in dgvAttributeTable.SelectedRows)
                {
                    MapPolygonLayer stateLayer = default(MapPolygonLayer);
                    stateLayer = (MapPolygonLayer)map1.Layers[0];
                    if (stateLayer == null)
                    { MessageBox.Show("The layer is not a polygon layer."); }
                    else
                    {
                        stateLayer.SelectByAttribute("[STATE_NAME] =" + "'" + row.Cells["STATE_NAME"].Value + "'");
                    }
                }
            }
        }

        private void loadMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AddLayer() method is used to add a shape file in the MapControl.
            map1.AddLayer();
        }

        private void legend1_Click(object sender, EventArgs e)
        {

        }
    }
}