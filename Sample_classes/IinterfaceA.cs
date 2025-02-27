using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_classes
{
    interface IinterfaceA
    {
        void first_method();
    }
    interface InterfaceB
    {
        void second_method();
    }
    class baby:IinterfaceA,InterfaceB
    {
        public void first_method()
        {
            Console.WriteLine(" hello i implemented interface");

        }
        public void second_method()
        {
            Console.WriteLine("hello i am from second interface");
        }
    }
}
