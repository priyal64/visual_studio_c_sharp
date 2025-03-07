using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Animal
    {
        //overloading

        public virtual void MakeSound()
        {

        }

        
    }
    class Dog:Animal
    {
        //override
        public override void MakeSound()
        {
            Console.WriteLine("dog barks as vow vow");
        }
    }
    class Cat:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("meow meow");  
        }
    }
}
