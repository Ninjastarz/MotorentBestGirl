using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modals
{
    public class PerKmRental
    {
        int CostPerKm = 1;
        public double TotalCost;
        public int KilometersTravelled;
        public int LitresUsed;

        public PerKmRental(int kilometersTravelled, int litresUsed)
        {
            TotalCost = CostPerKm * kilometersTravelled;
            KilometersTravelled = kilometersTravelled;
            LitresUsed = litresUsed;
        }
    }
}
