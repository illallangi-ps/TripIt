using System;

using Newtonsoft.Json;

namespace Illallangi.TripIt
{
    public class Error
    {
        [JsonProperty(@"code")]
        public string Code { get; set; }

        [JsonProperty(@"detailed_error_code")]
        public decimal DetailedErrorCode { get; set; }

        [JsonProperty(@"description")]
        public string Description { get; set; }

        [JsonProperty(@"entity_type")]
        public string EntityType { get; set; }

        [JsonProperty(@"timestamp")]
        public DateTime Timestamp { get; set; }
    }
}
