using System;

namespace Modals
{
    public class Vehicle
    {
        public string Manufacturer;
        public string Model;
        public int Year;
        public string RegistrationNo;
        public float KilometersTraveled;
        public string FuelEconomy;
        public double TotalCost;
        public int TotalFuelPurchased;
        public int TotalServices;
        public Vehicle() { }
        public Vehicle(string manufacturer, string model, int year, string registrationNo)
        {
            Manufacturer = manufacturer;
            Model = model;
            Year = year;
            RegistrationNo = registrationNo;
            KilometersTraveled = 0;
            TotalCost = 0;
            TotalFuelPurchased = 0;
        }
        public void AddJourney(Journey j)
        {
            KilometersTraveled += j.KilometersTraveled;
            TotalServices = ServicesDone(KilometersTraveled);
        }

        public int ServicesDone(float totalKilometers)
        {
            int services = Convert.ToInt32(KilometersTraveled) / 100;
            return services;
        }
        public void AddFuelPurchase(FuelPurchase fp)
        {
            TotalCost += fp.FuelCost;
            TotalFuelPurchased += fp.PurchasedAmount;
        }
        public void CalcFuelEconomy()
        {          
                int kpl = (Convert.ToInt32(KilometersTraveled) / TotalFuelPurchased) * 100;
                FuelEconomy = $"{kpl}L/100km";
        }
        public void PrintToScreen()
        {
            int i = Convert.ToInt32(KilometersTraveled) / 100;
        }
    }
}
