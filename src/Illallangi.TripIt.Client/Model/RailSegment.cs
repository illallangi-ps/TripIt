namespace Illallangi.TripIt.Model
{
    using Newtonsoft.Json;

    public class RailSegment
    {
        [JsonProperty(@"StartDateTime")]
        public TripItDateTime StartDateTime { get; set; }

        [JsonProperty(@"EndDateTime")]
        public TripItDateTime EndDateTime { get; set; }

        [JsonProperty(@"StartStationAddress")]
        public TripItAddress StartStationAddress { get; set; }

        [JsonProperty(@"EndStationAddress")]
        public TripItAddress EndStationAddress { get; set; }

        [JsonProperty(@"start_station_name")]
        public string StartStationName { get; set; }

        [JsonProperty(@"end_station_name")]
        public string EndStationName { get; set; }

        [JsonProperty(@"carrier_name")]
        public string CarrierName { get; set; }

        [JsonProperty(@"coach_number")]
        public string CoachNumber { get; set; }

        [JsonProperty(@"confirmation_num")]
        public string ConfirmationNum { get; set; }

        [JsonProperty(@"seats")]
        public string Seats { get; set; }

        [JsonProperty(@"service_class")]
        public string ServiceClass { get; set; }

        [JsonProperty(@"train_number")]
        public string TrainNumber { get; set; }

        [JsonProperty(@"train_type")]
        public string TrainType { get; set; }

        [JsonProperty(@"id")]
        public string Id { get; set; }
    }
}
