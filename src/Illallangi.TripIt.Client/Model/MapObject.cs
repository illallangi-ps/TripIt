namespace Illallangi.TripIt.Model
{
    using Newtonsoft.Json;

    public class MapObject : TripItObject
    {
        [JsonProperty(@"DateTime")]
        public TripItDateTime DateTime { get; set; }

        [JsonProperty(@"Address")]
        public TripItAddress Address { get; set; }
    }
}
