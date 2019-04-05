namespace Illallangi.TripIt.Model
{
    using System;

    using Newtonsoft.Json;

    public class PointsProgramExpiration
    {
        [JsonProperty(@"date")]
        public DateTime Date { get; set; }

        [JsonProperty(@"amount")]
        public string Amount { get; set; }
    }
}
