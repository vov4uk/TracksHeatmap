using Geo.Geodesy;
using Geo.Gps;
using Geo.Gps.Serialization;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TracksHeatmap
{
    public class TracksAnimator
    {
        private TracksOptimiserOptions tracksOptimiserOptions;
        private Geo.Gps.Track track;
        private string outImagesFolder;
        private int imageStep = 0;
        private PointLatLng lastPointLatLng = PointLatLng.Empty;
        private int upDownAnimationStep = 200;
        private GMapOverlay tracksMarkersOverlay;
        private bool drawMarkers = true;
        GMapOverlay tracksPolygonsOverlay;
        GMapOverlay tracksPolygons2Overlay;
        GMapOverlay tracksPolygons3Overlay;

        public int Progress;

        public TracksAnimator(TracksOptimiserOptions tracksOptimiserOptions)
        {
            this.tracksOptimiserOptions = tracksOptimiserOptions;
        }

        public List<Waypoint> InitAnimation(GMapControl gMap, List<Geo.Gps.Track> tracks, int upDownAnimationStep, bool drawMarkers, bool increasePointsDensity)
        {
            this.upDownAnimationStep = upDownAnimationStep;
            outImagesFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\TracksAnimator";
            if (!Directory.Exists(outImagesFolder))
                Directory.CreateDirectory(outImagesFolder);
            imageStep = 0;

            tracksMarkersOverlay = FindOverlay(Constants.TracksMarkers, gMap);
            if (tracksMarkersOverlay == null)
            {
                tracksMarkersOverlay = new GMapOverlay(Constants.TracksMarkers);
                gMap.Overlays.Add(tracksMarkersOverlay);
            }

            List<Waypoint> fixes = new List<Waypoint>();

            track = tracks[0];
            fixes.Add(track.GetFirstWaypoint());
            fixes.Add(track.GetLastWaypoint());

            TracksOptimiser tracksOptimiser = new TracksOptimiser();
            if (increasePointsDensity)
            {
                tracksOptimiserOptions.MultiplyPointDensity = 2;
            }
            tracksOptimiser.Run(gMap, new List<Geo.Gps.Track> { track }, tracksOptimiserOptions);
            tracksOptimiserOptions.MultiplyPointDensity = 1;

            tracksPolygonsOverlay = FindOverlay(Constants.TracksPolygonsId, gMap);
            tracksPolygons2Overlay = FindOverlay(Constants.TracksPolygons2Id, gMap);
            tracksPolygons3Overlay = FindOverlay(Constants.TracksPolygons3Id, gMap);

            if (drawMarkers)
            {
                GMapMarker marker = new GMarkerGoogle(new PointLatLng(fixes[0].Coordinate.Latitude, fixes[0].Coordinate.Longitude), GMarkerGoogleType.green_big_go);
                tracksMarkersOverlay.Markers.Add(marker);

                GMapMarker markerCurrent = new GMarkerGoogle(new PointLatLng(fixes[1].Coordinate.Latitude, fixes[1].Coordinate.Longitude), GMarkerGoogleType.orange_dot);
                markerCurrent.IsVisible = false;
                tracksMarkersOverlay.Markers.Add(markerCurrent);

                GMapMarker markerEnd = new GMarkerGoogle(new PointLatLng(fixes[1].Coordinate.Latitude, fixes[1].Coordinate.Longitude), GMarkerGoogleType.red_big_stop);
                tracksMarkersOverlay.Markers.Add(markerEnd);

                gMap.Refresh();
                
                // save 3 end frames
                for (int i = 0; i < 3; i++)
                {
                    SaveFrame(gMap);
                }

                markerCurrent.IsVisible = true;
                tracksMarkersOverlay.Markers.RemoveAt(2);
            }

            return fixes;
        }

        private void SaveFrame(GMapControl gMap)
        {
            //gMap.ToImage().Save(outImagesFolder + "\\tmp" + imageStep + ".png");
            gMap.ToImage().Save(outImagesFolder + "\\tmp" + imageStep + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            imageStep++;
        }

        public bool AnimationStep(GMapControl gMap)
        {
            if (TruncateTrack(gMap))
            {
                GMapOverlay tracksPolygonsOverlay = FindOverlay(Constants.TracksPolygonsId, gMap);
                GMapRoute route = tracksPolygonsOverlay.Routes[0];

                if (drawMarkers)
                {
                    tracksMarkersOverlay.Markers[1].Position = route.Points.Last();
                }

                Progress = route.Points.Count;
                gMap.Refresh();

                SaveFrame(gMap);

                return true;
            }
            else
            {
                for (int i = 0; i < imageStep; i++) {
                    File.Move(outImagesFolder + "\\tmp" + i + ".jpg", outImagesFolder + "\\" + (imageStep - i).ToString("D6") + ".jpg");
                }

                return false;
            }
        }

        private bool TruncateTrack(GMapControl gMap)
        {
            MakeOverlaysVisible(false);
            GMapRoute route = tracksPolygonsOverlay.Routes[0];

            SpheroidCalculator spheroidCalculator = new SpheroidCalculator();
            for (int pointIndex = route.Points.Count - 1; pointIndex >= 0; pointIndex--)
            {
                var point = route.Points[pointIndex];

                Geo.Coordinate point1 = new Waypoint(lastPointLatLng.Lat, lastPointLatLng.Lng).Coordinate;
                Geo.Coordinate point2 = new Waypoint(point.Lat, point.Lng).Coordinate;

                if (!lastPointLatLng.IsEmpty && Math.Abs(spheroidCalculator.CalculateLength(new Geo.CoordinateSequence(point1, point2)).SiValue) < upDownAnimationStep)
                {
                    RemovePoint(route, pointIndex);
                    if (tracksPolygons2Overlay.Routes.Count > 0)
                    {
                        RemovePoint(tracksPolygons2Overlay.Routes[0], pointIndex);
                    }
                    if (tracksPolygons3Overlay.Routes.Count > 0)
                    {
                        RemovePoint(tracksPolygons3Overlay.Routes[0], pointIndex);
                    }
                    continue;
                }

                lastPointLatLng = point;

                MakeOverlaysVisible(true);
                return true;
            }

            MakeOverlaysVisible(true);
            return false;
        }

        private void MakeOverlaysVisible(bool visible)
        {
            tracksPolygonsOverlay.IsVisibile = visible;
            tracksPolygons2Overlay.IsVisibile = visible;
            tracksPolygons3Overlay.IsVisibile = visible;
        }

        private void RemovePoint(GMapRoute route, int pointIndex)
        {
            route.Points.RemoveAt(pointIndex);
            route.LocalPoints.RemoveAt(pointIndex);
        }

        public static GMapOverlay FindOverlay(string overlayId, GMapControl gMap)
        {
            foreach (var overlay in gMap.Overlays)
                if (overlay.Id == overlayId)
                    return overlay;

            return null;
        }
    }
}
