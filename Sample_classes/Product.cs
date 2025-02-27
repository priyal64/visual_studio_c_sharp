using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_classes
{
    class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Product()
        {
            Console.WriteLine("hello i am default constructor... ");
        }
        public Product(string name) :this()
        {
            Name = name;
            Console.WriteLine("name is from only 1 parameter constructor : " + Name);

        }
        public Product(string name,string des):this(
            name)
        {
            Name = name;
            Description = des;
            Console.WriteLine("name is: " + name);
            Console.WriteLine("description is: " + des);

        }
    }
}
