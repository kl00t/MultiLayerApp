using Kernel;
using Ninject;
using Ninject.Web.Common;

namespace Client.WcfService
{
    public class Global : NinjectHttpApplication
    {
        protected override IKernel CreateKernel()
        {
            return new StandardKernel(new ServiceModule());
        }

        protected override void OnApplicationStarted()
        {
                
        }
    }
}