using System;
using Core;
using Kernel;
using Ninject;

namespace TopLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = CreateKernel();
            var topClass = kernel.Get<ITopClass>();
            var message = topClass.GetMessage("Scott");
            Console.WriteLine(message);

            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }

        private static IKernel CreateKernel()
        {
            return new StandardKernel(new ServiceModule());
        }
    }
}
