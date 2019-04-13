using System.Management.Automation;

namespace Illallangi.TripIt.Settings
{
    [Cmdlet(VerbsCommon.Set, "TripItSetting")]
    public sealed class SetSetting : TripItCmdlet
    {
        [Parameter(ValueFromPipelineByPropertyName = true)]
        public string ConsumerKey
        {
            get => Get<ISetting>().ConsumerKey;
            set => Get<ISetting>().ConsumerKey = value;
        }

        [Parameter(ValueFromPipelineByPropertyName = true)]
        public string ConsumerSecret
        {
            get => Get<ISetting>().ConsumerSecret;
            set => Get<ISetting>().ConsumerSecret = value;
        }

        [Parameter(ValueFromPipelineByPropertyName = true)]
        public string AuthorizeUrl
        {
            get => Get<ISetting>().AuthorizeUrl;
            set => Get<ISetting>().AuthorizeUrl = value;
        }

        [Parameter(ValueFromPipelineByPropertyName = true)]
        public string CallBackUrl
        {
            get => Get<ISetting>().CallBackUrl;
            set => Get<ISetting>().CallBackUrl = value;
        }

        [Parameter(ValueFromPipelineByPropertyName = true)]
        public string BaseUrl
        {
            get => Get<ISetting>().BaseUrl;
            set => Get<ISetting>().BaseUrl = value;
        }

        [Parameter(ValueFromPipelineByPropertyName = true)]
        public string AuthorizedKey
        {
            get => Get<ISetting>().AuthorizedKey;
            set => Get<ISetting>().AuthorizedKey = value;
        }

        [Parameter(ValueFromPipelineByPropertyName = true)]
        public string AuthorizedSecret
        {
            get => Get<ISetting>().AuthorizedSecret;
            set => Get<ISetting>().AuthorizedSecret = value;
        }
        
        protected override void EndProcessing()
        {
            WriteObject(Get<ISetting>());
        }
    }
}