using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiment_3
{
    class Vehicle
    {
        
        // decutaion of veribals
        private string manufacturer;
        private string modle;
        private long make_Year;
        private string registration_NO;
        private double totalKilometers_Travelled = 0;
        private int totalSevices = 0;
        private double fuel_Economy;
        private double distance_sevice;
        private bool seviced;
       

        public Vehicle ()
        {
           


        }
        public string GetManufacturer 
        {
            get { return (manufacturer); }
            set { manufacturer = value; }
        }
        public string GetModle
        {
            get { return (modle); }
            set { modle = value; }
        
        }
        public long GetMakeYear
        {
            get { return (make_Year); }
            set { make_Year = value; }
        }

        public string GetRegistration_NO
        {

            get { return (registration_NO); }
            set { registration_NO = value; }
        }
        public double Get_TotalKilometers_Travelled
        {
            get { return (totalKilometers_Travelled);  }
            set { totalKilometers_Travelled = value; }

        }
        public int GetTotalSevices
        {
          get { return (totalSevices); }
          set { totalSevices = value; }
        }
         public double GetFuel_Economy
        {
            get { return (fuel_Economy); }
            set { fuel_Economy = value; }
        }
        public double GetDistance_sevice
        {
            get { return (distance_sevice); }
            set { distance_sevice = value; }
        }
        public bool GetServiced
        {
            get { return (seviced); }
            set { seviced = value; }

        }



        public long make;
        public int sevice;
        public double kilo ;

        public void AddJourney(Journey J1)
        {
            
            Get_TotalKilometers_Travelled += J1.getKmsTravelled;
         

            if (Get_TotalKilometers_Travelled - GetDistance_sevice > 99)
            {
                GetServiced = true;
                GetDistance_sevice = Get_TotalKilometers_Travelled;
                
            }
            else
            {
                GetServiced = false;

            }
        }

    }
}
