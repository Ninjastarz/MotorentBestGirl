using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiment_3
{
    class Journey
    {
        // private variables used in jur
       private double Kilometers_Traveled = 0;
       
      
// public constructor
       public Journey(double pKmsTravelled)
        {
            Kilometers_Traveled = pKmsTravelled;
        }

    // public get set
        public double getKmsTravelled
        { get {return (Kilometers_Traveled);}
          set {Kilometers_Traveled = value;}
        }

    }
}
