using Newtonsoft.Json;

namespace Illallangi.TripIt.Trips
{
    public class Crs
    {
        [JsonProperty(@"record_locator")]
        public string RecordLocator { get; set; }

        [JsonProperty(@"notes")]
        public string Notes { get; set; }
    }
}
