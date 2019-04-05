using System.Threading.Tasks;
using Refit;

namespace Illallangi.TripIt.Api
{
    public interface IAccessTokenApi
    { 
        [Post(@"/oauth/access_token")]
        Task<string> AccessToken();
    }
}