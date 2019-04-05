namespace Illallangi.TripIt.Model
{
    using System;

    using Newtonsoft.Json;

    public class PointsProgram
    {
        [JsonProperty(@"id")]
        public string Id { get; set; }

        [JsonProperty(@"name")]
        public string Name { get; set; }

        [JsonProperty(@"account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty(@"account_login")]
        public string AccountLogin { get; set; }

        [JsonProperty(@"balance")]
        public string Balance { get; set; }

        [JsonProperty(@"elite_status")]
        public string EliteStatus { get; set; }

        [JsonProperty(@"elite_next_status")]
        public string EliteNextStatus { get; set; }

        [JsonProperty(@"elite_ytd_qualify")]
        public string EliteYtdQualify { get; set; }

        [JsonProperty(@"elite_need_to_earn")]
        public string EliteNeedToEarn { get; set; }

        [JsonProperty(@"last_modified")]
        public string LastModified { get; set; }

        [JsonProperty(@"total_num_activities")]
        public string TotalNumActivities { get; set; }

        [JsonProperty(@"total_num_expirations")]
        public string TotalNumExpirations { get; set; }

        [JsonProperty(@"error_message")]
        public string ErrorMessage { get; set; }

        [JsonProperty(@"nickname")]
        public string Nickname { get; set; }

        [JsonProperty(@"last_fetch_account_state_code")]
        public string LastFetchAccountStateCode { get; set; }

        [JsonProperty(@"account_state_code")]
        public string AccountStateCode { get; set; }

        [JsonProperty(@"is_dm_supported")]
        public bool IsDmSupported { get; set; }

        [JsonProperty(@"is_editable")]
        public bool IsEditable { get; set; }

        [JsonProperty(@"is_user_tracked")]
        public bool IsUserTracked { get; set; }

        [JsonProperty(@"lifetime_points")]
        public string LifetimePoints { get; set; }

        [JsonProperty(@"supplier_code")]
        public string SupplierCode { get; set; }

        [JsonProperty(@"program_date")]
        public DateTime ProgramDate { get; set; }

        [JsonProperty(@"Activity")]
        public PointsProgramActivity[] Activity { get; set; }

        [JsonProperty(@"Expiration")]
        public PointsProgramExpiration[] Expiration { get; set; }

        [JsonProperty(@"SubAccount")]
        public PointsProgramSubAccount[] SubAccount { get; set; }

        [JsonProperty(@"url")]
        public string Url { get; set; }
    }
}
