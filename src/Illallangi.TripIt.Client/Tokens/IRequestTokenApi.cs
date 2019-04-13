using System.Threading.Tasks;
using Refit;

namespace Illallangi.TripIt.Tokens
{
    public interface IRequestTokenApi
    {
        [Post(@"/oauth/request_token")]
        Task<string> RequestToken([Body(BodySerializationMethod.UrlEncoded)]RequestTokenParams p);
    }
}