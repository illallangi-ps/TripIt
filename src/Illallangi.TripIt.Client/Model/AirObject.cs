using Newtonsoft.Json;

namespace Illallangi.TripIt.Model
{
    public class AirObject : ReservationObject
    {
        [JsonProperty(@"Segment")]
        public AirSegment[] Segment { get; set; }

        [JsonProperty(@"Traveler")]
        public Traveler[] Traveler { get; set; }
    }
}
