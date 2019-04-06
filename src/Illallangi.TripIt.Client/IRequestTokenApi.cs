using System.Threading.Tasks;
using Refit;

namespace Illallangi.TripIt.Api
{
    public interface IRequestTokenApi
    {
        [Post(@"/oauth/request_token")]
        Task<string> RequestToken();
    }
}