using Newtonsoft.Json;

namespace Illallangi.TripIt
{
    public class Group
    {
        #region Properties

        #region String Properties

        [JsonProperty(@"display_name")]
        public string DisplayName { get; set; }

        [JsonProperty(@"url")]
        public string Url { get; set; }

        [JsonProperty(@"unique_name")]
        public string UniqueName { get; set; }
        
        #endregion

        #region Boolean Properties

        [JsonProperty(@"is_free")]
        public bool IsFree { get; set; }

        #endregion

        #endregion
    }
}
