using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhheritance_examples_programs
{
    class Duck: IFlyable,ISwimmable
    {
        public void Fly()
        {
            Console.WriteLine("i can fly");
        }
        public void Swim()
        {
            Console.WriteLine("i can swim");
        }
    }
}
