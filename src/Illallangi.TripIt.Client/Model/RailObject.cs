using Newtonsoft.Json;

namespace Illallangi.TripIt.Model
{
    public class RailObject : ReservationObject
    {
        [JsonProperty(@"Segment")]
        public RailSegment[] Segment { get; set; }

        [JsonProperty(@"Traveler")]
        public Traveler[] Traveler { get; set; }
    }
}
