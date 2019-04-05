namespace Illallangi.TripIt.Model
{
    using Newtonsoft.Json;

    public class CruiseSegment
    {
        [JsonProperty(@"StartDateTime")]
        public TripItDateTime StartDateTime { get; set; }

        [JsonProperty(@"EndDateTime")]
        public TripItDateTime EndDateTime { get; set; }

        [JsonProperty(@"LocationAddress")]
        public TripItAddress LocationAddress { get; set; }

        [JsonProperty(@"location_name")]
        public string LocationName { get; set; }

        [JsonProperty(@"detail_type_code")]
        public CruiseDetailTypeCode DetailTypeCode { get; set; }

        [JsonProperty(@"id")]
        public string Id { get; set; }
    }
}
