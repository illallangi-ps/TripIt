using System.Management.Automation;

namespace Illallangi.TripIt.Settings
{
    [Cmdlet(VerbsCommon.Set, "TripItSetting")]
    public sealed class SetSetting : TripItCmdlet
    {
        [Parameter(ValueFromPipelineByPropertyName = true)]
        public string ConsumerKey
        {
            get => this.Client.SettingApi.GetSetting().ConsumerKey;
            set => this.Client.SettingApi.GetSetting().ConsumerKey = value;
        }

        [Parameter(ValueFromPipelineByPropertyName = true)]
        public string ConsumerSecret
        {
            get => this.Client.SettingApi.GetSetting().ConsumerSecret;
            set => this.Client.SettingApi.GetSetting().ConsumerSecret = value;
        }

        [Parameter(ValueFromPipelineByPropertyName = true)]
        public string AuthorizeUrl
        {
            get => this.Client.SettingApi.GetSetting().AuthorizeUrl;
            set => this.Client.SettingApi.GetSetting().AuthorizeUrl = value;
        }

        [Parameter(ValueFromPipelineByPropertyName = true)]
        public string CallBackUrl
        {
            get => this.Client.SettingApi.GetSetting().CallBackUrl;
            set => this.Client.SettingApi.GetSetting().CallBackUrl = value;
        }

        [Parameter(ValueFromPipelineByPropertyName = true)]
        public string BaseUrl
        {
            get => this.Client.SettingApi.GetSetting().BaseUrl;
            set => this.Client.SettingApi.GetSetting().BaseUrl = value;
        }

        [Parameter(ValueFromPipelineByPropertyName = true)]
        public string AuthorizedKey
        {
            get => this.Client.SettingApi.GetSetting().AuthorizedKey;
            set => this.Client.SettingApi.GetSetting().AuthorizedKey = value;
        }

        [Parameter(ValueFromPipelineByPropertyName = true)]
        public string AuthorizedSecret
        {
            get => this.Client.SettingApi.GetSetting().AuthorizedSecret;
            set => this.Client.SettingApi.GetSetting().AuthorizedSecret = value;
        }
        
        protected override void EndProcessing()
        {
            this.WriteObject(this.Client.SettingApi.GetSetting());
        }
    }
}