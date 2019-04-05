namespace Illallangi.TripIt.Model
{
    using Newtonsoft.Json;

    public class AirSegment
    {
        [JsonProperty(@"Status")]
        public FlightStatus Status { get; set; }

        [JsonProperty(@"SeatTrackerSubscription")]
        public SeatTrackerSubscription SeatTrackerSubscription { get; set; }

        [JsonProperty(@"StartDateTime")]
        public TripItDateTime StartDateTime { get; set; }

        [JsonProperty(@"EndDateTime")]
        public TripItDateTime EndDateTime { get; set; }

        [JsonProperty(@"start_airport_code")]
        public string StartAirportCode { get; set; }

        [JsonProperty(@"start_airport_latitude")]
        public decimal StartAirportLatitude { get; set; }

        [JsonProperty(@"start_airport_longitude")]
        public decimal StartAirportLongitude { get; set; }

        [JsonProperty(@"start_city_name")]
        public string StartCityName { get; set; }

        [JsonProperty(@"start_country_code")]
        public string StartCountryCode { get; set; }

        [JsonProperty(@"start_gate")]
        public string StartGate { get; set; }

        [JsonProperty(@"start_terminal")]
        public string StartTerminal { get; set; }

        [JsonProperty(@"end_airport_code")]
        public string EndAirportCode { get; set; }

        [JsonProperty(@"end_airport_latitude")]
        public decimal EndAirportLatitude { get; set; }

        [JsonProperty(@"end_airport_longitude")]
        public decimal EndAirportLongitude { get; set; }

        [JsonProperty(@"end_city_name")]
        public string EndCityName { get; set; }

        [JsonProperty(@"end_country_code")]
        public string EndCountryCode { get; set; }

        [JsonProperty(@"end_gate")]
        public string EndGate { get; set; }

        [JsonProperty(@"end_terminal")]
        public string EndTerminal { get; set; }

        [JsonProperty(@"marketing_airline")]
        public string MarketingAirline { get; set; }

        [JsonProperty(@"marketing_airline_code")]
        public string MarketingAirlineCode { get; set; }

        [JsonProperty(@"marketing_flight_number")]
        public string MarketingFlightNumber { get; set; }

        [JsonProperty(@"operating_airline")]
        public string OperatingAirline { get; set; }

        [JsonProperty(@"operating_airline_code")]
        public string OperatingAirlineCode { get; set; }

        [JsonProperty(@"operating_flight_number")]
        public string OperatingFlightNumber { get; set; }

        [JsonProperty(@"alternate_flights_url")]
        public string AlternateFlightsUrl { get; set; }

        [JsonProperty(@"aircraft")]
        public string Aircraft { get; set; }

        [JsonProperty(@"aircraft_display_name")]
        public string AircraftDisplayName { get; set; }

        [JsonProperty(@"distance")]
        public string Distance { get; set; }

        [JsonProperty(@"duration")]
        public string Duration { get; set; }

        [JsonProperty(@"entertainment")]
        public string Entertainment { get; set; }

        [JsonProperty(@"meal")]
        public string Meal { get; set; }

        [JsonProperty(@"notes")]
        public string Notes { get; set; }

        [JsonProperty(@"ontime_perc")]
        public string OntimePerc { get; set; }

        [JsonProperty(@"seats")]
        public string Seats { get; set; }

        [JsonProperty(@"service_class")]
        public string ServiceClass { get; set; }

        [JsonProperty(@"stops")]
        public string Stops { get; set; }

        [JsonProperty(@"baggage_claim")]
        public string BaggageClaim { get; set; }

        [JsonProperty(@"check_in_url")]
        public string CheckInUrl { get; set; }

        [JsonProperty(@"mobile_check_in_url")]
        public string MobileCheckInUrl { get; set; }

        [JsonProperty(@"refund_info_url")]
        public string RefundInfoUrl { get; set; }

        [JsonProperty(@"mobile_refund_info_url")]
        public string MobileRefundInfoUrl { get; set; }

        [JsonProperty(@"change_reservation_url")]
        public string ChangeReservationUrl { get; set; }

        [JsonProperty(@"mobile_change_reservation_url")]
        public string MobileChangeReservationUrl { get; set; }

        [JsonProperty(@"customer_support_url")]
        public string CustomerSupportUrl { get; set; }

        [JsonProperty(@"mobile_customer_support_url")]
        public string MobileCustomerSupportUrl { get; set; }

        [JsonProperty(@"general_fees_url")]
        public string GeneralFeesUrl { get; set; }

        [JsonProperty(@"web_home_url")]
        public string WebHomeUrl { get; set; }

        [JsonProperty(@"mobile_home_url")]
        public string MobileHomeUrl { get; set; }

        [JsonProperty(@"is_eligible_seattracker")]
        public bool IsEligibleSeattracker { get; set; }

        [JsonProperty(@"conflict_resolution_url")]
        public string ConflictResolutionUrl { get; set; }

        [JsonProperty(@"is_hidden")]
        public bool IsHidden { get; set; }

        [JsonProperty(@"id")]
        public string Id { get; set; }

        [JsonProperty(@"is_international")]
        public bool IsInternational { get; set; }
    }
}
