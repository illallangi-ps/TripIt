using System;

using Newtonsoft.Json;

namespace Illallangi.TripIt.Profiles
{
    public class BillingPeriod
    {
        #region Properties

        #region String Properties

        [JsonProperty(@"product_type_code")]
        public string ProductTypeCode { get; set; }

        #endregion

        #region DateTime Properties

        [JsonProperty(@"end_date")]
        public DateTime EndDate { get; set; }

        [JsonProperty(@"hard_end_date")]
        public DateTime HardEndDate { get; set; }

        #endregion

        #endregion
    }
}
