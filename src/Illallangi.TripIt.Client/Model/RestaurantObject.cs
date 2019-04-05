namespace Illallangi.TripIt.Model
{
    using Newtonsoft.Json;

    public class RestaurantObject : ReservationObject
    {
        [JsonProperty(@"DateTime")]
        public TripItDateTime DateTime { get; set; }

        [JsonProperty(@"Address")]
        public TripItAddress Address { get; set; }

        [JsonProperty(@"ReservationHolder")]
        public Traveler ReservationHolder { get; set; }

        [JsonProperty(@"cuisine")]
        public string Cuisine { get; set; }

        [JsonProperty(@"dress_code")]
        public string DressCode { get; set; }

        [JsonProperty(@"hours")]
        public string Hours { get; set; }

        [JsonProperty(@"number_patrons")]
        public string NumberPatrons { get; set; }

        [JsonProperty(@"price_range")]
        public string PriceRange { get; set; }
    }
}
