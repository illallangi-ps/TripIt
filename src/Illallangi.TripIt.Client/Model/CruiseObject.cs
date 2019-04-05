namespace Illallangi.TripIt.Model
{
    using Newtonsoft.Json;

    public class CruiseObject : ReservationObject
    {
        public CruiseSegment[] Segment { get; set; }

        [JsonProperty(@"Traveler")]
        public Traveler[] Traveler { get; set; }

        [JsonProperty(@"cabin_number")]
        public string CabinNumber { get; set; }

        [JsonProperty(@"cabin_type")]
        public string CabinType { get; set; }

        [JsonProperty(@"dining")]
        public string Dining { get; set; }

        [JsonProperty(@"ship_name")]
        public string ShipName { get; set; }
    }
}
