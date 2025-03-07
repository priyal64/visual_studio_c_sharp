using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Mathematics
    {
        public void Average(int a,int b)
        {
            int c = a + b;
            Console.WriteLine("average of two int is:" + c / 2);
        }
        public void Average(int a,int b,int c)
        {
            int avg = (a + b + c) / 3;
            Console.WriteLine("the average of 3 numbers is : " + avg);

        }
        public void Average(double a,double b,double c)
        {
            double avg = (a + b + c) / 3;
            Console.WriteLine("the average of 3 float numbers is: " + avg);
        }
    }
}
