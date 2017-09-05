using MiddleLayer;
using Ninject.Modules;

namespace Kernel
{
    public class MiddleModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMiddleClass>().To<MiddleClass>();
        }
    }
}
