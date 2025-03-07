using ConsoleApp3;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Contracts;
using System.Runtime.Intrinsics.X86;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Animal a = new Animal();
            Dog d = new Dog();
            d.MakeSound();
            a.MakeSound();
            Cat c = new Cat();
            c.MakeSound();

            //1
            //overloading_Example
            overload_example o = new overload_example();
            o.Add(1, 2);
            o.Add(1, 2, 3);


            //2
            //compile time polymorphism
            //here in compile time only we are changing forms
            Compiletime_overload per = new Compiletime_overload();
            per.get_name("priyal");
            per.get_name("priiyyal", "nagda");

            runtime_overriding human = new runtime_overriding();
            human.features();
            child_of_runtime_over human2 = new child_of_runtime_over();
            human2.features();

            //3
            //here mathematics class can have many types of average it can be float,int,double
            //depending on the input values it changes
            Mathematics formula = new Mathematics();
            formula.Average(1, 10);
            formula.Average(1, 2, 3);
            formula.Average(4.0, 3.5, 3.0);




            //4
            //Method overriding
            //here all religions worship god
            //but different gods so that is how it is overriding the religion class (worship method)
            Hindu hind_person = new Hindu();
            hind_person.Worship();
            Muslim mus_person = new Muslim();
            mus_person.Worship();
            DOG1 DD = new DOG1();
            DD.Speak();
            //it overrides the speak function 


            //10
            Stud s;
            s.name = "hello";
            //yes we can use struct in csharp
            //can we achive polymorphism?
            //Inheritance is crucial for polymorphism:
            //To achieve polymorphism, a class needs to
            //be able to inherit from another class,
            //allowing objects of different types to be
            //treated as objects of a common base class. 



        }
}
}

////5

//Interface: 
//Allows a class to implement multiple interfaces, enabling "multiple inheritance-like" behavior. 
//Ideal for situations where you need to ensure
//different classes adhere to the same set of functionalities regardless of their relationship. 

//Abstract Class:
//Can provide some concrete method implementations alongside abstract methods.
//Can only be extended by one class. 

//When to use an interface vs. an abstract class:

//Use an interface:
//When we need to define a common behavior across completely unrelated classes.
//When we want to achieve multiple inheritance-like behavior.
//When we need to enforce a strict contract without providing any concrete implementation details.

//Use an abstract class:
//When we have a set of closely related classes that share a significant amount of common functionality.
//When we want to provide some default implementation for methods that subclasses can override if needed.
//When we need to manage shared state among related classes. 