namespace Practice_m2_csharp
{
    internal class Program
    {
        static int find_min(int[] num,int n)
        {
            int ans = Int32.MaxValue;
            for(int i=0;i<n;i++)
            {
                if (ans > num[i])
                {
                    ans = num[i];
                }
            }
            return ans;
        }
        static void Main(string[] args)
        {
            //string str = "wwwowww";
            //if(Palindrome(str))
            //{
            //    Console.WriteLine("yes it is palindrome");
            //}
            //else
            //{
            //    Console.WriteLine("No it is not palindrome");
            //}
            Console.WriteLine("Enter length value");
            int n = int.Parse(Console.ReadLine());
            int[] num = new int[n];
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("enter value for index " + i);
                num[i] = int.Parse(Console.ReadLine());
            }
            int ans = find_min(num,n);
            Console.WriteLine(" the minimum number is " + ans);
        }

        static string Reverse(string str)
        {
            char[] charray = str.ToCharArray();
            int len = charray.Length;
            string rev = "";
            for (int i=0;i<len;i++)
            {
                rev += charray[len - i - 1];
            }
            return rev;
        }
        static bool Palindrome(string str)
        {
            string rev = Reverse(str);
            return str.Equals(rev);
        }
    }
}
