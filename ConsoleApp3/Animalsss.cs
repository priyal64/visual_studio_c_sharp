using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class Animalsss
    {
        public virtual void what_i_do()
        { }
    }
    class Aquatics:Animalsss
    {
        public override void what_i_do()
        {
            Console.WriteLine("i be in water whole day and night ,i can't come out.i can swim only");
        }

    }
    class Terestrial:Animalsss
    {
        public override void what_i_do()
        {
            Console.WriteLine("i be in land whole my life, i can walk or run");
        }
    }
    class Aerial:Animalsss
    {
        public override void what_i_do()
        {
            Console.WriteLine("I be in air ,i can fly high in the sky");
        }
    }

}
