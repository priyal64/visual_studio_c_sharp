using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhheritance_examples_programs
{
    class Base_Vehicle
    {
        public int Speed { get; set; }
        public string Brand { get; set; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("brand name is:" + Brand + " speed is: " + Speed);
        }
    }
    class Car1:Base_Vehicle
    {
        public override void DisplayInfo()
        {
            base.DisplayInfo();
        }
    }

    class Bike1:Base_Vehicle
    {
        public override void DisplayInfo()
        {
            base.DisplayInfo();
        }
    }
}
