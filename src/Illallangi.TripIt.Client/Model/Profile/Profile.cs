using System;
using System.Collections.Generic;

using Illallangi.TripIt.Model.Common;

using Newtonsoft.Json;

namespace Illallangi.TripIt.Model.Profile
{
    public class Profile
    {
        #region Properties

        #region Id Properties

        [JsonProperty(@"uuid")]
        public Guid ProfileId { get; set; }

        [JsonProperty(@"@ref")]
        public string ProfileRef { get; set; }

        #endregion
        
        #region String Properties

        [JsonProperty(@"screen_name")]
        public string ScreenName { get; set; }

        [JsonProperty(@"public_display_name")]
        public string PublicDisplayName { get; set; }

        [JsonProperty(@"profile_url")]
        public string ProfileUrl { get; set; }

        [JsonProperty(@"home_city")]
        public string HomeCity { get; set; }

        [JsonProperty(@"home_country_code")]
        public string HomeCountryCode { get; set; }

        [JsonProperty(@"company")]
        public string Company { get; set; }

        [JsonProperty(@"about_me_info")]
        public string AboutMeInfo { get; set; }

        [JsonProperty(@"photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty(@"activity_feed_url")]
        public string ActivityFeedUrl { get; set; }

        [JsonProperty(@"alerts_feed_url")]
        public string AlertsFeedUrl { get; set; }

        [JsonProperty(@"ical_url")]
        public string IcalUrl { get; set; }

        [JsonProperty(@"sms_phone_number")]
        public string SmsPhoneNumber { get; set; }

        [JsonProperty(@"sms_country_code")]
        public string SmsCountryCode { get; set; }

        [JsonProperty(@"sms_email_address")]
        public string SmsEmailAddress { get; set; }

        #endregion

        #region Boolean Properties

        [JsonProperty(@"is_client")]
        public bool IsClient { get; set; }

        [JsonProperty(@"is_pro")]
        public bool IsPro { get; set; }

        [JsonProperty(@"should_allow_pro_purchase")]
        public bool ShouldAllowProPurchase { get; set; }

        [JsonProperty(@"is_t4t_mobile_cal")]
        public bool IsT4TMobileCal { get; set; }

        [JsonProperty(@"is_legacy_paid_app_user")]
        public bool IsLegacyPaidAppUser { get; set; }

        [JsonProperty(@"is_concur_linked")]
        public bool IsConcurLinked { get; set; }

        #endregion

        #region Collection Properties

        [JsonProperty(@"ProfileEmailAddresses")]
        public ProfileEmailAddressCollection EmailAddresses { get; set; }

        [JsonProperty(@"NotificationSettings")]
        public ProfileNotificationSettingCollection NotificationSettings { get; set; }

        #endregion

        #region List Properties

        [JsonProperty(@"GroupMemberships")]
        [JsonConverter(typeof(SingleOrArrayConverter<Group>))]
        public List<Group> GroupMemberships { get; set; }

        [JsonProperty(@"BillingPeriods")]
        [JsonConverter(typeof(SingleOrArrayConverter<BillingPeriod>))]
        public List<BillingPeriod> BillingPeriods { get; set; }

        #endregion

        #endregion
    }
}