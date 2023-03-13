namespace Task2
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
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            loadMapToolStripMenuItem = new ToolStripMenuItem();
            clearMapToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            zoomInToolStripMenuItem = new ToolStripMenuItem();
            zoomOutToolStripMenuItem = new ToolStripMenuItem();
            zoomExtentToolStripMenuItem = new ToolStripMenuItem();
            splcMapLegend = new SplitContainer();
            legend1 = new DotSpatial.Controls.Legend();
            map1 = new DotSpatial.Controls.Map();
            splcDataOperation = new SplitContainer();
            gbOperations = new GroupBox();
            txtPopulation = new TextBox();
            btnFilterByStateName = new Button();
            lblPopulation = new Label();
            label1 = new Label();
            btnFilterByPopulation = new Button();
            btnViewAttributes = new Button();
            btnRandomColors = new Button();
            btnFilterByPopUpState = new Button();
            btnDisplayStateName = new Button();
            dgvAttributeTable = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splcMapLegend).BeginInit();
            splcMapLegend.Panel1.SuspendLayout();
            splcMapLegend.Panel2.SuspendLayout();
            splcMapLegend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splcDataOperation).BeginInit();
            splcDataOperation.Panel1.SuspendLayout();
            splcDataOperation.Panel2.SuspendLayout();
            splcDataOperation.SuspendLayout();
            gbOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttributeTable).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(751, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { loadMapToolStripMenuItem, clearMapToolStripMenuItem, exitToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(37, 20);
            toolStripMenuItem1.Text = "&File";
            // 
            // loadMapToolStripMenuItem
            // 
            loadMapToolStripMenuItem.Name = "loadMapToolStripMenuItem";
            loadMapToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.L;
            loadMapToolStripMenuItem.Size = new Size(170, 22);
            loadMapToolStripMenuItem.Text = "&Load Map";
            loadMapToolStripMenuItem.Click += loadMapToolStripMenuItem_Click;
            // 
            // clearMapToolStripMenuItem
            // 
            clearMapToolStripMenuItem.Name = "clearMapToolStripMenuItem";
            clearMapToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            clearMapToolStripMenuItem.Size = new Size(170, 22);
            clearMapToolStripMenuItem.Text = "&Clear Map";
            clearMapToolStripMenuItem.Click += clearMapToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            exitToolStripMenuItem.Size = new Size(170, 22);
            exitToolStripMenuItem.Text = "&Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { zoomInToolStripMenuItem, zoomOutToolStripMenuItem, zoomExtentToolStripMenuItem });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(104, 20);
            toolStripMenuItem2.Text = "&Map Operations";
            // 
            // zoomInToolStripMenuItem
            // 
            zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            zoomInToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Up;
            zoomInToolStripMenuItem.Size = new Size(194, 22);
            zoomInToolStripMenuItem.Text = "Zoom &In";
            zoomInToolStripMenuItem.Click += zoomInToolStripMenuItem_Click;
            // 
            // zoomOutToolStripMenuItem
            // 
            zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            zoomOutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Down;
            zoomOutToolStripMenuItem.Size = new Size(194, 22);
            zoomOutToolStripMenuItem.Text = "Zoom &Out";
            zoomOutToolStripMenuItem.Click += zoomOutToolStripMenuItem_Click;
            // 
            // zoomExtentToolStripMenuItem
            // 
            zoomExtentToolStripMenuItem.Name = "zoomExtentToolStripMenuItem";
            zoomExtentToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            zoomExtentToolStripMenuItem.Size = new Size(194, 22);
            zoomExtentToolStripMenuItem.Text = "Zoom &Extent";
            zoomExtentToolStripMenuItem.Click += zoomExtentToolStripMenuItem_Click;
            // 
            // splcMapLegend
            // 
            splcMapLegend.Dock = DockStyle.Top;
            splcMapLegend.Location = new Point(0, 24);
            splcMapLegend.Name = "splcMapLegend";
            // 
            // splcMapLegend.Panel1
            // 
            splcMapLegend.Panel1.Controls.Add(legend1);
            splcMapLegend.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splcMapLegend.Panel2
            // 
            splcMapLegend.Panel2.Controls.Add(map1);
            splcMapLegend.Size = new Size(751, 308);
            splcMapLegend.SplitterDistance = 248;
            splcMapLegend.TabIndex = 1;
            // 
            // legend1
            // 
            legend1.BackColor = Color.White;
            legend1.ControlRectangle = new Rectangle(0, 0, 248, 308);
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
            legend1.Size = new Size(248, 308);
            legend1.TabIndex = 0;
            legend1.Text = "legend1";
            legend1.UseLegendForSelection = true;
            legend1.VerticalScrollEnabled = true;
            legend1.Click += legend1_Click;
            // 
            // map1
            // 
            map1.AllowDrop = true;
            map1.BackColor = Color.White;
            map1.CollisionDetection = false;
            map1.ExtendBuffer = false;
            map1.FunctionMode = DotSpatial.Controls.FunctionMode.Pan;
            map1.IsBusy = false;
            map1.IsZoomedToMaxExtent = false;
            map1.Legend = legend1;
            map1.Location = new Point(3, 3);
            map1.Name = "map1";
            map1.ProgressHandler = null;
            map1.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
            map1.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
            map1.RedrawLayersWhileResizing = false;
            map1.SelectionEnabled = true;
            map1.Size = new Size(495, 305);
            map1.TabIndex = 0;
            map1.ZoomOutFartherThanMaxExtent = false;
            map1.Load += map1_Load;
            // 
            // splcDataOperation
            // 
            splcDataOperation.Dock = DockStyle.Fill;
            splcDataOperation.Location = new Point(0, 332);
            splcDataOperation.Name = "splcDataOperation";
            splcDataOperation.Orientation = Orientation.Horizontal;
            // 
            // splcDataOperation.Panel1
            // 
            splcDataOperation.Panel1.Controls.Add(gbOperations);
            // 
            // splcDataOperation.Panel2
            // 
            splcDataOperation.Panel2.Controls.Add(dgvAttributeTable);
            splcDataOperation.Size = new Size(751, 237);
            splcDataOperation.SplitterDistance = 126;
            splcDataOperation.TabIndex = 2;
            splcDataOperation.SplitterMoved += splcDataOperation_SplitterMoved;
            // 
            // gbOperations
            // 
            gbOperations.Controls.Add(txtPopulation);
            gbOperations.Controls.Add(btnFilterByStateName);
            gbOperations.Controls.Add(lblPopulation);
            gbOperations.Controls.Add(label1);
            gbOperations.Controls.Add(btnFilterByPopulation);
            gbOperations.Controls.Add(btnViewAttributes);
            gbOperations.Controls.Add(btnRandomColors);
            gbOperations.Controls.Add(btnFilterByPopUpState);
            gbOperations.Controls.Add(btnDisplayStateName);
            gbOperations.Dock = DockStyle.Fill;
            gbOperations.Location = new Point(0, 0);
            gbOperations.Name = "gbOperations";
            gbOperations.Size = new Size(751, 126);
            gbOperations.TabIndex = 0;
            gbOperations.TabStop = false;
            gbOperations.Text = "Operations";
            // 
            // txtPopulation
            // 
            txtPopulation.Location = new Point(398, 52);
            txtPopulation.Name = "txtPopulation";
            txtPopulation.Size = new Size(145, 23);
            txtPopulation.TabIndex = 8;
            // 
            // btnFilterByStateName
            // 
            btnFilterByStateName.Location = new Point(167, 22);
            btnFilterByStateName.Name = "btnFilterByStateName";
            btnFilterByStateName.Size = new Size(149, 23);
            btnFilterByStateName.TabIndex = 1;
            btnFilterByStateName.Text = "Filter by &State Name";
            btnFilterByStateName.UseVisualStyleBackColor = true;
            btnFilterByStateName.Click += btnFilterByStateName_Click;
            // 
            // lblPopulation
            // 
            lblPopulation.AutoSize = true;
            lblPopulation.Location = new Point(167, 55);
            lblPopulation.Name = "lblPopulation";
            lblPopulation.Size = new Size(225, 15);
            lblPopulation.TabIndex = 7;
            lblPopulation.Text = "Enter the ammount of population in 1990";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 108);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 6;
            label1.Text = "Attribute Table";
            label1.Click += label1_Click;
            // 
            // btnFilterByPopulation
            // 
            btnFilterByPopulation.Location = new Point(549, 52);
            btnFilterByPopulation.Name = "btnFilterByPopulation";
            btnFilterByPopulation.Size = new Size(194, 23);
            btnFilterByPopulation.TabIndex = 5;
            btnFilterByPopulation.Text = "Filter by amount of &population";
            btnFilterByPopulation.UseVisualStyleBackColor = true;
            btnFilterByPopulation.Click += btnFilterByPopulation_Click;
            // 
            // btnViewAttributes
            // 
            btnViewAttributes.Location = new Point(12, 51);
            btnViewAttributes.Name = "btnViewAttributes";
            btnViewAttributes.Size = new Size(149, 23);
            btnViewAttributes.TabIndex = 4;
            btnViewAttributes.Text = "View &Attributes";
            btnViewAttributes.UseVisualStyleBackColor = true;
            btnViewAttributes.Click += btnViewAttributes_Click;
            // 
            // btnRandomColors
            // 
            btnRandomColors.Location = new Point(549, 22);
            btnRandomColors.Name = "btnRandomColors";
            btnRandomColors.Size = new Size(191, 23);
            btnRandomColors.TabIndex = 3;
            btnRandomColors.Text = "&Random colors based on State Name";
            btnRandomColors.UseVisualStyleBackColor = true;
            btnRandomColors.Click += btnRandomColors_Click;
            // 
            // btnFilterByPopUpState
            // 
            btnFilterByPopUpState.Location = new Point(322, 22);
            btnFilterByPopUpState.Name = "btnFilterByPopUpState";
            btnFilterByPopUpState.Size = new Size(221, 23);
            btnFilterByPopUpState.TabIndex = 2;
            btnFilterByPopUpState.Text = "Filter by &Population and State Name";
            btnFilterByPopUpState.UseVisualStyleBackColor = true;
            btnFilterByPopUpState.Click += btnFilterByPopUpState_Click;
            // 
            // btnDisplayStateName
            // 
            btnDisplayStateName.Location = new Point(15, 22);
            btnDisplayStateName.Name = "btnDisplayStateName";
            btnDisplayStateName.Size = new Size(146, 23);
            btnDisplayStateName.TabIndex = 9;
            btnDisplayStateName.Text = "&Display State Name";
            btnDisplayStateName.Click += btnDisplayStateName_Click;
            // 
            // dgvAttributeTable
            // 
            dgvAttributeTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttributeTable.Dock = DockStyle.Fill;
            dgvAttributeTable.Location = new Point(0, 0);
            dgvAttributeTable.Name = "dgvAttributeTable";
            dgvAttributeTable.RowTemplate.Height = 25;
            dgvAttributeTable.Size = new Size(751, 107);
            dgvAttributeTable.TabIndex = 0;
            dgvAttributeTable.CellContentClick += dgvAttributeTable_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 569);
            Controls.Add(splcDataOperation);
            Controls.Add(splcMapLegend);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splcMapLegend.Panel1.ResumeLayout(false);
            splcMapLegend.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splcMapLegend).EndInit();
            splcMapLegend.ResumeLayout(false);
            splcDataOperation.Panel1.ResumeLayout(false);
            splcDataOperation.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splcDataOperation).EndInit();
            splcDataOperation.ResumeLayout(false);
            gbOperations.ResumeLayout(false);
            gbOperations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttributeTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem loadMapToolStripMenuItem;
        private ToolStripMenuItem clearMapToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem zoomInToolStripMenuItem;
        private ToolStripMenuItem zoomOutToolStripMenuItem;
        private ToolStripMenuItem zoomExtentToolStripMenuItem;
        private SplitContainer splcMapLegend;
        private SplitContainer splcDataOperation;
        private DotSpatial.Controls.Legend legend1;
        private DotSpatial.Controls.Map map1;
        private GroupBox gbOperations;
        private TextBox txtPopulation;
        private Label lblPopulation;
        private Label label1;
        private Button btnFilterByPopulation;
        private Button btnViewAttributes;
        private Button btnRandomColors;
        private Button btnFilterByPopUpState;
        private Button btnFilterByStateName;
        private Button btnDisplayStateName;
        private DataGridView dgvAttributeTable;
    }
}