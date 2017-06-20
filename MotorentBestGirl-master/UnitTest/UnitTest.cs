using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modals;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod()]
        public void TestCostOutput()
        {
            for (int i = 0; i < 1000; i++)
            {
                var Purchase = new FuelPurchase(i);

                // assert  
                double actualCost = Purchase.Cost;
                double expectedCost = 2.00 * i;
                double allowedVariance = 0.25 * i;
                Assert.AreEqual(expectedCost, actualCost, allowedVariance);
            }
        }

        [TestMethod()]
        public void TestFuelEfficiency()
        {
            var v = new Vehicle()
            {
                TotalFuelPurchased = 1
            };

            for (int i = 2; i < 1024; i *= i)
            {
                v.KilometersTraveled = i;
                v.CalcFuelEconomy();

                Assert.AreEqual($"{i}km/L", v.FuelEconomy);
            }
        }

        [TestMethod()]
        public void TestKilometerTotal()
        {
            int total = 0;
            var motor = new Vehicle();
            for (int i = 1; i < 11; i++)
            {
                var journey = new Journey((i * 10));
                total += journey.KilometersTraveled;
                motor.AddJourney(journey);

                Assert.AreEqual(motor.KilometersTraveledSinceService, motor.KilometersTraveled);
                Assert.AreEqual(total, motor.KilometersTraveled);
            }
            Assert.AreEqual(motor.KilometersTraveledSinceService, motor.KilometersTraveled);
            Assert.AreEqual(550, motor.KilometersTraveled);
        }

        [TestMethod()]
        public void TestAppleProduct()
        {
            var motor = new Vehicle();
            motor.AddJourney(new Journey(101));
            Service.CheckServiceNeeded(motor);
            Assert.AreEqual(false, motor.NeedService);
        }
    }
}
