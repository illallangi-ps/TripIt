namespace Illallangi.TripIt.Model
{
    using Newtonsoft.Json;

    public class SeatTrackerSubscriptionMatchesMatchedSeats
    {
        [JsonProperty(@"matched_seat")]
        public string MatchedSeat { get; set; }

        [JsonProperty(@"match_index")]
        public string MatchIndex { get; set; }
    }
}
