using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhheritance_examples_programs
{
    class Person
    {

        public int salary { get; set; }

        public string name { get; set; }

        public string schoolname { get; set; }

        public string collegename { get; set; }

        public void get_name(string name)
        {
            Console.WriteLine("Name of the person is: " + name);
        }

    }
    class Student:Person
    {
        public string first_name { get; set; }
        public string last_name { get; set; }

        public int classnumber { get;set;}

        public void get_class_number(int classnumber)
        {
            Console.WriteLine("CLASS NUMBER IS :", classnumber);  //assuming student is in school
        }
    }
}
