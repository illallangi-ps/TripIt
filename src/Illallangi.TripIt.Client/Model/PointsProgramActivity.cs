namespace Illallangi.TripIt.Model
{
    using System;

    using Newtonsoft.Json;

    public class PointsProgramActivity
    {
        [JsonProperty(@"date")]
        public DateTime Date { get; set; }

        [JsonProperty(@"description")]
        public string Description { get; set; }

        [JsonProperty(@"@base")]
        public string Base { get; set; }

        [JsonProperty(@"bonus")]
        public string Bonus { get; set; }

        [JsonProperty(@"total")]
        public string Total { get; set; }
    }
}
