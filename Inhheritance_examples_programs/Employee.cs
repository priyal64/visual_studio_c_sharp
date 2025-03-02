using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Inhheritance_examples_programs
{
    class Employee
    {
        public int Salary { get; set; }

        public string Name { get; set; }

        
        public Employee(string name, int salary) 
        {
            Salary = salary;
            Name = name;
            Console.WriteLine("Name is: " + Name + " salary is: " + Salary);
        }

    }
    class Manager : Employee
    {
        public int Bonus { get; set; }

        public Manager(string name,int salary, int bonus) : base(name, salary)
        {

            Bonus = bonus;
        }
        public void Display()
        {
            Console.WriteLine(" bonus is: " + Bonus);
        }
    }
}
