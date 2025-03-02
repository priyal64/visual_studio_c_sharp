using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exams_or_practice
{
    class Student_while_input
    {
        private string name;
        private int rollNo;

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
            }
        }

        public int RollNo
        {
            get { return rollNo; }
            set
            {
                if (value >= 0)
                {
                    rollNo = value;
                }
            }
        }
    }
}
