using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResolverDemo;
using Moq;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mockCard = new Mock<ICreditCard>();
            mockCard.Setup(foo => foo.Charge()).Returns("Swiping a vitual card !");
            var shopTest = new Shopper(mockCard.Object);
            shopTest.DoShopping();
        }
    }
}
