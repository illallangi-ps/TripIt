namespace Illallangi.TripIt.Model
{
    using System;

    using Newtonsoft.Json;

    public class WeatherObject : TripItObject
    {
        [JsonProperty(@"date")]
        public DateTime Date { get; set; }

        [JsonProperty(@"location")]
        public string Location { get; set; }

        [JsonProperty(@"avg_high_temp_c")]
        public double AvgHighTempC { get; set; }

        [JsonProperty(@"avg_low_temp_c")]
        public double AvgLowTempC { get; set; }

        [JsonProperty(@"avg_wind_speed_kn")]
        public double AvgWindSpeedKn { get; set; }

        [JsonProperty(@"avg_precipitation_cm")]
        public double AvgPrecipitationCm { get; set; }

        [JsonProperty(@"avg_snow_depth_cm")]
        public double AvgSnowDepthCm { get; set; }
    }
}
