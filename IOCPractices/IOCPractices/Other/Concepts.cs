using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCPractices
{

    public class Test
    {
        public void test()
        {
            Apple a = new Apple();
            var k = a.SomeOperation(2, 3);
            Debug.Write(k);

            Ball ball = new Ball();
            var l = ball.SomeOperation(2, 3);
            Debug.Write(l);
            B b = new B();
            C c = new C();
            var x = ball.SomeOperationNew(3, 3);
        }
    }
    public abstract class AbstractTest
    {
        //abstract method cannot be in a normal class
        //abstract class can contain normal methods ! 
        public int Add(int a, int b)
        {
            return a + b;
        }

        public abstract int AddAgain(int a, int b);

    }

    public class AbstractTestUse : AbstractTest
    {
        public override int AddAgain(int a, int b)
        {
            return Add(a, b);
        }
    }

    public class Apple
    {
        public virtual int SomeOperation(int i, int j)
        {
            return i + j;
        }

        public virtual int SomeOperationSealed(int i, int j)
        {
            return i + j;
        }

        private void TestPrivate()
        { }
        public void TestPublic()
        { }
        protected void TestProtected()
        { }
        internal void TestInternal()
        { }

        public int SomeOperationNew(int i, int j)
        {
            return i - j;
        }
    }

    public class Ball : Apple
    {
        public override int SomeOperation(int i, int j)
        {
            //na TestPrivate();
            TestInternal();
            TestProtected();
            TestPublic();
            var c = new Apple();
            c.TestPublic();
            c.TestInternal();//na in other assembly
            //na c.TestProtected();
            return i - j;
        }

        public new int SomeOperationNew(int i, int j)
        {
            //with new in method there is no compiler warning when overrding method without virtual key word
            return i - j;
        }

        public sealed override int SomeOperationSealed(int i, int j)
        {
            return i + j;
        }


    }

    public class Cat : Ball
    {
        public override int SomeOperation(int i, int j)
        {
            return i - j;
        }

        public new int SomeOperationq(int i, int j)
        {
            return i - j;
        }

        //Its sealed
        //public override int SomeOperationSealed(int i, int j)
        //{
        //    return i + j;
        //}
    }

}
