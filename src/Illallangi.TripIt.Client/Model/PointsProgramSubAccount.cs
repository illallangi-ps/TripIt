namespace Illallangi.TripIt.Model
{
    using Newtonsoft.Json;

    public class PointsProgramSubAccount
    {
        [JsonProperty(@"id")]
        public string Id { get; set; }

        [JsonProperty(@"account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty(@"name")]
        public string Name { get; set; }

        [JsonProperty(@"nickname")]
        public string Nickname { get; set; }

        [JsonProperty(@"balance")]
        public string Balance { get; set; }
    }
}
