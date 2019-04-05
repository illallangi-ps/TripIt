namespace Illallangi.TripIt.Model
{
    public class DateTime
    {
        [JsonProperty(@"date")]
        [JsonProperty(@"date")]
        [JsonProperty(@"date")]
        public DateTime date { get; set; }

        [JsonProperty(@"time")]
        [JsonProperty(@"time")]
        [JsonProperty(@"time")]
        public DateTime time { get; set; }

        [JsonProperty(@"timezone")]
        public string timezone { get; set; }

        [JsonProperty(@"utc_offset")]
        public string utc_offset { get; set; }
    }
}
