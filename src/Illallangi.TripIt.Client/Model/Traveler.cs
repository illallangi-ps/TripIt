namespace Illallangi.TripIt.Model
{
    using Newtonsoft.Json;

    public class Traveler
    {
        [JsonProperty(@"first_name")]
        public string FirstName { get; set; }

        [JsonProperty(@"middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty(@"last_name")]
        public string LastName { get; set; }

        [JsonProperty(@"frequent_traveler_num")]
        public string FrequentTravelerNum { get; set; }

        [JsonProperty(@"frequent_traveler_supplier")]
        public string FrequentTravelerSupplier { get; set; }

        [JsonProperty(@"meal_preference")]
        public string MealPreference { get; set; }

        [JsonProperty(@"seat_preference")]
        public string SeatPreference { get; set; }

        [JsonProperty(@"ticket_num")]
        public string TicketNum { get; set; }
    }
}
