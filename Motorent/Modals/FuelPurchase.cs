using System;
using System.Collections.Generic;
using System.Text;

namespace Modals
{
    public class FuelPurchase
    {
        public int PurchasedAmount;
        public double FuelCost;
        public FuelPurchase(int purchasedAmount, double fuelCost)
        {
            PurchasedAmount = purchasedAmount;
            FuelCost = fuelCost;
        }
    }
}
