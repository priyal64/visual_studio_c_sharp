namespace CUSTOM_EXCEPTION_CSHARP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            try
            {
                var res = Anyfunc(0);

            }
            catch(Customed_exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static int Anyfunc(int n)
        {
            if(n==0)
            {
                throw new Customed_exception();
            }
            return n * 2;
        }
    }
}
