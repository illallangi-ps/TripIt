using System.Diagnostics.CodeAnalysis;
using System.Management.Automation;

namespace Illallangi.TripIt.Profiles
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [Cmdlet(VerbsCommon.Get, "TripItProfile")]
    public sealed class GetProfile : TripItCmdlet
    {
        protected override void EndProcessing()
        {
            this.WriteObject(this.Client.ProfileApi.GetProfile().Result.Profile, true);
        }
    }
}