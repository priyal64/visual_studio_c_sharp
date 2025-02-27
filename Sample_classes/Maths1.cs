using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_classes
{
    class Maths1
    {
        public virtual void Display()
        {
            Console.WriteLine("I am base class");
        }

    }
    class Algerba1: Maths1
    {
        public override void Display()
        {
            Console.WriteLine("i am child class");
        }
    }
}
