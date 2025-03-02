using System.Diagnostics;

namespace Inhheritance_examples_programs
{
     class Program
    {
        static void Main(string[] args)
        {
            //Car c = new Car();
            //c.Brand = "Honda";
            //c.Speed = 100;
            //c.DisplayInfo();

            //Car_1 c = new Car_1();
            //c.Brand = "toyota";
            //c.Speed = 110;
            //c.carcolor = "blue";
            //c.DisplayInfo();

            //Car1 c = new Car1();
            //c.Brand = "hero";
            //c.Speed = 120;
            //c.DisplayInfo();


            //Animal d = new Dog();
            //d.MakeSound();
            //d.sleep();


            //SavingsAccount a = new SavingsAccount();
            //a.CalculateInterest();

            //Duck d = new Duck();
            //d.Fly();
            //d.Swim();


            //Student s = new Student();
            //Person per = s;
            ////per.get_class_number(10); //this can't be accessed by person since it is upcast


            ////same for downcast
            //Student s1 = (Student)per;
            //s1.get_class_number(10);



            //ClothingProduct c = new ClothingProduct();
            //c.GetDiscountedPrice();

            //SecuritySystem S = new SecuritySystem();
            //S.Authenticate();

            //Manager m = new Manager(" abcdbd bab",10000, 100 );
            //m.Display();




            Robot r = new Robot();
            r.Start();
            r.Move();
        }

    }
}
