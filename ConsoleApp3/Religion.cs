using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Religion
    {
        public virtual void Worship()
        {
            Console.WriteLine("worship god");
        }
        //public new void worship_place()
        //{
        //    Console.WriteLine("");
        //};
    }
    class Hindu:Religion
    {
        public override void Worship()
        {
            Console.WriteLine("Worship RAM");
        }
    }
    class Muslim: Religion
    {
        public override void Worship()
        {
            Console.WriteLine("Worship Allah");
        }
    }
    class Christian:Religion
    {
        public override void Worship()
        {
            Console.WriteLine("worship jesus");
        }
    }
}
