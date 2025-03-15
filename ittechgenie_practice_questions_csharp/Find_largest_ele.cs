using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ittechgenie_practice_questions_csharp
{
    class Find_largest_ele
    {
        public int find_max(int[] arr)
        {
            int ans = int.MinValue;
            for (int i=0;i<arr.Length;i++)
            {
                if (arr[i]>ans)
                {
                    ans = arr[i];
                }
            }
            return ans;
        }

        public double find_sum(int[] arr)
        {
            double ans = 0;
            for(int i=0;i<arr.Length;i++)
            {
                ans += arr[i];
            }
            return ans;
        }
    }
}
