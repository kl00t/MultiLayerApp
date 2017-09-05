using System;
using System.Collections.Generic;
using Kernel;
using Ninject;
using Ninject.Modules;

namespace TopLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel(new TopModule());

            var modules = new List<INinjectModule>
            {
                new MiddleModule(),
                new BottomModule()
            };

            kernel.Load(modules);

            var topClass = kernel.Get<ITopClass>();
            var message = topClass.GetMessage();
            Console.WriteLine(message);

            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
    }
}
