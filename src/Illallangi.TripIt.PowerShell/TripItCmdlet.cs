using System;
using System.Management.Automation;
using System.Management.Automation.Host;
using Illallangi.TripIt.Api;
using Illallangi.TripIt.Client;

namespace Illallangi.TripIt
{
    public abstract class TripItCmdlet : PSCmdlet
    {
        #region Fields

        private ITripItApi currentClient;

        #endregion

        #region Properties

        protected ITripItApi Client => this.currentClient ?? (this.currentClient = this.GetClient());

        #endregion

        #region Methods

        private void AuthorizeToken(Uri uri, string token)
        {
            System.Diagnostics.Process.Start(uri.ToString());
            this.Host.UI.WriteLine($@"TripIt will now open in your default web browser to authorize token ""{token}"".");
            this.Host.UI.WriteLine(@"Please complete the authorization process and press OK once complete.");
            this.Host.UI.RawUI.ReadKey(ReadKeyOptions.NoEcho | ReadKeyOptions.IncludeKeyDown);
        }

        private TripItRefitClient GetClient()
        {
            return new TripItRefitClient(
                this.AuthorizeToken,
                this.Host.UI.WriteDebugLine);
        }

        #endregion
    }
}