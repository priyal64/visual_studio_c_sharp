using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ittechgenie_practice_questions_csharp
{
    class Duplicate_value_hashset
    {
     public int[] remove_duplicates(int[] arr)
        {


            HashSet<int> hs = new HashSet<int>();
            for(int i=0;i<arr.Length;i++)
            {
                hs.Add(arr[i]);
            }
            int j = 0;
            int[] ans_arr = new int[hs.Count];
           foreach(var i in hs)
            {
                ans_arr[j++] = i;
            }
            return ans_arr;
        }
    }

}
