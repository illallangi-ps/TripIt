using System.Collections.Generic;

using Newtonsoft.Json;

namespace Illallangi.TripIt.Profiles
{
    [JsonObject]
    public class ProfileNotificationSettingCollection : List<NotificationSetting>
    {
        [JsonProperty(@"NotificationSetting")]
        public ICollection<NotificationSetting> Values => new JsonCollection<NotificationSetting>(this);
    }
}