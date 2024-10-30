using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        //Assignment 10
        //Polymorphism in C# with Readonly Property 
        //{
        //    // Polymorphism: Base class reference holding derived class instances
        //    Animal myDog = new Dog();
        //    Animal myCat = new Cat();

        //    myDog.MakeSound();
        //    myCat.MakeSound();

        //    Console.WriteLine($"Species of myDog: {myDog.Species}");
        //    Console.WriteLine($"Species of myCat: {myCat.Species}");
        //    Console.ReadLine();
        //}

        //Assignment 9
        // Demonstrating the Need for Multiple Inheritance of Interfaces
        //{
        //    Car myCar = new Car("Toyota");

        //    // Using the IMovable interface
        //    myCar.Move(10); 
        //    myCar.Move(5);  

        //    // Using the IDrawable interface
        //    myCar.Draw();   
        //    Console.ReadLine();
        //}


        //Assignment 8
        // Achieving Runtime Polymorphism with Abstract Classes and Interfaces in C#
        //{
        //    // Using runtime polymorphism
        //    Shape circle = new Circle(5.0); // Shape reference to a Circle object
        //    Shape rectangle = new Rectangle(4.0, 6.0); // Shape reference to a Rectangle object

        //    IShape iCircle = new Circle(5.0); // IShape reference to a Circle object
        //    IShape iRectangle = new Rectangle(4.0, 6.0); // IShape reference to a Rectangle object

        //    Console.WriteLine("Circle Area: " + circle.Area());
        //    Console.WriteLine("Circle Perimeter: " + iCircle.Perimeter());

        //    Console.WriteLine("Rectangle Area: " + rectangle.Area());
        //    Console.WriteLine("Rectangle Perimeter: " + iRectangle.Perimeter());
        //    Console.ReadLine();
        //}


        //Assignment 7
        //Understanding Early Binding and Late Binding in C# 
        //{
        //    // Early Binding - Method Overloading
        //    Shape shape = new Shape();
        //    shape.Draw();               // Calls the generic Draw method
        //    shape.Draw(5);             // Calls the overloaded Draw for circle
        //    shape.Draw(4, 6);          // Calls the overloaded Draw for rectangle

        //    // Late Binding - Method Overriding
        //    Shape myCircle = new Circle();
        //    Shape myRectangle = new Rectangle();

        //    myCircle.DrawShape();      // Calls the overridden method in Circle
        //    myRectangle.DrawShape();   // Calls the overridden method in Rectangle
        //    Console.ReadLine();
        //}


        //Assignment 6
        //Polymorphism with Arrays as Properties in a Class 
        //{
        //    string[] managerTasks = { "Plan project", "Conduct team meetings" };
        //    string[] developerTasks = { "Write code", "Fix bugs", "Review code" };
        //    Employee manager = new Manager(managerTasks);
        //    Employee developer = new Developer(developerTasks);

        //    // Demonstrating polymorphism
        //    ShowEmployeeDetails(manager);
        //    ShowEmployeeDetails(developer);
        //}

        //static void ShowEmployeeDetails(Employee employee)
        //{
        //    employee.ShowDetails(); // Calls the overridden method based on the object type
        //    Console.ReadLine();
        //}


        //Assignment 5
        //Polymorphism with Static Data and Methods
        //{
        //    Employee manager1 = new Manager();
        //    Employee developer1 = new Developer();
        //    manager1.ShowDetails();   // Calls the overridden method in Manager
        //    developer1.ShowDetails(); // Calls the overridden method in Developer
        //    Employee.DisplayTotalEmployees();
        //    Console.ReadLine();
        //}


        //Assignment 4
        //Method Overriding  
        //{
        //    Payment creditCardPayment = new CreditCardPayment();
        //    Payment payPalPayment = new PayPalPayment();
        //    creditCardPayment.ProcessPayment(); // Calls the CreditCardPayment method
        //    payPalPayment.ProcessPayment();      // Calls the PayPalPayment method
        //    Console.ReadLine();
        //}

        //Assignment 3
        //Method Overriding  
        //{
        //    Vehicle myVehicle = new Vehicle();
        //    myVehicle.Drive(); // Calls the base class method
        //    Car myCar = new Car();
        //    myCar.Drive(); // Calls the overridden method
        //    Vehicle myPolymorphicCar = new Car();
        //    myPolymorphicCar.Drive(); // Calls the overridden method in Car
        //    Console.ReadLine();
        //}


        //Assignment 2
        //Method Overloading and its uses 
        //{
        //    // Calling the overloaded Multiply methods from the Calculator class
        //    Console.WriteLine($"Multiply two integers: 3 * 4 = {Calculator.Multiply(3, 4)}");
        //    Console.WriteLine($"Multiply three integers: 2 * 3 * 4 = {Calculator.Multiply(2, 3, 4)}");
        //    Console.WriteLine($"Multiply two doubles: 3.5 * 2.0 = {Calculator.Multiply(3.5, 2.0)}");
        //    Console.WriteLine($"Multiply integer and double: 5 * 2.5 = {Calculator.Multiply(5, 2.5)}");
        //    Console.WriteLine($"Multiply double and integer: 2.5 * 5 = {Calculator.Multiply(2.5, 5)}");
        //    Console.ReadLine();
        //}


        //Assignment 1
        //To demonstrate Polymorphism and its Advantages
        //{
        //    List<Shape> shapes = new List<Shape>();

        //    shapes.Add(new Circle());
        //    shapes.Add(new Rectangle());

        //    // Looping through each shape and calling the Draw method
        //    foreach (var shape in shapes)
        //    {
        //        shape.Draw(); 
        //    }
        //    Console.ReadLine();
        //}

    }
}
