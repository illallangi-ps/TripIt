namespace Illallangi.TripIt.Model
{
    public class SeatTrackerCriteria
    {
        // [XmlElementAttribute("adjacent_seat_amount", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        // [XmlElementAttribute("area_preferences", typeof(SeatTrackerCriteriaArea_preferences), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        // [XmlElementAttribute("individual_seat", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        // [XmlElementAttribute("qualifier", typeof(string), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        // [XmlElementAttribute("seat_preferences", typeof(SeatTrackerCriteriaSeat_preferences), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        // [XmlElementAttribute("should_find_bulkhead_row", typeof(bool), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        // [XmlElementAttribute("should_find_exit_row", typeof(bool), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        // [XmlElementAttribute("should_find_first_class", typeof(bool), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        // [XmlElementAttribute("should_find_premium_seats", typeof(bool), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        // [XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items { get; set; }
    }
}