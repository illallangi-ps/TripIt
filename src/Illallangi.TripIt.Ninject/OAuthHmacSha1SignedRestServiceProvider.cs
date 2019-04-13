using System;
using System.Linq;
using System.Net.Http;
using System.Web;
using Illallangi.Extensions;
using Newtonsoft.Json;
using Ninject.Activation;
using Refit;

namespace Illallangi.TripIt
{
    public class OAuthHmacSha1SignedRestServiceProvider<T> : Provider<T>
    {
        private IOAuthSetting Setting { get; }
        private OAuthHmacSha1SigningHandler OAuthHmacSha1SigningHandler { get; }
        private Action<AuthorizeEventArgs> Authorize { get; }
        public OAuthHmacSha1SignedRestServiceProvider(
            IOAuthSetting setting, 
            OAuthHmacSha1SigningHandler oAuthHmacSha1SigningHandler,
            Action<AuthorizeEventArgs> authorize)
        {
            Setting = setting;
            OAuthHmacSha1SigningHandler = oAuthHmacSha1SigningHandler;
            Authorize = authorize;
        }

        private void OnAuthorize(string token, string uri, params object[] args) => Authorize(new AuthorizeEventArgs(token, uri, args));


        protected override T CreateInstance(IContext ctx)
        {
            if (!string.IsNullOrEmpty(Setting.AuthorizedKey))
                return RestService.For<T>(
                    new HttpClient(OAuthHmacSha1SigningHandler)
                    {
                        BaseAddress = new Uri(Setting.BaseUrl)
                    });

            var requestTokenString = RestService.For<Tokens.IRequestTokenApi>(new HttpClient(OAuthHmacSha1SigningHandler)
                    { BaseAddress = new Uri(Setting.BaseUrl) })
                .RequestToken(new Tokens.RequestTokenParams
                {
                    ConsumerKey = Setting.ConsumerKey
                })
                .Result;

            Setting.AuthorizedKey = HttpUtility.ParseQueryString(requestTokenString).ToDictionary()["oauth_token"].Single();
            Setting.AuthorizedSecret = HttpUtility.ParseQueryString(requestTokenString).ToDictionary()["oauth_token_secret"].Single();
                
            OnAuthorize(Setting.AuthorizedKey, Setting.AuthorizeUrl, Setting.AuthorizedKey, Setting.CallBackUrl);

            var accessTokenString = RestService.For<Tokens.IAccessTokenApi>(new HttpClient(OAuthHmacSha1SigningHandler)
                    { BaseAddress = new Uri(Setting.BaseUrl) })
                .AccessToken(new Tokens.AccessTokenParams
                {
                    ConsumerKey = Setting.ConsumerKey,
                    RequestToken = Setting.AuthorizedKey,
                    RequestTokenSecret = Setting.AuthorizedSecret
                })
                .Result;

            Setting.AuthorizedKey = HttpUtility.ParseQueryString(accessTokenString).ToDictionary()["oauth_token"].Single();
            Setting.AuthorizedSecret = HttpUtility.ParseQueryString(accessTokenString).ToDictionary()["oauth_token_secret"].Single();

            return RestService.For<T>(
                new HttpClient(OAuthHmacSha1SigningHandler)
                {
                    BaseAddress = new Uri(Setting.BaseUrl)
                });
        }
    }
}