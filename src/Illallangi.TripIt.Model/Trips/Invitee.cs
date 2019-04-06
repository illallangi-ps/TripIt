using Newtonsoft.Json;

namespace Illallangi.TripIt.Trips
{
    public class Invitee
    {
        [JsonProperty(@"is_read_only")]
        public bool IsReadOnly { get; set; }

        [JsonProperty(@"is_traveler")]
        public bool IsTraveler { get; set; }

        [JsonProperty(@"is_owner")]
        public bool IsOwner { get; set; }

        [JsonProperty(@"profile_ref")]
        public string ProfileRef { get; set; }
    }
}
