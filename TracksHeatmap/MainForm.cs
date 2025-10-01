using Geo.Geodesy;
using Geo.Gps;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System.Configuration;
using System.Data;

namespace TracksHeatmap
{
    public partial class MainForm : Form
    {
        private List<GMapProvider> mapTypes = new List<GMapProvider>();
        private List<Geo.Gps.Track> Tracks;
        private TracksAnimator tracksAnimator;

        public MainForm()
        {
            InitializeComponent();


            //var section = ConfigurationManager.GetSection("System.Windows.Forms.ApplicationConfigurationSection") as NameValueCollection;
            //var value = section["DpiAwareness"];

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // Get the appSettings section.
            //AppSettingsSection appSettings = (AppSettingsSection)config.GetSection("System.Windows.Forms.ApplicationSettingsSection");
            //var dpiAware = appSettings.Settings["DpiAwareness"].Value;

            //lblDpiAware.Text = "Dpi awareness: " + dpiAware;

            //appSettings.Settings["DpiAwareness"].Value = "PerMonitorV2";
            //appSettings.Settings["DpiAwareness"].Value = "unaware";
            //config.Save();


            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            splitContainer1.Panel2MinSize = groupBox2.Width + 2 * groupBox2.Left;
            MainForm_Resize(null, EventArgs.Empty);

            mapTypes.Add(GMapProviders.ArcGIS_World_Topo_Map);
            mapTypes.Add(GMapProviders.ArcGIS_World_Street_Map);
            mapTypes.Add(GMapProviders.ArcGIS_StreetMap_World_2D_Map);
            mapTypes.Add(GMapProviders.BingMap);
            mapTypes.Add(GMapProviders.GoogleMap);
            mapTypes.Add(GMapProviders.GoogleHybridMap);
            mapTypes.Add(GMapProviders.GoogleTerrainMap);
            mapTypes.Add(GMapProviders.GoogleSatelliteMap);
            mapTypes.Add(GMapProviders.CzechMap);
            mapTypes.Add(GMapProviders.CzechTuristMap);
            mapTypes.Add(GMapProviders.OpenCycleMap);
            mapTypes.Add(GMapProviders.OpenCycleTransportMap);
            mapTypes.Add(GMapProviders.OpenCycleLandscapeMap);
            mapTypes.Add(GMapProviders.OpenStreet4UMap);
            mapTypes.Add(GMapProviders.OpenStreetMap);
            mapTypes.Add(GMapProviders.OpenStreetMapGraphHopper);
            mapTypes.Add(GMapProviders.YandexMap);
            mapTypes.Add(GMapProviders.WikiMapiaMap);
            mapTypes.Add(GMapProviders.UMPMap);

            foreach (GMapProvider mapType in mapTypes)
            {
                cmbMapType.Items.Add(GetMapName(mapType));
            }

            var tracksStyles = Enum.GetValues(typeof(TracksStyles)).Cast<TracksStyles>();
            foreach (var style in tracksStyles)
            {
                cmbPlotStyle.Items.Add(style.ToString().Replace("_", " "));
            }
            cmbPlotStyle.SelectedIndex = tracksStyles.Count() - 1;

            Version version = System.Reflection.Assembly.GetEntryAssembly().GetName().Version;
            this.Text = "Tracks heatmap (" + version.Major + "." + version.Minor + ")";

            this.btnTrackColor.ForeColor = Color.FromArgb(255, 255, 3, 18);
        }

        private string GetMapName(GMapProvider mapType)
        {
            if (mapType == GMapProviders.CzechMap) return "Mapy.cz";
            else if (mapType == GMapProviders.CzechTuristMap) return "Mapy.cz turist";

            return mapType.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chkKeepAspectRatio.Checked = true;
            chkAsVisible.Checked = true;
            menuTrackName.Visible = false;

            cmbMapType.SelectedIndex = mapTypes.IndexOf(GMapProviders.OpenStreetMap);

            gMap.DragButton = MouseButtons.Left;
            gMap.Position = new PointLatLng(50.059721, 22.4930113);
            gMap.Zoom = 12;
        }

        private void gMap_OnMapZoomChanged()
        {
            zoomLabel.Text = "Zoom: " + gMap.Zoom.ToString("F1");
            UpdateExportZoom();
            LoadTracksToMap();
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            gMap.Zoom += 1;
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            gMap.Zoom -= 1;
        }

        private void cmbMapType_SelectedIndexChanged(object sender, EventArgs e)
        {
            gMap.MapProvider = mapTypes[cmbMapType.SelectedIndex];
            gMap.Refresh();
        }

        private void btnLoadFiles_Click(object sender, EventArgs e)
        {
            LoadTracksForm loadTracksForm = new LoadTracksForm();
            loadTracksForm.ViewArea = gMap.ViewArea;

            if (loadTracksForm.ShowDialog() == DialogResult.OK)
            {
                TimeSpan totalTime = loadTracksForm.TotalTime;
                lblTracks.Text = "Tracks: " + loadTracksForm.Tracks.Count + ";  " + (loadTracksForm.TotalDistance / 1000).ToString("F2") + "km;  " + totalTime.TotalHours.ToString("F1") + "h";
                this.Tracks = loadTracksForm.Tracks;
                txtInfo.Text = loadTracksForm.GetInfo();
                LoadTracksToMap();

                if (loadTracksForm.CenterTracks)
                {
                    // center tracks after loading
                    btnCenterTracks_Click(sender, e);
                }
            }
        }

        private void LoadTracksToMap()
        {
            if (Tracks == null) return;

            TracksOptimiser tracksOptimiser = UpdateTracksPlot();
            if (tracksOptimiser != null)
                lblMapPoints.Text = tracksOptimiser.Info;
        }

        private void gMap_SizeChanged(object sender, EventArgs e)
        {
            LoadTracksToMap();
            chkKeepAspectRatio_CheckedChanged(sender, e);
        }

        private void btnCenterTracks_Click(object sender, EventArgs e)
        {
            GMapOverlay tracksPolygonsOverlay = TracksOptimiser.FindOverlay(Constants.TracksPolygonsId, gMap);
            if (tracksPolygonsOverlay != null && tracksPolygonsOverlay.Routes.Count > 0)
            {
                gMap.ZoomAndCenterRoutes(tracksPolygonsOverlay.Id);
            }
        }

        private void chkKeepAspectRatio_CheckedChanged(object sender, EventArgs e)
        {
            numExportHeight.Enabled = !chkKeepAspectRatio.Checked;

            if (chkAsVisible.Checked)
            {
                numExportWidth.Value = gMap.Size.Width;
                numExportHeight.Value = gMap.Size.Height;
            }
            else if (chkKeepAspectRatio.Checked)
            {
                double ratio = (double)gMap.Size.Height / gMap.Size.Width;
                numExportHeight.Value = (int)(ratio * Convert.ToDouble(numExportWidth.Value));
            }

            UpdateExportZoom();
        }

        private void UpdateExportZoom()
        {
            numExportZoom.Enabled = chkExportZoomOverride.Checked;

            if (gMap.Zoom > 1)
            {
                if (chkAsVisible.Checked)
                {
                    numExportZoom.Value = (int)gMap.Zoom;
                }
                else if (!numExportZoom.Enabled)
                {
                    double zoom = gMap.Zoom + Math.Ceiling(Math.Sqrt(Convert.ToDouble(numExportWidth.Value) / gMap.Size.Width));
                    numExportZoom.Value = (int)zoom;
                }
            }
        }

        private void btnTrackColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = btnTrackColor.ForeColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnTrackColor.ForeColor = colorDialog.Color;
                numTrackWidth_ValueChanged(sender, e);
            }
        }

        private void numTrackWidth_ValueChanged(object sender, EventArgs e)
        {
            UpdateTracksPlot();
        }

        private TracksOptimiser UpdateTracksPlot()
        {
            if (Tracks == null) return null;

            TracksOptimiser tracksOptimiser = new TracksOptimiser();
            tracksOptimiser.Run(this.gMap, this.Tracks, GetTrackOptions());

            return tracksOptimiser;
        }

        private TracksOptimiserOptions GetTrackOptions()
        {
            TracksOptimiserOptions options = new TracksOptimiserOptions();

            options.TrackColor = btnTrackColor.ForeColor;
            options.TrackWidth = (int)numTrackWidth.Value;
            options.TracksStyles = (TracksStyles)cmbPlotStyle.SelectedIndex;
            options.BackgroundColor = btnTrackBakground.BackColor;
            options.BackgroundColor2 = btnTrackBakground2.BackColor;
            options.TrackBackgroundWidth = Convert.ToDouble(numBakgroundWidth.Value);
            options.TrackBackground2Width = Convert.ToDouble(numBakground2Width.Value);
            options.DisconnectGapPoints = chkDisconnectGapPoints.Checked;
            options.DisconnectTrackGapsMultiple = Convert.ToDouble(numDisconnectTrackGaps.Value);

            return options;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            chkKeepAspectRatio_CheckedChanged(sender, e);

            if (chkAsVisible.Checked)
            {
                menuSaveAsImage_Click(sender, e);
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.Filter = "PNG|*.png|JPG|*.jpg";
                saveFileDialog.FilterIndex = 0;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportForm export = new ExportForm();
                    export.Tracks = this.Tracks;
                    export.gmap = this.gMap;
                    export.TracksOptimiserOptions = GetTrackOptions();
                    export.exportWidth = (int)numExportWidth.Value;
                    export.exportHeight = (int)numExportHeight.Value;
                    export.exportZoom = Convert.ToInt32(numExportZoom.Value);
                    export.filename = saveFileDialog.FileName;
                    export.ShowDialog();
                }
            }
        }

        private void numExportWidth_ValueChanged(object sender, EventArgs e)
        {
            chkKeepAspectRatio_CheckedChanged(sender, e);
        }

        private void chkAsVisible_CheckedChanged(object sender, EventArgs e)
        {
            numExportWidth.Enabled = !chkAsVisible.Checked;
            chkKeepAspectRatio.Enabled = !chkAsVisible.Checked;
            chkKeepAspectRatio_CheckedChanged(sender, e);
        }

        private void menuSaveAsImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.Filter = "PNG|*.png|JPG|*.jpg";
            saveFileDialog.FilterIndex = 0;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                gMap.ToImage().Save(saveFileDialog.FileName);
            }
        }

        private void gMap_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                PointLatLng coordinate = gMap.FromLocalToLatLng(e.X, e.Y);
                menuGPSposition.Text = coordinate.Lat.ToString("F4") + ", " + coordinate.Lng.ToString("F4");

                contextMenuStrip1.Show(gMap, e.Location);
            }
            else
            {
                menuTrackName.Visible = false;
                lblSelectedRoute.Text = String.Empty;
            }
        }

        private void menuGPSposition_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(((ToolStripMenuItem)sender).Text);
        }

        private void btnTrackBakground_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = btnTrackBakground.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnTrackBakground.BackColor = colorDialog.Color;
                numTrackWidth_ValueChanged(sender, e);
            }
        }

        private void btnTrackBakground2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = btnTrackBakground2.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnTrackBakground2.BackColor = colorDialog.Color;
                numTrackWidth_ValueChanged(sender, e);
            }
        }

        private void gMap_OnRouteClick(GMapRoute item, MouseEventArgs e)
        {
            lblSelectedRoute.Text = item.Tag.ToString();
            menuTrackName.Text = item.Tag.ToString();
            menuTrackName.Visible = true;
        }

        private void cmbPlotStyle_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateTracksPlot();
        }

        private void chkDisconnectGapPoints_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTracksPlot();
        }

        private void btnMoreStats_Click(object sender, EventArgs e)
        {
            StatsForm statsForm = new StatsForm();
            statsForm.Tracks = this.Tracks;
            statsForm.TracksOptimiserOptions = GetTrackOptions();
            statsForm.MapProvider = gMap.MapProvider;
            statsForm.ShowDialog();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            int width = splitContainer1.Width - splitContainer1.Panel2MinSize;
            if (width > splitContainer1.Panel1MinSize)
            {
                splitContainer1.SplitterDistance = width;
            }
        }

        private void btnSaveAllAsOne_Click(object sender, EventArgs e)
        {
            string lineBreak = string.Empty;// Environment.NewLine;
            int count = 0;
            SpheroidCalculator spheroidCalculator = new SpheroidCalculator();

            using (TextWriter file = new StreamWriter(@"C:\Users\lynnx\Desktop\all.gpx", false))
            {
                file.Write("<?xml version=\"1.0\" encoding=\"UTF-8\"?><gpx xmlns=\"http://www.topografix.com/GPX/1/1\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" version=\"1.1\" xsi:schemaLocation=\"http://www.topografix.com/GPX/1/1 http://www.topografix.com/GPX/1/1/gpx.xsd\" creator=\"TracksHeatmap\">" + lineBreak);

                foreach (var track in this.Tracks)
                {
                    file.Write("<trk><name>" + track.GetFirstWaypoint().TimeUtc.Value.ToString("yyyy-MM-dd") + " " + track.Metadata["name"] + "</name>" + lineBreak);

                    foreach (var segment in track.Segments)
                    {
                        file.Write("<trkseg>" + lineBreak);

                        Geo.Gps.Waypoint lastPoint = null;
                        foreach (var point in segment.Waypoints)
                        {
                            if (lastPoint != null && Math.Abs(spheroidCalculator.CalculateLength(new Geo.CoordinateSequence(lastPoint.Coordinate, point.Coordinate)).SiValue) < 200)
                            {
                                continue;
                            }

                            file.Write("<trkpt lat=\"" + point.Coordinate.Latitude.ToString("F6") + "\" lon=\"" + point.Coordinate.Longitude.ToString("F6") + "\">" + lineBreak);
                            file.Write("<time>" + point.TimeUtc.Value.ToString("yyyy-MM-ddTHH:mm:ssZ") + "</time>" + lineBreak);
                            file.Write("</trkpt>" + lineBreak);
                            lastPoint = point;
                        }

                        file.Write("</trkseg>" + lineBreak);
                    }
                    file.Write("</trk>" + lineBreak);
                    count++;
                    //if (count > 500) break;
                }

                file.Write("</gpx>" + lineBreak);
            }

            MessageBox.Show("done.");
        }

        private void timerAnimation_Tick(object sender, EventArgs e)
        {
            timerAnimation.Enabled = false;
            if (tracksAnimator.AnimationStep(this.gMap))
            {
                lblAnimationInfo.Text = "Track points left: " + tracksAnimator.Progress;
                timerAnimation.Enabled = true;
            }
            else
            {
                lblAnimationInfo.Text = "Track points left: done";
                btnAnimateSingle.Enabled = true;
            }
        }

        private void btnAnimateSingle_Click(object sender, EventArgs e)
        {
            btnAnimateSingle.Enabled = false;
            this.tracksAnimator = new TracksAnimator(GetTrackOptions());
            List<Waypoint> fixes = tracksAnimator.InitAnimation(this.gMap, this.Tracks, Convert.ToInt32(this.upDownAnimationStep.Value), chkAnimationDrawMarkers.Checked, chkIncreasePointsDensity.Checked);

            timerAnimation.Enabled = true;
        }

        private void cmbDpiAwareness_SelectedIndexChanged(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // Get the appSettings section.
            AppSettingsSection appSettings = (AppSettingsSection)config.GetSection("System.Windows.Forms.ApplicationConfigurationSection");
            var dpiAware = appSettings.Settings["DpiAwareness"].Value;

            appSettings.Settings["DpiAwareness"].Value = cmbDpiAwareness.SelectedItem.ToString();

            config.Save();
        }
    }
}
