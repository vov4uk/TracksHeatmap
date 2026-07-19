using System.Globalization;
using System.Xml.Linq;
using Geo.Gps;

namespace TracksHeatmap
{
    internal static class TcxReader
    {
        public static List<Track> Read(Stream stream)
        {
            var tracks = new List<Track>();

            var doc = XDocument.Load(stream);
            if (doc.Root == null)
            {
                return tracks;
            }

            XNamespace ns = doc.Root.GetDefaultNamespace();

            foreach (var activity in doc.Descendants(ns + "Activity"))
            {
                var track = new Track();

                foreach (var trackElement in activity.Descendants(ns + "Track"))
                {
                    var segment = new TrackSegment();

                    foreach (var trackpoint in trackElement.Elements(ns + "Trackpoint"))
                    {
                        var waypoint = ParseTrackpoint(trackpoint, ns);
                        if (waypoint != null)
                        {
                            segment.Waypoints.Add(waypoint);
                        }
                    }

                    if (segment.Waypoints.Count > 0)
                    {
                        track.Segments.Add(segment);
                    }
                }

                if (track.Segments.Count > 0)
                {
                    tracks.Add(track);
                }
            }

            return tracks;
        }

        private static Waypoint? ParseTrackpoint(XElement trackpoint, XNamespace ns)
        {
            var position = trackpoint.Element(ns + "Position");
            if (position == null)
            {
                return null;
            }

            var latElement = position.Element(ns + "LatitudeDegrees");
            var lonElement = position.Element(ns + "LongitudeDegrees");
            if (latElement == null || lonElement == null)
            {
                return null;
            }

            if (!double.TryParse(latElement.Value, NumberStyles.Float, CultureInfo.InvariantCulture, out double latitude)
                || !double.TryParse(lonElement.Value, NumberStyles.Float, CultureInfo.InvariantCulture, out double longitude))
            {
                return null;
            }

            var timeElement = trackpoint.Element(ns + "Time");
            if (timeElement == null
                || !DateTime.TryParse(timeElement.Value, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal, out DateTime timeUtc))
            {
                return null;
            }

            double elevation = 0;
            var elevationElement = trackpoint.Element(ns + "AltitudeMeters");
            if (elevationElement != null)
            {
                double.TryParse(elevationElement.Value, NumberStyles.Float, CultureInfo.InvariantCulture, out elevation);
            }

            return new Waypoint(latitude, longitude, elevation, timeUtc);
        }
    }
}
