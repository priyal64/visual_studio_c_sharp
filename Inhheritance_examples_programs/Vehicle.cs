using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhheritance_examples_programs
{
    class Vehicle
    {
        public string Brand { get; set; }
        public int Speed {get; set; }

        public void DisplayInfo()
        {
            
        }
    }
    class Car :Vehicle
    {
        public void DisplayInfo()  
        {
            Console.WriteLine("car brand is "+Brand+" the speed of the car is: "+Speed);

        }

    }
    class Bike:Vehicle
    {
        public void DisplayInfo()
        {
            Console.WriteLine("bike brand is: " + Brand + " the speed of the bike is: " + Speed);
        }
    }

}
