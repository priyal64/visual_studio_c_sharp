using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ittechgenie_practice_questions_csharp
{
    class Dictionary_class_count
    {
        public Dictionary<int,int> Count_key_value(int[] arr)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            for(int i=0;i<arr.Length;i++)
            {
                if (d.ContainsKey(arr[i]))
                {
                    d[arr[i]]= 1 + d[arr[i]];
                }
                else
                {
                    d.Add(arr[i], 1);
                }
            }
            return d;
        }
    }
}
