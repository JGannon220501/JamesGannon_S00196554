using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using JamesGannon_S00196554;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //ARRANGE
            Game g1 = new Game();
            g1.Price = 100;
            decimal finalPrice = 50;
            //ACT
            g1.DecreasePrice(50);
            //ASSERT
            Assert.AreEqual(finalPrice, g1.Price);
        }
    }
}
