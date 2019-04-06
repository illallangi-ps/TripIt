using Illallangi.TripIt.Api;
using Illallangi.TripIt.Model.Settings;

namespace Illallangi.TripIt.Client
{
    public sealed class SettingsClient : ISettingsApi
    {
        #region Fields

        private Settings currentSettings;

        #endregion

        #region Methods

        public Settings GetSettings()
        {
            return this.currentSettings ?? (this.currentSettings = new Settings());
        }

        #endregion
    }
}