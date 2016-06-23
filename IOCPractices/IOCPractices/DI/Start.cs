using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCPractices.DI
{
    public class Start
    {
        public void StartMe()
        {
            DemoAppFirstWay demoApp = new DemoAppFirstWay();
            demoApp.FirstWay();

            DemoAppSecondWay secondWay = new DemoAppSecondWay();
            secondWay.SecondWayStart();
            secondWay.SeconWayEveryTime();
        }
    }
}
