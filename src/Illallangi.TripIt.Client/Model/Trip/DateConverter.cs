namespace Illallangi.TripIt.Model.Trip
{
    using Newtonsoft.Json.Converters;

    public class DateConverter : IsoDateTimeConverter
    {
        public DateConverter()
        {
            base.DateTimeFormat = @"yyyy-MM-dd";
        }
    }
}