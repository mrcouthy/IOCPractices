using Autofac;
using ResolverDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacDemo
{
    class Program
    {
        private static IContainer Container { get; set; }
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Visa>().As<ICreditCard>();
            builder.RegisterType<Shopper>().As<IShopper>();
            Container = builder.Build();


            //Some other place
            

            // Create the scope, resolve your IDateWriter,
            // use it, then dispose of the scope.
            using (var scope = Container.BeginLifetimeScope())
            {
                var shopper = scope.Resolve<IShopper>();
                shopper.DoShopping();
            }
            Console.ReadLine();

        }
    }
}
