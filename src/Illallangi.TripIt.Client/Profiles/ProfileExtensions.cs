using System.Collections.Generic;

namespace Illallangi.TripIt.Profiles
{
    public static class ProfileExtensions
    {
        public static IEnumerable<Profile> GetProfile(this IProfileApi api)
        {
            var result = api.GetProfile();
            foreach (var profile in result.Result.Profile)
            {
                yield return profile;
            }
        }
    }
}