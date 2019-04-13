using System;
using System.Collections.Generic;

namespace Illallangi.TripIt.Trips
{
    public static class TripExtensions
    {
        public static IEnumerable<Trip> GetTrip(this ITripApi api)
        {
            foreach (var past in new[] { "true", "false" })
            {
                var result = new Response { PageNum = 0, PageSize = 25, MaxPage = int.MaxValue };
                do
                {
                    result = api.GetTrip(result.PageNum + 1, result.PageSize, past).Result;
                    foreach (var trip in result.Trip)
                    {
                        yield return trip;
                    }
                }
                while (result.PageNum < result.MaxPage);
            }
        }

        public static IEnumerable<object> NewTrip(this ITripApi api, DateTime startDate, DateTime endDate, string primaryLocation, string displayName)
        {
            var request = new Request
                              {
                                  Trip = new Trip
                                             {
                                                 StartDate = startDate,
                                                 EndDate = endDate,
                                                 PrimaryLocation = primaryLocation,
                                                 DisplayName = displayName
                                             }
                              };
            var result = api.NewTrip(
                new Dictionary<string, object>
                    {
                        {
                            @"json",
                            request
                        }
                    });

            foreach (var trip in result.Result.Trip)
            {
                yield return trip;
            }
        }
    }
}