using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolverDemo
{
    public class WithoutIOCContainer
    {
        public void Demo()
        {
            var visa = new Visa();
            var shopper = new Shopper(visa);
            shopper.DoShopping();
            Console.Read();
        }
    }
}
