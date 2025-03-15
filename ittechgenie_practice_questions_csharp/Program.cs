namespace ittechgenie_practice_questions_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 and 5
            //string s = Console.ReadLine("enter a word");
            //Reverse_a_string r = new Reverse_a_string();
            //string rev = r.Reverse_String(s);
            //Console.WriteLine("reverse string answer is: " + rev);
            //r.Is_Palindrome(s);

            //2,6
            //Console.WriteLine("Enter length of the array:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[n];
            //Console.WriteLine("enter numbers...");
            //for(int i=0;i<n;i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Find_largest_ele ele = new Find_largest_ele();
            //int ans=ele.find_max(arr);
            //Console.WriteLine("max number in this array is: " + ans);


            //Console.WriteLine("sum of array elements =...");
            //double s=ele.find_sum(arr);
            //Console.WriteLine(s);



            //given an array asking us to remove duplicates
            //so  i am using hashet code to remove the duplicates and returning it in the array form again

            //Console.WriteLine("Enter length of the array:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[n];
            //Console.WriteLine("enter numbers...");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //using hashset

            //Duplicate_value_hashset d = new Duplicate_value_hashset();

            //int[] ans_array = d.remove_duplicates(arr);
            //Console.WriteLine("Duplicates are removed....now the array looks like....");
            //for(int i=0;i<ans_array.Length;i++)
            //{
            //    Console.WriteLine(ans_array[i]);
            //}

            //count
            //using dictionary 
            // Dictionary_class_count d = new Dictionary_class_count();
            //Dictionary<int,int> dic= new Dictionary<int, int>();
            // dic=d.Count_key_value(arr);
            // foreach(var elem in dic)
            // {
            //     Console.WriteLine($"Key: {elem.Key}, Count: {elem.Value}");
            // }


            //given 2 sorted arrays
            //asking us to merge therefore using 2 pointers for that....

            Console.WriteLine("Enter length of array1");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter length of array2");
            int m = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2 = new int[m];

            Console.WriteLine("enter elements for array1 ");
            for(int i=0;i<n;i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("enter elements for array2");
            for (int i = 0; i < m; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr1);
            Array.Sort(arr2);
            Sorting_class sorts = new Sorting_class();
            int[] merge_array=sorts.merge_sorted_arrays(arr1, arr2);
            Console.WriteLine("mERGED ARRAY IS:");



        }
    }
}
