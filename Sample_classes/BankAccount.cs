using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_classes
{
    class BankAccount
    {
        private string accountid;
        
        public string AccountId
        {
            //get => accountid;
            //set => accountid = value;
            get
            {
                return "Dconfuse"+accountid+"fornotexposing";
            }
            set
            {
                if (value.Length==10)
                {
                    accountid = value;
                }
                else
                {
                    Console.WriteLine("account id must be 10 characters long");
                }
            }
        }
    }
}
