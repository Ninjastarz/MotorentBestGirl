using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modals
{
    public class PerDayRental
    {
        int DailyCost = 100;
        public double TotalCost;
        public int KilometersTravelled;
        public int LitresUsed;
        public PerDayRental(int kilometersTravelled, int daysRented, int litresUsed)
        {
            TotalCost = DailyCost * daysRented;
            KilometersTravelled = kilometersTravelled;
            LitresUsed = litresUsed;
        }
    }
}
