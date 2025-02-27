using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exams_or_practice
{
    class Vehicle
    {
        public virtual void Start()
        {
            Console.WriteLine("i am from vehicle class");
        }

    }
    class Bike: Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("i am going to start bike");
        }

    }
    class Car: Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("i am going to start car");
        }
    }
}
