using Dynastream.Fit;
using Geo.Gps;

namespace TracksHeatmap
{
    internal static class FitReader
    {
        // A FIT semicircle is 1/2^31 of a half-circle (180 degrees).
        private const double SemicirclesToDegrees = 180.0 / 2147483648.0;

        public static List<Track> Read(Stream stream)
        {
            var decode = new Decode();
            var listener = new FitListener();
            decode.MesgEvent += listener.OnMesg;
            decode.Read(stream);

            var segment = new TrackSegment();

            foreach (RecordMesg record in listener.FitMessages.RecordMesgs)
            {
                var waypoint = ParseRecord(record);
                if (waypoint != null)
                {
                    segment.Waypoints.Add(waypoint);
                }
            }

            var tracks = new List<Track>();
            if (segment.Waypoints.Count > 0)
            {
                var track = new Track();
                track.Segments.Add(segment);
                tracks.Add(track);
            }

            return tracks;
        }

        private static Waypoint? ParseRecord(RecordMesg record)
        {
            int? latitude = record.GetPositionLat();
            int? longitude = record.GetPositionLong();
            if (latitude == null || longitude == null)
            {
                return null;
            }

            Dynastream.Fit.DateTime timestamp = record.GetTimestamp();
            if (timestamp == null)
            {
                return null;
            }

            double elevation = record.GetEnhancedAltitude() ?? record.GetAltitude() ?? 0;

            return new Waypoint(
                latitude.Value * SemicirclesToDegrees,
                longitude.Value * SemicirclesToDegrees,
                elevation,
                timestamp.GetDateTime());
        }
    }
}
