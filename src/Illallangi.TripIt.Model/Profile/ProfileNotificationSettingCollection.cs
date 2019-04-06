using System.Collections.Generic;

using Newtonsoft.Json;

namespace Illallangi.TripIt.Model.Profile
{
    [JsonObject]
    public class ProfileNotificationSettingCollection : List<NotificationSetting>
    {
        [JsonProperty(@"NotificationSetting")]
        public ICollection<NotificationSetting> Values => new JsonCollection<NotificationSetting>(this);
    }
}