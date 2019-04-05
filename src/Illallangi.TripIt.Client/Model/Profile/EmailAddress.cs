using Newtonsoft.Json;

namespace Illallangi.TripIt.Model.Profile
{
    public class EmailAddress
    {
        #region Properties

        #region String Properties

        [JsonProperty(@"email_ref")]
        public string EmailRef { get; set; }

        [JsonProperty(@"address")]
        public string Address { get; set; }

        #endregion

        #region Boolean Properties

        [JsonProperty(@"is_auto_import")]
        public bool IsAutoImport { get; set; }

        [JsonProperty(@"is_confirmed")]
        public bool IsConfirmed { get; set; }

        [JsonProperty(@"is_primary")]
        public bool IsPrimary { get; set; }

        [JsonProperty(@"is_auto_inbox_eligible")]
        public bool IsAutoInboxEligible { get; set; }

        #endregion

        #endregion

        #region Methods

        public override string ToString()
        {
            return $@"{this.Address}";
        }

        #endregion
    }
}
