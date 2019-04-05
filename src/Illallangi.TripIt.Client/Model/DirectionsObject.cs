namespace Illallangi.TripIt.Model
{
    using Newtonsoft.Json;

    public class DirectionsObject : TripItObject
    {
        [JsonProperty(@"DateTime")]
        public TripItDateTime DateTime { get; set; }

        [JsonProperty(@"StartAddress")]
        public TripItAddress StartAddress { get; set; }

        [JsonProperty(@"EndAddress")]
        public TripItAddress EndAddress { get; set; }

        [JsonProperty(@"detail_type_code")]
        public DirectionsDetailTypeCode DetailTypeCode { get; set; }
    }
}
