using System;
using System.IO;
using Newtonsoft.Json;

namespace Illallangi.TripIt.Settings
{
    public sealed class JsonSetting : Observable, ISetting
    {
        private const string DefaultAuthorizeUrl = @"https://www.tripit.com/oauth/authorize?oauth_token={0}&oauth_callback={1}";
        private const string DefaultCallBackUrl = @"http://fiftyeight.us/callback.html";
        private const string DefaultBaseUrl = @"https://api.tripit.com";
        
        private const string Path = @"%localappdata%\Illallangi Enterprises\TripIt\setting.json";

        private string currentConsumerKey;
        private string currentConsumerSecret;
        private string currentAuthorizeUrl;
        private string currentCallBackUrl;
        private string currentBaseUrl;
        private string currentAuthorizedKey;
        private string currentAuthorizedSecret;
        
        public static JsonSetting Retrieve()
        {
            return File.Exists(Environment.ExpandEnvironmentVariables(Path))
                ? JsonConvert.DeserializeObject<JsonSetting>(
                    File.ReadAllText(Environment.ExpandEnvironmentVariables(Path)))
                : new JsonSetting();
        }

        private JsonSetting()
        {
            AuthorizeUrl = DefaultAuthorizeUrl;
            CallBackUrl = DefaultCallBackUrl;
            BaseUrl = DefaultBaseUrl;

            PropertyChanged += (sender, args) =>
            {
                if (!Directory.Exists(System.IO.Path.GetDirectoryName(Environment.ExpandEnvironmentVariables(Path))))
                {
                    Directory.CreateDirectory(System.IO.Path.GetDirectoryName(Environment.ExpandEnvironmentVariables(Path)) ?? throw new InvalidOperationException($@"Error creating ${Path}, GetDirectoryName Null"));
                }

                File.WriteAllText(Environment.ExpandEnvironmentVariables(Path), JsonConvert.SerializeObject(sender, Formatting.Indented));
            };
        }

        public bool ShouldSerializeConsumerKey() => !string.IsNullOrWhiteSpace(ConsumerKey);
        
        [JsonProperty(@"consumerKey")]
        public string ConsumerKey
        {
            get => currentConsumerKey;
            set => SetField(ref currentConsumerKey, value);
        }

        public bool ShouldSerializeConsumerSecret() => !string.IsNullOrWhiteSpace(ConsumerSecret);

        [JsonProperty(@"consumerSecret")]
        public string ConsumerSecret
        {
            get => currentConsumerSecret;
            set => SetField(ref currentConsumerSecret, value);
        }

        public bool ShouldSerializeAuthorizeUrl() => AuthorizeUrl != DefaultAuthorizeUrl;

        [JsonProperty(@"authorizeUrl")]
        public string AuthorizeUrl
        {
            get => currentAuthorizeUrl;
            set => SetField(ref currentAuthorizeUrl, value);
        }

        public bool ShouldSerializeCallBackUrl() => CallBackUrl != DefaultCallBackUrl;

        [JsonProperty(@"callBackUrl")]
        public string CallBackUrl
        {
            get => currentCallBackUrl;
            set => SetField(ref currentCallBackUrl, value);
        }

        public bool ShouldSerializeBaseUrl() => BaseUrl != DefaultBaseUrl;

        [JsonProperty(@"baseUrl")]
        public string BaseUrl
        {
            get => currentBaseUrl;
            set => SetField(ref currentBaseUrl, value);
        }

        public bool ShouldSerializeAuthorizedKey() => !string.IsNullOrWhiteSpace(AuthorizedKey);

        [JsonProperty(@"authorizedKey")]
        public string AuthorizedKey
        {
            get => currentAuthorizedKey;
            set => SetField(ref currentAuthorizedKey, value);
        }

        public bool ShouldSerializeAuthorizedSecret() => !string.IsNullOrWhiteSpace(AuthorizedSecret);

        [JsonProperty(@"authorizedSecret")]
        public string AuthorizedSecret
        {
            get => currentAuthorizedSecret;
            set => SetField(ref currentAuthorizedSecret, value);
        }
    }
}