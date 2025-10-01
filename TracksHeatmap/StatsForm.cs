using Geo.Gps;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System.Data;
using System.Text;
//using System.Windows.Forms.DataVisualization.Charting;

namespace TracksHeatmap
{
    public partial class StatsForm : Form
    {
        enum Ranges { Yearly, Monthly, Daily }
        private int currentTrackIdx;

        public List<Track> Tracks;
        public TracksOptimiserOptions TracksOptimiserOptions;
        public GMapProvider MapProvider;

        public StatsForm()
        {
            InitializeComponent();

            var ranges = Enum.GetValues(typeof(Ranges)).Cast<Ranges>();
            foreach (var range in ranges)
            {
                cmbActivityRange.Items.Add(range.ToString());
            }

            tabControl1.TabPages.Remove(tabPageActivityStats);
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            this.gMapTracksBrowser.Zoom += 1;
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            this.gMapTracksBrowser.Zoom -= 1;
        }

        private void StatsForm_Load(object sender, EventArgs e)
        {
            gMapTracksBrowser.DragButton = MouseButtons.Left;
            gMapTracksBrowser.Position = new PointLatLng(50.059721, 22.4930113);
            gMapTracksBrowser.Zoom = 12;
            gMapTracksBrowser.MapProvider = this.MapProvider;
            gMapTracksBrowser.Refresh();

            if (Tracks != null && Tracks.Count > 0)
            {
                currentTrackIdx = Tracks.Count - 1;
                LoadTrackToMap(currentTrackIdx, true);
            }
            else
            {
                lblTracksPosition.Text = "(no tracks)";
            }
            UpdatePreviousNextButtons();
        }

        private void LoadTrackToMap(int idx, bool zoomTrack)
        {
            if (Tracks == null || idx >= Tracks.Count) return;

            lblTracksPosition.Text = (idx + 1) + " of " + Tracks.Count;

            TracksOptimiser tracksOptimiser = new TracksOptimiser();
            tracksOptimiser.Run(gMapTracksBrowser, new List<Track>() { this.Tracks[idx] }, TracksOptimiserOptions);

            if (tracksOptimiser != null)
                lblMapPoints.Text = tracksOptimiser.Info;

            GMapOverlay tracksPolygonsOverlay = TracksOptimiser.FindOverlay(Constants.TracksPolygonsId, gMapTracksBrowser);
            if (tracksPolygonsOverlay != null && tracksPolygonsOverlay.Routes.Count > 0)
            {
                Track track = this.Tracks[idx];
                StringBuilder text = new StringBuilder();
                text.AppendLine("Distance: " + (track.GetLength().SiValue / 1000).ToString("F2") + "km");

                TimeSpan TotalTime = track.GetDuration();
                text.Append("Time: ");
                if (TotalTime.Days > 0) text.Append(TotalTime.Days + "d ");
                if (TotalTime.Hours > 0) text.Append(TotalTime.Hours + "h ");
                if (TotalTime.Minutes > 0) text.Append(TotalTime.Minutes + "m ");
                text.AppendLine();

                text.AppendLine("Avg. speed: " + track.GetAverageSpeed().ConvertTo(Geo.Measure.SpeedUnit.Kph).Value.ToString("F2") + "km/h");
                txtTracksBrowserInfo.Text = text.ToString();

                if (zoomTrack)
                {
                    gMapTracksBrowser.ZoomAndCenterRoutes(tracksPolygonsOverlay.Id);
                }
            }
        }

        private void UpdatePreviousNextButtons()
        {
            btnPrevious.Enabled = this.Tracks != null && this.Tracks.Count > 0 && this.currentTrackIdx > 0;
            btnNext.Enabled = this.Tracks != null && this.Tracks.Count > 0 && this.currentTrackIdx < this.Tracks.Count - 1;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.currentTrackIdx++;
            UpdatePreviousNextButtons();
            LoadTrackToMap(this.currentTrackIdx, true);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.currentTrackIdx--;
            UpdatePreviousNextButtons();
            LoadTrackToMap(this.currentTrackIdx, true);
        }

        private void gMapTracksBrowser_OnMapZoomChanged()
        {
            zoomLabel.Text = "Zoom: " + gMapTracksBrowser.Zoom.ToString("F1");
            LoadTrackToMap(this.currentTrackIdx, false);
        }

        private void gMapTracksBrowser_SizeChanged(object sender, EventArgs e)
        {
            LoadTrackToMap(this.currentTrackIdx, true);
        }

        private void cmbActivityRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ShowActivityStats();
        }

        //private void ShowActivityStats()
        //{
        //    this.chartActivityStats.ChartAreas[0].AxisX.Minimum = 5;

        //    for (int i = 0; i < 12; i++)
        //    {
        //        DataPoint point = new DataPoint(i + 1, i * 2);
        //        point.AxisLabel = "aa";
        //        this.chartActivityStats.Series[0].Points.Add(point);
        //    }
        //}
    }
}
