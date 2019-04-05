namespace Illallangi.TripIt.Model
{
    using Newtonsoft.Json;

    public class PartnerAgency
    {
        [JsonProperty(@"partner_agency_id")]
        public string PartnerAgencyId { get; set; }

        [JsonProperty(@"partner_agency_name")]
        public string PartnerAgencyName { get; set; }

        [JsonProperty(@"partner_agency_short_name")]
        public string PartnerAgencyShortName { get; set; }

        [JsonProperty(@"partner_agency_logo_small_url")]
        public string PartnerAgencyLogoSmallUrl { get; set; }

        [JsonProperty(@"partner_agency_logo_medium_url")]
        public string PartnerAgencyLogoMediumUrl { get; set; }

        [JsonProperty(@"partner_agency_logo_large_url")]
        public string PartnerAgencyLogoLargeUrl { get; set; }
    }
}
