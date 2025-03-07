using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Animal1
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal speaks");
        }

    }
    class DOG1 : Animal1
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barks");
        }
    }



}
