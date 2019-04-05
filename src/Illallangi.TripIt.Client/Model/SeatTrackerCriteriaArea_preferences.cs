namespace Illallangi.TripIt.Model
{
    using Newtonsoft.Json;

    public class SeatTrackerCriteriaAreaPreferences
    {
        [JsonProperty(@"area_preference")]
        public SeatTrackerCriteriaAreaPreferencesAreaPreference[] AreaPreference { get; set; }
    }
}
