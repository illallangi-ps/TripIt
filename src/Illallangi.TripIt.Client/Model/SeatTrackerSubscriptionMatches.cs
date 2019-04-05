namespace Illallangi.TripIt.Model
{
    public class SeatTrackerSubscriptionMatches
    {
        // [XmlElementAttribute("LastUpdatedDateTime", typeof(DateTime), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        // [XmlElementAttribute("last_updated_timestamp", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        // [XmlElementAttribute("matched_seats", typeof(SeatTrackerSubscriptionMatchesMatched_seats), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        // [XmlElementAttribute("num_matches", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        // [XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items { get; set; }
    }
}
