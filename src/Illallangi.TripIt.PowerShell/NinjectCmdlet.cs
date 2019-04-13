using System.Management.Automation;
using System.Net;
using Ninject;
using Ninject.Modules;

namespace Illallangi.TripIt
{
    public abstract class NinjectCmdlet<TModule> : PSCmdlet where TModule : class, INinjectModule
    {
        private TModule currentModule;
        private IKernel currentKernel;

        protected TModule Module => currentModule ?? (currentModule = GetModule());
        private IKernel Kernel => currentKernel ?? (currentKernel = new StandardKernel(Module));

        protected NinjectCmdlet()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        protected T Get<T>()
        {
            return Kernel.Get<T>();
        }

        protected abstract TModule GetModule();
    }
}