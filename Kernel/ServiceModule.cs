﻿using Core;
using Ninject.Modules;
using Repository;

namespace Kernel
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IBottomClass>().To<BottomClass>();
            Bind<IMiddleClass>().To<MiddleClass>();
            Bind<ITopClass>().To<TopClass>();
        }
    }
}
