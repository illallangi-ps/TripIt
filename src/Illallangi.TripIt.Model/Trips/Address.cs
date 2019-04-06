using Newtonsoft.Json;

namespace Illallangi.TripIt.Trips
{
    public class Address
    {
        [JsonProperty(@"address")]
        public string FullAddress { get; set; }

        [JsonProperty(@"addr1")]
        public string Address1 { get; set; }

        [JsonProperty(@"addr2")]
        public string Address2 { get; set; }

        [JsonProperty(@"city")]
        public string City { get; set; }

        [JsonProperty(@"state")]
        public string State { get; set; }

        [JsonProperty(@"zip")]
        public string Zip { get; set; }

        [JsonProperty(@"country")]
        public string Country { get; set; }

        [JsonProperty(@"latitude")]
        public decimal Latitude { get; set; }

        [JsonProperty(@"longitude")]
        public decimal Longitude { get; set; }
    }
}
