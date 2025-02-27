using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exams_or_practice
{
    class Student
    {
        int RollNo ;
        string Name ;
        
        public void Addstudent(string Name,int RollNo)
        {
            if(Name=="")
            {
                Console.WriteLine("please enter name,it should not be empty");
            }
            else if(RollNo<0)
            {
                Console.WriteLine("please enter positive number...");
            }
            else
            {
                Console.WriteLine("Student name is added");
            }
        }



    }
}
