using Newtonsoft.Json;

namespace Illallangi.TripIt.Model.Trip
{
    public class Crs
    {
        [JsonProperty(@"record_locator")]
        public string RecordLocator { get; set; }

        [JsonProperty(@"notes")]
        public string Notes { get; set; }
    }
}
