using System;
using System.Net;
using System.Net.Http;
using Refit;

namespace Illallangi.TripIt
{
    using System.Web;

    public sealed class TripItRefitClient
    {
        #region Fields

        private readonly Action<Uri, string> authorizeToken;

        #region Clients

        private Profiles.IProfileApi currentProfileClient;
        private Trips.ITripApi currentTripClient;
        private Tokens.IRequestTokenApi currentRequestTokenClient;
        private Tokens.IAccessTokenApi currentAccessTokenClient;

        #endregion

        #region Tokens

        private OAuthToken currentConsumerToken;
        private OAuthToken currentUnauthorizedToken;
        private OAuthToken currentAuthorizedToken;

        #endregion

        #endregion

        #region Constructors

        public TripItRefitClient(Settings.ISettingApi settingApi, Action<Uri, string> authorizeToken, SecurityProtocolType securityProtocol = SecurityProtocolType.Tls12)
        {
            this.SettingApi = settingApi;
            this.authorizeToken = authorizeToken ?? throw new ArgumentNullException(nameof(authorizeToken));
            ServicePointManager.SecurityProtocol = securityProtocol;
        }

        #endregion

        #region Properties

        #region Clients

        public Profiles.IProfileApi ProfileApi => this.currentProfileClient ?? (this.currentProfileClient = this.GetClient<Profiles.IProfileApi>());

        public Trips.ITripApi TripApi => this.currentTripClient ?? (this.currentTripClient = this.GetClient<Trips.ITripApi>());

        private Tokens.IRequestTokenApi RequestTokenApi => this.currentRequestTokenClient ?? (this.currentRequestTokenClient = this.GetRequestTokenClient());

        private Tokens.IAccessTokenApi AccessTokenApi => this.currentAccessTokenClient ?? (this.currentAccessTokenClient = this.GetAccessTokenClient());

        public Settings.ISettingApi SettingApi { get; }

        #endregion Clients

        #region Tokens

        private OAuthToken ConsumerToken => this.currentConsumerToken ?? (this.currentConsumerToken = this.GetConsumerToken());

        private OAuthToken UnauthorizedToken => this.currentUnauthorizedToken ?? (this.currentUnauthorizedToken = this.GetUnauthorizedToken());

        private OAuthToken AuthorizedToken => this.currentAuthorizedToken ?? (this.currentAuthorizedToken = this.GetAuthorizedToken());

        #endregion

        #endregion

        #region Methods

        #region Clients

        private T GetClient<T>()
        {
            return RestService.For<T>(
                new HttpClient(new OAuthHmacSha1Handler(
                    new HttpClientHandler(),
                    this.ConsumerToken,
                    this.AuthorizedToken))
                    {
                        BaseAddress = new Uri(this.SettingApi.GetSetting().BaseUrl)
                    });
        }
        
        private Tokens.IRequestTokenApi GetRequestTokenClient()
        {
            return RestService.For<Tokens.IRequestTokenApi>(
                new HttpClient(new OAuthHmacSha1Handler(
                    new HttpClientHandler(), 
                    this.ConsumerToken))
                    {
                        BaseAddress = new Uri(this.SettingApi.GetSetting().BaseUrl)
                    });
        }
        
        private Tokens.IAccessTokenApi GetAccessTokenClient()
        {
            return RestService.For<Tokens.IAccessTokenApi>(
                new HttpClient(new OAuthHmacSha1Handler(
                    new HttpClientHandler(),
                    this.ConsumerToken,
                    this.UnauthorizedToken))
                    {
                        BaseAddress = new Uri(this.SettingApi.GetSetting().BaseUrl)
                    });
        }

        #endregion

        #region Tokens

        private OAuthToken GetConsumerToken()
        {
            return new OAuthToken(this.SettingApi.GetSetting().ConsumerKey, this.SettingApi.GetSetting().ConsumerSecret);
        }

        private OAuthToken GetUnauthorizedToken()
        {

            return OAuthToken.FromQueryString(this.RequestTokenApi.RequestToken().Result);
        }

        private OAuthToken GetAuthorizedToken()
        {
            if (string.IsNullOrEmpty(this.SettingApi.GetSetting().AuthorizedSecret) | string.IsNullOrEmpty(this.SettingApi.GetSetting().AuthorizedKey))
            {
                var uriString = string.Format(
                    this.SettingApi.GetSetting().AuthorizeUrl,
                    this.UnauthorizedToken.Key,
                    HttpUtility.UrlEncode(this.SettingApi.GetSetting().CallBackUrl));
                this.authorizeToken(
                    new Uri(uriString),
                    this.UnauthorizedToken.Key);
                var result = OAuthToken.FromQueryString(this.AccessTokenApi.AccessToken().Result);
                this.SettingApi.GetSetting().AuthorizedKey = result.Key;
                this.SettingApi.GetSetting().AuthorizedSecret = result.Secret;
            }

            return new OAuthToken(this.SettingApi.GetSetting().AuthorizedKey, this.SettingApi.GetSetting().AuthorizedSecret);
        }

        #endregion

        #endregion
    }
}
