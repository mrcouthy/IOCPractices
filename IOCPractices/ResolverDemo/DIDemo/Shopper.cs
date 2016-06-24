using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolverDemo
{
    public interface IShopper
    {
        void DoShopping();
    }
    public class Shopper : IShopper
    {
        private readonly ICreditCard creditCard;

        public Shopper(ICreditCard creditCard)
        {
            this.creditCard = creditCard;
        }

        public void DoShopping()
        {
            //Add items
            //...
            var chargeMessage = creditCard.Charge();
            Console.WriteLine(chargeMessage);
        }
    }
}
