namespace Task5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlOperations = new Panel();
            txtElevation = new TextBox();
            chbRasterValue = new CheckBox();
            lblRasterValue = new Label();
            lblElevation = new Label();
            btnReclassify = new Button();
            btnMultiplyRaster = new Button();
            btnChangeColor = new Button();
            btnHillshade = new Button();
            btnLoadRaster = new Button();
            pnlLegend = new Panel();
            legend1 = new DotSpatial.Controls.Legend();
            pnlMap = new Panel();
            map1 = new DotSpatial.Controls.Map();
            appManager1 = new DotSpatial.Controls.AppManager();
            pnlOperations.SuspendLayout();
            pnlLegend.SuspendLayout();
            pnlMap.SuspendLayout();
            SuspendLayout();
            // 
            // pnlOperations
            // 
            pnlOperations.Controls.Add(txtElevation);
            pnlOperations.Controls.Add(chbRasterValue);
            pnlOperations.Controls.Add(lblRasterValue);
            pnlOperations.Controls.Add(lblElevation);
            pnlOperations.Controls.Add(btnReclassify);
            pnlOperations.Controls.Add(btnMultiplyRaster);
            pnlOperations.Controls.Add(btnChangeColor);
            pnlOperations.Controls.Add(btnHillshade);
            pnlOperations.Controls.Add(btnLoadRaster);
            pnlOperations.Dock = DockStyle.Top;
            pnlOperations.Location = new Point(0, 0);
            pnlOperations.Name = "pnlOperations";
            pnlOperations.Size = new Size(441, 86);
            pnlOperations.TabIndex = 0;
            // 
            // txtElevation
            // 
            txtElevation.Location = new Point(73, 31);
            txtElevation.Name = "txtElevation";
            txtElevation.Size = new Size(42, 23);
            txtElevation.TabIndex = 8;
            txtElevation.Text = "3000";
            // 
            // chbRasterValue
            // 
            chbRasterValue.AutoSize = true;
            chbRasterValue.Checked = true;
            chbRasterValue.CheckState = CheckState.Checked;
            chbRasterValue.Location = new Point(247, 34);
            chbRasterValue.Name = "chbRasterValue";
            chbRasterValue.Size = new Size(173, 19);
            chbRasterValue.TabIndex = 7;
            chbRasterValue.Text = "Raster value at clicked point";
            chbRasterValue.UseVisualStyleBackColor = true;
            chbRasterValue.CheckedChanged += chbRaterValue_CheckedChanged;
            // 
            // lblRasterValue
            // 
            lblRasterValue.AutoSize = true;
            lblRasterValue.Location = new Point(247, 56);
            lblRasterValue.Name = "lblRasterValue";
            lblRasterValue.Size = new Size(116, 15);
            lblRasterValue.TabIndex = 6;
            lblRasterValue.Text = "Row: Column: Value:";
            // 
            // lblElevation
            // 
            lblElevation.AutoSize = true;
            lblElevation.Location = new Point(12, 34);
            lblElevation.Name = "lblElevation";
            lblElevation.Size = new Size(58, 15);
            lblElevation.TabIndex = 5;
            lblElevation.Text = "Elevation:";
            lblElevation.Click += label1_Click;
            // 
            // btnReclassify
            // 
            btnReclassify.Location = new Point(121, 31);
            btnReclassify.Name = "btnReclassify";
            btnReclassify.Size = new Size(120, 23);
            btnReclassify.TabIndex = 4;
            btnReclassify.Text = "&Reclassify Raster";
            btnReclassify.UseVisualStyleBackColor = true;
            btnReclassify.Click += btnReclassify_Click;
            // 
            // btnMultiplyRaster
            // 
            btnMultiplyRaster.Location = new Point(326, 5);
            btnMultiplyRaster.Name = "btnMultiplyRaster";
            btnMultiplyRaster.Size = new Size(100, 23);
            btnMultiplyRaster.TabIndex = 3;
            btnMultiplyRaster.Text = "&Multiply Raster";
            btnMultiplyRaster.UseVisualStyleBackColor = true;
            btnMultiplyRaster.Click += btnMultiplyRaster_Click;
            // 
            // btnChangeColor
            // 
            btnChangeColor.Location = new Point(213, 5);
            btnChangeColor.Name = "btnChangeColor";
            btnChangeColor.Size = new Size(93, 23);
            btnChangeColor.TabIndex = 2;
            btnChangeColor.Text = "Change &Color";
            btnChangeColor.UseVisualStyleBackColor = true;
            btnChangeColor.Click += btnChangeColor_Click;
            // 
            // btnHillshade
            // 
            btnHillshade.Location = new Point(130, 5);
            btnHillshade.Name = "btnHillshade";
            btnHillshade.Size = new Size(65, 23);
            btnHillshade.TabIndex = 1;
            btnHillshade.Text = "&Hillshade";
            btnHillshade.UseVisualStyleBackColor = true;
            btnHillshade.Click += btnHillshade_Click;
            // 
            // btnLoadRaster
            // 
            btnLoadRaster.Location = new Point(12, 5);
            btnLoadRaster.Name = "btnLoadRaster";
            btnLoadRaster.Size = new Size(87, 23);
            btnLoadRaster.TabIndex = 0;
            btnLoadRaster.Text = "&Load Raster";
            btnLoadRaster.UseVisualStyleBackColor = true;
            btnLoadRaster.Click += btnLoadRaster_Click;
            // 
            // pnlLegend
            // 
            pnlLegend.BorderStyle = BorderStyle.FixedSingle;
            pnlLegend.Controls.Add(legend1);
            pnlLegend.Dock = DockStyle.Left;
            pnlLegend.Location = new Point(0, 86);
            pnlLegend.Name = "pnlLegend";
            pnlLegend.Size = new Size(130, 324);
            pnlLegend.TabIndex = 1;
            // 
            // legend1
            // 
            legend1.BackColor = Color.White;
            legend1.ControlRectangle = new Rectangle(0, 0, 128, 322);
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
            legend1.Size = new Size(128, 322);
            legend1.TabIndex = 0;
            legend1.Text = "legend1";
            legend1.UseLegendForSelection = true;
            legend1.VerticalScrollEnabled = true;
            // 
            // pnlMap
            // 
            pnlMap.BorderStyle = BorderStyle.Fixed3D;
            pnlMap.Controls.Add(map1);
            pnlMap.Dock = DockStyle.Fill;
            pnlMap.Location = new Point(130, 86);
            pnlMap.Name = "pnlMap";
            pnlMap.Size = new Size(311, 324);
            pnlMap.TabIndex = 2;
            // 
            // map1
            // 
            map1.AllowDrop = true;
            map1.BackColor = Color.White;
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
            map1.Size = new Size(307, 320);
            map1.TabIndex = 0;
            map1.ZoomOutFartherThanMaxExtent = false;
            map1.MouseUp += map1_MouseUp;
            // 
            // appManager1
            // 
            appManager1.Directories = (List<string>)resources.GetObject("appManager1.Directories");
            appManager1.DockManager = null;
            appManager1.HeaderControl = null;
            appManager1.Legend = legend1;
            appManager1.Map = map1;
            appManager1.ProgressHandler = null;
            appManager1.ExtensionsActivating += btnLoadRaster_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 410);
            Controls.Add(pnlMap);
            Controls.Add(pnlLegend);
            Controls.Add(pnlOperations);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            pnlOperations.ResumeLayout(false);
            pnlOperations.PerformLayout();
            pnlLegend.ResumeLayout(false);
            pnlMap.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlOperations;
        private Label lblElevation;
        private Button btnReclassify;
        private Button btnMultiplyRaster;
        private Button btnChangeColor;
        private Button btnHillshade;
        private Button btnLoadRaster;
        private Panel pnlLegend;
        private Panel pnlMap;
        private Label lblRasterValue;
        private TextBox txtElevation;
        private CheckBox chbRasterValue;
        private DotSpatial.Controls.Legend legend1;
        private DotSpatial.Controls.Map map1;
        private DotSpatial.Controls.AppManager appManager1;
    }
}