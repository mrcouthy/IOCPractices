using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCPractices
{
   public static  class Concepts2
    {
        public static void test()
        {
            // this key word is not allowed in static since there is no current object context
        }
    }

    public class A
    {
        public A()
        {
            string s = "It come here from c";
        }
    }

    public class B:A
    {
        public B():base()
        {

        }
    }

    public class C : A
    {
        public C() 
        {

        }
    }
}
