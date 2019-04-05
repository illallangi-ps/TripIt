namespace Illallangi.TripIt.Model
{
    using Newtonsoft.Json;

    public class TripItDateTime
    {
        [JsonProperty(@"date")]
        public System.DateTime Date { get; set; }

        [JsonProperty(@"time")]
        public System.DateTime Time { get; set; }

        [JsonProperty(@"timezone")]
        public string Timezone { get; set; }

        [JsonProperty(@"utc_offset")]
        public string UtcOffset { get; set; }
    }
}
