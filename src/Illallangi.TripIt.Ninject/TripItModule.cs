using System;
using System.Net.Http;
using Newtonsoft.Json;
using Ninject;
using Ninject.Modules;

namespace Illallangi.TripIt
{
    public class TripItModule : NinjectModule
    {
        public TripItModule(Action<AuthorizeEventArgs> authorize)
        {
            Authorize = authorize ?? throw new ArgumentNullException(nameof(authorize));
        }

        private Action<AuthorizeEventArgs> Authorize { get; }
        
        private void OnAuthorize(string token, string uri, params object[] args) => Authorize(new AuthorizeEventArgs(token, uri, args));

        public override void Load()
        {
            Bind<Action<AuthorizeEventArgs>>().ToConstant(Authorize).InSingletonScope();
            
            Bind<Settings.ISetting>().ToMethod(ctx => Settings.JsonSetting.Retrieve()).InSingletonScope();
            Bind<IOAuthSetting>().ToMethod(ctx => ctx.Kernel.Get<Settings.ISetting>()).InSingletonScope();

            Bind<HttpClientHandler>().To<HttpClientHandler>().InSingletonScope();

            Bind<OAuthHmacSha1SigningHandler>().ToMethod(ctx => new OAuthHmacSha1SigningHandler(
                ctx.Kernel.Get<HttpClientHandler>(),
                ctx.Kernel.Get<Settings.ISetting>()));
            
            Bind<Tokens.IRequestTokenApi>().ToProvider<OAuthHmacSha1SignedRestServiceProvider<Tokens.IRequestTokenApi>>().InSingletonScope();
            Bind<Tokens.IAccessTokenApi>().ToProvider<OAuthHmacSha1SignedRestServiceProvider<Tokens.IAccessTokenApi>>().InSingletonScope();
            Bind<Profiles.IProfileApi>().ToProvider<OAuthHmacSha1SignedRestServiceProvider<Profiles.IProfileApi>>().InSingletonScope();
            Bind<Trips.ITripApi>().ToProvider<OAuthHmacSha1SignedRestServiceProvider<Trips.ITripApi>>().InSingletonScope();
        }
    }
}
