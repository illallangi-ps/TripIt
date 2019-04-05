using Microsoft.Win32;

namespace Illallangi.TripIt.Model.Settings
{
    public sealed class Settings
    {
        private const string DefaultConsumerKey = @"XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        private const string DefaultConsumerSecret = @"XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        private const string DefaultAuthorizeUrl = @"https://www.tripit.com/oauth/authorize?oauth_token={0}&oauth_callback={1}";
        private const string DefaultCallBackUrl = @"http://fiftyeight.us/callback.html";
        private const string DefaultBaseUrl = @"https://api.tripit.com";
        private const string KeyName = @"Software\Illallangi Enterprises\TripIt Client";

        public string ConsumerKey
        {
            get => this.ConsumerKey = Registry.CurrentUser.CreateSubKeyAndGetValue(KeyName, nameof(this.ConsumerKey), DefaultConsumerKey);
            set => Registry.CurrentUser.CreateSubKeyAndSetValue(KeyName, nameof(this.ConsumerKey), value);
        }

        public string ConsumerSecret
        {
            get => this.ConsumerSecret = Registry.CurrentUser.CreateSubKeyAndGetValue(KeyName, nameof(this.ConsumerSecret), DefaultConsumerSecret);
            set => Registry.CurrentUser.CreateSubKeyAndSetValue(KeyName, nameof(this.ConsumerSecret), value);
        }

        public string AuthorizeUrl
        {
            get => this.AuthorizeUrl = Registry.CurrentUser.CreateSubKeyAndGetValue(KeyName, nameof(this.AuthorizeUrl), DefaultAuthorizeUrl);
            set => Registry.CurrentUser.CreateSubKeyAndSetValue(KeyName, nameof(this.AuthorizeUrl), value);
        }

        public string CallBackUrl
        {
            get => this.CallBackUrl = Registry.CurrentUser.CreateSubKeyAndGetValue(KeyName, nameof(this.CallBackUrl), DefaultCallBackUrl);
            set => Registry.CurrentUser.CreateSubKeyAndSetValue(KeyName, nameof(this.CallBackUrl), value);
        }

        public string BaseUrl
        {
            get => this.BaseUrl = Registry.CurrentUser.CreateSubKeyAndGetValue(KeyName, nameof(this.BaseUrl), DefaultBaseUrl);
            set => Registry.CurrentUser.CreateSubKeyAndSetValue(KeyName, nameof(this.BaseUrl), value);
        }

        public string AuthorizedKey
        {
            get => this.AuthorizedKey = Registry.CurrentUser.CreateSubKeyAndGetValue(KeyName, nameof(this.AuthorizedKey));
            set => Registry.CurrentUser.CreateSubKeyAndSetValue(KeyName, nameof(this.AuthorizedKey), value);
        }

        public string AuthorizedSecret
        {
            get => this.AuthorizedSecret = Registry.CurrentUser.CreateSubKeyAndGetValue(KeyName, nameof(this.AuthorizedSecret));
            set => Registry.CurrentUser.CreateSubKeyAndSetValue(KeyName, nameof(this.AuthorizedSecret), value);
        }
    }
}