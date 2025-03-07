using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Compiletime_overload
    {
      //here while writing code or in compile time only we are making many forms of the function
      public string get_name(string firstname)
        {
            return firstname + "is the fullname of the person";
        }
        public string get_name(string firstname,string lastname)
        {
            return firstname + " " + lastname + " is the full name of the person";
        }
        public string get_name(string firstname,string lastname,string initial_name)
        {
            return initial_name + " " + firstname + " " + lastname + " is the full name of the person"; 
        }
    }

}
