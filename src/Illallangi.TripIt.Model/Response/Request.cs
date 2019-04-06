namespace Illallangi.TripIt.Model.Response
{
    using Illallangi.TripIt.Model.Trip;

    using Newtonsoft.Json;

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