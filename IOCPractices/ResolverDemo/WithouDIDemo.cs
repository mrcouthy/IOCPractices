
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolverDemo
{
    public class WithouDiDemo
    {
        public void Demo()
        {
            var visaShopper = new VisaShopper();
            visaShopper.Charge();
            var masterShopper = new MasterCardShopper();
            masterShopper.Charge();
            Console.Read();
        }

        public class VisaShopper
        {
            public void Charge()
            {
                var visaCard = new Visa();
                var chargeMessage = visaCard.Charge();
                Console.WriteLine(chargeMessage);
            }
        }

        public class MasterCardShopper
        {
            public void Charge()
            {
                var masterCard = new MasterCard();
                var chargeMessage = masterCard.Charge();
                Console.WriteLine(chargeMessage);
            }
        }

        public class MasterCard 
        {
            public string Charge()
            {
                return "Swiping the MasterCard!";
            }
        }

        public class Visa
        {
            public string Charge()
            {
                return "Chaaaarging with the Visa!";
            }
        }

    }
}
