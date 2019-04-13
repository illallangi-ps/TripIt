using Newtonsoft.Json;

namespace Illallangi.TripIt.Profiles
{
    public class NotificationSetting
    {
        #region Properties

        #region String Properties

        [JsonProperty(@"code")]
        public string Code { get; set; }

        [JsonProperty(@"name")]
        public string Name { get; set; }

        [JsonProperty(@"type")]
        public string Type { get; set; }

        [JsonProperty(@"is_premium")]
        public string IsPremium { get; set; }

        #endregion

        #region Boolean Properties

        [JsonProperty(@"is_enabled")]
        public bool IsEnabled { get; set; }

        #endregion

        #endregion

        #region Methods

        public override string ToString()
        {
            return $@"{Name}: {IsEnabled}";
        }

        #endregion
    }
}
