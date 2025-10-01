using Geo.Gps.Serialization;
using GMap.NET;
using System.ComponentModel;
using System.Text;
using TracksHeatmap.Properties;

namespace TracksHeatmap
{
    public partial class LoadTracksForm : Form
    {
        private string[] filenames;
        private DateTime minTrackDate = DateTime.MaxValue;
        private DateTime maxTrackDate = DateTime.MinValue;
        private double avgSpeedSum = 0;
        private int avgSpeedCount = 0;

        public List<Geo.Gps.Track> Tracks = new List<Geo.Gps.Track>();
        public double TotalDistance;
        public TimeSpan TotalTime = TimeSpan.Zero;
        public RectLatLng ViewArea;
        public bool CenterTracks;

        public LoadTracksForm()
        {
            InitializeComponent();
        }

        private void LoadTracksForm_Load(object sender, EventArgs e)
        {
            dtFrom.Value = new DateTime(DateTime.Today.Year, 1, 1);
            dtTo.Value = DateTime.Today;

            lblProgressPercent.Text = "0%";
            progressBar1.Value = 0;

            if (Settings.Default.LastSelectedPath != null && Settings.Default.LastSelectedPath.Length > 0 && Directory.Exists(Settings.Default.LastSelectedPath))
            {
                LoadFolder(Settings.Default.LastSelectedPath);
            }
        }

        private void btnLoadFolder_Click(object sender, EventArgs e)
        {
            using (var openFolderDialog = new FolderBrowserDialog())
            {
                openFolderDialog.ShowNewFolderButton = false;
                DialogResult result = openFolderDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(openFolderDialog.SelectedPath))
                {
                    Settings.Default.LastSelectedPath = openFolderDialog.SelectedPath;
                    Settings.Default.Save();
                    LoadFolder(openFolderDialog.SelectedPath);
                }
            }
        }

        private void LoadFolder(string selectedPath)
        {
            try
            {
                this.filenames = Directory.GetFiles(selectedPath, "*.gpx");
                lblFolderOrFiles.Text = "Files found: " + this.filenames.Length.ToString() + "; " + selectedPath;
            }
            catch (Exception ex)
            {
                lblFolderOrFiles.Text = "Error: " + ex.Message;
            }
        }

        private void btnLoadFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectFilesDialog = new OpenFileDialog();

            selectFilesDialog.Filter = "gpx files (*.gpx)|*.gpx";
            selectFilesDialog.FilterIndex = 0;
            selectFilesDialog.RestoreDirectory = true;
            selectFilesDialog.Multiselect = true;
            selectFilesDialog.Title = "Please select files";

            if (selectFilesDialog.ShowDialog() == DialogResult.OK)
            {
                this.filenames = selectFilesDialog.FileNames;
                lblFolderOrFiles.Text = "Files selected: " + this.filenames.Length.ToString();
            }
        }

        private void EnableControls(bool enable)
        {
            groupBoxSelectFolderFiles.Enabled = enable;
            groupBoxOptions.Enabled = enable;
            btnLoad.Enabled = enable;
            btnCancel.Enabled = enable;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            CenterTracks = chkCenterTracks.Checked;

            if (this.filenames == null || this.filenames.Length == 0)
            {
                MessageBox.Show("Select folder or files to load", "Warning");
                return;
            }

            EnableControls(false);

            var backgroundWorker = new BackgroundWorker();
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.DoWork += LoadFiles;
            backgroundWorker.ProgressChanged += worker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler((object senderCompleted, RunWorkerCompletedEventArgs eCompleted) =>
            {
                this.DialogResult = DialogResult.OK;
            });
            backgroundWorker.RunWorkerAsync();
        }

        private void LoadFiles(object sender, DoWorkEventArgs e)
        {
            int count = 0;
            this.TotalDistance = 0;

            foreach (string path in this.filenames)
            {
                if (chkFilenameMustContain.Checked && !(new FileInfo(path).Name.Contains(txtMustContain.Text)))
                    continue;

                List<Geo.Gps.Track> tracks = null;

                var gpx10 = new Gpx10Serializer();
                var gpx11 = new Gpx11Serializer();
                using (var stream = new FileStream(path, FileMode.Open))
                {
                    var streamWrapper = new StreamWrapper(stream);
                    if (gpx10.CanDeSerialize(streamWrapper))
                    {
                        var data = gpx10.DeSerialize(streamWrapper);
                        tracks = data.Tracks;
                    }
                    else if (gpx11.CanDeSerialize(streamWrapper))
                    {
                        var data = gpx11.DeSerialize(streamWrapper);
                        tracks = data.Tracks;
                    }
                }

                foreach (var track in tracks)
                {
                    if (chkAvgSpeedBetween.Checked)
                    {
                        Geo.Measure.Speed speed = track.GetAverageSpeed().ConvertTo(Geo.Measure.SpeedUnit.Kph);
                        if (speed.Value < Convert.ToDouble(numSpeedFrom.Value) || speed.Value > Convert.ToDouble(numSpeedTo.Value))
                            continue;
                    }

                    bool isAnyPointOnMap = false;

                    if (chkLoadForVisibleMap.Checked)
                    {
                        foreach (var segment in track.Segments)
                        {
                            for (int idx = segment.Waypoints.Count - 1; idx >= 0; idx--)
                            {
                                if (segment.Waypoints[idx].Coordinate.Latitude >= ViewArea.Bottom && segment.Waypoints[idx].Coordinate.Latitude <= ViewArea.Top
                                    && segment.Waypoints[idx].Coordinate.Longitude >= ViewArea.Left && segment.Waypoints[idx].Coordinate.Longitude <= ViewArea.Right)
                                {
                                    isAnyPointOnMap = true;
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        isAnyPointOnMap = true;
                    }

                    bool betweenAnyDates = false;
                    if (chkDatesBetween.Checked)
                    {
                        foreach (var segment in track.Segments)
                        {
                            for (int idx = segment.Waypoints.Count - 1; idx >= 0; idx--)
                            {
                                if (segment.Waypoints[idx].TimeUtc.Value.Date >= dtFrom.Value && segment.Waypoints[idx].TimeUtc.Value.Date <= dtTo.Value)
                                {
                                    betweenAnyDates = true;
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        betweenAnyDates = true;
                    }

                    if (isAnyPointOnMap && betweenAnyDates)
                    {
                        Geo.Gps.Waypoint firstPoint = track.GetFirstWaypoint();
                        if (firstPoint.TimeUtc < minTrackDate) minTrackDate = firstPoint.TimeUtc.Value;
                        if (firstPoint.TimeUtc > maxTrackDate) maxTrackDate = firstPoint.TimeUtc.Value;

                        this.TotalDistance += track.GetLength().Value;
                        this.TotalTime += track.GetDuration();

                        Geo.Measure.Speed speed = track.GetAverageSpeed();
                        this.avgSpeedSum += speed.SiValue;
                        this.avgSpeedCount++;

                        track.Metadata.Add("filename", new FileInfo(path).Name);
                        this.Tracks.Add(track);
                    }
                }

                count++;
                ((BackgroundWorker)sender).ReportProgress((int)((double)count / (double)this.filenames.Length * 100f));
            }

            ((BackgroundWorker)sender).ReportProgress(100);
        }

        public string GetInfo()
        {
            StringBuilder text = new StringBuilder();

            text.AppendLine(minTrackDate.ToShortDateString() + " - " + maxTrackDate.ToShortDateString());
            text.AppendLine("Tracks: " + this.Tracks.Count);
            text.AppendLine("Distance: " + (this.TotalDistance / 1000).ToString("F2") + "km");

            text.Append("Time: ");
            if (TotalTime.Days > 0) text.Append(TotalTime.Days + "d ");
            if (TotalTime.Hours > 0) text.Append(TotalTime.Hours + "h ");
            if (TotalTime.Minutes > 0) text.Append(TotalTime.Minutes + "m ");
            text.AppendLine();

            Geo.Measure.Speed speed = new Geo.Measure.Speed(this.avgSpeedSum / this.avgSpeedCount);
            text.AppendLine("Avg. speed: " + speed.ConvertTo(Geo.Measure.SpeedUnit.Kph).Value.ToString("F2") + "km/h");

            return text.ToString();
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage > progressBar1.Value)
            {
                progressBar1.Value = e.ProgressPercentage;
                lblProgressPercent.Text = e.ProgressPercentage + "%";
            }
        }

    }
}
