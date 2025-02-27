using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exams_or_practice
{
    class Calculator
    {

        public void Add(int a,int b)
        {
            Console.WriteLine("the sum of two numbers in integer is: " + (a + b));
        }
        public void Add(int a,int b,int c)
        {
            Console.WriteLine("the sum of three numbers in integer is: " + (a + b + c));
        }

        public void Add(double a,double b)
        {
            Console.WriteLine("the sum of two double numbers is:" + (a + b));

        }

    }
}
