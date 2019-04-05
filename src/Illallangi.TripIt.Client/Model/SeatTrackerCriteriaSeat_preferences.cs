using Newtonsoft.Json;

namespace Illallangi.TripIt.Model
{
    public class SeatTrackerCriteriaSeatPreferences
    {
        [JsonProperty(@"seat_preference")]
        public SeatTrackerCriteriaSeatPreferencesSeatPreference[] SeatPreference { get; set; }
    }
}
