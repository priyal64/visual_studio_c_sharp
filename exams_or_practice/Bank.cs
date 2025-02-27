using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exams_or_practice
{
    class Bank
    {
        public static double InterestRate = 5.0;
        public string AccountHolder;

        // Constructor
        public Bank(string name)
        {
            AccountHolder = name;
        }
        public static void SetInterestRate(double newRate)
        {
            InterestRate = newRate;
        }
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Holder: {AccountHolder}, Interest Rate: {InterestRate}%");
        }

    }
}
