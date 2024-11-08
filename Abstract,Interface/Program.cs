using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface_Partial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type calculatorType = typeof(Calculator);
            // Retrieve DeveloperAttribute on the Calculator class
            if (Attribute.GetCustomAttribute(calculatorType, typeof(DeveloperAttribute)) is DeveloperAttribute classAttribute)
            {
                Console.WriteLine($"Class '{calculatorType.Name}' was developed by {classAttribute.DeveloperName} on {classAttribute.LastModifiedDate}");
            }
            // Retrieve DeveloperAttribute on the Add method
            MethodInfo addMethod = calculatorType.GetMethod("Add");
            if (Attribute.GetCustomAttribute(addMethod, typeof(DeveloperAttribute)) is DeveloperAttribute methodAttribute)
            {
                Console.WriteLine($"Method '{addMethod.Name}' was developed by {methodAttribute.DeveloperName} on {methodAttribute.LastModifiedDate}");
            }
            Console.ReadLine();
        }


        //Assignment 11
        //Enum keyword
        //{
        //    Car2 sedan = new Car2(CarType.Sedan);
        //    Car2 suv = new Car2(CarType.SUV);
        //    Car2 truck = new Car2(CarType.Truck);
        //    Car2 coupe = new Car2(CarType.Coupe);

        //    sedan.DisplayCarTypeMessage(sedan.Type);
        //    suv.DisplayCarTypeMessage(suv.Type);
        //    truck.DisplayCarTypeMessage(truck.Type);
        //    coupe.DisplayCarTypeMessage(coupe.Type);
        //    Console.ReadLine();
        //}


        //Assignment 10
        //Exception Handling
        //{
        //    Divider.Divide(10, 2); // Valid division
        //    Divider.Divide(10, 0); // Division by zero, will trigger exception
        //    Console.ReadLine();
        //}


        //Assignment 9
        //Indexer
        //{
        //    Library library = new Library();
        //    library[0] = new Book("2 States", "Chetan Bhagat");
        //    library[1] = new Book("Harry Potter", "J.K Rowling");
        //    library[2] = new Book("The Cost of Living", "Arundati Roy");
        //    library.DisplayAllBooks();
        //    Console.ReadLine();
        //}


        //Assignment 8
        //Partial Method
        //{
        //    Employee employee = new Employee
        //    {
        //        BaseSalary = 50000m
        //    };
        //    employee.ShowSalary();
        //    Console.ReadLine();
        //}


        //Assignment 7
        //Partial Class
        //{
        //    Person person = new Person();
        //    person.Name = "Ram";
        //    person.ShowDetails();
        //    Console.ReadLine();
        //}


        //Assignment 6
        //Extension Methods
        //{
        //    int number1 = 4;
        //    int number2 = 7;
        //    Console.WriteLine($"{number1} is even: {number1.IsEven()}");
        //    Console.WriteLine($"{number2} is even: {number2.IsEven()}");
        //    Console.ReadLine();
        //}


        //Assignment 5
        //Static Class
        //{
        //    // Calling Add and Multiply methods directly without creating an instance
        //    int sum = MathOperations.Add(5, 3);
        //    int product = MathOperations.Multiply(4, 6);

        //    Console.WriteLine("Sum: " + sum);       
        //    Console.WriteLine("Product: " + product);
        //    Console.ReadLine();
        //}


        //Assignment 4
        //Interface vs.Abstract Class
        //{
        //    Bird myDuck = new Duck();
        //    Bird myPenguin = new Penguin();

        //    myDuck.Fly();
        //    myPenguin.Fly();

        //    // Casting to ISwim interface to call Swim method
        //    ISwim swimmingDuck = (ISwim)myDuck;
        //    ISwim swimmingPenguin = (ISwim)myPenguin;


        //    swimmingDuck.Swim();
        //    swimmingPenguin.Swim();
        //    Console.ReadLine();
        //}


        //Assignment 3
        //Interface
        //{
        //    IDrive myCar = new Car1();
        //    IDrive myTruck = new Truck();

        //    myCar.Drive();  
        //    myTruck.Drive();
        //    Console.ReadLine();
        //}

        // Assignment 2
        // Virtual Functions
        //{
        //    Animal myAnimal = new Animal();
        //    Animal myDog = new Dog();
        //    Animal myCat = new Cat();

        //    myAnimal.MakeSound(); 
        //    myDog.MakeSound();   
        //    myCat.MakeSound();   
        //}


        //Assignment 1
        //Abstract Class
        //{
        //    Vehicle myCar = new Car();
        //    Vehicle myMotorcycle = new Motorcycle();

        //    myCar.StartEngine();
        //    myCar.StopEngine();

        //    myMotorcycle.StartEngine();
        //    myMotorcycle.StopEngine();
        //    Console.ReadLine();
        //}
    }
}
