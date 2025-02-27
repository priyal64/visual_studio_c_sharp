using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_classes
{
    class Maths
    {
        public void Display()
        {
            Console.WriteLine("i am base class");
        }
    }
    class Algebra : Maths
    {
        public void Display()
        {
            Console.WriteLine("i am child class");
        }
    }
}
