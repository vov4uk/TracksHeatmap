using GMap.NET;
using GMap.NET.WindowsForms;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace TracksHeatmap
{
    public partial class ExportForm : Form
    {
        public List<Geo.Gps.Track> Tracks;
        public GMapControl gmap;
        public int exportWidth;
        public int exportHeight;
        public string filename;
        public TracksOptimiserOptions TracksOptimiserOptions;
        public int exportZoom = 12;

        BackgroundWorker worker = new BackgroundWorker();
        List<GPoint> list;
        int all;
        private GMap.NET.GSize maxOfTiles;
        private readonly AutoResetEvent done = new AutoResetEvent(true);
        private readonly Queue<GPoint> CachedTiles = new Queue<GPoint>();

        public ExportForm()
        {
            InitializeComponent();

            GMaps.Instance.OnTileCacheComplete += new TileCacheComplete(OnTileCacheComplete);
            GMaps.Instance.OnTileCacheStart += new TileCacheStart(OnTileCacheStart);
            GMaps.Instance.OnTileCacheProgress += new TileCacheProgress(OnTileCacheProgress);

            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.ProgressChanged += new ProgressChangedEventHandler(worker_ProgressChanged);
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
        }

        private void ExportForm_Load(object sender, EventArgs e)
        {
            gMapExport.Zoom = exportZoom;

            int ratio = Convert.ToInt32(Math.Pow(2, gMapExport.Zoom - gmap.Zoom));

            gMapExport.Size = new Size(gmap.Size.Width * ratio, gmap.Size.Height * ratio);

            TracksOptimiser tracksOptimiser = new TracksOptimiser();
            tracksOptimiser.ZoomRatio = Math.Round(exportZoom - gmap.Zoom, 1);
            tracksOptimiser.Run(gMapExport, this.Tracks, this.TracksOptimiserOptions);

            gMapExport.Position = gmap.Position;
            gMapExport.ScaleMode = ScaleModes.Integer;
            gMapExport.ShowCenter = false;

            gMapExport.MapProvider = gmap.MapProvider;

            gMapExport.ReloadMap();
            gMapExport.Refresh();

            StartPrefetch();
        }

        private Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        #region Map events

        void OnTileCacheComplete()
        {
            Console.WriteLine("OnTileCacheComplete");

            if (!IsDisposed)
            {
                done.Set();
            }
        }

        void OnTileCacheStart()
        {
            Console.WriteLine("OnTileCacheStart");

            if (!IsDisposed)
            {
                done.Reset();
            }
        }

        void OnTileCacheProgress(int left)
        {
            Console.WriteLine(left + " tile to save...");
        }

        #endregion

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ResizeImage(gMapExport.ToImage(), this.exportWidth, this.exportHeight).Save(this.filename);

            list.Clear();

            GMaps.Instance.UseMemoryCache = true;
            GMaps.Instance.CacheOnIdleRead = true;
            GMaps.Instance.BoostCacheEngine = false;

            worker.Dispose();

            this.DialogResult = DialogResult.OK;
        }

        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Console.WriteLine("Fetching tile at zoom (" + gMapExport.Zoom + "): " + ((int)e.UserState).ToString() + " of " + all + ", complete: " + e.ProgressPercentage.ToString() + "%");
            lblProgressInfo.Text = e.ProgressPercentage.ToString() + "%";
        }

        bool CacheTiles(int zoom, GPoint p)
        {
            foreach (var pr in gMapExport.MapProvider.Overlays)
            {
                Exception ex;
                PureImage img;

                // tile number inversion(BottomLeft -> TopLeft)
                if (pr.InvertedAxisY)
                {
                    img = GMaps.Instance.GetImageFrom(pr, new GPoint(p.X, maxOfTiles.Height - p.Y), zoom, out ex);
                }
                else // ok
                {
                    img = GMaps.Instance.GetImageFrom(pr, p, zoom, out ex);
                }

                if (img != null)
                {
                    img.Dispose();
                    img = null;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (list != null)
            {
                list.Clear();
                list = null;
            }
            list = gMapExport.MapProvider.Projection.GetAreaTileList(gMapExport.ViewArea, (int)gMapExport.Zoom, 0);
            maxOfTiles = gMapExport.MapProvider.Projection.GetTileMatrixMaxXY((int)gMapExport.Zoom);
            all = list.Count;

            int countOk = 0;
            int retryCount = 0;

            lock (this)
            {
                CachedTiles.Clear();
            }

            for (int i = 0; i < all; i++)
            {
                if (worker.CancellationPending)
                    break;

                GPoint p = list[i];
                {
                    if (CacheTiles((int)gMapExport.Zoom, p))
                    {
                        countOk++;
                        retryCount = 0;
                    }
                    else
                    {
                        if (++retryCount <= 2) // retry only one
                        {
                            i--;
                            System.Threading.Thread.Sleep(1234);
                            continue;
                        }
                        else
                        {
                            retryCount = 0;
                        }
                    }
                }

                worker.ReportProgress((int)((i + 1) * 100 / all), i + 1);
            }

            e.Result = countOk;

            if (!IsDisposed)
            {
                done.WaitOne();
            }
        }

        public void StartPrefetch()
        {
            if (!worker.IsBusy)
            {
                GMaps.Instance.UseMemoryCache = false;
                GMaps.Instance.CacheOnIdleRead = false;
                GMaps.Instance.BoostCacheEngine = true;

                worker.RunWorkerAsync();
            }
        }
    }
}
