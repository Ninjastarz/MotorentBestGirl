using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modals;

namespace UnitTestGitHub
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod()]
        public void TestFuelEfficiency()
        {
            int fuelp = 10;
            float kmst = 100;
            double expected = 10;

            var v = new Vehicle(fuelp, kmst);

            double actual = v.CalcFuelEconomy();

            Assert.AreEqual(expected, actual);

        }
      
    }
}
