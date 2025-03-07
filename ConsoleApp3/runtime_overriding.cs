using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class runtime_overriding
    {
        public virtual void features()
        {
            Console.WriteLine("i have very few features");
        }
    }
    class child_of_runtime_over:runtime_overriding
    {
        public override void features()
        {
            Console.WriteLine("I have more features than parent");
        }
    }
}
