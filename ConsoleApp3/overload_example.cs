using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class overload_example
    {
        public void Add(int a,int b)
        {
            Console.WriteLine("SUM OF INT IS :" + (a + b));
        }
        public void Add(double a,double b,double c)
        {
            Console.WriteLine("sum of double 3 numbers is :" + (a + b + c));
        }
    }
}
