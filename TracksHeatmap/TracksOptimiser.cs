using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TracksHeatmap
{
    public enum TracksStyles { Simple, Random_colors, With_background, With_2_backgrounds }

    public class TracksOptimiser
    {
        private GMapControl gMap;
        private TracksOptimiserOptions options;

        public string Info;
        public double ZoomRatio = 1;

        public void Run(GMapControl gMap, List<Geo.Gps.Track> tracks, TracksOptimiserOptions options)
        {
            if (tracks == null) return;
            this.gMap = gMap;
            this.options = options;

            int minPixels = 10;
            switch (options.TracksStyles)
            {
                case TracksStyles.Simple: minPixels = 3; break;
                case TracksStyles.With_background: minPixels = 7; break;
                default: break;
            }

            double minimimDistance = minPixels /* at least 3 pixels */ * gMap.ViewArea.WidthLng / gMap.Size.Width;
            minimimDistance /= options.MultiplyPointDensity;
            int oldCount = 0, newCount = 0;
            GMapOverlay tracksPolygonsOverlay = FindOverlay(Constants.TracksPolygonsId, gMap);
            GMapOverlay tracksPolygons2Overlay = FindOverlay(Constants.TracksPolygons2Id, gMap);
            GMapOverlay tracksPolygons3Overlay = FindOverlay(Constants.TracksPolygons3Id, gMap);
            if (tracksPolygonsOverlay == null)
            {
                tracksPolygonsOverlay = new GMapOverlay(Constants.TracksPolygonsId);
                tracksPolygons2Overlay = new GMapOverlay(Constants.TracksPolygons2Id);
                tracksPolygons3Overlay = new GMapOverlay(Constants.TracksPolygons3Id);

                gMap.Overlays.Add(tracksPolygons3Overlay);
                gMap.Overlays.Add(tracksPolygons2Overlay);
                gMap.Overlays.Add(tracksPolygonsOverlay);
            }

            tracksPolygonsOverlay.Routes.Clear();
            tracksPolygons2Overlay.Routes.Clear();
            tracksPolygons3Overlay.Routes.Clear();

            foreach (var track in tracks)
            {
                Geo.Gps.Waypoint lastPoint = track.GetFirstWaypoint();
                string tagName = lastPoint.TimeUtc.ToString() + " " + lastPoint.TimeUtc.ToString();
                if (track.Metadata.ContainsKey("name"))
                {
                    tagName += "; " + track.Metadata["name"].ToString();
                }
                if (track.Metadata.ContainsKey("filename"))
                {
                    tagName += "; " + track.Metadata["filename"].ToString();
                }

                // add route for each segment, segments may be separate
                foreach (var segment in track.Segments)
                {
                    List<PointLatLng> mapPoints = new List<PointLatLng>();
                    lastPoint = segment.GetFirstWaypoint();
                    mapPoints.Add(new PointLatLng(lastPoint.Coordinate.Latitude, lastPoint.Coordinate.Longitude));

                    foreach (var point in segment.Waypoints)
                    {
                        if (AddPoint(mapPoints, lastPoint, point, minimimDistance, tagName))
                        {
                            lastPoint = point;
                            newCount++;
                        }

                        oldCount++;
                    }

                    // always add last point, single gpx file may be divided by tracks
                    if (segment.GetLastWaypoint() != lastPoint)
                    {
                        Geo.Gps.Waypoint newPoint = segment.GetLastWaypoint();
                        mapPoints.Add(new PointLatLng(newPoint.Coordinate.Latitude, newPoint.Coordinate.Longitude));
                    }

                    if (mapPoints.Count > 1)
                    {
                        AddRoute(mapPoints, tagName);
                    }

                }
            }

            double ratio = (double)newCount / oldCount * 100;
            Info = "Map points: " + newCount + " (" + ratio.ToString("F0") + "%)";

            gMap.Refresh();
        }

        private bool AddPoint(List<PointLatLng> mapPoints, Geo.Gps.Waypoint lastPoint, Geo.Gps.Waypoint newPoint, double minimimDistance, string tagName)
        {
            double distance = GetDistance(lastPoint.Coordinate.Latitude, lastPoint.Coordinate.Longitude, newPoint.Coordinate.Latitude, newPoint.Coordinate.Longitude);
            if (options.DisconnectGapPoints && distance >= options.DisconnectTrackGapsMultiple * minimimDistance)
            {
                // start new route if point is too far away
                AddRoute(mapPoints, tagName);
                mapPoints.Clear();
                mapPoints.Add(new PointLatLng(newPoint.Coordinate.Latitude, newPoint.Coordinate.Longitude));

                return true;
            }
            else if (distance > minimimDistance)
            {
                mapPoints.Add(new PointLatLng(newPoint.Coordinate.Latitude, newPoint.Coordinate.Longitude));
                return true;
            }

            return false;
        }

        private static readonly Random rand = new Random();

        private void AddRoute(List<PointLatLng> mapPoints, string tagName)
        {
            GMapOverlay tracksPolygonsOverlay = FindOverlay(Constants.TracksPolygonsId, gMap);
            GMapOverlay tracksPolygons2Overlay = FindOverlay(Constants.TracksPolygons2Id, gMap);
            GMapOverlay tracksPolygons3Overlay = FindOverlay(Constants.TracksPolygons3Id, gMap);

            GMapRoute route = new GMapRoute(mapPoints, "track" + tracksPolygonsOverlay.Routes.Count);

            if (options.TracksStyles == TracksStyles.Random_colors) {
                Color randColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                route.Stroke = new Pen(Color.FromArgb(255, randColor), Convert.ToSingle(options.TrackWidth * this.ZoomRatio));
            }
            else
            {
                route.Stroke = new Pen(Color.FromArgb(255, options.TrackColor), Convert.ToSingle(options.TrackWidth * this.ZoomRatio));
            }
            route.Tag = tagName;
            route.IsHitTestVisible = true;
            tracksPolygonsOverlay.Routes.Add(route);

            if (options.TracksStyles == TracksStyles.With_background || options.TracksStyles == TracksStyles.With_2_backgrounds)
            {
                GMapRoute route2 = new GMapRoute(mapPoints, "track2_" + tracksPolygons2Overlay.Routes.Count);
                route2.Stroke = new Pen(Color.FromArgb(200, options.BackgroundColor), Convert.ToSingle(options.TrackBackgroundWidth * this.ZoomRatio));
                route2.Tag = tagName;
                route2.IsHitTestVisible = true;
                tracksPolygons2Overlay.Routes.Add(route2);
            }

            if (options.TracksStyles == TracksStyles.With_2_backgrounds)
            {
                GMapRoute route3 = new GMapRoute(mapPoints, "track3_" + tracksPolygons2Overlay.Routes.Count);
                route3.Stroke = new Pen(Color.FromArgb(100, options.BackgroundColor2), Convert.ToSingle(options.TrackBackground2Width * this.ZoomRatio));
                route3.Tag = tagName;
                route3.IsHitTestVisible = true;
                tracksPolygons3Overlay.Routes.Add(route3);
            }
        }

        public static GMapOverlay FindOverlay(string overlayId, GMapControl gMap)
        {
            foreach (var overlay in gMap.Overlays)
                if (overlay.Id == overlayId)
                    return overlay;

            return null;
        }

        public static double GetDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }
    }

    public class TracksOptimiserOptions
    {
        public Color TrackColor;
        public double TrackWidth;
        public TracksStyles TracksStyles;
        public Color BackgroundColor;
        public Color BackgroundColor2 = Color.FromArgb(3, 124, 34);
        public double TrackBackgroundWidth = 4;
        public double TrackBackground2Width = 7;
        public bool DisconnectGapPoints = true;
        public double DisconnectTrackGapsMultiple = 4;
        public double MultiplyPointDensity = 1; // e.g. for animation
    }
}
