using System.Threading.Tasks;

namespace Illallangi.TripIt.Tokens
{
    public static class TokenExtensions
    { 
        public static async Task<OAuthToken> AccessToken(this IAccessTokenApi api)
        {
            var raw = api.AccessToken();
            return OAuthToken.FromQueryString(await raw);
        }

        public static async Task<OAuthToken> RequestToken(this IRequestTokenApi api)
        {
            var raw = api.RequestToken();
            return OAuthToken.FromQueryString(await raw);
        }
    }
}