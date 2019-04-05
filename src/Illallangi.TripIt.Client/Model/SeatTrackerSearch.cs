namespace Illallangi.TripIt.Model
{
    using Newtonsoft.Json;

    public class SeatTrackerSearch
    {
        [JsonProperty(@"DepartureDateTime")]
        public TripItDateTime DepartureDateTime { get; set; }

        [JsonProperty(@"ArrivalDateTime")]
        public TripItDateTime ArrivalDateTime { get; set; }

        [JsonProperty(@"LastSearchDateTime")]
        public TripItDateTime LastSearchDateTime { get; set; }

        [JsonProperty(@"LastUpdatedDateTime")]
        public TripItDateTime LastUpdatedDateTime { get; set; }

        [JsonProperty(@"start_airport_code")]
        public string StartAirportCode { get; set; }

        [JsonProperty(@"end_airport_code")]
        public string EndAirportCode { get; set; }

        [JsonProperty(@"airline_code")]
        public string AirlineCode { get; set; }

        [JsonProperty(@"flight_number")]
        public string FlightNumber { get; set; }

        [JsonProperty(@"airline_phone_number")]
        public string AirlinePhoneNumber { get; set; }

        [JsonProperty(@"airline_url")]
        public string AirlineUrl { get; set; }

        [JsonProperty(@"deactivation_code")]
        public string DeactivationCode { get; set; }

        [JsonProperty(@"last_search_timestamp")]
        public string LastSearchTimestamp { get; set; }

        [JsonProperty(@"last_updated_timestamp")]
        public string LastUpdatedTimestamp { get; set; }

        [JsonProperty(@"id")]
        public string Id { get; set; }
    }
}
