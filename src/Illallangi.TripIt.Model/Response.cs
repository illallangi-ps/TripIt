using System.Collections.Generic;
using Newtonsoft.Json;

namespace Illallangi.TripIt
{
    public class Response
    {
        #region Properties

        #region Int Properties

        [JsonProperty(@"page_num")]
        public int PageNum { get; set; }

        [JsonProperty(@"page_size")]
        public int PageSize { get; set; }

        [JsonProperty(@"max_page")]
        public int MaxPage { get; set; }

        #endregion

        #region String Properties

        [JsonProperty(@"timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty(@"num_bytes")]
        public string NumBytes { get; set; }

        #endregion

        #region List Properties
        
        [JsonProperty(@"Error")]
        [JsonConverter(typeof(SingleOrArrayConverter<Error>))]
        public List<Error> Error { get; set; }

        [JsonProperty(@"Warning")]
        [JsonConverter(typeof(SingleOrArrayConverter<Warning>))]
        public List<Warning> Warning { get; set; }

        [JsonProperty(@"Profile")]
        [JsonConverter(typeof(SingleOrArrayConverter<Profiles.Profile>))]
        public List<Profiles.Profile> Profile { get; set; }

        [JsonProperty(@"Trip")]
        [JsonConverter(typeof(SingleOrArrayConverter<Trips.Trip>))]
        public List<Trips.Trip> Trip { get; set; }

        /*

        public ActivityObject[] ActivityObject { get; set; }

        public AirObject[] AirObject { get; set; }

        public CarObject[] CarObject { get; set; }

        public CruiseObject[] CruiseObject { get; set; }

        public DirectionsObject[] DirectionsObject { get; set; }

        public LodgingObject[] LodgingObject { get; set; }

        public MapObject[] MapObject { get; set; }

        public NoteObject[] NoteObject { get; set; }

        public ParkingObject[] ParkingObject { get; set; }

        public RailObject[] RailObject { get; set; }

        public RestaurantObject[] RestaurantObject { get; set; }

        public TransportObject[] TransportObject { get; set; }

        public WeatherObject[] WeatherObject { get; set; }

        public PartnerAgency[] PartnerAgency { get; set; }

        public PointsProgram[] PointsProgram { get; set; }

        */

        #endregion

        #endregion
    }
}