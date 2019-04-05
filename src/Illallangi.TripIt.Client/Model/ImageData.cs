namespace Illallangi.TripIt.Model
{
    using Newtonsoft.Json;

    public class ImageData
    {
        // [XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary")]
        [JsonProperty(@"content")]
        public byte[] Content { get; set; }

        [JsonProperty(@"mime_type")]

        public ImageDataMimeType MimeType { get; set; }
    }
}
