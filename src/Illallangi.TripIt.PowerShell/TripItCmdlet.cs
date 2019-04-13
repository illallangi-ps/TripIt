using System.Management.Automation.Host;

namespace Illallangi.TripIt
{
    public abstract class TripItCmdlet : NinjectCmdlet<TripItModule>
    {
        protected override TripItModule GetModule()
        {
            return new TripItModule(
                args =>
                {
                    System.Diagnostics.Process.Start(args.Uri.ToString());
                    Host.UI.WriteLine(
                        $@"TripIt will now open in your default web browser to authorize token ""{args.Token}"".");
                    Host.UI.WriteLine(@"Please complete the authorization process and press any key once complete.");
                    Host.UI.RawUI.ReadKey(ReadKeyOptions.NoEcho | ReadKeyOptions.IncludeKeyDown);
                });
        }
    }
}