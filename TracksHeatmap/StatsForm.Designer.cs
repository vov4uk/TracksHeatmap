namespace TracksHeatmap
{
    partial class StatsForm
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
            //System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
           //System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            //System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageTracksBrowser = new System.Windows.Forms.TabPage();
            this.tableLayoutTracksBrowser = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.splitContainerTracksBrowser = new System.Windows.Forms.SplitContainer();
            this.gMapTracksBrowser = new GMap.NET.WindowsForms.GMapControl();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.zoomLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMapPoints = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTracksPosition = new System.Windows.Forms.Label();
            this.txtTracksBrowserInfo = new System.Windows.Forms.TextBox();
            this.tabPageActivityStats = new System.Windows.Forms.TabPage();
            this.tableLayoutActivityStats = new System.Windows.Forms.TableLayoutPanel();
            this.cmbActivityRange = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblActivityStatsTitle = new System.Windows.Forms.Label();
            //this.chartActivityStats = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPageTracksBrowser.SuspendLayout();
            this.tableLayoutTracksBrowser.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTracksBrowser)).BeginInit();
            this.splitContainerTracksBrowser.Panel1.SuspendLayout();
            this.splitContainerTracksBrowser.Panel2.SuspendLayout();
            this.splitContainerTracksBrowser.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabPageActivityStats.SuspendLayout();
            this.tableLayoutActivityStats.SuspendLayout();
            this.panel2.SuspendLayout();
            //((System.ComponentModel.ISupportInitialize)(this.chartActivityStats)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageTracksBrowser);
            this.tabControl1.Controls.Add(this.tabPageActivityStats);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1162, 545);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageTracksBrowser
            // 
            this.tabPageTracksBrowser.Controls.Add(this.tableLayoutTracksBrowser);
            this.tabPageTracksBrowser.Location = new System.Drawing.Point(4, 22);
            this.tabPageTracksBrowser.Name = "tabPageTracksBrowser";
            this.tabPageTracksBrowser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTracksBrowser.Size = new System.Drawing.Size(1154, 519);
            this.tabPageTracksBrowser.TabIndex = 0;
            this.tabPageTracksBrowser.Text = "Tracks browser";
            this.tabPageTracksBrowser.UseVisualStyleBackColor = true;
            // 
            // tableLayoutTracksBrowser
            // 
            this.tableLayoutTracksBrowser.ColumnCount = 1;
            this.tableLayoutTracksBrowser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutTracksBrowser.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutTracksBrowser.Controls.Add(this.splitContainerTracksBrowser, 0, 1);
            this.tableLayoutTracksBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutTracksBrowser.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutTracksBrowser.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutTracksBrowser.Name = "tableLayoutTracksBrowser";
            this.tableLayoutTracksBrowser.RowCount = 2;
            this.tableLayoutTracksBrowser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutTracksBrowser.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutTracksBrowser.Size = new System.Drawing.Size(1148, 513);
            this.tableLayoutTracksBrowser.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTracksPosition);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 32);
            this.panel1.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(1043, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 25);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevious.Location = new System.Drawing.Point(937, 4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(100, 25);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "< Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // splitContainerTracksBrowser
            // 
            this.splitContainerTracksBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTracksBrowser.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerTracksBrowser.IsSplitterFixed = true;
            this.splitContainerTracksBrowser.Location = new System.Drawing.Point(0, 32);
            this.splitContainerTracksBrowser.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainerTracksBrowser.Name = "splitContainerTracksBrowser";
            // 
            // splitContainerTracksBrowser.Panel1
            // 
            this.splitContainerTracksBrowser.Panel1.Controls.Add(this.gMapTracksBrowser);
            // 
            // splitContainerTracksBrowser.Panel2
            // 
            this.splitContainerTracksBrowser.Panel2.Controls.Add(this.txtTracksBrowserInfo);
            this.splitContainerTracksBrowser.Panel2.Controls.Add(this.btnZoomOut);
            this.splitContainerTracksBrowser.Panel2.Controls.Add(this.btnZoomIn);
            this.splitContainerTracksBrowser.Panel2.Margin = new System.Windows.Forms.Padding(5);
            this.splitContainerTracksBrowser.Size = new System.Drawing.Size(1148, 481);
            this.splitContainerTracksBrowser.SplitterDistance = 987;
            this.splitContainerTracksBrowser.TabIndex = 1;
            // 
            // gMapTracksBrowser
            // 
            this.gMapTracksBrowser.AutoSize = true;
            this.gMapTracksBrowser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gMapTracksBrowser.Bearing = 0F;
            this.gMapTracksBrowser.CanDragMap = true;
            this.gMapTracksBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapTracksBrowser.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapTracksBrowser.GrayScaleMode = false;
            this.gMapTracksBrowser.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            //this.gMapTracksBrowser.LevelsKeepInMemmory = 5;
            this.gMapTracksBrowser.Location = new System.Drawing.Point(0, 0);
            this.gMapTracksBrowser.MarkersEnabled = true;
            this.gMapTracksBrowser.MaxZoom = 18;
            this.gMapTracksBrowser.MinZoom = 2;
            this.gMapTracksBrowser.MouseWheelZoomEnabled = true;
            this.gMapTracksBrowser.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapTracksBrowser.Name = "gMapTracksBrowser";
            this.gMapTracksBrowser.NegativeMode = false;
            this.gMapTracksBrowser.PolygonsEnabled = true;
            this.gMapTracksBrowser.RetryLoadTile = 0;
            this.gMapTracksBrowser.RoutesEnabled = true;
            this.gMapTracksBrowser.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapTracksBrowser.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapTracksBrowser.ShowTileGridLines = false;
            this.gMapTracksBrowser.Size = new System.Drawing.Size(987, 481);
            this.gMapTracksBrowser.TabIndex = 0;
            this.gMapTracksBrowser.Zoom = 12D;
            this.gMapTracksBrowser.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.gMapTracksBrowser_OnMapZoomChanged);
            this.gMapTracksBrowser.SizeChanged += new System.EventHandler(this.gMapTracksBrowser_SizeChanged);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnZoomOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomOut.Location = new System.Drawing.Point(43, 446);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(30, 30);
            this.btnZoomOut.TabIndex = 3;
            this.btnZoomOut.Text = "-";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnZoomIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomIn.Location = new System.Drawing.Point(7, 446);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(30, 30);
            this.btnZoomIn.TabIndex = 2;
            this.btnZoomIn.Text = "+";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomLabel,
            this.lblMapPoints});
            this.statusStrip1.Location = new System.Drawing.Point(0, 548);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1162, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // zoomLabel
            // 
            this.zoomLabel.Name = "zoomLabel";
            this.zoomLabel.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.zoomLabel.Size = new System.Drawing.Size(77, 17);
            this.zoomLabel.Text = "Zoom: 18";
            this.zoomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMapPoints
            // 
            this.lblMapPoints.Name = "lblMapPoints";
            this.lblMapPoints.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblMapPoints.Size = new System.Drawing.Size(99, 17);
            this.lblMapPoints.Text = "Map points: 0";
            this.lblMapPoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTracksPosition
            // 
            this.lblTracksPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTracksPosition.Location = new System.Drawing.Point(831, 6);
            this.lblTracksPosition.Name = "lblTracksPosition";
            this.lblTracksPosition.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTracksPosition.Size = new System.Drawing.Size(100, 20);
            this.lblTracksPosition.TabIndex = 2;
            this.lblTracksPosition.Text = "1 of 2";
            this.lblTracksPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTracksBrowserInfo
            // 
            this.txtTracksBrowserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTracksBrowserInfo.Location = new System.Drawing.Point(7, 7);
            this.txtTracksBrowserInfo.Multiline = true;
            this.txtTracksBrowserInfo.Name = "txtTracksBrowserInfo";
            this.txtTracksBrowserInfo.Size = new System.Drawing.Size(145, 212);
            this.txtTracksBrowserInfo.TabIndex = 4;
            // 
            // tabPageActivityStats
            // 
            this.tabPageActivityStats.Controls.Add(this.tableLayoutActivityStats);
            this.tabPageActivityStats.Location = new System.Drawing.Point(4, 22);
            this.tabPageActivityStats.Name = "tabPageActivityStats";
            this.tabPageActivityStats.Size = new System.Drawing.Size(1154, 519);
            this.tabPageActivityStats.TabIndex = 1;
            this.tabPageActivityStats.Text = "Activity stats";
            this.tabPageActivityStats.UseVisualStyleBackColor = true;
            // 
            // tableLayoutActivityStats
            // 
            this.tableLayoutActivityStats.ColumnCount = 1;
            this.tableLayoutActivityStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutActivityStats.Controls.Add(this.panel2, 0, 0);
            //this.tableLayoutActivityStats.Controls.Add(this.chartActivityStats, 0, 1);
            this.tableLayoutActivityStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutActivityStats.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutActivityStats.Name = "tableLayoutActivityStats";
            this.tableLayoutActivityStats.RowCount = 2;
            this.tableLayoutActivityStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutActivityStats.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutActivityStats.Size = new System.Drawing.Size(1154, 519);
            this.tableLayoutActivityStats.TabIndex = 0;
            // 
            // cmbActivityRange
            // 
            this.cmbActivityRange.FormattingEnabled = true;
            this.cmbActivityRange.Location = new System.Drawing.Point(0, 3);
            this.cmbActivityRange.Name = "cmbActivityRange";
            this.cmbActivityRange.Size = new System.Drawing.Size(121, 21);
            this.cmbActivityRange.TabIndex = 4;
            this.cmbActivityRange.SelectedIndexChanged += new System.EventHandler(this.cmbActivityRange_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblActivityStatsTitle);
            this.panel2.Controls.Add(this.cmbActivityRange);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1148, 26);
            this.panel2.TabIndex = 1;
            // 
            // lblActivityStatsTitle
            // 
            this.lblActivityStatsTitle.AutoSize = true;
            this.lblActivityStatsTitle.Location = new System.Drawing.Point(172, 6);
            this.lblActivityStatsTitle.Name = "lblActivityStatsTitle";
            this.lblActivityStatsTitle.Size = new System.Drawing.Size(95, 13);
            this.lblActivityStatsTitle.TabIndex = 5;
            this.lblActivityStatsTitle.Text = "lblActivityStatsTitle";
            // 
            // chartActivityStats
            // 
            //chartArea1.Name = "ChartArea1";
            //this.chartActivityStats.ChartAreas.Add(chartArea1);
            //this.chartActivityStats.Dock = System.Windows.Forms.DockStyle.Fill;
            //legend1.Name = "Legend1";
            //this.chartActivityStats.Legends.Add(legend1);
            //this.chartActivityStats.Location = new System.Drawing.Point(3, 35);
            //this.chartActivityStats.Name = "chartActivityStats";
            //series1.ChartArea = "ChartArea1";
            //series1.Legend = "Legend1";
            //series1.Name = "Series1";
            //this.chartActivityStats.Series.Add(series1);
            //this.chartActivityStats.Size = new System.Drawing.Size(1148, 481);
            //this.chartActivityStats.TabIndex = 2;
            //this.chartActivityStats.Text = "chart1";
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 570);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "StatsForm";
            this.Text = "Stats";
            this.Load += new System.EventHandler(this.StatsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageTracksBrowser.ResumeLayout(false);
            this.tableLayoutTracksBrowser.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainerTracksBrowser.Panel1.ResumeLayout(false);
            this.splitContainerTracksBrowser.Panel1.PerformLayout();
            this.splitContainerTracksBrowser.Panel2.ResumeLayout(false);
            this.splitContainerTracksBrowser.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTracksBrowser)).EndInit();
            this.splitContainerTracksBrowser.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPageActivityStats.ResumeLayout(false);
            this.tableLayoutActivityStats.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            //((System.ComponentModel.ISupportInitialize)(this.chartActivityStats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageTracksBrowser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutTracksBrowser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.SplitContainer splitContainerTracksBrowser;
        private GMap.NET.WindowsForms.GMapControl gMapTracksBrowser;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel zoomLabel;
        private System.Windows.Forms.ToolStripStatusLabel lblMapPoints;
        private System.Windows.Forms.Label lblTracksPosition;
        private System.Windows.Forms.TextBox txtTracksBrowserInfo;
        private System.Windows.Forms.TabPage tabPageActivityStats;
        private System.Windows.Forms.TableLayoutPanel tableLayoutActivityStats;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblActivityStatsTitle;
        private System.Windows.Forms.ComboBox cmbActivityRange;
        //private System.Windows.Forms.DataVisualization.Charting.Chart chartActivityStats;
    }
}