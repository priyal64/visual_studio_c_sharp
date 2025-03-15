namespace Practice_ques_for_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter 2 numbers to be divided:");
                String[] values = (Console.ReadLine().Split());
                double a, b;
                a = double.Parse(values[0]);
                b = double.Parse(values[1]);
                if(b!=0)
                {
                    double c=a / b;
                    
                    Console.WriteLine("Division answer is: " + c);
                }
                else
                {
                    Console.WriteLine("should give not null value");
                }

            }
            catch(FormatException)
            {
                Console.WriteLine("Enter only numeric value");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
