using DotSpatial.Controls;
namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void grbOperations_Enter(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            //Info function is used to get the information of the selected shape
            map1.FunctionMode = FunctionMode.Info;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip btnToolTip = new ToolTip();
            btnToolTip.SetToolTip(btnLoad, "Shift + L");
            btnToolTip.SetToolTip(btnZoomIn, "Shift + I");
            btnToolTip.SetToolTip(btnZoomOut, "Shift + O");
            btnToolTip.SetToolTip(btnClear, "Shift + C");
            btnToolTip.SetToolTip(btnZoomToExtent, "Shift + E");
            btnToolTip.SetToolTip(btnLoad, "Shift + L");
            btnToolTip.SetToolTip(btnInfo, "Shift + f");
            btnToolTip.SetToolTip(btnMeasure, "Shift + M");
            btnToolTip.SetToolTip(btnSelect, "Shift + S");
            btnToolTip.SetToolTip(btnNone, "Shift + N");
            btnToolTip.SetToolTip(btnPan, "Shift + N");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //AddLayer method is used to add shape layers
            map1.AddLayer();
        }

        private void btnCLear_Click(object sender, EventArgs e)
        {
            //ClearLayers method is used to remove all the layers from the mapcontrol
            map1.ClearLayers();
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            //ZoomIn method is used to ZoomIn the shape file
            map1.ZoomIn();
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            //ZoomOut method is used to ZoomIn the shape file
            map1.ZoomOut();
        }

        private void btnZoomToExtent_Click(object sender, EventArgs e)
        {
            //ZoomToMaxExtent method is used to Extent the shape file
            map1.ZoomToMaxExtent();
        }

        private void btnPan_Click(object sender, EventArgs e)
        {
            //Pan function is used to pan the map
            map1.FunctionMode = FunctionMode.Pan;
        }

        private void btnMeasure_Click(object sender, EventArgs e)
        {
            //Measure function is used to measure the distance and area
            // map1.FunctionMode = FunctionMode.Measure;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //Select function is used to select a shape on the shape file
            map1.FunctionMode = FunctionMode.Select;
        }

        private void btnNone_Click(object sender, EventArgs e)
        {
            //None function is used to change the mouse cursor to default
            map1.FunctionMode = FunctionMode.None;
        }
    }
}