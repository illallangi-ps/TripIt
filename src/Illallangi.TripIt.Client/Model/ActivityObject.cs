namespace Illallangi.TripIt.Model
{
    using System;

    using Newtonsoft.Json;

    public class ActivityObject : ReservationObject
    {
        [JsonProperty(@"StartDateTime")]
        public TripItDateTime StartDateTime { get; set; }

        [JsonProperty(@"EndDateTime")]
        public TripItDateTime EndDateTime { get; set; }

        [JsonProperty(@"end_time")]
        public DateTime EndTime { get; set; }

        [JsonProperty(@"Address")]
        public TripItAddress Address { get; set; }

        [JsonProperty(@"Participant")]
        public Traveler[] Participant { get; set; }

        [JsonProperty(@"detail_type_code")]
        public ActivityDetailTypeCode DetailTypeCode { get; set; }

        [JsonProperty(@"location_name")]
        public string LocationName { get; set; }
    }
}
