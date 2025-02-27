using System.Drawing;

namespace exams_or_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BankAccount B = new BankAccount();
            //B.Deposit(100, 10);

            //Student s = new Student();
            //s.Addstudent("", 1);

            //Book b = new Book();
            //Book b1 = new Book("ek ladki", "Premchand");

            //Rectangle s = new Rectangle();
            //s.breadth = 12;
            //s.length = 10;
            //s.CalcualteArea();

            //Vehicle v = new Car();
            //v.Start();

            //Person p = new Students();
            //((Students)p).s_name = "hello";
            //p.GetDetails();

            //Calculator c = new Calculator();
            //c.Add(5, 10);
            //c.Add(2147483647000, 21474836470000);

            //VideoPlayer v = new VideoPlayer();
            //v.Play();

            //Admin a = new Admin("hellooo");
            //a.AccessControl();
            //User c = new Customer("hey");
            //c.AccessControl();


            //ComplexNumbers c = new ComplexNumbers(1, 2);
            //ComplexNumbers c2 = new ComplexNumbers(2, 3);

            //ComplexNumbers r = c + c2;
            //Console.WriteLine(r);


            //Bank A1 = new Bank("PPPP");
            //Bank A2 = new Bank("KKK");
            //A1.DisplayAccountInfo();
            //A2.DisplayAccountInfo();
            //Bank.SetInterestRate(6.5);
            //Console.WriteLine("\nAfter updating interest rate:\n");
            //A1.DisplayAccountInfo();
            //A2.DisplayAccountInfo();


            //SecuritySystem s = new SecuritySystem();
            //s.Authenticate();


            Button myButton = new Button();
            myButton.OnClick += ButtonClicked;
            myButton.Click();

            


        }
        static void ButtonClicked()
        {
            Console.WriteLine("button clicked even handleeeeed");
        }
    }
}
