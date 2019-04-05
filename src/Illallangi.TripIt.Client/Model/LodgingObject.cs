namespace Illallangi.TripIt.Model
{
    using Newtonsoft.Json;

    public class LodgingObject : ReservationObject
    {
        [JsonProperty(@"EstimatedStartDateTime")]
        public TripItDateTime EstimatedStartDateTime { get; set; }

        [JsonProperty(@"EstimatedEndDateTime")]
        public TripItDateTime EstimatedEndDateTime { get; set; }

        [JsonProperty(@"StartDateTime")]
        public TripItDateTime StartDateTime { get; set; }

        [JsonProperty(@"EndDateTime")]
        public TripItDateTime EndDateTime { get; set; }

        [JsonProperty(@"Address")]
        public TripItAddress Address { get; set; }

        [JsonProperty(@"Guest")]
        public Traveler[] Guest { get; set; }

        [JsonProperty(@"number_guests")]
        public string NumberGuests { get; set; }

        [JsonProperty(@"number_rooms")]
        public string NumberRooms { get; set; }

        [JsonProperty(@"room_type")]
        public string RoomType { get; set; }

        [JsonProperty(@"bic_code")]
        public string BicCode { get; set; }
    }
}
