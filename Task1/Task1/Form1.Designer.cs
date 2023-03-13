namespace Task1
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
            grbOperations = new GroupBox();
            lblTitle = new Label();
            btnInfo = new Button();
            btnLoad = new Button();
            btnClear = new Button();
            btnSelect = new Button();
            btnZoomIn = new Button();
            btnMeasure = new Button();
            btnPan = new Button();
            btnNone = new Button();
            btnZoomOut = new Button();
            btnZoomToExtent = new Button();
            pnlMap = new Panel();
            map1 = new DotSpatial.Controls.Map();
            pnlOperations.SuspendLayout();
            grbOperations.SuspendLayout();
            pnlMap.SuspendLayout();
            SuspendLayout();
            // 
            // pnlOperations
            // 
            pnlOperations.Controls.Add(grbOperations);
            pnlOperations.Dock = DockStyle.Top;
            pnlOperations.Location = new Point(0, 0);
            pnlOperations.Name = "pnlOperations";
            pnlOperations.Size = new Size(609, 100);
            pnlOperations.TabIndex = 0;
            // 
            // grbOperations
            // 
            grbOperations.Controls.Add(lblTitle);
            grbOperations.Controls.Add(btnInfo);
            grbOperations.Controls.Add(btnLoad);
            grbOperations.Controls.Add(btnClear);
            grbOperations.Controls.Add(btnSelect);
            grbOperations.Controls.Add(btnZoomIn);
            grbOperations.Controls.Add(btnMeasure);
            grbOperations.Controls.Add(btnPan);
            grbOperations.Controls.Add(btnNone);
            grbOperations.Controls.Add(btnZoomOut);
            grbOperations.Controls.Add(btnZoomToExtent);
            grbOperations.Dock = DockStyle.Fill;
            grbOperations.Location = new Point(0, 0);
            grbOperations.Name = "grbOperations";
            grbOperations.Size = new Size(609, 100);
            grbOperations.TabIndex = 10;
            grbOperations.TabStop = false;
            grbOperations.Text = "Operations";
            grbOperations.Enter += grbOperations_Enter;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(191, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(224, 30);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "Basic Map Operations";
            // 
            // btnInfo
            // 
            btnInfo.Location = new Point(93, 71);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(75, 23);
            btnInfo.TabIndex = 6;
            btnInfo.Text = "In&fo";
            btnInfo.UseVisualStyleBackColor = true;
            btnInfo.Click += btnInfo_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(12, 35);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "&Load Map";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(93, 35);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 1;
            btnClear.Text = "&Clear Map";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnCLear_Click;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(259, 71);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(75, 23);
            btnSelect.TabIndex = 8;
            btnSelect.Text = "&Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnZoomIn
            // 
            btnZoomIn.Location = new Point(174, 35);
            btnZoomIn.Name = "btnZoomIn";
            btnZoomIn.Size = new Size(75, 23);
            btnZoomIn.TabIndex = 2;
            btnZoomIn.Text = "Zoom &In";
            btnZoomIn.UseVisualStyleBackColor = true;
            btnZoomIn.Click += btnZoomIn_Click;
            // 
            // btnMeasure
            // 
            btnMeasure.Location = new Point(174, 71);
            btnMeasure.Name = "btnMeasure";
            btnMeasure.Size = new Size(75, 23);
            btnMeasure.TabIndex = 7;
            btnMeasure.Text = "&Measure";
            btnMeasure.UseVisualStyleBackColor = true;
            btnMeasure.Click += btnMeasure_Click;
            // 
            // btnPan
            // 
            btnPan.Location = new Point(474, 35);
            btnPan.Name = "btnPan";
            btnPan.Size = new Size(75, 23);
            btnPan.TabIndex = 5;
            btnPan.Text = "&Pan";
            btnPan.UseVisualStyleBackColor = true;
            btnPan.Click += btnPan_Click;
            // 
            // btnNone
            // 
            btnNone.Location = new Point(340, 71);
            btnNone.Name = "btnNone";
            btnNone.Size = new Size(75, 23);
            btnNone.TabIndex = 9;
            btnNone.Text = "&None";
            btnNone.UseVisualStyleBackColor = true;
            btnNone.Click += btnNone_Click;
            // 
            // btnZoomOut
            // 
            btnZoomOut.Location = new Point(255, 35);
            btnZoomOut.Name = "btnZoomOut";
            btnZoomOut.Size = new Size(79, 23);
            btnZoomOut.TabIndex = 3;
            btnZoomOut.Text = "Zoom &Out";
            btnZoomOut.UseVisualStyleBackColor = true;
            btnZoomOut.Click += btnZoomOut_Click;
            // 
            // btnZoomToExtent
            // 
            btnZoomToExtent.Location = new Point(340, 35);
            btnZoomToExtent.Name = "btnZoomToExtent";
            btnZoomToExtent.Size = new Size(128, 23);
            btnZoomToExtent.TabIndex = 4;
            btnZoomToExtent.Text = "Zoom to &Extent";
            btnZoomToExtent.UseVisualStyleBackColor = true;
            btnZoomToExtent.Click += btnZoomToExtent_Click;
            // 
            // pnlMap
            // 
            pnlMap.Controls.Add(map1);
            pnlMap.Dock = DockStyle.Fill;
            pnlMap.Location = new Point(0, 100);
            pnlMap.Name = "pnlMap";
            pnlMap.Size = new Size(609, 271);
            pnlMap.TabIndex = 1;
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
            map1.Legend = null;
            map1.Location = new Point(0, 0);
            map1.Name = "map1";
            map1.ProgressHandler = null;
            map1.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
            map1.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
            map1.RedrawLayersWhileResizing = false;
            map1.SelectionEnabled = true;
            map1.Size = new Size(609, 271);
            map1.TabIndex = 0;
            map1.ZoomOutFartherThanMaxExtent = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 371);
            Controls.Add(pnlMap);
            Controls.Add(pnlOperations);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            pnlOperations.ResumeLayout(false);
            grbOperations.ResumeLayout(false);
            grbOperations.PerformLayout();
            pnlMap.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlOperations;
        private GroupBox grbOperations;
        private Button btnNone;
        private Button btnSelect;
        private Button btnMeasure;
        private Button btnInfo;
        private Button btnPan;
        private Button btnZoomToExtent;
        private Button btnZoomOut;
        private Button btnZoomIn;
        private Button btnClear;
        private Button btnLoad;
        private Panel pnlMap;
        private DotSpatial.Controls.Map map1;
        private Label lblTitle;
    }
}