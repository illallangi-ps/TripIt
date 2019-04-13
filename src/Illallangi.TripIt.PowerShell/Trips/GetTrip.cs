using System.Diagnostics.CodeAnalysis;
using System.Management.Automation;

namespace Illallangi.TripIt.Trips
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [Cmdlet(VerbsCommon.Get, "TripItTrip")]
    public sealed class GetTrip : TripItCmdlet
    {
        protected override void EndProcessing()
        {
            WriteObject(Get<ITripApi>().GetTrip(), true);
        }
    }
}