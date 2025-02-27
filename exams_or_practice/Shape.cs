using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exams_or_practice
{
     public abstract class Shape
    {
        public virtual void CalcualteArea()
        {

        }
       
    }
    public class Rectangle : Shape
    {
        public int length { get; set; }
        public int breadth { get; set; }
        public override void CalcualteArea()
        {
            int x = length * breadth;
            Console.WriteLine("AREA OF rectangle is:" + x);
        }
    }
    public class Circle: Shape
    {
        public int radius;
        public override void CalcualteArea()
        {
            //int ans = ();
            Console.WriteLine("the area of circle is: " + 3.14 * radius * radius);
        }
    }
}
