using System.Diagnostics.CodeAnalysis;
using System.Management.Automation;

using Illallangi.TripIt.Api.Extensions;

namespace Illallangi.TripIt
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [Cmdlet(VerbsCommon.Get, "TripItProfile")]
    public sealed class GetProfile : TripItCmdlet
    {
        protected override void EndProcessing()
        {
            this.WriteObject(this.Client.GetProfile(), true);
        }
    }
}