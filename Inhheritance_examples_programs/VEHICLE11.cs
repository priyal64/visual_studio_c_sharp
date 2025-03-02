using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhheritance_examples_programs
{
    class VEHICLE11
    {
        public int Speed { get; set; }
        public string Brand{ get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine("brand name is: " + Brand + " speed is: " + Speed);
        }
    }
    class Car_1:VEHICLE11
    {
        public string carcolor { get; set; }

        
    }
    class Bike_1:VEHICLE11
    {
        public string bikecolor { get; set; }

    }
}
