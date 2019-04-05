namespace Illallangi.TripIt.Model
{
    using Newtonsoft.Json;

    public class TransportSegment
    {
        [JsonProperty(@"StartDateTime")]
        public TripItDateTime StartDateTime { get; set; }

        [JsonProperty(@"EndDateTime")]
        public TripItDateTime EndDateTime { get; set; }

        [JsonProperty(@"StartLocationAddress")]
        public TripItAddress StartLocationAddress { get; set; }

        [JsonProperty(@"EndLocationAddress")]
        public TripItAddress EndLocationAddress { get; set; }

        [JsonProperty(@"start_location_name")]
        public string StartLocationName { get; set; }

        [JsonProperty(@"end_location_name")]
        public string EndLocationName { get; set; }

        [JsonProperty(@"detail_type_code")]
        public TransportDetailTypeCode DetailTypeCode { get; set; }

        [JsonProperty(@"carrier_name")]
        public string CarrierName { get; set; }

        [JsonProperty(@"confirmation_num")]
        public string ConfirmationNum { get; set; }

        [JsonProperty(@"number_passengers")]
        public string NumberPassengers { get; set; }

        [JsonProperty(@"vehicle_description")]
        public string VehicleDescription { get; set; }

        [JsonProperty(@"id")]
        public string Id { get; set; }
    }
}
