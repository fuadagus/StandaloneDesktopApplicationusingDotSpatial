namespace Task4
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
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            zoomInToolStripMenuItem = new ToolStripMenuItem();
            zoomOutToolStripMenuItem = new ToolStripMenuItem();
            zoomToMaxExtentToolStripMenuItem = new ToolStripMenuItem();
            panToolStripMenuItem = new ToolStripMenuItem();
            measureToolStripMenuItem = new ToolStripMenuItem();
            defaultToolStripMenuItem = new ToolStripMenuItem();
            pnlOperations = new Panel();
            gbShapeAttribute = new GroupBox();
            btnDisplayLabel = new Button();
            cmbFieldName = new ComboBox();
            lblFieldName = new Label();
            gbCutomAttribute = new GroupBox();
            btnDelete = new Button();
            btnSave = new Button();
            btnAdd = new Button();
            txtCustomAttribute = new TextBox();
            lblLabelName = new Label();
            gbCustom = new GroupBox();
            btnsetColor = new Button();
            btnsetFont = new Button();
            pnlMap = new Panel();
            map1 = new DotSpatial.Controls.Map();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            pnlOperations.SuspendLayout();
            gbShapeAttribute.SuspendLayout();
            gbCutomAttribute.SuspendLayout();
            gbCustom.SuspendLayout();
            pnlMap.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(587, 27);
            panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(587, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadToolStripMenuItem, clearToolStripMenuItem, exitToolStripMenuItem });
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
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(101, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { zoomInToolStripMenuItem, zoomOutToolStripMenuItem, zoomToMaxExtentToolStripMenuItem, panToolStripMenuItem, measureToolStripMenuItem, defaultToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(95, 20);
            toolStripMenuItem1.Text = "Menu Options";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // zoomInToolStripMenuItem
            // 
            zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            zoomInToolStripMenuItem.Size = new Size(180, 22);
            zoomInToolStripMenuItem.Text = "Zoom In";
            zoomInToolStripMenuItem.Click += zoomInToolStripMenuItem_Click;
            // 
            // zoomOutToolStripMenuItem
            // 
            zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            zoomOutToolStripMenuItem.Size = new Size(180, 22);
            zoomOutToolStripMenuItem.Text = "Zoom Out";
            zoomOutToolStripMenuItem.Click += zoomOutToolStripMenuItem_Click;
            // 
            // zoomToMaxExtentToolStripMenuItem
            // 
            zoomToMaxExtentToolStripMenuItem.Name = "zoomToMaxExtentToolStripMenuItem";
            zoomToMaxExtentToolStripMenuItem.Size = new Size(180, 22);
            zoomToMaxExtentToolStripMenuItem.Text = "Zoom to MaxExtent";
            zoomToMaxExtentToolStripMenuItem.Click += zoomToMaxExtentToolStripMenuItem_Click;
            // 
            // panToolStripMenuItem
            // 
            panToolStripMenuItem.Name = "panToolStripMenuItem";
            panToolStripMenuItem.Size = new Size(180, 22);
            panToolStripMenuItem.Text = "Pan";
            panToolStripMenuItem.Click += panToolStripMenuItem_Click;
            // 
            // measureToolStripMenuItem
            // 
            measureToolStripMenuItem.Name = "measureToolStripMenuItem";
            measureToolStripMenuItem.Size = new Size(180, 22);
            measureToolStripMenuItem.Text = "Measure";
            // 
            // defaultToolStripMenuItem
            // 
            defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            defaultToolStripMenuItem.Size = new Size(180, 22);
            defaultToolStripMenuItem.Text = "Default";
            defaultToolStripMenuItem.Click += defaultToolStripMenuItem_Click;
            // 
            // pnlOperations
            // 
            pnlOperations.BorderStyle = BorderStyle.FixedSingle;
            pnlOperations.Controls.Add(gbShapeAttribute);
            pnlOperations.Controls.Add(gbCutomAttribute);
            pnlOperations.Controls.Add(gbCustom);
            pnlOperations.Dock = DockStyle.Left;
            pnlOperations.Location = new Point(0, 27);
            pnlOperations.Name = "pnlOperations";
            pnlOperations.Size = new Size(251, 331);
            pnlOperations.TabIndex = 1;
            // 
            // gbShapeAttribute
            // 
            gbShapeAttribute.Controls.Add(btnDisplayLabel);
            gbShapeAttribute.Controls.Add(cmbFieldName);
            gbShapeAttribute.Controls.Add(lblFieldName);
            gbShapeAttribute.Location = new Point(3, 96);
            gbShapeAttribute.Name = "gbShapeAttribute";
            gbShapeAttribute.Size = new Size(241, 81);
            gbShapeAttribute.TabIndex = 1;
            gbShapeAttribute.TabStop = false;
            gbShapeAttribute.Text = "Display label from Attribute table";
            // 
            // btnDisplayLabel
            // 
            btnDisplayLabel.Location = new Point(51, 45);
            btnDisplayLabel.Name = "btnDisplayLabel";
            btnDisplayLabel.Size = new Size(164, 23);
            btnDisplayLabel.TabIndex = 2;
            btnDisplayLabel.Text = "Display Labels";
            btnDisplayLabel.UseVisualStyleBackColor = true;
            btnDisplayLabel.Click += btnDisplayLabel_Click;
            // 
            // cmbFieldName
            // 
            cmbFieldName.FormattingEnabled = true;
            cmbFieldName.Location = new Point(51, 16);
            cmbFieldName.Name = "cmbFieldName";
            cmbFieldName.Size = new Size(164, 23);
            cmbFieldName.TabIndex = 1;
            // 
            // lblFieldName
            // 
            lblFieldName.AutoSize = true;
            lblFieldName.Location = new Point(13, 19);
            lblFieldName.Name = "lblFieldName";
            lblFieldName.Size = new Size(32, 15);
            lblFieldName.TabIndex = 0;
            lblFieldName.Text = "Field";
            // 
            // gbCutomAttribute
            // 
            gbCutomAttribute.Controls.Add(btnDelete);
            gbCutomAttribute.Controls.Add(btnSave);
            gbCutomAttribute.Controls.Add(btnAdd);
            gbCutomAttribute.Controls.Add(txtCustomAttribute);
            gbCutomAttribute.Controls.Add(lblLabelName);
            gbCutomAttribute.Location = new Point(3, 183);
            gbCutomAttribute.Name = "gbCutomAttribute";
            gbCutomAttribute.Size = new Size(241, 160);
            gbCutomAttribute.TabIndex = 1;
            gbCutomAttribute.TabStop = false;
            gbCutomAttribute.Text = "Custom Attributes for existing shape file";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(150, 54);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(65, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(77, 54);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(67, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(8, 54);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(63, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtCustomAttribute
            // 
            txtCustomAttribute.Location = new Point(89, 22);
            txtCustomAttribute.Name = "txtCustomAttribute";
            txtCustomAttribute.Size = new Size(126, 23);
            txtCustomAttribute.TabIndex = 1;
            txtCustomAttribute.TextChanged += txtCustomAttribute_TextChanged;
            // 
            // lblLabelName
            // 
            lblLabelName.AutoSize = true;
            lblLabelName.Location = new Point(8, 30);
            lblLabelName.Name = "lblLabelName";
            lblLabelName.Size = new Size(70, 15);
            lblLabelName.TabIndex = 0;
            lblLabelName.Text = "Label Name";
            // 
            // gbCustom
            // 
            gbCustom.Controls.Add(btnsetColor);
            gbCustom.Controls.Add(btnsetFont);
            gbCustom.Location = new Point(3, 5);
            gbCustom.Name = "gbCustom";
            gbCustom.Size = new Size(241, 85);
            gbCustom.TabIndex = 0;
            gbCustom.TabStop = false;
            gbCustom.Text = "Set the label properties";
            // 
            // btnsetColor
            // 
            btnsetColor.Location = new Point(51, 51);
            btnsetColor.Name = "btnsetColor";
            btnsetColor.Size = new Size(164, 23);
            btnsetColor.TabIndex = 1;
            btnsetColor.Text = "Set Color";
            btnsetColor.UseVisualStyleBackColor = true;
            btnsetColor.Click += btnsetColor_Click;
            // 
            // btnsetFont
            // 
            btnsetFont.Location = new Point(51, 22);
            btnsetFont.Name = "btnsetFont";
            btnsetFont.Size = new Size(164, 23);
            btnsetFont.TabIndex = 0;
            btnsetFont.Text = "Set Font Style and Size";
            btnsetFont.UseVisualStyleBackColor = true;
            btnsetFont.Click += btnsetFont_Click;
            // 
            // pnlMap
            // 
            pnlMap.BorderStyle = BorderStyle.Fixed3D;
            pnlMap.Controls.Add(map1);
            pnlMap.Dock = DockStyle.Fill;
            pnlMap.Location = new Point(251, 27);
            pnlMap.Name = "pnlMap";
            pnlMap.Size = new Size(336, 331);
            pnlMap.TabIndex = 2;
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
            map1.Legend = null;
            map1.Location = new Point(0, 0);
            map1.Name = "map1";
            map1.ProgressHandler = null;
            map1.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
            map1.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
            map1.RedrawLayersWhileResizing = false;
            map1.SelectionEnabled = true;
            map1.Size = new Size(332, 327);
            map1.TabIndex = 0;
            map1.ZoomOutFartherThanMaxExtent = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 358);
            Controls.Add(pnlMap);
            Controls.Add(pnlOperations);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlOperations.ResumeLayout(false);
            gbShapeAttribute.ResumeLayout(false);
            gbShapeAttribute.PerformLayout();
            gbCutomAttribute.ResumeLayout(false);
            gbCutomAttribute.PerformLayout();
            gbCustom.ResumeLayout(false);
            pnlMap.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem zoomInToolStripMenuItem;
        private ToolStripMenuItem zoomOutToolStripMenuItem;
        private ToolStripMenuItem zoomToMaxExtentToolStripMenuItem;
        private ToolStripMenuItem panToolStripMenuItem;
        private ToolStripMenuItem measureToolStripMenuItem;
        private ToolStripMenuItem defaultToolStripMenuItem;
        private Panel pnlOperations;
        private Panel pnlMap;
        private GroupBox gbShapeAttribute;
        private Button btnDisplayLabel;
        private ComboBox cmbFieldName;
        private Label lblFieldName;
        private GroupBox gbCutomAttribute;
        private Button btnDelete;
        private Button btnSave;
        private Button btnAdd;
        private TextBox txtCustomAttribute;
        private Label lblLabelName;
        private GroupBox gbCustom;
        private Button btnsetColor;
        private Button btnsetFont;
        private DotSpatial.Controls.Map map1;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
    }
}