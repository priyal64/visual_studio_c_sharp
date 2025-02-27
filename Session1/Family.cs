using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1
{
    public class Family
    {
    }
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Man : Person
    {
        public string FreeTravelBy { get; set; }
    }
    public class Woman:Person
    {
        public string FreeTravelByBus { get; set; }
    }
}
