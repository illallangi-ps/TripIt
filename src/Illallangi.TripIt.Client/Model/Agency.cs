namespace Illallangi.TripIt.Model
{
    using Newtonsoft.Json;

    public class Agency
    {
        [JsonProperty(@"agency_conf_num")]
        public string AgencyConfNum { get; set; }

        [JsonProperty(@"agency_name")]
        public string AgencyName { get; set; }

        [JsonProperty(@"agency_client_name")]
        public string AgencyClientName { get; set; }

        [JsonProperty(@"agency_phone")]
        public string AgencyPhone { get; set; }

        [JsonProperty(@"agency_email_address")]
        public string AgencyEmailAddress { get; set; }

        [JsonProperty(@"agency_url")]
        public string AgencyUrl { get; set; }

        [JsonProperty(@"agency_contact")]
        public string AgencyContact { get; set; }

        [JsonProperty(@"partner_agency_id")]
        public string PartnerAgencyId { get; set; }
    }
}
