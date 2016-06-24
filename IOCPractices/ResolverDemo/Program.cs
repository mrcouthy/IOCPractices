 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolverDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Resolver resolver = new Resolver();
            resolver.Register<Shopper, Shopper>();
            resolver.Register<ICreditCard, Visa>();

            var shopper = resolver.Resolve<Shopper>();
            shopper.DoShopping();

            Console.Read();
        }
    }
}
