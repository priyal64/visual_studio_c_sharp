namespace Exception_hNDLING_IN_CSHARP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] a = new int[10];
                int j = 0;
                for (int i = 0; i < 10; i++)
                {
                    a[i] = j++;
                }

                a[10] = j++; // IndexOutOfRangeException

                // Uncomment the following line to cause a FormatException
                // a[9] = int.Parse("String i want to give");

                //Uncomment the following line to cause a NullReferenceException
                //string nullString = null;
                //int length = nullString.Length;

                //Uncomment the following line to cause an ArithmeticException
                //int zero = 0;
                //int result = 10 / zero;

                //Uncomment the following lines to cause a StackOverflowException (be careful, this can crash your application)
                //RecursiveMethod();

                //Uncomment to cause an array type mismatch
                //object[] objArray = new object[1];
                //objArray[0] = "string";
                //int x = (int)objArray[0];

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error: Array index is out of bounds.");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Invalid format.");
                Console.WriteLine(ex.Message);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("Error: Arithmetic operation failed.");
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Error: Null reference exception.");
                Console.WriteLine(ex.Message);
            }
            catch (StackOverflowException ex)
            {
                Console.WriteLine("Error: Stack overflow exception.");
                Console.WriteLine(ex.Message);
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine("Error: Invalid Cast Exception");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Execution complete (try-catch-finally block).");
            }
        }

        //Recursive method to cause a StackOverflowException
        static void RecursiveMethod()
        {
            RecursiveMethod();
        }
    }
}