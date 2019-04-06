using System.Threading.Tasks;

using Refit;

namespace Illallangi.TripIt.Trips
{
    using System.Collections.Generic;

    public interface ITripApi
    {
        [Get(@"/v1/list/trip/past/{past}?format=json&page_num={pageNumber}&page_size={pageSize}")]
        Task<Response> GetTrip(int pageNumber, int pageSize, string past);

        [Post(@"/v1/create?format=json")]
        Task<Response> NewTrip([Body(BodySerializationMethod.UrlEncoded)] Dictionary<string, object> data);
    }
}