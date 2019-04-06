namespace Illallangi.TripIt.Settings
{
    public sealed class SettingClient : ISettingApi
    {
        #region Fields

        private ISetting currentSetting;

        #endregion

        #region Methods

        public ISetting GetSetting()
        {
            return this.currentSetting ?? (this.currentSetting = JsonSetting.Retrieve());
        }

        #endregion
    }
}