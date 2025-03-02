using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhheritance_examples_programs
{
    class Account
    {
        public virtual void CalculateInterest()
        {

        }
    }
    sealed class SavingsAccount:Account
    {
        public override void CalculateInterest()
        {
            Console.WriteLine("THIS IS OVERRIDING CALCULATEINTEREST METHOD FROM ACCOUNT CLASS");
        }
    }
}
