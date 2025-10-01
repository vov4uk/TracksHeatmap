namespace TracksHeatmap
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuTrackName = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGPSposition = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSaveAsImage = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.zoomLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMapPoints = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSelectedRoute = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbPlotStyle = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCenterTracks = new System.Windows.Forms.Button();
            this.cmbMapType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxLoad = new System.Windows.Forms.GroupBox();
            this.lblTracks = new System.Windows.Forms.Label();
            this.btnLoadFiles = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkExportZoomOverride = new System.Windows.Forms.CheckBox();
            this.numExportZoom = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.chkAsVisible = new System.Windows.Forms.CheckBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numExportHeight = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.chkKeepAspectRatio = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numExportWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPagePlotOptions = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.numDisconnectTrackGaps = new System.Windows.Forms.NumericUpDown();
            this.chkDisconnectGapPoints = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.numBakground2Width = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTrackBakground2 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.numBakgroundWidth = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTrackBakground = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnTrackColor = new System.Windows.Forms.Button();
            this.numTrackWidth = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPageStats = new System.Windows.Forms.TabPage();
            this.btnMoreStats = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.tabPageTools = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.chkAnimationDrawMarkers = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.upDownAnimationStep = new System.Windows.Forms.NumericUpDown();
            this.lblAnimationInfo = new System.Windows.Forms.Label();
            this.btnAnimateSingle = new System.Windows.Forms.Button();
            this.btnSaveAllAsOne = new System.Windows.Forms.Button();
            this.timerAnimation = new System.Windows.Forms.Timer(this.components);
            this.chkIncreasePointsDensity = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxLoad.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExportZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExportHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExportWidth)).BeginInit();
            this.tabPagePlotOptions.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDisconnectTrackGaps)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBakground2Width)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBakgroundWidth)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTrackWidth)).BeginInit();
            this.tabPageStats.SuspendLayout();
            this.tabPageTools.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownAnimationStep)).BeginInit();
            this.SuspendLayout();
            // 
            // gMap
            // 
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemory = 5;
            this.gMap.Location = new System.Drawing.Point(0, 0);
            this.gMap.Margin = new System.Windows.Forms.Padding(0);
            this.gMap.MarkersEnabled = true;
            this.gMap.MaxZoom = 18;
            this.gMap.MinZoom = 2;
            this.gMap.MouseWheelZoomEnabled = true;
            this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap.Name = "gMap";
            this.gMap.NegativeMode = false;
            this.gMap.PolygonsEnabled = true;
            this.gMap.RetryLoadTile = 0;
            this.gMap.RoutesEnabled = true;
            this.gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap.ShowTileGridLines = false;
            this.gMap.Size = new System.Drawing.Size(1846, 1150);
            this.gMap.TabIndex = 1;
            this.gMap.Zoom = 2D;
            this.gMap.OnRouteClick += new GMap.NET.WindowsForms.RouteClick(this.gMap_OnRouteClick);
            this.gMap.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.gMap_OnMapZoomChanged);
            this.gMap.SizeChanged += new System.EventHandler(this.gMap_SizeChanged);
            this.gMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gMap_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTrackName,
            this.menuGPSposition,
            this.toolStripMenuItem1,
            this.menuSaveAsImage});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(243, 124);
            // 
            // menuTrackName
            // 
            this.menuTrackName.Name = "menuTrackName";
            this.menuTrackName.Size = new System.Drawing.Size(242, 38);
            this.menuTrackName.Text = "Track name";
            this.menuTrackName.Click += new System.EventHandler(this.menuGPSposition_Click);
            // 
            // menuGPSposition
            // 
            this.menuGPSposition.Name = "menuGPSposition";
            this.menuGPSposition.Size = new System.Drawing.Size(242, 38);
            this.menuGPSposition.Text = "GPS position";
            this.menuGPSposition.Click += new System.EventHandler(this.menuGPSposition_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(239, 6);
            // 
            // menuSaveAsImage
            // 
            this.menuSaveAsImage.Name = "menuSaveAsImage";
            this.menuSaveAsImage.Size = new System.Drawing.Size(242, 38);
            this.menuSaveAsImage.Text = "Save as image";
            this.menuSaveAsImage.Click += new System.EventHandler(this.menuSaveAsImage_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomLabel,
            this.lblMapPoints,
            this.lblSelectedRoute});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1150);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.statusStrip1.Size = new System.Drawing.Size(2304, 42);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // zoomLabel
            // 
            this.zoomLabel.Name = "zoomLabel";
            this.zoomLabel.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.zoomLabel.Size = new System.Drawing.Size(136, 32);
            this.zoomLabel.Text = "Zoom: 18";
            this.zoomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMapPoints
            // 
            this.lblMapPoints.Name = "lblMapPoints";
            this.lblMapPoints.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblMapPoints.Size = new System.Drawing.Size(181, 32);
            this.lblMapPoints.Text = "Map points: 0";
            this.lblMapPoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSelectedRoute
            // 
            this.lblSelectedRoute.Name = "lblSelectedRoute";
            this.lblSelectedRoute.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblSelectedRoute.Size = new System.Drawing.Size(20, 32);

            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnZoomIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomIn.Location = new System.Drawing.Point(10, 1031);
            this.btnZoomIn.Margin = new System.Windows.Forms.Padding(6);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(60, 58);
            this.btnZoomIn.TabIndex = 0;
            this.btnZoomIn.Text = "+";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnZoomOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomOut.Location = new System.Drawing.Point(82, 1031);
            this.btnZoomOut.Margin = new System.Windows.Forms.Padding(6);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(60, 58);
            this.btnZoomOut.TabIndex = 1;
            this.btnZoomOut.Text = "-";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gMap);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(2304, 1150);
            this.splitContainer1.SplitterDistance = 1846;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPagePlotOptions);
            this.tabControl1.Controls.Add(this.tabPageStats);
            this.tabControl1.Controls.Add(this.tabPageTools);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(450, 1150);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBoxLoad);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnZoomOut);
            this.tabPage1.Controls.Add(this.btnZoomIn);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage1.Size = new System.Drawing.Size(434, 1103);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Actions";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbPlotStyle);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 375);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(412, 109);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Plot options";
            // 
            // cmbPlotStyle
            // 
            this.cmbPlotStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlotStyle.FormattingEnabled = true;
            this.cmbPlotStyle.Location = new System.Drawing.Point(76, 42);
            this.cmbPlotStyle.Margin = new System.Windows.Forms.Padding(6);
            this.cmbPlotStyle.Name = "cmbPlotStyle";
            this.cmbPlotStyle.Size = new System.Drawing.Size(320, 33);
            this.cmbPlotStyle.TabIndex = 4;
            this.cmbPlotStyle.SelectedValueChanged += new System.EventHandler(this.cmbPlotStyle_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Style:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCenterTracks);
            this.groupBox2.Controls.Add(this.cmbMapType);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(412, 190);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View";
            // 
            // btnCenterTracks
            // 
            this.btnCenterTracks.Location = new System.Drawing.Point(18, 108);
            this.btnCenterTracks.Margin = new System.Windows.Forms.Padding(6);
            this.btnCenterTracks.Name = "btnCenterTracks";
            this.btnCenterTracks.Size = new System.Drawing.Size(382, 44);
            this.btnCenterTracks.TabIndex = 6;
            this.btnCenterTracks.Text = "Center tracks on map";
            this.btnCenterTracks.UseVisualStyleBackColor = true;
            this.btnCenterTracks.Click += new System.EventHandler(this.btnCenterTracks_Click);
            // 
            // cmbMapType
            // 
            this.cmbMapType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMapType.FormattingEnabled = true;
            this.cmbMapType.Location = new System.Drawing.Point(86, 37);
            this.cmbMapType.Margin = new System.Windows.Forms.Padding(6);
            this.cmbMapType.Name = "cmbMapType";
            this.cmbMapType.Size = new System.Drawing.Size(310, 33);
            this.cmbMapType.TabIndex = 5;
            this.cmbMapType.SelectedIndexChanged += new System.EventHandler(this.cmbMapType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Map:";
            // 
            // groupBoxLoad
            // 
            this.groupBoxLoad.Controls.Add(this.lblTracks);
            this.groupBoxLoad.Controls.Add(this.btnLoadFiles);
            this.groupBoxLoad.Location = new System.Drawing.Point(12, 213);
            this.groupBoxLoad.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxLoad.Name = "groupBoxLoad";
            this.groupBoxLoad.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxLoad.Size = new System.Drawing.Size(412, 150);
            this.groupBoxLoad.TabIndex = 6;
            this.groupBoxLoad.TabStop = false;
            this.groupBoxLoad.Text = "Load tracks";
            // 
            // lblTracks
            // 
            this.lblTracks.AutoSize = true;
            this.lblTracks.Location = new System.Drawing.Point(12, 106);
            this.lblTracks.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTracks.Name = "lblTracks";
            this.lblTracks.Size = new System.Drawing.Size(101, 25);
            this.lblTracks.TabIndex = 1;
            this.lblTracks.Text = "Tracks: 0";
            // 
            // btnLoadFiles
            // 
            this.btnLoadFiles.Location = new System.Drawing.Point(18, 37);
            this.btnLoadFiles.Margin = new System.Windows.Forms.Padding(6);
            this.btnLoadFiles.Name = "btnLoadFiles";
            this.btnLoadFiles.Size = new System.Drawing.Size(382, 44);
            this.btnLoadFiles.TabIndex = 0;
            this.btnLoadFiles.Text = "Load gpx files";
            this.btnLoadFiles.UseVisualStyleBackColor = true;
            this.btnLoadFiles.Click += new System.EventHandler(this.btnLoadFiles_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkExportZoomOverride);
            this.groupBox1.Controls.Add(this.numExportZoom);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.chkAsVisible);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numExportHeight);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chkKeepAspectRatio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numExportWidth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 496);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(412, 321);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Export";
            // 
            // chkExportZoomOverride
            // 
            this.chkExportZoomOverride.AutoSize = true;
            this.chkExportZoomOverride.Location = new System.Drawing.Point(208, 200);
            this.chkExportZoomOverride.Margin = new System.Windows.Forms.Padding(6);
            this.chkExportZoomOverride.Name = "chkExportZoomOverride";
            this.chkExportZoomOverride.Size = new System.Drawing.Size(122, 29);
            this.chkExportZoomOverride.TabIndex = 13;
            this.chkExportZoomOverride.Text = "override";
            this.chkExportZoomOverride.UseVisualStyleBackColor = true;
            this.chkExportZoomOverride.CheckedChanged += new System.EventHandler(this.chkAsVisible_CheckedChanged);
            // 
            // numExportZoom
            // 
            this.numExportZoom.Location = new System.Drawing.Point(100, 198);
            this.numExportZoom.Margin = new System.Windows.Forms.Padding(6);
            this.numExportZoom.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numExportZoom.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numExportZoom.Name = "numExportZoom";
            this.numExportZoom.Size = new System.Drawing.Size(96, 31);
            this.numExportZoom.TabIndex = 12;
            this.numExportZoom.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 202);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "Zoom:";
            // 
            // chkAsVisible
            // 
            this.chkAsVisible.AutoSize = true;
            this.chkAsVisible.Location = new System.Drawing.Point(100, 35);
            this.chkAsVisible.Margin = new System.Windows.Forms.Padding(6);
            this.chkAsVisible.Name = "chkAsVisible";
            this.chkAsVisible.Size = new System.Drawing.Size(189, 29);
            this.chkAsVisible.TabIndex = 10;
            this.chkAsVisible.Text = "as current view";
            this.chkAsVisible.UseVisualStyleBackColor = true;
            this.chkAsVisible.CheckedChanged += new System.EventHandler(this.chkAsVisible_CheckedChanged);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(18, 252);
            this.btnExport.Margin = new System.Windows.Forms.Padding(6);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(382, 44);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Export as image";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "pixels";
            // 
            // numExportHeight
            // 
            this.numExportHeight.Location = new System.Drawing.Point(100, 156);
            this.numExportHeight.Margin = new System.Windows.Forms.Padding(6);
            this.numExportHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numExportHeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numExportHeight.Name = "numExportHeight";
            this.numExportHeight.Size = new System.Drawing.Size(124, 31);
            this.numExportHeight.TabIndex = 5;
            this.numExportHeight.Value = new decimal(new int[] {
            900,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Height:";
            // 
            // chkKeepAspectRatio
            // 
            this.chkKeepAspectRatio.AutoSize = true;
            this.chkKeepAspectRatio.Location = new System.Drawing.Point(100, 118);
            this.chkKeepAspectRatio.Margin = new System.Windows.Forms.Padding(6);
            this.chkKeepAspectRatio.Name = "chkKeepAspectRatio";
            this.chkKeepAspectRatio.Size = new System.Drawing.Size(212, 29);
            this.chkKeepAspectRatio.TabIndex = 3;
            this.chkKeepAspectRatio.Text = "Keep aspect ratio";
            this.chkKeepAspectRatio.UseVisualStyleBackColor = true;
            this.chkKeepAspectRatio.CheckedChanged += new System.EventHandler(this.chkKeepAspectRatio_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "pixels";
            // 
            // numExportWidth
            // 
            this.numExportWidth.Location = new System.Drawing.Point(100, 79);
            this.numExportWidth.Margin = new System.Windows.Forms.Padding(6);
            this.numExportWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numExportWidth.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numExportWidth.Name = "numExportWidth";
            this.numExportWidth.Size = new System.Drawing.Size(124, 31);
            this.numExportWidth.TabIndex = 1;
            this.numExportWidth.Value = new decimal(new int[] {
            1600,
            0,
            0,
            0});
            this.numExportWidth.ValueChanged += new System.EventHandler(this.numExportWidth_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width:";
            // 
            // tabPagePlotOptions
            // 
            this.tabPagePlotOptions.Controls.Add(this.groupBox7);
            this.tabPagePlotOptions.Controls.Add(this.groupBox6);
            this.tabPagePlotOptions.Controls.Add(this.groupBox5);
            this.tabPagePlotOptions.Controls.Add(this.groupBox4);
            this.tabPagePlotOptions.Location = new System.Drawing.Point(8, 39);
            this.tabPagePlotOptions.Margin = new System.Windows.Forms.Padding(6);
            this.tabPagePlotOptions.Name = "tabPagePlotOptions";
            this.tabPagePlotOptions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPagePlotOptions.Size = new System.Drawing.Size(434, 1103);
            this.tabPagePlotOptions.TabIndex = 2;
            this.tabPagePlotOptions.Text = "Plot options";
            this.tabPagePlotOptions.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.numDisconnectTrackGaps);
            this.groupBox7.Controls.Add(this.chkDisconnectGapPoints);
            this.groupBox7.Location = new System.Drawing.Point(16, 585);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox7.Size = new System.Drawing.Size(404, 192);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Other";
            // 
            // numDisconnectTrackGaps
            // 
            this.numDisconnectTrackGaps.Location = new System.Drawing.Point(310, 35);
            this.numDisconnectTrackGaps.Margin = new System.Windows.Forms.Padding(6);
            this.numDisconnectTrackGaps.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDisconnectTrackGaps.Name = "numDisconnectTrackGaps";
            this.numDisconnectTrackGaps.Size = new System.Drawing.Size(78, 31);
            this.numDisconnectTrackGaps.TabIndex = 1;
            this.numDisconnectTrackGaps.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numDisconnectTrackGaps.ValueChanged += new System.EventHandler(this.numTrackWidth_ValueChanged);
            // 
            // chkDisconnectGapPoints
            // 
            this.chkDisconnectGapPoints.AutoSize = true;
            this.chkDisconnectGapPoints.Checked = true;
            this.chkDisconnectGapPoints.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDisconnectGapPoints.Location = new System.Drawing.Point(16, 37);
            this.chkDisconnectGapPoints.Margin = new System.Windows.Forms.Padding(6);
            this.chkDisconnectGapPoints.Name = "chkDisconnectGapPoints";
            this.chkDisconnectGapPoints.Size = new System.Drawing.Size(257, 29);
            this.chkDisconnectGapPoints.TabIndex = 0;
            this.chkDisconnectGapPoints.Text = "Disconnect track gaps";
            this.chkDisconnectGapPoints.UseVisualStyleBackColor = true;
            this.chkDisconnectGapPoints.CheckedChanged += new System.EventHandler(this.chkDisconnectGapPoints_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.numBakground2Width);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.btnTrackBakground2);
            this.groupBox6.Location = new System.Drawing.Point(16, 381);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox6.Size = new System.Drawing.Size(404, 192);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Track second background bolor";
            // 
            // numBakground2Width
            // 
            this.numBakground2Width.DecimalPlaces = 1;
            this.numBakground2Width.Location = new System.Drawing.Point(92, 92);
            this.numBakground2Width.Margin = new System.Windows.Forms.Padding(6);
            this.numBakground2Width.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numBakground2Width.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBakground2Width.Name = "numBakground2Width";
            this.numBakground2Width.Size = new System.Drawing.Size(82, 31);
            this.numBakground2Width.TabIndex = 9;
            this.numBakground2Width.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numBakground2Width.ValueChanged += new System.EventHandler(this.numTrackWidth_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 98);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(73, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Width:";
            // 
            // btnTrackBakground2
            // 
            this.btnTrackBakground2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(124)))), ((int)(((byte)(34)))));
            this.btnTrackBakground2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrackBakground2.ForeColor = System.Drawing.Color.Black;
            this.btnTrackBakground2.Location = new System.Drawing.Point(12, 37);
            this.btnTrackBakground2.Margin = new System.Windows.Forms.Padding(6);
            this.btnTrackBakground2.Name = "btnTrackBakground2";
            this.btnTrackBakground2.Size = new System.Drawing.Size(376, 44);
            this.btnTrackBakground2.TabIndex = 7;
            this.btnTrackBakground2.Text = "Track background color";
            this.btnTrackBakground2.UseVisualStyleBackColor = false;
            this.btnTrackBakground2.Click += new System.EventHandler(this.btnTrackBakground2_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.numBakgroundWidth);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.btnTrackBakground);
            this.groupBox5.Location = new System.Drawing.Point(16, 177);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox5.Size = new System.Drawing.Size(404, 192);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Track background bolor";
            // 
            // numBakgroundWidth
            // 
            this.numBakgroundWidth.DecimalPlaces = 1;
            this.numBakgroundWidth.Location = new System.Drawing.Point(92, 92);
            this.numBakgroundWidth.Margin = new System.Windows.Forms.Padding(6);
            this.numBakgroundWidth.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numBakgroundWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBakgroundWidth.Name = "numBakgroundWidth";
            this.numBakgroundWidth.Size = new System.Drawing.Size(82, 31);
            this.numBakgroundWidth.TabIndex = 7;
            this.numBakgroundWidth.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numBakgroundWidth.ValueChanged += new System.EventHandler(this.numTrackWidth_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 98);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(73, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Width:";
            // 
            // btnTrackBakground
            // 
            this.btnTrackBakground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(63)))));
            this.btnTrackBakground.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrackBakground.ForeColor = System.Drawing.Color.Black;
            this.btnTrackBakground.Location = new System.Drawing.Point(12, 37);
            this.btnTrackBakground.Margin = new System.Windows.Forms.Padding(6);
            this.btnTrackBakground.Name = "btnTrackBakground";
            this.btnTrackBakground.Size = new System.Drawing.Size(376, 44);
            this.btnTrackBakground.TabIndex = 6;
            this.btnTrackBakground.Text = "Track background color";
            this.btnTrackBakground.UseVisualStyleBackColor = false;
            this.btnTrackBakground.Click += new System.EventHandler(this.btnTrackBakground_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnTrackColor);
            this.groupBox4.Controls.Add(this.numTrackWidth);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(16, 6);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox4.Size = new System.Drawing.Size(404, 160);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Track color";
            // 
            // btnTrackColor
            // 
            this.btnTrackColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrackColor.ForeColor = System.Drawing.Color.Red;
            this.btnTrackColor.Location = new System.Drawing.Point(12, 37);
            this.btnTrackColor.Margin = new System.Windows.Forms.Padding(6);
            this.btnTrackColor.Name = "btnTrackColor";
            this.btnTrackColor.Size = new System.Drawing.Size(376, 44);
            this.btnTrackColor.TabIndex = 3;
            this.btnTrackColor.Text = "Track color";
            this.btnTrackColor.UseVisualStyleBackColor = true;
            this.btnTrackColor.Click += new System.EventHandler(this.btnTrackColor_Click);
            // 
            // numTrackWidth
            // 
            this.numTrackWidth.DecimalPlaces = 1;
            this.numTrackWidth.Location = new System.Drawing.Point(92, 92);
            this.numTrackWidth.Margin = new System.Windows.Forms.Padding(6);
            this.numTrackWidth.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTrackWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTrackWidth.Name = "numTrackWidth";
            this.numTrackWidth.Size = new System.Drawing.Size(82, 31);
            this.numTrackWidth.TabIndex = 4;
            this.numTrackWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTrackWidth.ValueChanged += new System.EventHandler(this.numTrackWidth_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Width:";
            // 
            // tabPageStats
            // 
            this.tabPageStats.Controls.Add(this.btnMoreStats);
            this.tabPageStats.Controls.Add(this.txtInfo);
            this.tabPageStats.Location = new System.Drawing.Point(8, 39);
            this.tabPageStats.Margin = new System.Windows.Forms.Padding(6);
            this.tabPageStats.Name = "tabPageStats";
            this.tabPageStats.Padding = new System.Windows.Forms.Padding(6);
            this.tabPageStats.Size = new System.Drawing.Size(434, 1103);
            this.tabPageStats.TabIndex = 1;
            this.tabPageStats.Text = "Stats";
            this.tabPageStats.UseVisualStyleBackColor = true;
            // 
            // btnMoreStats
            // 
            this.btnMoreStats.Location = new System.Drawing.Point(12, 12);
            this.btnMoreStats.Margin = new System.Windows.Forms.Padding(6);
            this.btnMoreStats.Name = "btnMoreStats";
            this.btnMoreStats.Size = new System.Drawing.Size(408, 44);
            this.btnMoreStats.TabIndex = 1;
            this.btnMoreStats.Text = "More stats";
            this.btnMoreStats.UseVisualStyleBackColor = true;
            this.btnMoreStats.Click += new System.EventHandler(this.btnMoreStats_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInfo.Location = new System.Drawing.Point(6, 67);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(6);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(420, 1023);
            this.txtInfo.TabIndex = 0;
            this.txtInfo.Text = "Load tracks first...";
            // 
            // tabPageTools
            // 
            this.tabPageTools.Controls.Add(this.groupBox8);
            this.tabPageTools.Controls.Add(this.btnSaveAllAsOne);
            this.tabPageTools.Location = new System.Drawing.Point(8, 39);
            this.tabPageTools.Name = "tabPageTools";
            this.tabPageTools.Size = new System.Drawing.Size(434, 1103);
            this.tabPageTools.TabIndex = 3;
            this.tabPageTools.Text = "Tools";
            this.tabPageTools.UseVisualStyleBackColor = true;

            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.chkIncreasePointsDensity);
            this.groupBox8.Controls.Add(this.chkAnimationDrawMarkers);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Controls.Add(this.upDownAnimationStep);
            this.groupBox8.Controls.Add(this.lblAnimationInfo);
            this.groupBox8.Controls.Add(this.btnAnimateSingle);
            this.groupBox8.Location = new System.Drawing.Point(16, 97);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(401, 293);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Animate single track";
            // 
            // chkAnimationDrawMarkers
            // 
            this.chkAnimationDrawMarkers.AutoSize = true;
            this.chkAnimationDrawMarkers.Checked = true;
            this.chkAnimationDrawMarkers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAnimationDrawMarkers.Location = new System.Drawing.Point(16, 85);
            this.chkAnimationDrawMarkers.Name = "chkAnimationDrawMarkers";
            this.chkAnimationDrawMarkers.Size = new System.Drawing.Size(173, 29);
            this.chkAnimationDrawMarkers.TabIndex = 6;
            this.chkAnimationDrawMarkers.Text = "draw markers";
            this.chkAnimationDrawMarkers.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 25);
            this.label12.TabIndex = 5;
            this.label12.Text = "Animation step";
            // 
            // upDownAnimationStep
            // 
            this.upDownAnimationStep.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.upDownAnimationStep.Location = new System.Drawing.Point(171, 36);
            this.upDownAnimationStep.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.upDownAnimationStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDownAnimationStep.Name = "upDownAnimationStep";
            this.upDownAnimationStep.Size = new System.Drawing.Size(120, 31);
            this.upDownAnimationStep.TabIndex = 4;
            this.upDownAnimationStep.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // lblAnimationInfo
            // 
            this.lblAnimationInfo.AutoSize = true;
            this.lblAnimationInfo.Location = new System.Drawing.Point(11, 246);
            this.lblAnimationInfo.Name = "lblAnimationInfo";
            this.lblAnimationInfo.Size = new System.Drawing.Size(207, 25);
            this.lblAnimationInfo.TabIndex = 3;
            this.lblAnimationInfo.Text = "Track points left: n/a";
            // 
            // btnAnimateSingle
            // 
            this.btnAnimateSingle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnimateSingle.Location = new System.Drawing.Point(16, 174);
            this.btnAnimateSingle.Name = "btnAnimateSingle";
            this.btnAnimateSingle.Size = new System.Drawing.Size(363, 53);
            this.btnAnimateSingle.TabIndex = 2;
            this.btnAnimateSingle.Text = "Save image sequence";
            this.btnAnimateSingle.UseVisualStyleBackColor = true;
            this.btnAnimateSingle.Click += new System.EventHandler(this.btnAnimateSingle_Click);
            // 
            // btnSaveAllAsOne
            // 
            this.btnSaveAllAsOne.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAllAsOne.Location = new System.Drawing.Point(16, 17);
            this.btnSaveAllAsOne.Name = "btnSaveAllAsOne";
            this.btnSaveAllAsOne.Size = new System.Drawing.Size(401, 53);
            this.btnSaveAllAsOne.TabIndex = 0;
            this.btnSaveAllAsOne.Text = "Save all tracks as one .gpx";
            this.btnSaveAllAsOne.UseVisualStyleBackColor = true;
            this.btnSaveAllAsOne.Click += new System.EventHandler(this.btnSaveAllAsOne_Click);
            // 
            // timerAnimation
            // 
            this.timerAnimation.Tick += new System.EventHandler(this.timerAnimation_Tick);
            // 
            // chkIncreasePointsDensity
            // 
            this.chkIncreasePointsDensity.AutoSize = true;
            this.chkIncreasePointsDensity.Location = new System.Drawing.Point(16, 124);
            this.chkIncreasePointsDensity.Name = "chkIncreasePointsDensity";
            this.chkIncreasePointsDensity.Size = new System.Drawing.Size(318, 29);
            this.chkIncreasePointsDensity.TabIndex = 7;
            this.chkIncreasePointsDensity.Text = "increase track points density";
            this.chkIncreasePointsDensity.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2304, 1192);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Tracks heatmap";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxLoad.ResumeLayout(false);
            this.groupBoxLoad.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExportZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExportHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExportWidth)).EndInit();
            this.tabPagePlotOptions.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDisconnectTrackGaps)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBakground2Width)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBakgroundWidth)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTrackWidth)).EndInit();
            this.tabPageStats.ResumeLayout(false);
            this.tabPageStats.PerformLayout();
            this.tabPageTools.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownAnimationStep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GMap.NET.WindowsForms.GMapControl gMap;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel zoomLabel;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPageStats;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numExportHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkKeepAspectRatio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numExportWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMapType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxLoad;
        private System.Windows.Forms.Button btnLoadFiles;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblTracks;
        private System.Windows.Forms.ToolStripStatusLabel lblMapPoints;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCenterTracks;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbPlotStyle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkAsVisible;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAsImage;
        private System.Windows.Forms.TabPage tabPagePlotOptions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numTrackWidth;
        private System.Windows.Forms.Button btnTrackColor;
        private System.Windows.Forms.ToolStripMenuItem menuGPSposition;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Button btnTrackBakground;
        private System.Windows.Forms.Button btnTrackBakground2;
        private System.Windows.Forms.ToolStripMenuItem menuTrackName;
        private System.Windows.Forms.ToolStripStatusLabel lblSelectedRoute;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown numBakground2Width;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown numBakgroundWidth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox chkDisconnectGapPoints;
        private System.Windows.Forms.NumericUpDown numDisconnectTrackGaps;
        private System.Windows.Forms.Button btnMoreStats;
        private System.Windows.Forms.CheckBox chkExportZoomOverride;
        private System.Windows.Forms.NumericUpDown numExportZoom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPageTools;
        private System.Windows.Forms.Button btnSaveAllAsOne;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnAnimateSingle;
        private System.Windows.Forms.Timer timerAnimation;
        private System.Windows.Forms.Label lblAnimationInfo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown upDownAnimationStep;
        private System.Windows.Forms.CheckBox chkAnimationDrawMarkers;

        private System.Windows.Forms.CheckBox chkIncreasePointsDensity;
    }
}

