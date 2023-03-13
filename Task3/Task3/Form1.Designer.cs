namespace Task3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlOperations = new Panel();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            fileToolStripMenuItem1 = new ToolStripMenuItem();
            shapefileOperationsToolStripMenuItem = new ToolStripMenuItem();
            pointToolStripMenuItem = new ToolStripMenuItem();
            createPointShapefileToolStripMenuItem = new ToolStripMenuItem();
            savePontShapefileToolStripMenuItem = new ToolStripMenuItem();
            polylineToolStripMenuItem = new ToolStripMenuItem();
            createPolylineShapefileToolStripMenuItem = new ToolStripMenuItem();
            savePolylineShapefileToolStripMenuItem = new ToolStripMenuItem();
            polygoneToolStripMenuItem = new ToolStripMenuItem();
            createPolygoneShapefileToolStripMenuItem = new ToolStripMenuItem();
            savePolygoneShapefileToolStripMenuItem = new ToolStripMenuItem();
            mapOptionsToolStripMenuItem = new ToolStripMenuItem();
            defaultToolStripMenuItem = new ToolStripMenuItem();
            informationToolStripMenuItem = new ToolStripMenuItem();
            measurmentToolStripMenuItem = new ToolStripMenuItem();
            zoomInToolStripMenuItem = new ToolStripMenuItem();
            zoomOutToolStripMenuItem = new ToolStripMenuItem();
            zoomToExtentToolStripMenuItem = new ToolStripMenuItem();
            panToolStripMenuItem = new ToolStripMenuItem();
            printMapToolStripMenuItem = new ToolStripMenuItem();
            attributeTableOperationsToolStripMenuItem = new ToolStripMenuItem();
            viewAtributeTableToolStripMenuItem = new ToolStripMenuItem();
            addAColumnInTheAttributeTebleToolStripMenuItem = new ToolStripMenuItem();
            deleteAColumnInTheAttributeTableToolStripMenuItem = new ToolStripMenuItem();
            updateAttributeTableInShapefileToolStripMenuItem = new ToolStripMenuItem();
            exportAttributeTableToExcelToolStripMenuItem = new ToolStripMenuItem();
            pnlAttribute = new Panel();
            dgvAttributeTable = new DataGridView();
            pnlLegend = new Panel();
            legend1 = new DotSpatial.Controls.Legend();
            pnlMap = new Panel();
            map1 = new DotSpatial.Controls.Map();
            pnlOperations.SuspendLayout();
            menuStrip1.SuspendLayout();
            pnlAttribute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttributeTable).BeginInit();
            pnlLegend.SuspendLayout();
            pnlMap.SuspendLayout();
            SuspendLayout();
            // 
            // pnlOperations
            // 
            pnlOperations.Controls.Add(menuStrip1);
            pnlOperations.Dock = DockStyle.Top;
            pnlOperations.Location = new Point(0, 0);
            pnlOperations.Name = "pnlOperations";
            pnlOperations.Size = new Size(800, 39);
            pnlOperations.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, shapefileOperationsToolStripMenuItem, mapOptionsToolStripMenuItem, attributeTableOperationsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadToolStripMenuItem, clearToolStripMenuItem, exitToolStripMenuItem, fileToolStripMenuItem1 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(101, 22);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(101, 22);
            clearToolStripMenuItem.Text = "Clear";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(101, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.Size = new Size(101, 22);
            fileToolStripMenuItem1.Text = "File";
            // 
            // shapefileOperationsToolStripMenuItem
            // 
            shapefileOperationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pointToolStripMenuItem, polylineToolStripMenuItem, polygoneToolStripMenuItem });
            shapefileOperationsToolStripMenuItem.Name = "shapefileOperationsToolStripMenuItem";
            shapefileOperationsToolStripMenuItem.Size = new Size(128, 20);
            shapefileOperationsToolStripMenuItem.Text = "Shapefile Operations";
            // 
            // pointToolStripMenuItem
            // 
            pointToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createPointShapefileToolStripMenuItem, savePontShapefileToolStripMenuItem });
            pointToolStripMenuItem.Name = "pointToolStripMenuItem";
            pointToolStripMenuItem.Size = new Size(124, 22);
            pointToolStripMenuItem.Text = "Point";
            // 
            // createPointShapefileToolStripMenuItem
            // 
            createPointShapefileToolStripMenuItem.Name = "createPointShapefileToolStripMenuItem";
            createPointShapefileToolStripMenuItem.Size = new Size(190, 22);
            createPointShapefileToolStripMenuItem.Text = "Create Point Shapefile";
            createPointShapefileToolStripMenuItem.Click += createPointShapefileToolStripMenuItem_Click;
            // 
            // savePontShapefileToolStripMenuItem
            // 
            savePontShapefileToolStripMenuItem.Name = "savePontShapefileToolStripMenuItem";
            savePontShapefileToolStripMenuItem.Size = new Size(190, 22);
            savePontShapefileToolStripMenuItem.Text = "Save Pont Shapefile";
            savePontShapefileToolStripMenuItem.Click += savePontShapefileToolStripMenuItem_Click;
            // 
            // polylineToolStripMenuItem
            // 
            polylineToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createPolylineShapefileToolStripMenuItem, savePolylineShapefileToolStripMenuItem });
            polylineToolStripMenuItem.Name = "polylineToolStripMenuItem";
            polylineToolStripMenuItem.Size = new Size(124, 22);
            polylineToolStripMenuItem.Text = "Polyline";
            // 
            // createPolylineShapefileToolStripMenuItem
            // 
            createPolylineShapefileToolStripMenuItem.Name = "createPolylineShapefileToolStripMenuItem";
            createPolylineShapefileToolStripMenuItem.Size = new Size(204, 22);
            createPolylineShapefileToolStripMenuItem.Text = "Create Polyline Shapefile";
            createPolylineShapefileToolStripMenuItem.Click += createPolylineShapefileToolStripMenuItem_Click;
            // 
            // savePolylineShapefileToolStripMenuItem
            // 
            savePolylineShapefileToolStripMenuItem.Name = "savePolylineShapefileToolStripMenuItem";
            savePolylineShapefileToolStripMenuItem.Size = new Size(204, 22);
            savePolylineShapefileToolStripMenuItem.Text = "Save Polyline Shapefile";
            savePolylineShapefileToolStripMenuItem.Click += savePolylineShapefileToolStripMenuItem_Click;
            // 
            // polygoneToolStripMenuItem
            // 
            polygoneToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createPolygoneShapefileToolStripMenuItem, savePolygoneShapefileToolStripMenuItem });
            polygoneToolStripMenuItem.Name = "polygoneToolStripMenuItem";
            polygoneToolStripMenuItem.Size = new Size(124, 22);
            polygoneToolStripMenuItem.Text = "Polygone";
            // 
            // createPolygoneShapefileToolStripMenuItem
            // 
            createPolygoneShapefileToolStripMenuItem.Name = "createPolygoneShapefileToolStripMenuItem";
            createPolygoneShapefileToolStripMenuItem.Size = new Size(212, 22);
            createPolygoneShapefileToolStripMenuItem.Text = "Create Polygone Shapefile";
            createPolygoneShapefileToolStripMenuItem.Click += createPolygoneShapefileToolStripMenuItem_Click;
            // 
            // savePolygoneShapefileToolStripMenuItem
            // 
            savePolygoneShapefileToolStripMenuItem.Name = "savePolygoneShapefileToolStripMenuItem";
            savePolygoneShapefileToolStripMenuItem.Size = new Size(212, 22);
            savePolygoneShapefileToolStripMenuItem.Text = "Save Polygone Shapefile";
            savePolygoneShapefileToolStripMenuItem.Click += savePolygoneShapefileToolStripMenuItem_Click;
            // 
            // mapOptionsToolStripMenuItem
            // 
            mapOptionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { defaultToolStripMenuItem, informationToolStripMenuItem, measurmentToolStripMenuItem, zoomInToolStripMenuItem, zoomOutToolStripMenuItem, zoomToExtentToolStripMenuItem, panToolStripMenuItem, printMapToolStripMenuItem });
            mapOptionsToolStripMenuItem.Name = "mapOptionsToolStripMenuItem";
            mapOptionsToolStripMenuItem.Size = new Size(88, 20);
            mapOptionsToolStripMenuItem.Text = "Map Options";
            // 
            // defaultToolStripMenuItem
            // 
            defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            defaultToolStripMenuItem.Size = new Size(156, 22);
            defaultToolStripMenuItem.Text = "Default";
            // 
            // informationToolStripMenuItem
            // 
            informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            informationToolStripMenuItem.Size = new Size(156, 22);
            informationToolStripMenuItem.Text = "Information";
            // 
            // measurmentToolStripMenuItem
            // 
            measurmentToolStripMenuItem.Name = "measurmentToolStripMenuItem";
            measurmentToolStripMenuItem.Size = new Size(156, 22);
            measurmentToolStripMenuItem.Text = "Measurment";
            // 
            // zoomInToolStripMenuItem
            // 
            zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            zoomInToolStripMenuItem.Size = new Size(156, 22);
            zoomInToolStripMenuItem.Text = "Zoom In";
            // 
            // zoomOutToolStripMenuItem
            // 
            zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            zoomOutToolStripMenuItem.Size = new Size(156, 22);
            zoomOutToolStripMenuItem.Text = "Zoom Out";
            // 
            // zoomToExtentToolStripMenuItem
            // 
            zoomToExtentToolStripMenuItem.Name = "zoomToExtentToolStripMenuItem";
            zoomToExtentToolStripMenuItem.Size = new Size(156, 22);
            zoomToExtentToolStripMenuItem.Text = "Zoom to Extent";
            // 
            // panToolStripMenuItem
            // 
            panToolStripMenuItem.Name = "panToolStripMenuItem";
            panToolStripMenuItem.Size = new Size(156, 22);
            panToolStripMenuItem.Text = "Pan";
            // 
            // printMapToolStripMenuItem
            // 
            printMapToolStripMenuItem.Name = "printMapToolStripMenuItem";
            printMapToolStripMenuItem.Size = new Size(156, 22);
            printMapToolStripMenuItem.Text = "Print Map";
            printMapToolStripMenuItem.Click += printMapToolStripMenuItem_Click;
            // 
            // attributeTableOperationsToolStripMenuItem
            // 
            attributeTableOperationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewAtributeTableToolStripMenuItem, addAColumnInTheAttributeTebleToolStripMenuItem, deleteAColumnInTheAttributeTableToolStripMenuItem, updateAttributeTableInShapefileToolStripMenuItem, exportAttributeTableToExcelToolStripMenuItem });
            attributeTableOperationsToolStripMenuItem.Name = "attributeTableOperationsToolStripMenuItem";
            attributeTableOperationsToolStripMenuItem.Size = new Size(157, 20);
            attributeTableOperationsToolStripMenuItem.Text = "Attribute Table Operations";
            // 
            // viewAtributeTableToolStripMenuItem
            // 
            viewAtributeTableToolStripMenuItem.Name = "viewAtributeTableToolStripMenuItem";
            viewAtributeTableToolStripMenuItem.Size = new Size(270, 22);
            viewAtributeTableToolStripMenuItem.Text = "View Atribute table";
            viewAtributeTableToolStripMenuItem.Click += viewAtributeTableToolStripMenuItem_Click;
            // 
            // addAColumnInTheAttributeTebleToolStripMenuItem
            // 
            addAColumnInTheAttributeTebleToolStripMenuItem.Name = "addAColumnInTheAttributeTebleToolStripMenuItem";
            addAColumnInTheAttributeTebleToolStripMenuItem.Size = new Size(270, 22);
            addAColumnInTheAttributeTebleToolStripMenuItem.Text = "Add a column in the attribute teble";
            addAColumnInTheAttributeTebleToolStripMenuItem.Click += addAColumnInTheAttributeTebleToolStripMenuItem_Click;
            // 
            // deleteAColumnInTheAttributeTableToolStripMenuItem
            // 
            deleteAColumnInTheAttributeTableToolStripMenuItem.Name = "deleteAColumnInTheAttributeTableToolStripMenuItem";
            deleteAColumnInTheAttributeTableToolStripMenuItem.Size = new Size(270, 22);
            deleteAColumnInTheAttributeTableToolStripMenuItem.Text = "Delete a column in the attribute table";
            deleteAColumnInTheAttributeTableToolStripMenuItem.Click += deleteAColumnInTheAttributeTableToolStripMenuItem_Click;
            // 
            // updateAttributeTableInShapefileToolStripMenuItem
            // 
            updateAttributeTableInShapefileToolStripMenuItem.Name = "updateAttributeTableInShapefileToolStripMenuItem";
            updateAttributeTableInShapefileToolStripMenuItem.Size = new Size(270, 22);
            updateAttributeTableInShapefileToolStripMenuItem.Text = "Update attribute table in Shapefile";
            updateAttributeTableInShapefileToolStripMenuItem.Click += updateAttributeTableInShapefileToolStripMenuItem_Click;
            // 
            // exportAttributeTableToExcelToolStripMenuItem
            // 
            exportAttributeTableToExcelToolStripMenuItem.Name = "exportAttributeTableToExcelToolStripMenuItem";
            exportAttributeTableToExcelToolStripMenuItem.Size = new Size(270, 22);
            exportAttributeTableToExcelToolStripMenuItem.Text = "Export Attribute table to Excel";
            exportAttributeTableToExcelToolStripMenuItem.Click += exportAttributeTableToExcelToolStripMenuItem_Click;
            // 
            // pnlAttribute
            // 
            pnlAttribute.Controls.Add(dgvAttributeTable);
            pnlAttribute.Dock = DockStyle.Bottom;
            pnlAttribute.Location = new Point(0, 307);
            pnlAttribute.Name = "pnlAttribute";
            pnlAttribute.Size = new Size(800, 143);
            pnlAttribute.TabIndex = 1;
            // 
            // dgvAttributeTable
            // 
            dgvAttributeTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttributeTable.Dock = DockStyle.Fill;
            dgvAttributeTable.Location = new Point(0, 0);
            dgvAttributeTable.Name = "dgvAttributeTable";
            dgvAttributeTable.RowTemplate.Height = 25;
            dgvAttributeTable.Size = new Size(800, 143);
            dgvAttributeTable.TabIndex = 0;
            dgvAttributeTable.CellContentClick += dgvAttributeTable_CellContentClick;
            // 
            // pnlLegend
            // 
            pnlLegend.Controls.Add(legend1);
            pnlLegend.Dock = DockStyle.Left;
            pnlLegend.Location = new Point(0, 39);
            pnlLegend.Name = "pnlLegend";
            pnlLegend.Size = new Size(134, 268);
            pnlLegend.TabIndex = 2;
            // 
            // legend1
            // 
            legend1.BackColor = Color.White;
            legend1.ControlRectangle = new Rectangle(0, 0, 134, 268);
            legend1.Dock = DockStyle.Fill;
            legend1.DocumentRectangle = new Rectangle(0, 0, 187, 428);
            legend1.HorizontalScrollEnabled = true;
            legend1.Indentation = 30;
            legend1.IsInitialized = false;
            legend1.Location = new Point(0, 0);
            legend1.MinimumSize = new Size(5, 5);
            legend1.Name = "legend1";
            legend1.ProgressHandler = null;
            legend1.ResetOnResize = false;
            legend1.SelectionFontColor = Color.Black;
            legend1.SelectionHighlight = Color.FromArgb(215, 238, 252);
            legend1.Size = new Size(134, 268);
            legend1.TabIndex = 0;
            legend1.Text = "legend1";
            legend1.UseLegendForSelection = true;
            legend1.VerticalScrollEnabled = true;
            // 
            // pnlMap
            // 
            pnlMap.Controls.Add(map1);
            pnlMap.Dock = DockStyle.Fill;
            pnlMap.Location = new Point(134, 39);
            pnlMap.Name = "pnlMap";
            pnlMap.Size = new Size(666, 268);
            pnlMap.TabIndex = 3;
            // 
            // map1
            // 
            map1.AllowDrop = true;
            map1.BackColor = Color.White;
            map1.BorderStyle = BorderStyle.Fixed3D;
            map1.CollisionDetection = false;
            map1.Dock = DockStyle.Fill;
            map1.ExtendBuffer = false;
            map1.FunctionMode = DotSpatial.Controls.FunctionMode.None;
            map1.IsBusy = false;
            map1.IsZoomedToMaxExtent = false;
            map1.Legend = legend1;
            map1.Location = new Point(0, 0);
            map1.Name = "map1";
            map1.ProgressHandler = null;
            map1.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
            map1.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
            map1.RedrawLayersWhileResizing = false;
            map1.SelectionEnabled = true;
            map1.Size = new Size(666, 268);
            map1.TabIndex = 0;
            map1.ZoomOutFartherThanMaxExtent = false;
            map1.MouseDown += map1_MouseDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlMap);
            Controls.Add(pnlLegend);
            Controls.Add(pnlAttribute);
            Controls.Add(pnlOperations);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            pnlOperations.ResumeLayout(false);
            pnlOperations.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlAttribute.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAttributeTable).EndInit();
            pnlLegend.ResumeLayout(false);
            pnlMap.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlOperations;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem shapefileOperationsToolStripMenuItem;
        private ToolStripMenuItem pointToolStripMenuItem;
        private ToolStripMenuItem createPointShapefileToolStripMenuItem;
        private ToolStripMenuItem savePontShapefileToolStripMenuItem;
        private ToolStripMenuItem polylineToolStripMenuItem;
        private ToolStripMenuItem createPolylineShapefileToolStripMenuItem;
        private ToolStripMenuItem savePolylineShapefileToolStripMenuItem;
        private ToolStripMenuItem polygoneToolStripMenuItem;
        private ToolStripMenuItem createPolygoneShapefileToolStripMenuItem;
        private ToolStripMenuItem savePolygoneShapefileToolStripMenuItem;
        private ToolStripMenuItem mapOptionsToolStripMenuItem;
        private ToolStripMenuItem defaultToolStripMenuItem;
        private ToolStripMenuItem informationToolStripMenuItem;
        private ToolStripMenuItem measurmentToolStripMenuItem;
        private ToolStripMenuItem zoomInToolStripMenuItem;
        private ToolStripMenuItem zoomOutToolStripMenuItem;
        private ToolStripMenuItem zoomToExtentToolStripMenuItem;
        private ToolStripMenuItem panToolStripMenuItem;
        private ToolStripMenuItem printMapToolStripMenuItem;
        private ToolStripMenuItem attributeTableOperationsToolStripMenuItem;
        private ToolStripMenuItem viewAtributeTableToolStripMenuItem;
        private ToolStripMenuItem addAColumnInTheAttributeTebleToolStripMenuItem;
        private ToolStripMenuItem deleteAColumnInTheAttributeTableToolStripMenuItem;
        private ToolStripMenuItem updateAttributeTableInShapefileToolStripMenuItem;
        private ToolStripMenuItem exportAttributeTableToExcelToolStripMenuItem;
        private Panel pnlAttribute;
        private DataGridView dgvAttributeTable;
        private Panel pnlLegend;
        private DotSpatial.Controls.Legend legend1;
        private Panel pnlMap;
        private DotSpatial.Controls.Map map1;
        private ToolStripMenuItem fileToolStripMenuItem1;
    }
}