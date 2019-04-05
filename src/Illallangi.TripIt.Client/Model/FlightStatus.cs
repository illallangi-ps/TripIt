namespace Illallangi.TripIt.Model
{
    using Newtonsoft.Json;

    public class FlightStatus
    {
        [JsonProperty(@"ScheduledDepartureDateTime")]
        public TripItDateTime ScheduledDepartureDateTime { get; set; }

        [JsonProperty(@"EstimatedDepartureDateTime")]
        public TripItDateTime EstimatedDepartureDateTime { get; set; }

        [JsonProperty(@"ScheduledArrivalDateTime")]
        public TripItDateTime ScheduledArrivalDateTime { get; set; }

        [JsonProperty(@"EstimatedArrivalDateTime")]
        public TripItDateTime EstimatedArrivalDateTime { get; set; }

        [JsonProperty(@"flight_status")]
        public FlightStatusCode FlightStatusCode { get; set; }

        [JsonProperty(@"is_connection_at_risk")]
        public bool IsConnectionAtRisk { get; set; }

        [JsonProperty(@"departure_terminal")]
        public string DepartureTerminal { get; set; }

        [JsonProperty(@"departure_gate")]
        public string DepartureGate { get; set; }

        [JsonProperty(@"arrival_terminal")]
        public string ArrivalTerminal { get; set; }

        [JsonProperty(@"arrival_gate")]
        public string ArrivalGate { get; set; }

        [JsonProperty(@"layover_minutes")]
        public string LayoverMinutes { get; set; }

        [JsonProperty(@"baggage_claim")]
        public string BaggageClaim { get; set; }

        [JsonProperty(@"diverted_airport_code")]
        public string DivertedAirportCode { get; set; }

        [JsonProperty(@"last_modified")]
        public string LastModified { get; set; }
    }
}
