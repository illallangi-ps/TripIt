using System.Threading.Tasks;
using Refit;

namespace Illallangi.TripIt.Profiles
{
    [Headers(OAuthHmacSha1SigningHandler.AuthorizationHeader)]
    public interface IProfileApi
    {
        [Get(@"/v1/get/profile?format=json")]
        Task<Response> GetProfile();
    }
}