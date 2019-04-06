using Newtonsoft.Json;

namespace Illallangi.TripIt.Trips
{
    public class Request
    {
        #region Properties

        public Trip Trip { get; set; }

        #endregion

        #region Methods

        public override string ToString()
        {
            return JsonConvert.SerializeObject(
                this, 
                new JsonSerializerSettings
                     {
                         NullValueHandling = NullValueHandling.Ignore
                     });
        }

        #endregion
    }
}