using System;
using System.IO;
using Newtonsoft.Json;

namespace Illallangi.TripIt.Settings
{
    public sealed class JsonSetting : Observable, ISetting
    {
        private const string defaultAuthorizeUrl = @"https://www.tripit.com/oauth/authorize?oauth_token={0}&oauth_callback={1}";
        private const string defaultCallBackUrl = @"http://fiftyeight.us/callback.html";
        private const string defaultBaseUrl = @"https://api.tripit.com";
        
        private const string path = @"%localappdata%\Illallangi Enterprises\TripIt\setting.json";

        private string consumerKey;
        private string consumerSecret;
        private string authorizeUrl;
        private string callBackUrl;
        private string baseUrl;
        private string authorizedKey;
        private string authorizedSecret;

        public static JsonSetting Retrieve()
        {
            return File.Exists(Environment.ExpandEnvironmentVariables(path))
                ? JsonConvert.DeserializeObject<JsonSetting>(
                    File.ReadAllText(Environment.ExpandEnvironmentVariables(path)))
                : new JsonSetting
                {
                    AuthorizeUrl = defaultAuthorizeUrl,
                    CallBackUrl = defaultCallBackUrl,
                    BaseUrl = defaultBaseUrl
                };
        }

        private JsonSetting()
        {
            PropertyChanged += (sender, args) =>
            {
                if (!Directory.Exists(Path.GetDirectoryName(Environment.ExpandEnvironmentVariables(path))))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(Environment.ExpandEnvironmentVariables(path)));
                }

                File.WriteAllText(Environment.ExpandEnvironmentVariables(path), JsonConvert.SerializeObject(sender, Formatting.Indented));
            };
        }

        [JsonProperty(@"consumerKey")]
        public string ConsumerKey
        {
            get => consumerKey;
            set => SetField(ref consumerKey, value);
        }
        
        [JsonProperty(@"consumerSecret")]
        public string ConsumerSecret
        {
            get => consumerSecret;
            set => SetField(ref consumerSecret, value);
        }
        
        [JsonProperty(@"authorizeUrl")]
        public string AuthorizeUrl
        {
            get => authorizeUrl;
            set => SetField(ref authorizeUrl, value);
        }
        
        [JsonProperty(@"callBackUrl")]
        public string CallBackUrl
        {
            get => callBackUrl;
            set => SetField(ref callBackUrl, value);
        }
        
        [JsonProperty(@"baseUrl")]
        public string BaseUrl
        {
            get => baseUrl;
            set => SetField(ref baseUrl, value);
        }
        
        [JsonProperty(@"authorizedKey")]
        public string AuthorizedKey
        {
            get => authorizedKey;
            set => SetField(ref authorizedKey, value);
        }
        
        [JsonProperty(@"authorizedSecret")]
        public string AuthorizedSecret
        {
            get => authorizedSecret;
            set => SetField(ref authorizedSecret, value);
        }
    }
}