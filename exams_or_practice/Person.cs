using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exams_or_practice
{
    class Person
    {
        public void GetDetails()
        {
            Console.WriteLine("hello");
        }
    }
     class Students: Person
    {
        public string s_name;
        public void GetDetails()
        {
            Console.WriteLine("Student name is: " + s_name);
        }
    }
    class Teacher : Person
    {
        public string? t_name { get; set; }

        public void GetDetails()
        {
            Console.WriteLine("teacher name is: " + t_name);
        }
    }
}
