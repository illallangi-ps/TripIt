namespace Illallangi.TripIt.Model
{
    using Newtonsoft.Json;

    public class NoteObject : TripItObject
    {
        [JsonProperty(@"DateTime")]
        public TripItDateTime DateTime { get; set; }

        [JsonProperty(@"Address")]
        public TripItAddress Address { get; set; }

        [JsonProperty(@"detail_type_code")]
        public NoteDetailTypeCode DetailTypeCode { get; set; }

        [JsonProperty(@"source")]
        public string Source { get; set; }

        [JsonProperty(@"text")]
        public string Text { get; set; }

        [JsonProperty(@"url")]
        public string Url { get; set; }

        [JsonProperty(@"notes")]
        public string Notes { get; set; }
    }
}
