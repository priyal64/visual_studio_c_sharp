using exams_or_practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exams_or_practice
{
    ////notes

    //ShallowC() copies the Department object but keeps the same reference for Manager.
    //DeepC() creates a completely new Department and Manager, making them independent copies.
    //Deep copy is useful when you want to avoid unintended modifications to shared objects.


    public class Manager
    {
        public string Name { get; set; }
    }
    public class Department
    {
        public Manager Manager { get; set; }

        public Department ShallowCopy()
        {
            return (Department)MemberwiseClone();
        }

        public Department DeepCopy()
        {
            Department deepCopy = (Department)MemberwiseClone();
            deepCopy.Manager = new Manager { Name = Manager.Name };
            return deepCopy;
        }
    }
}