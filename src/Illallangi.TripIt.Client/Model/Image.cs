namespace Illallangi.TripIt.Model
{
    using Newtonsoft.Json;

    public class Image
    {
        [JsonProperty(@"caption")]
        public string Caption { get; set; }

        [JsonProperty(@"url")]
        public string Url { get; set; }

        [JsonProperty(@"ImageData")]
        public ImageData ImageData { get; set; }

        [JsonProperty(@"id")]
        public string Id { get; set; }
    }
}
