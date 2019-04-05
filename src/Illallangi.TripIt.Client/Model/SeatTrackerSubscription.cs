namespace Illallangi.TripIt.Model
{
    using Newtonsoft.Json;

    public class SeatTrackerSubscription
    {
        [JsonProperty(@"SeatTrackerSearch")]
        public SeatTrackerSearch SeatTrackerSearch { get; set; }

        [JsonProperty(@"SeatTrackerSubscriptionMatches")]
        public SeatTrackerSubscriptionMatches SeatTrackerSubscriptionMatches { get; set; }

        [JsonProperty(@"SeatTrackerCriteria")]
        public SeatTrackerCriteria SeatTrackerCriteria { get; set; }

        [JsonProperty(@"trip_item_id")]
        public string TripItemId { get; set; }

        [JsonProperty(@"display_name")]
        public string DisplayName { get; set; }

        [JsonProperty(@"description")]
        public string Description { get; set; }

        [JsonProperty(@"seats")]
        public string Seats { get; set; }

        [JsonProperty(@"deactivation_code")]
        public string DeactivationCode { get; set; }

        [JsonProperty(@"last_updated_timestamp")]
        public string LastUpdatedTimestamp { get; set; }

        [JsonProperty(@"id")]
        public string Id { get; set; }
    }
}
