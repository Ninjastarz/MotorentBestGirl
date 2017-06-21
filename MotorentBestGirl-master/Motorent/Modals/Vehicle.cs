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
        public double TotalRevenue;
        public bool NeedService;
        public int ServiceCount;
        public int KilometersTraveledSinceService;

        public Vehicle( int pfuel, float pkms_travel)
        {
            TotalFuelPurchased = pfuel;
            KilometersTraveled = pkms_travel;

        }
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
            KilometersTraveledSinceService += j.KilometersTraveled;
        }

        //adds the litres purchased and the cost of a fuelpurchase to a vehicle
        public void AddFuelPurchase(FuelPurchase fp)
        {
            TotalCost += fp.Cost;
            TotalFuelPurchased += fp.litres;
        }

        //calculates the fuel economy;
        public double CalcFuelEconomy()
        {
            if (TotalFuelPurchased == 0)
            {
                FuelEconomy = "No Fuel Bought";
                return 0;
            }
            else
            {
                double kperl = (KilometersTraveled / TotalFuelPurchased);
                FuelEconomy = $"{kperl}km/L";
                return kperl;
            }
        }

        //returns a string containing required information about the vehicle
        public string PrintToScreen()
        {
            return
                $"Manufacturer: {this.Manufacturer},\n" +
                $"Model: {this.Model},\n" +
                $"Make Year: {this.Year},\n" +
                $"Registration No: {this.RegistrationNo},\n" +
                $"Total Kilometers Travelled: {this.KilometersTraveled},\n" +
                $"Total Services: {this.TotalServices},\n" +
                $"Revenue Recorded: {this.TotalRevenue},\n" +
                $"Kilometers since last service: {this.KilometersTraveledSinceService},\n" +
                $"Fuel Economy: {this.FuelEconomy},\n" +
                $"Requires Service: {this.NeedService}.";
        }
    }
}
