using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exams_or_practice
{
    sealed class SecuritySystem
    {
        public void Authenticate()
        {
            Console.WriteLine("Authentication successful!");
        }
    }
    // This will cause a compilation error
    // class AdvancedSecurity : SecuritySystem {
    // } 
}
