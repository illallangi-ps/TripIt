using System;
using System.Net;
using System.Net.Http;
using Illallangi.TripIt.Api;
using Illallangi.TripIt.Api.Extensions;
using Refit;

namespace Illallangi.TripIt.Client
{
    using System.Web;

    public sealed class TripItRefitClient : ITripItApi
    {
        #region Fields

        private readonly Action<Uri, string> authorizeToken;

        #region Clients

        private ISettingsApi currentSettingsClient;
        private IProfileApi currentProfileClient;
        private ITripApi currentTripClient;
        private IRequestTokenApi currentRequestTokenClient;
        private IAccessTokenApi currentAccessTokenClient;

        #endregion

        #region Tokens

        private OAuthToken currentConsumerToken;
        private OAuthToken currentUnauthorizedToken;
        private OAuthToken currentAuthorizedToken;

        #endregion

        #endregion

        #region Constructors

        public TripItRefitClient(Action<Uri, string> authorizeToken, Action<string> debug = null, SecurityProtocolType securityProtocol = SecurityProtocolType.Tls12)
        {
            this.authorizeToken = authorizeToken ?? throw new ArgumentNullException(nameof(authorizeToken));
            this.Debug = debug ?? (str => { });
            ServicePointManager.SecurityProtocol = securityProtocol;
        }

        #endregion

        #region Properties

        public Action<string> Debug { get; }

        #region Clients

        public ISettingsApi SettingsApi => this.currentSettingsClient ?? (this.currentSettingsClient = this.GetSettingsClient());

        public IProfileApi ProfileApi => this.currentProfileClient ?? (this.currentProfileClient = this.GetClient<IProfileApi>());

        public ITripApi TripApi => this.currentTripClient ?? (this.currentTripClient = this.GetClient<ITripApi>());

        public IRequestTokenApi RequestTokenApi => this.currentRequestTokenClient ?? (this.currentRequestTokenClient = this.GetRequestTokenClient());

        public IAccessTokenApi AccessTokenApi => this.currentAccessTokenClient ?? (this.currentAccessTokenClient = this.GetAccessTokenClient());

        #endregion Clients

        #region Tokens

        private OAuthToken ConsumerToken => this.currentConsumerToken ?? (this.currentConsumerToken = this.GetConsumerToken());

        private OAuthToken UnauthorizedToken => this.currentUnauthorizedToken ?? (this.currentUnauthorizedToken = this.GetUnauthorizedToken());

        private OAuthToken AuthorizedToken => this.currentAuthorizedToken ?? (this.currentAuthorizedToken = this.GetAuthorizedToken());

        #endregion

        #endregion

        #region Methods

        #region Clients

        private SettingsClient GetSettingsClient()
        {
            return new SettingsClient();
        }

        private T GetClient<T>()
        {
            return RestService.For<T>(
                new HttpClient(new OAuthHmacSha1Handler(
                    new HttpClientHandler(),
                    this.ConsumerToken,
                    this.AuthorizedToken,
                    debug: this.Debug))
                    {
                        BaseAddress = new Uri(this.SettingsApi.GetSettings().BaseUrl)
                    });
        }
        
        private IRequestTokenApi GetRequestTokenClient()
        {
            return RestService.For<IRequestTokenApi>(
                new HttpClient(new OAuthHmacSha1Handler(
                    new HttpClientHandler(), 
                    this.ConsumerToken, 
                    debug: this.Debug))
                    {
                        BaseAddress = new Uri(this.SettingsApi.GetSettings().BaseUrl)
                    });
        }
        
        private IAccessTokenApi GetAccessTokenClient()
        {
            return RestService.For<IAccessTokenApi>(
                new HttpClient(new OAuthHmacSha1Handler(
                    new HttpClientHandler(),
                    this.ConsumerToken,
                    this.UnauthorizedToken,
                    debug: this.Debug))
                    {
                        BaseAddress = new Uri(this.SettingsApi.GetSettings().BaseUrl)
                    });
        }

        #endregion

        #region Tokens

        private OAuthToken GetConsumerToken()
        {
            return new OAuthToken(this.SettingsApi.GetSettings().ConsumerKey, this.SettingsApi.GetSettings().ConsumerSecret);
        }

        private OAuthToken GetUnauthorizedToken()
        {
            return this.RequestToken().Result;
        }

        private OAuthToken GetAuthorizedToken()
        {
            if (string.IsNullOrEmpty(this.SettingsApi.GetSettings().AuthorizedSecret) | string.IsNullOrEmpty(this.SettingsApi.GetSettings().AuthorizedKey))
            {
                var uriString = string.Format(
                    this.SettingsApi.GetSettings().AuthorizeUrl,
                    this.UnauthorizedToken.Key,
                    HttpUtility.UrlEncode(this.SettingsApi.GetSettings().CallBackUrl));
                this.authorizeToken(
                    new Uri(uriString),
                    this.UnauthorizedToken.Key);
                var result = this.AccessToken().Result;
                this.SettingsApi.GetSettings().AuthorizedKey = result.Key;
                this.SettingsApi.GetSettings().AuthorizedSecret = result.Secret;
            }

            return new OAuthToken(this.SettingsApi.GetSettings().AuthorizedKey, this.SettingsApi.GetSettings().AuthorizedSecret);
        }

        #endregion

        #endregion
    }
}
