using System.Management.Automation;

namespace Illallangi.TripIt.Settings
{
    [Cmdlet(VerbsCommon.Get, "TripItSetting")]
    public sealed class GetSetting : TripItCmdlet
    {
        protected override void EndProcessing()
        {
            this.WriteObject(this.Client.SettingApi.GetSetting());
        }
    }
}