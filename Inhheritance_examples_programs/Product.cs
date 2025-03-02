using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhheritance_examples_programs
{
    class Product
    {
        public string Name{ get; set; }
        public int Price { get; set; }

        public virtual void GetDiscountedPrice()
        {

        }

    }
    class ElectronicProduct:Product
    {
        public override void GetDiscountedPrice()
        {
            Console.WriteLine("i am electronic product: i have discount rules as follows");
        }


    }
    class ClothingProduct:Product
    {
        public override void GetDiscountedPrice()
        {
            Console.WriteLine("i am clothing product : i have discount as follows");
        }
    }

}
