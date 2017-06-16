using System;
using System.Collections.Generic;
using System.Text;

namespace Modals
{
    public class FuelPurchase
    {
        const double BasePrice = 1.50;
        double variance;
        public int litres;
        public double Cost;
        public FuelPurchase(int litres)
        {
            this.litres = litres;
            Random rand = new Random();
            variance = (0.50 - (rand.Next(50) / 100));
            Cost = (BasePrice + variance) * litres;
        }
    }
}
