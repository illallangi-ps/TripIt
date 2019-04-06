namespace Illallangi.TripIt.Settings
{
    public sealed class SettingClient : ISettingApi
    {
        #region Fields

        private Setting currentSetting;

        #endregion

        #region Methods

        public Setting GetSetting()
        {
            return this.currentSetting ?? (this.currentSetting = new Setting());
        }

        #endregion
    }
}