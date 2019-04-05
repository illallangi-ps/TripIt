namespace Illallangi.TripIt
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Management.Automation;

    using Illallangi.TripIt.Api.Extensions;

    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [Cmdlet(VerbsCommon.New, "TripItTrip")]
    public sealed class NewTrip : TripItCmdlet
    {
        [Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        public DateTime StartDate { get; set; }

        [Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        public DateTime EndDate { get; set; }

        [Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        public string PrimaryLocation { get; set; }

        [Parameter(ValueFromPipelineByPropertyName = true, Mandatory = true)]
        public string DisplayName { get; set; }

        protected override void ProcessRecord()
        {
            this.WriteObject(this.Client.NewTrip(this.StartDate, this.EndDate, this.PrimaryLocation, this.DisplayName), true);
        }
    }
}