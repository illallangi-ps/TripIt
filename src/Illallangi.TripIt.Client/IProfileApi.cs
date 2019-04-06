using System.Threading.Tasks;
using Illallangi.TripIt.Model.Response;
using Refit;

namespace Illallangi.TripIt.Api
{
    public interface IProfileApi
    {
        [Get(@"/v1/get/profile?format=json")]
        Task<Response> GetProfile();
    }
}