using Newtonsoft.Json;

namespace Illallangi.TripIt.Model
{
    public class TransportObject : ReservationObject
    {
        [JsonProperty(@"Segment")]
        public TransportSegment[] Segment { get; set; }

        [JsonProperty(@"Traveler")]
        public Traveler[] Traveler { get; set; }
    }
}
