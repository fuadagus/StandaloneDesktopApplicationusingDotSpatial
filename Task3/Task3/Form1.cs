using DotSpatial.Controls;
using DotSpatial.Data;
using DotSpatial.Symbology;
using DotSpatial.Topology;
using System.Data;
using Microsoft.Office.Interop.Excel;
using NetTopologySuite.Geometries.Implementation;
using NetTopologySuite.Geometries;
using GeoAPI.Geometries;

namespace Task3
{
    public partial class Form1 : Form
    {
        String shapeType;
        #region Point ShapeFile class level variable
        //the new point feature set
        FeatureSet pointF = new FeatureSet(DotSpatial.Data.FeatureType.Point);
        //the id of point
        int pointID = 0;
        //to differentiate the right and left mouse click
        bool pointmouseClick = false;
        #endregion

        #region Polyline ShapeFile class level variables
        MapLineLayer lineLayer = default(MapLineLayer);
        //the line feature set
        FeatureSet lineF = new FeatureSet(DotSpatial.Data.FeatureType.Line);
        int lineID = 0;
        //boolean variable for first time mouse click
        bool firstClick = false;
        //It controls the drawing the polyline after the polyline saved operation.
        bool linemouseClick = false;
        #endregion

        #region Polygon ShapeFile class level variables
        FeatureSet polygonF = new FeatureSet(DotSpatial.Data.FeatureType.Polygon);
        int polygonID = 0;
        bool polygonmouseClick = false;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void createPointShapefileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Change the cursor style
            map1.Cursor = Cursors.Cross;
            //set the shape type to the classlevel string variable
            //we are going to use this variable in select case statement
            shapeType = "Point";
            //set projection
            pointF.Projection = map1.Projection;
            //initialize the featureSet attribute table
            DataColumn column = new DataColumn("ID");
            pointF.DataTable.Columns.Add(column);
            //add the featureSet as map layer
            MapPointLayer pointLayer = (MapPointLayer)map1.Layers.Add(pointF);
            //Create a new symbolizer
            PointSymbolizer symbol = new PointSymbolizer(Color.Red, DotSpatial.Symbology.PointShape.Ellipse, 12);
            //Set the symbolizer to the point layer
            pointLayer.Symbolizer = symbol;
            //Set the legentText as point
            pointLayer.LegendText = "point";
            //Set left mouse click as true
            pointmouseClick = true;
        }

        private void map1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (shapeType)
            {
                case "Point":
                    if (e.Button == MouseButtons.Left)
                    {
                        if ((pointmouseClick))
                        {
                            //This method is used to convert the screen cordinate to map coordinate
                            //e.location is the mouse click point on the map control
                            //   Console.WriteLine(map1.PixelToProj(e.Location).ToString);
                            //   IPoint titik = new IPoint(map1.PixelToProj(e.Location));
                            //   var poin = GeometryConverter.ToDotSpatial(titik);

                            //   DotSpatial.Topology.Coordinate coord = poin;
                            //     map1.PixelToProj(e.Location);
                            NetTopologySuite.Geometries.Coordinate coord = map1.PixelToProj(e.Location);

                            //Create a new point
                            //Input parameter is clicked point coordinate
                            NetTopologySuite.Geometries.Point point = new NetTopologySuite.Geometries.Point(coord);
                            //Add the point into the Point Feature
                            //assigning the point feature to IFeature because via it only we can set the attributes.
                            IFeature currentFeature = pointF.AddFeature(point);
                            //increase the point id
                            pointID = pointID + 1;
                            //set the ID attribute
                            currentFeature.DataRow["ID"] = pointID;
                            //refresh the map
                            map1.ResetBuffer();
                        }
                    }
                    else
                    {
                        //mouse right click
                        map1.Cursor = Cursors.Default;
                        pointmouseClick = false;
                    }
                    break;

                case "line":
                    if (e.Button == MouseButtons.Left)
                    {


                        //left click - fill array of coordinates
                        //coordinate of clicked point
                        /*  NetTopologySuite.Geometries.Coordinate coord = map1.PixelToProj(e.Location);
                     */
                        if (linemouseClick)
                        {
                            //first time left click - create empty line feature
                            FeatureSet lineFeatureSet = new FeatureSet(DotSpatial.Data.FeatureType.Line);

                            List<NetTopologySuite.Geometries.Coordinate> coordList = new List<NetTopologySuite.Geometries.Coordinate>
                                  {
                                   new NetTopologySuite.Geometries.Coordinate(map1.PixelToProj(e.Location)),
                                   new NetTopologySuite.Geometries.Coordinate(map1.PixelToProj(e.Location))
                                   };
                            // var lineP = new NetTopologySuite.Geometries.Prepared.PreparedLineString(coordList.ToArray());
                            // initial feature creation
                            NetTopologySuite.Geometries.LineString newLine = new NetTopologySuite.Geometries.LineString(coordList.ToArray());
                            var lineFeature = lineFeatureSet.AddFeature(newLine);
                            /*      NetTopologySuite.Geometries.Prepared.PreparedLineString
                                  new DotSpatial.Topology.LineString(
                                      coordList.ToArray()));

                            */  // mouse click occurs here and adds a new Coordinate to your Coordinate-list
                            coordList.Add(new NetTopologySuite.Geometries.Coordinate(map1.PixelToProj(e.Location)));

                            // create a new LineString with all of the coordinates
                            lineFeature.Geometry = new NetTopologySuite.Geometries.LineString(coordList.ToArray());
                            //   lineID = lineID + 1;
                            //    lineFeature.DataRow["ID"] = lineID;
                            Console.WriteLine(lineFeature.DataRow.ToString());  


                            /*      if (firstClick)
                                    {

                                      /*  //Create a new List called lineArray.
                                        //This list will store the Coordinates
                                        //We are going to store the mouse click coordinates into this array.
                                        NetTopologySuite.Geometries.Coordinate[] lineArray = new NetTopologySuite.Geometries.Coordinate[lineID+1];
                                        //Create an instance for LineString class.
                                        //We need to pass collection of list coordinates
                                        NetTopologySuite.Geometries.LineString lineGeometry = new NetTopologySuite.Geometries.LineString(lineArray);
                                        //Add the linegeometry to line feature
                                        IFeature lineFeature = lineF.AddFeature(lineGeometry);
                                        //add first coordinate to the line feature
                                       //lineFeature.Add(coord);
                                        //set the line feature attribute
                                        lineID = lineID + 1;
                                       lineFeature.DataRow["LineID"] = lineID;

                                      firstClick = false;
                                    }
                                    else
                                    {
                                        //second or more clicks - add points to the existing feature
                                        IFeature existingFeature = lineF.Features[lineF.Features.Count - 1];
                                     //   existingFeature.Coordinates.Add(coord);
                                        //refresh the map if line has 2 or more points
                                    //    if (existingFeature.Coordinates.Count >= 2)
                                        {
                                            lineF.InitializeVertices();
                                            map1.ResetBuffer();
                                        }
                                    } */
                        }

                    }
                    else
                    {
                        //right click - reset first mouse click
                        firstClick = true;
                        map1.ResetBuffer();
                    }
                    break;

                      /* case "polygon":
                              if (e.Button == MouseButtons.Left)
                              {
                                  //left click - fill array of coordinates
                                  Coordinate coord = map1.PixelToProj(e.Location);
                                  if (polygonmouseClick)
                                  {
                                      //first time left click - create empty line feature
                                      if (firstClick)
                                      {
                                //Create a new List called polygonArray.
                                //this list will store the Coordinates
                                //We are going to store the mouse click coordinates into this array.
                                FeatureSet polygoneFeatureSet = new FeatureSet(DotSpatial.Data.FeatureType.Polygon);
                                List<NetTopologySuite.Geometries.Coordinate> polygonArray = new List<NetTopologySuite.Geometries.Coordinate>() {
                                   new NetTopologySuite.Geometries.Coordinate(map1.PixelToProj(e.Location)),
                                   new NetTopologySuite.Geometries.Coordinate(map1.PixelToProj(e.Location))
                                };
                                   //Create an instance for LinearRing class.
                                   //We pass the polygon List to the constructor of this class
                                 NetTopologySuite.Geometries.LinearRing polygonGeometry = new NetTopologySuite.Geometries.LinearRing(polygonArray.ToArray());
                                          //Add the polygonGeometry instance to PolygonFeature
                                     //     IFeature polygonFeature = polygonF.AddFeature(polygonGeometry);
                                var polygonFeature = polygoneFeatureSet.AddFeature(polygonGeometry);
                                polygonArray.Add(new NetTopologySuite.Geometries.Coordinate(map1.PixelToProj(e.Location)));

                                // create a new LineString with all of the coordinates
                                 polygonFeature.Geometry = new NetTopologySuite.Geometries.Polygon(polygonArray.ToArray());

                                //add first coordinate to the polygon feature
                                //polygonFeature.Coordinates.Add(coord);
                                //set the polygon feature attribute
                                polygonID = polygonID + 1;
                                          polygonFeature.DataRow["PolygonID"] = polygonID;
                                          firstClick = false;
                                      }
                                      else
                                      {
                                          //second or more clicks - add points to the existing feature
                                          IFeature existingFeature = (IFeature)polygonF.Features[polygonF.Features.Count - 1];
                                          existingFeature.UpdateEnvelope(coord);
                                          //refresh the map if line has 2 or more points
                                          if (existingFeature.Coordinate.Count >= 3)
                                          {
                                              //refresh the map
                                              polygonF.InitializeVertices();
                                              map1.ResetBuffer();
                                          }
                                      }
                                  }
                              }
                              else
                              {
                                  //right click - reset first mouse click
                                  firstClick = true;
                              }
                              break;*/

             
            }
        }

        private void savePontShapefileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pointF.SaveAs("point.shp", true);
            MessageBox.Show("The point shapefile has been saved.");
            map1.Cursor = Cursors.Arrow;
        }

        private void createPolylineShapefileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Change the mouse cursor
            map1.Cursor = Cursors.Cross;
            //set shape type
            shapeType = "line";
            //set projection
            lineF.Projection = map1.Projection;
            //initialize the featureSet attribute table
            DataColumn column = new DataColumn("LineID");
            if (!lineF.DataTable.Columns.Contains("LineID"))
            {
                lineF.DataTable.Columns.Add(column);
            }
            //add the featureSet as map layer
            lineLayer = (MapLineLayer)map1.Layers.Add(lineF);
            //Set the symbolizer to the line feature.
            LineSymbolizer symbol = new LineSymbolizer(Color.Blue, 6);
            lineLayer.Symbolizer = symbol;
            lineLayer.LegendText = "line";
            firstClick = true;
            linemouseClick = true;
        }

        private void savePolylineShapefileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lineF.SaveAs("c:\\MW\\line.shp", true);
            MessageBox.Show("The line shapefile has been saved");
            map1.Cursor = Cursors.Arrow;
            linemouseClick = false;
        }

        private void createPolygoneShapefileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //initialize polyline feature set
            map1.Cursor = Cursors.Cross;
            //set shape type
            shapeType = "polygon";
            //set projection
            polygonF.Projection = map1.Projection;
            //initialize the featureSet attribute table
            DataColumn column = new DataColumn("PolygonID");
            if (!polygonF.DataTable.Columns.Contains("PolygonID"))
            {
                polygonF.DataTable.Columns.Add(column);
            }
            //add the featureSet as map layer
            MapPolygonLayer polygonLayer = (MapPolygonLayer)map1.Layers.Add(polygonF);
            PolygonSymbolizer symbol = new PolygonSymbolizer(Color.Green);
            polygonLayer.Symbolizer = symbol;
            polygonLayer.LegendText = "polygon";
            firstClick = true;
            polygonmouseClick = true;
        }

        private void savePolygoneShapefileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            polygonF.SaveAs("c:\\MW\\polygon.shp", true);
            MessageBox.Show("The polygon shapefile has been saved.");
            map1.Cursor = Cursors.Arrow;
            polygonmouseClick = false;
        }

        private void viewAtributeTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Declare a datatable
            System.Data.DataTable dt = null;
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
                    //Set the datagridview datasource from datatable dt
                    dgvAttributeTable.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Please add a layer to the map.");
            }
        }

        private void addAColumnInTheAttributeTebleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Declare a datatable
            System.Data.DataTable dt = null;
            //check the layers
            if (map1.Layers.Count > 0)
            {
                //Declare a mappolygon layer
                MapPolygonLayer stateLayer = default(MapPolygonLayer);
                //Assign the mappolygon layer from the map
                stateLayer = (MapPolygonLayer)map1.Layers[0];
                if (stateLayer == null)
                {
                    MessageBox.Show("The layer is not a polygon layer.");
                }
                else
                {
                    //Get the shapefile's attribute table to our datatable dt
                    dt = stateLayer.DataSet.DataTable;
                    //Add new column
                    DataColumn column = new DataColumn("PercentMales");
                    dt.Columns.Add(column);
                    //calculate values
                    foreach (DataRow row in dt.Rows)
                    {
                        double males = Convert.ToDouble(row["males"]);
                        double females = Convert.ToDouble(row["females"]);
                        double malesPercentage = (males / (males + females)) * 100;
                        row["PercentMales"] = malesPercentage;
                    }
                    //Set the datagridview datasource from datatable dt
                    dgvAttributeTable.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Please add a layer to the map.");
            }
        }

        private void updateAttributeTableInShapefileToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
                    stateLayer.DataSet.Save();
                }
            }
            else
            {
                MessageBox.Show("Please add a layer to the map.");
            }
        }

        private void deleteAColumnInTheAttributeTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Declare a datatable
            System.Data.DataTable dt = null;
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
                    //Remove a column
                    dt.Columns.Remove("PercentMale");
                    //Set the datagridview datasource from datatable dt
                    dgvAttributeTable.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Please add a layer to the map.");
            }
        }

        private void exportAttributeTableToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Declare a datatable
            System.Data.DataTable dt = null;
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
                    //Call the sub ExportToExcel
                    //This sub procedure expects a datatable as an input
                    ExportToExcel(dt);
                }
            }
            else
            {
                MessageBox.Show("Please add a layer to the map.");
            }

            /// <summary>
            /// This sub method is used to create an excel worksheet from the attribute table
            /// </summary>
            /// <param name="objDT">attribute table as a datatable input</param>
            /// <remarks>Click the COM tab of the Add Reference dialog box, and find Microsoft Excel 14 Object Library.</remarks>
            void ExportToExcel(System.Data.DataTable objDT)
            {
                //excel = new Excel.Application();
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                string strFilename = null;
                int intCol = 0;
                int intRow = 0;
                //path for storing excel datasheet
                string strPath = "C:\\2009 Falls\\";
                if (xlApp == null)
                {
                    MessageBox.Show("It appears that Excel is not installed on this machine. This operation requires MS Excel to be installed on this machine.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                try
                {
                    //var _with1 = Microsoft.Office.Interop.Excel.Application();
                    xlApp.SheetsInNewWorkbook = 1;
                    xlApp.Workbooks.Add();
                    // xlApp.Worksheets[1].Select();
                    xlApp.Cells[1, 1] = "Attribute table";
                    //Heading of the excel file
                    //  xlApp.Cells[1, 1].EntireRow.Font.Bold = true;
                    //Add the column names from the attribute table to excel worksheet
                    int intI = 1;
                    for (intCol = 0; intCol <= objDT.Columns.Count - 1; intCol++)
                    {
                        xlApp.Cells[2, intI] = objDT.Columns[intCol].ColumnName;
                        // xlApp.Cells[2, intI].EntireRow.Font.Bold = true;
                        intI += 1;
                    }
                    //Add the data row values from the attribute table to ecxel worksheet
                    intI = 3;
                    int intK = 1;
                    for (intCol = 0; intCol <= objDT.Columns.Count - 1; intCol++)
                    {
                        intI = 3;
                        for (intRow = 0; intRow <= objDT.Rows.Count - 1; intRow++)
                        {
                            xlApp.Cells[intI, intK] = objDT.Rows[intRow].ItemArray[intCol];
                            intI += 1;
                        }
                    }
                    intK += 1;
                    if (strPath.Substring(strPath.Length - 1, 1) != "\\")
                    {
                        strPath = strPath + "\\";
                    }
                    strFilename = strPath + "AttributeTable.xls";
                    xlApp.ActiveCell.Worksheet.SaveAs(strFilename);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
                    xlApp = null;
                    MessageBox.Show("Data's are exported to Excel Succesfully in '" + strFilename + "'", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                // The excel is created and opened for insert value. We most close this excel using this system
                System.Diagnostics.Process[] pro = (System.Diagnostics.Process[])System.Diagnostics.Process.GetProcessesByName("EXCEL");
                foreach (System.Diagnostics.Process i in pro)
                {
                    i.Kill();
                }
            }
        }

        private void printMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DotSpatial.Controls.LayoutForm frm = new DotSpatial.Controls.LayoutForm();
            frm.MapControl = map1;
            frm.Show();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map1.AddLayer();
        }

        private void dgvAttributeTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
