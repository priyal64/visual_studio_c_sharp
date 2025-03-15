using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ittechgenie_practice_questions_csharp
{
    class Sorting_class
    {
        public int[] merge_sorted_arrays(int[] arr1, int[] arr2)
        {
            int n = arr1.Length;
            int m = arr2.Length;
            int[] new_arr = new int[n + m];
            int i = 0;
            int j = 0;
            int z = 0;
            while(i<n && j<m)
            {
                while(arr1[i] < arr2[j])
                {
                    new_arr[z++] = arr1[i];
                    i++;
                }
                while (arr1[j] < arr2[i])
                {
                    new_arr[z++] = arr2[j];
                    j++;
                }


            }
            if(i!=n-1)
            {
                while (i<n)
                {
                    new_arr[z++] = arr1[i];
                    i++;
                }
            }
            if(j!=m)
            {
                while(j<m)
                {
                    new_arr[z++] = arr2[j];
                    j++;
                }
            }
            return new_arr;

        }
    }
}
