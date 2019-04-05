namespace Illallangi.TripIt.Model
{
    using System;

    using Newtonsoft.Json;

    public class ReservationObject : TripItObject
    {
        [JsonProperty(@"CancellationDateTime")]
        public TripItDateTime CancellationDateTime { get; set; }

        [JsonProperty(@"booking_date")]
        public DateTime BookingDate { get; set; }

        [JsonProperty(@"booking_rate")]
        public string BookingRate { get; set; }

        [JsonProperty(@"booking_site_conf_num")]
        public string BookingSiteConfNum { get; set; }

        [JsonProperty(@"booking_site_name")]
        public string BookingSiteName { get; set; }

        [JsonProperty(@"booking_site_phone")]
        public string BookingSitePhone { get; set; }

        [JsonProperty(@"booking_site_email_address")]
        public string BookingSiteEmailAddress { get; set; }

        [JsonProperty(@"booking_site_url")]
        public string BookingSiteUrl { get; set; }

        [JsonProperty(@"record_locator")]
        public string RecordLocator { get; set; }

        [JsonProperty(@"supplier_conf_num")]
        public string SupplierConfNum { get; set; }

        [JsonProperty(@"supplier_contact")]
        public string SupplierContact { get; set; }

        [JsonProperty(@"supplier_email_address")]
        public string SupplierEmailAddress { get; set; }

        [JsonProperty(@"supplier_name")]
        public string SupplierName { get; set; }

        [JsonProperty(@"supplier_phone")]
        public string SupplierPhone { get; set; }

        [JsonProperty(@"supplier_url")]
        public string SupplierUrl { get; set; }

        [JsonProperty(@"is_purchased")]
        public bool IsPurchased { get; set; }

        [JsonProperty(@"notes")]
        public string Notes { get; set; }

        [JsonProperty(@"restrictions")]
        public string Restrictions { get; set; }

        [JsonProperty(@"total_cost")]
        public string TotalCost { get; set; }

        [JsonProperty(@"is_tripit_booking")]
        public bool IsTripitBooking { get; set; }

        public Agency Agency { get; set; }
    }
}
