using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_classes
{
    interface IAccount
    {
        //public int Cr { get; set; }
        //public int Dr { get; set; }
        //public string Particulars { get; set; }
        //public DateTime TransactionDate { get; set; }

        public void AddAccount(IAccount account)
        {
            throw new NotImplementedException();
        }
        public void DeleteAccount(IAccount account)
        {
            throw new NotImplementedException();
        }


    }
    class Child_class : IAccount
    {
        public void AddAccount()
        {
            Console.WriteLine(" account is created");
        }
        public void DeleAccount()
        {
            Console.WriteLine("account is deleted");
        }

    }
}

