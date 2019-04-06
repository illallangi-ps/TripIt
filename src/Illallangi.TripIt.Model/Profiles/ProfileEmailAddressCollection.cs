using System.Collections.Generic;

using Newtonsoft.Json;

namespace Illallangi.TripIt.Profiles
{
    [JsonObject]
    public class ProfileEmailAddressCollection : List<EmailAddress>
    {
        [JsonProperty(@"ProfileEmailAddress")]
        public ICollection<EmailAddress> Values => new JsonCollection<EmailAddress>(this);
    }
}