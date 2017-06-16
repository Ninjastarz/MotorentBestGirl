using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modals
{
    public static class Service
    {
        public static void CheckServiceNeeded(Vehicle v)
        {
            if (v.KilometersTraveledSinceService >= 100)
            {
                v.NeedService = true;
            }
            else
            {
                v.NeedService = false;
            }
        }

        //services the vehicle
        public static void ServiceVehicle(Vehicle v)
        {
            v.ServiceCount = Convert.ToInt32(Math.Floor(v.KilometersTraveled % 100));
            v.TotalServices++;
            v.KilometersTraveledSinceService = 0;
            v.NeedService = false;
        }
    }
}
