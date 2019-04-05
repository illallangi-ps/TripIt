namespace Illallangi.TripIt.Model
{
    using Newtonsoft.Json;

    public class CarObject : ReservationObject
    {
        [JsonProperty(@"EstimatedStartDateTime")]
        public TripItDateTime EstimatedStartDateTime { get; set; }

        [JsonProperty(@"EstimatedEndDateTime")]
        public TripItDateTime EstimatedEndDateTime { get; set; }

        [JsonProperty(@"StartDateTime")]
        public TripItDateTime StartDateTime { get; set; }

        [JsonProperty(@"EndDateTime")]
        public TripItDateTime EndDateTime { get; set; }

        [JsonProperty(@"StartLocationAddress")]
        public TripItAddress StartLocationAddress { get; set; }

        [JsonProperty(@"EndLocationAddress")]
        public TripItAddress EndLocationAddress { get; set; }

        [JsonProperty(@"Driver")]
        public Traveler Driver { get; set; }

        [JsonProperty(@"start_location_hours")]
        public string StartLocationHours { get; set; }

        [JsonProperty(@"start_location_name")]
        public string StartLocationName { get; set; }

        [JsonProperty(@"start_location_phone")]
        public string StartLocationPhone { get; set; }

        [JsonProperty(@"end_location_hours")]
        public string EndLocationHours { get; set; }

        [JsonProperty(@"end_location_name")]
        public string EndLocationName { get; set; }

        [JsonProperty(@"end_location_phone")]
        public string EndLocationPhone { get; set; }

        [JsonProperty(@"car_description")]
        public string CarDescription { get; set; }

        [JsonProperty(@"car_type")]
        public string CarType { get; set; }

        [JsonProperty(@"mileage_charges")]
        public string MileageCharges { get; set; }
    }
}
