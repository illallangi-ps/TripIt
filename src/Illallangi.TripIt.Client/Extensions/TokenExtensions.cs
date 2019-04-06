using System.Threading.Tasks;

namespace Illallangi.TripIt.Api.Extensions
{
    public static class TokenExtensions
    { 
        public static async Task<OAuthToken> AccessToken(this ITripItApi api)
        {
            var raw = api.AccessTokenApi.AccessToken();
            return OAuthToken.FromQueryString(await raw);
        }

        public static async Task<OAuthToken> RequestToken(this ITripItApi api)
        {
            var raw = api.RequestTokenApi.RequestToken();
            return OAuthToken.FromQueryString(await raw);
        }
    }
}