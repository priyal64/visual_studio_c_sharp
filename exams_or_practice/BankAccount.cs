using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exams_or_practice
{
    class BankAccount
    {
        private int balance;
        public void Deposit(int balance,int amount)
        {
            balance = balance + amount;
            Console.WriteLine("Amount is deposited");
            Console.WriteLine("your new balance is : " + balance);
        }

        public void Withdraw(int balance,int amount)
        {
            if(amount>balance || amount<0)
            {
                Console.WriteLine("please enter valid amount");
            }
            else
            {
                balance = balance - amount;
                Console.WriteLine("amount deducted...");
                Console.WriteLine("your new balance is : "+balance);
            }
        }
    }
}
