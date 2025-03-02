using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhheritance_examples_programs
{
    class Machine
    {
        public virtual void Start()
        {

        }
    }
    class Robot : Machine, IMovable
    {
        public override void Start()
        {
            Console.WriteLine("i can implement");

        }
        public void Move()
        {
            Console.WriteLine("YEAHHHH I AM WORKING");
        }

    }
}
