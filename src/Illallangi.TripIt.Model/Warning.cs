using System;

using Newtonsoft.Json;

namespace Illallangi.TripIt
{
    public class Warning
    {
        [JsonProperty(@"description")]
        public string Description { get; set; }

        [JsonProperty(@"entity_type")]
        public string EntityType { get; set; }

        [JsonProperty(@"Timestamp")]
        public DateTime Timestamp { get; set; }
    }
}
