using System.Collections.Generic;

using Illallangi.TripIt.Model.Profile;

namespace Illallangi.TripIt.Api.Extensions
{
    public static class ProfileExtensions
    {
        public static IEnumerable<Profile> GetProfile(this ITripItApi api)
        {
            var result = api.ProfileApi.GetProfile();
            foreach (var profile in result.Result.Profile)
            {
                yield return profile;
            }
        }
    }
}