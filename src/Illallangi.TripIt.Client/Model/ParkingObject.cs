namespace Illallangi.TripIt.Model
{
    using Newtonsoft.Json;

    public class ParkingObject : ReservationObject
    {
        [JsonProperty(@"StartDateTime")]
        public TripItDateTime StartDateTime { get; set; }

        [JsonProperty(@"EndDateTime")]
        public TripItDateTime EndDateTime { get; set; }

        [JsonProperty(@"Address")]
        public TripItAddress Address { get; set; }

        [JsonProperty(@"location_hours")]
        public string LocationHours { get; set; }

        [JsonProperty(@"location_name")]
        public string LocationName { get; set; }

        [JsonProperty(@"valet_ticket_num")]
        public string ValetTicketNum { get; set; }

        [JsonProperty(@"location_phone")]
        public string LocationPhone { get; set; }
    }
}
