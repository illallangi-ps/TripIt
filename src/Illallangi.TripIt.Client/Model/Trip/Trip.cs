using System;
using System.Collections.Generic;

using Illallangi.TripIt.Model.Common;

using Newtonsoft.Json;

namespace Illallangi.TripIt.Model.Trip
{
    public class Trip
    {
        #region Properties

        #region Id Properties

        [JsonProperty(@"id")]
        public string TripId { get; set; }

        #endregion

        #region String Properties

        [JsonProperty(@"description")]
        public string Description { get; set; }

        [JsonProperty(@"display_name")]
        public string DisplayName { get; set; }

        [JsonProperty(@"image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty(@"primary_location")]
        public string PrimaryLocation { get; set; }

        [JsonProperty(@"last_modified")]
        public string LastModified { get; set; }

        #endregion

        #region Boolean Properties

        [JsonProperty(@"is_private")]
        public bool IsPrivate { get; set; }

        [JsonProperty(@"is_expensible")]
        public bool IsExpensible { get; set; }

        [JsonProperty(@"is_pro_enabled")]
        public bool IsProEnabled { get; set; }

        #endregion
        
        #region Collection Properties

        [JsonProperty(@"TripPurposes")]
        public TripPurposeCollection TripPurposes { get; set; }

        #endregion

        #region List Properties

        [JsonProperty(@"TripInvitees")]
        [JsonConverter(typeof(SingleOrArrayConverter<Invitee>))]
        public List<Invitee> TripInvitees { get; set; }

        [JsonProperty(@"TripCrsRemarks")]
        [JsonConverter(typeof(SingleOrArrayConverter<Crs>))]
        public List<Crs> TripCrsRemarks { get; set; }

        [JsonProperty(@"GroupInvitees")]
        [JsonConverter(typeof(SingleOrArrayConverter<Group>))]
        public List<Group> GroupInvitees { get; set; }

        #endregion

        #region Uri Properties

        [JsonProperty(@"relative_url")]
        public Uri RelativeUrl { get; set; }

        #endregion

        #region DateTime Properties

        [JsonProperty(@"start_date")]
        [JsonConverter(typeof(DateConverter))]
        public DateTime StartDate { get; set; }

        [JsonProperty(@"end_date")]
        [JsonConverter(typeof(DateConverter))]
        public DateTime EndDate { get; set; }

        #endregion

        #region Complex Properties

        [JsonProperty(@"PrimaryLocationAddress")]
        public Address PrimaryLocationAddress { get; set; }

        #endregion

        #endregion
    }
}
