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


            Report myReport = new Report();
            // Call the methods from the implemented interfaces
            myReport.Print();
            myReport.SaveToFile();
            // Demonstrate using interface references
            IPrintable printableReport = myReport;
            ISerializable serializableReport = myReport;
            printableReport.Print();
            serializableReport.SaveToFile();

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


            //Button myButton = new Button();
            //myButton.OnClick += ButtonClicked;
            //myButton.Click();

            //IVehicle myVehicle = VehicleFactory.GetVehicle("car");
            //myVehicle.Drive();

            //12
            //prints kkkk ,kkkk,ppp


            //Department originalDept = new Department
            //{
            //    Manager = new Manager { Name = "I AM piyal" }
            //};
            // Shallow Copy
            //Department shallowCopyDept = originalDept.ShallowCopy();
            //// Deep Copy
            //Department deepCopyDept = originalDept.DeepCopy();

            //// Demonstrate Shallow Copy:
            //Console.WriteLine("--- Shallow Copy ---");
            //Console.WriteLine($"Original Manager Name: {originalDept.Manager.Name}");
            //Console.WriteLine($"Shallow Copy Manager Name: {shallowCopyDept.Manager.Name}");
            //// Change the manager's name in the original object
            //originalDept.Manager.Name = "Priyal ";
            //Console.WriteLine("--- After Changing Original ---");
            //Console.WriteLine($"Original Manager Name: {originalDept.Manager.Name}");
            //Console.WriteLine($"Shallow Copy Manager Name: {shallowCopyDept.Manager.Name}"); // Shallow copy's manager also changes!
            //// Demonstrate Deep Copy:
            //Console.WriteLine("\n--- Deep Copy ---");
            //Console.WriteLine($"Original Manager Name: {originalDept.Manager.Name}");
            //Console.WriteLine($"Deep Copy Manager Name: {deepCopyDept.Manager.Name}");
            //// Change the manager's name in the original object
            //originalDept.Manager.Name = "New Manager";
            //Console.WriteLine("--- After Changing Original again ---");
            //Console.WriteLine($"Original Manager Name: {originalDept.Manager.Name}");
            //Console.WriteLine($"Deep Copy Manager Name: {deepCopyDept.Manager.Name}"); // Deep copy's manager is unchanged!

            //ILogger fileLogger = new FileLogger();
            //ILogger timestampLogger = new TimestampLogger(fileLogger);
            //ILogger errorLogger = new ErrorCategoryLogger(timestampLogger);
            //errorLogger.Log("This is an error message.");

            //18 
            //ConfigurationManager config = ConfigurationManager.Instance;
            //Console.WriteLine(config.GetSetting("database"));

            //19 
            //NotificationService service = new NotificationService();
            //service.AddObserver(new EmailNotifier());
            //service.AddObserver(new SMSNotifier());
            //service.NotifyObservers("New notification arrived!");

            ////20 
            //ShoppingCart cart = new ShoppingCart();
            //cart.SetDiscountStrategy(new PercentageDiscount(10));
            //Console.WriteLine($"Total with 10% discount: {cart.CalculateTotal(100)}");

            //cart.SetDiscountStrategy(new FixedAmountDiscount(20));
            //Console.WriteLine($"Total with 20 fixed discount: {cart.CalculateTotal(100)}");

            //cart.SetDiscountStrategy(new NoDiscount());
            //Console.WriteLine($"Total with no discount: {cart.CalculateTotal(100)}");

        }
        static void ButtonClicked()
        {
            Console.WriteLine("button clicked even handleeeeed");
        }
    }
}
