using Newtonsoft.Json.Converters;

namespace Illallangi.TripIt.Trips
{
    public class DateConverter : IsoDateTimeConverter
    {
        public DateConverter()
        {
            base.DateTimeFormat = @"yyyy-MM-dd";
        }
    }
}