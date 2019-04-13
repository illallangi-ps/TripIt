using System.Threading.Tasks;
using Refit;

namespace Illallangi.TripIt.Tokens
{
    public interface IAccessTokenApi
    { 
        [Post(@"/oauth/access_token")]
        Task<string> AccessToken([Body(BodySerializationMethod.UrlEncoded)]AccessTokenParams p);
    }
}