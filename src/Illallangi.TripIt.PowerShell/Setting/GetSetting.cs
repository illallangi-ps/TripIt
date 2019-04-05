using System.Diagnostics.CodeAnalysis;
using System.Management.Automation;

namespace Illallangi.TripIt
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [Cmdlet(VerbsCommon.Get, "TripItSetting")]
    public sealed class GetSetting : TripItCmdlet
    {
        protected override void EndProcessing()
        {
            this.WriteObject(this.Client.SettingsApi.GetSettings());
        }
    }
}