using BottomLayer;
using Ninject.Modules;

namespace Kernel
{
    public class BottomModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IBottomClass>().To<BottomClass>();
        }
    }
}
