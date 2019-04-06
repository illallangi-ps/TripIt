using System;
using System.Collections.Generic;

using Illallangi.TripIt.Model.Response;
using Illallangi.TripIt.Model.Trip;

namespace Illallangi.TripIt.Api.Extensions
{
    using Newtonsoft.Json;

    public static class TripExtensions
    {
        public static IEnumerable<Trip> GetTrip(this ITripItApi api)
        {
            foreach (var past in new[] { "true", "false" })
            {
                var result = new Response { PageNum = 0, PageSize = 25, MaxPage = int.MaxValue };
                do
                {
                    result = api.TripApi.GetTrip(result.PageNum + 1, result.PageSize, past).Result;
                    foreach (var trip in result.Trip)
                    {
                        yield return trip;
                    }
                }
                while (result.PageNum < result.MaxPage);
            }
        }

        public static IEnumerable<object> NewTrip(this ITripItApi api, DateTime startDate, DateTime endDate, string primaryLocation, string displayName)
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
            api.Debug(request.ToString());

            var result = api.TripApi.NewTrip(
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