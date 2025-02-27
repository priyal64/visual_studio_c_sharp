using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("enter a value of a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter a value of b: ");
            b = Convert.ToInt32(Console.ReadLine());

            int c;
            c = a + b;
            Console.WriteLine("sum of a and b is: " + c);

        }
    }
}

