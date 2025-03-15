using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ittechgenie_practice_questions_csharp
{
    class Reverse_a_string
    {
        //this  code is only for words not for sentence....
        public string Reverse_String(string s)
        {
            string ans = "";
            int len = s.Length;

            for(int i=len-1;i>=0;i--)
            {
                ans += s[i];
            }
            return ans;
        }

        public int Is_Palindrome(string s)
        {
            string q =Reverse_String(s);
            if(q==s)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

    }
}
