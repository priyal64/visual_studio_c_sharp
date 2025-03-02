using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhheritance_examples_programs
{
    abstract class Animal
    {
        //public abstract void MakeSound();
        public virtual void MakeSound()
        {

        }
        public void sleep()
        {
            Console.WriteLine("this class always sleep");
        }
            
    }
    class Dog:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("vow vow");
        }

    }
    class Cat: Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("meow meow");
        }
    }
}
