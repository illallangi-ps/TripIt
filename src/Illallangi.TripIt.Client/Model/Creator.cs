namespace Illallangi.TripIt.Model
{
    using Newtonsoft.Json;

    public class Creator
    {
        [JsonProperty(@"consumer_key")]
        public string ConsumerKey { get; set; }

        [JsonProperty(@"consumer_name")]
        public string ConsumerName { get; set; }
    }
}
