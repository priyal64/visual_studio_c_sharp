using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exams_or_practice
{
    class User
    {
     public string UserName { get; set; }
     public string Role { get; set; }

    public User(string userName, string role)
        {
            UserName = userName;
            Role = role;
        }
        public virtual void AccessControl()
        {
            //Console.

        }
    }
     class Admin:User
    {
        public Admin(string UserName):base(UserName,"Admin" )
        { }
        public override void AccessControl()
        {
            Console.WriteLine(UserName+" is accessed");

        }


    
    }
    class Customer:User
    {
        public Customer(string UserName):base(UserName, "Customer")
        {

        }
        public override void AccessControl()
        {
            Console.WriteLine("i can't access" +UserName );
        }
    }

}
