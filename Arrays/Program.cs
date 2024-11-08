using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net; 
using log4net.Config;
using static Logger;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args) 
        
        //Assignment 15
        //Exception and Run time exception
        //        {
        //            FileProcessor fileProcessor = new FileProcessor();
        //        fileProcessor.ReadFileContent("nonexistentfile.txt"); // Attempt to read a non-existent file

        //            // Test MathOperations
        //            MathOperations mathOperations = new MathOperations();
        //        mathOperations.Divide(10, 0); // Attempt to divide by zero

        //            // Test Person
        //            Person person = new Person();
        //            try
        //            {
        //                person.SetAge(-5); // Attempt to set an invalid age
        //            }
        //            catch (InvalidAgeException ex)
        //            {
        //                Console.WriteLine(ex.Message); // Handle invalid age exception
        //            }
        //Console.ReadLine();
        //        }



        //Assignment 14
        //Need for user-defined exceptions
        //{
        //    NumberValidator validator = new NumberValidator();

        //    Console.Write("Enter a positive number: ");
        //    try
        //    {
        //        int number = int.Parse(Console.ReadLine());
        //        validator.ValidatePositiveNumber(number); // Validate the number
        //    }
        //    catch (NegativeNumberException ex) // Catch the custom exception
        //    {
        //        Console.WriteLine($"Error: {ex.Message}");
        //    }
        //    catch (FormatException) // Handle non-integer input
        //    {
        //        Console.WriteLine("Please enter a valid integer.");
        //    }
        //    Console.ReadLine();
        //}



    //    Assignment 13
    //    Logging Exceptions
    //    {
    //        LoggingExample.Divide(10, 0);
    //        LoggingExample.Divide(10, 2);
    //        Console.ReadLine();
    //    }
    //public class LoggingExample
    //{
    //    public static void Divide(int a, int b)
    //    {
    //        try
    //        {
    //            int result = a / b;
    //            Console.WriteLine("Result: " + result);
    //        }
    //        catch (DivideByZeroException ex)
    //        {
    //            Logger.LogError("Attempted to divide by zero", ex);
    //            Console.WriteLine("DivideByZeroException caught and logged");
    //        }
    //    }
    //}


    //Assignment 12
    //Custom Exception
    //    {
    //    NumberChecker checker = new NumberChecker();

    //    Console.Write("Enter a positive number: ");
    //    try
    //    {
    //        int number = int.Parse(Console.ReadLine());
    //        checker.CheckNumber(number); // Validate the number
    //    }
    //    catch (NegativeNumberException ex) // Catch the custom exception
    //    {
    //        Console.WriteLine($"Error: {ex.Message}");
    //    }
    //    catch (FormatException) // Handle non-integer input
    //    {
    //        Console.WriteLine("Please enter a valid integer.");
    //    }
    //    Console.ReadLine();
    //}

    //Assignment 11
    //throw and throws
    //{
    //    AgeValidator validator = new AgeValidator();

    //    try
    //    {
    //        Console.WriteLine("Enter age: ");
    //        int age = int.Parse(Console.ReadLine());

    //        validator.ValidateAge(age); // Call ValidateAge method
    //    }
    //    catch (ArgumentException ex) // Catch the exception if age is invalid
    //    {
    //        Console.WriteLine($"Validation Error: {ex.Message}");
    //    }
    //    catch (FormatException)
    //    {
    //        Console.WriteLine("Please enter a valid integer for age.");
    //    }
    //    Console.ReadLine();
    //}


    //Assignment 10
    //Finally block
    //{
    //    FileReader.ReadFile("example.txt");
    //    Console.ReadLine();
    //}


    //Assignment 9
    //Multiple catch blocks
    //{
    //    Calculator1.DivideIntegers();
    //    Console.ReadLine();
    //}


    //Assignment 8
    //Exception
    //{
    //    int userInput = Input.GetUserInput();
    //    Console.WriteLine("You entered: " + userInput);
    //    Console.ReadLine();
    //}


    //Assignment 7
    //Exception and its Types
    //{
    //    ExceptionDemo.DemonstrateFileNotFoundException();
    //    ExceptionDemo.DemonstrateIndexOutOfRangeException();
    //    Console.ReadLine();
    //}


    //Assignment 6
    //Need for out parameters
    //{
    //    int numerator = 20;
    //    int denominator = 6;
    //    int quotient, remainder;

    //    Calculator.Divide(numerator, denominator, out quotient, out remainder);
    //    Console.WriteLine($"Numerator: {numerator}, Denominator: {denominator}");
    //    Console.WriteLine($"Quotient: {quotient}, Remainder: {remainder}");
    //    Console.ReadLine();
    //}


    //Assignment 5
    //Need for pass by reference using ref keyword
    //{
    //    int playerScore = 50;
    //    Console.WriteLine($"Initial Score: {playerScore}");
    //    // Call IncreaseScore method, passing playerScore by reference
    //    ScoreManager.IncreaseScore(ref playerScore);
    //    Console.WriteLine($"Score after increase: {playerScore}");
    //    Console.ReadLine();
    //}


    //Assignment 4
    //Need for value types and reference types
    //{
    //    Circle circle1 = new Circle(5.0);
    //    Console.WriteLine($"Circle 1: Radius = {circle1.Radius}, Area = {circle1.CalculateArea()}");

    //    // Modify circle1's radius
    //    circle1.Radius = 10.0;
    //    Console.WriteLine($"After modifying Circle 1: Radius = {circle1.Radius}, Area = {circle1.CalculateArea()}");

    //    Circle circle2 = circle1; // circle2 is a copy of circle1
    //    Console.WriteLine($"After modifying Circle 1: Radius = {circle2.Radius}, Area = {circle2.CalculateArea()}");
    //    circle2.Radius = 15.0;
    //    Console.WriteLine($"Circle 1 after modifying Circle 2: Radius = {circle1.Radius}, Area = {circle1.CalculateArea()}");
    //    Console.WriteLine($"Circle 2: Radius = {circle2.Radius}, Area = {circle2.CalculateArea()}");

    //    Shape shape1 = new Shape("Rectangle");
    //    Console.WriteLine($"Shape 1: Name = {shape1.Name}");

    //    // Modify shape1's name
    //    shape1.Name = "Square"; // This changes the original object
    //    Console.WriteLine($"After modifying Shape 1: Name = {shape1.Name}");

    //    Shape shape2 = shape1; // shape2 references the same object as shape1
    //    Console.WriteLine($"After modifying Shape 1: Name = {shape1.Name}");
    //    Console.WriteLine($"After modifying Shape 2: Name = {shape2.Name}");
    //    shape2.Name = "Circle";
    //    Console.WriteLine($"Shape 1 after modifying Shape 2: Name = {shape1.Name}");
    //    Console.WriteLine($"Shape 2: Name = {shape2.Name}");
    //    Console.ReadLine();
    //}


    //Assignment 3
    //Need for enumerations
    //{
    //    Order order1 = new Order(1);
    //    order1.DisplayOrderInfo(); // Display initial order status
    //    order1.UpdateStatus(OrderStatus.Shipped);
    //    order1.DisplayOrderInfo(); // Display updated order status
    //    order1.UpdateStatus(OrderStatus.Delivered);
    //    order1.DisplayOrderInfo(); // Display final order status
    //    Console.ReadLine();
    //}


    //Assignment 2
    //Need for an array of objects
    //{
    //    MovieLibrary movieLibrary = new MovieLibrary(5);
    //movieLibrary.AddMovie(new Movie("The Shawshank Redemption", 1994));
    //    movieLibrary.AddMovie(new Movie("The Godfather", 1972));
    //    movieLibrary.AddMovie(new Movie("The Dark Knight", 2008));
    //    movieLibrary.AddMovie(new Movie("Pulp Fiction", 1994));
    //    movieLibrary.AddMovie(new Movie("The Lord of the Rings: The Return of the King", 2003));

    //    // Attempt to add another movie (should fail as capacity is full)
    //    movieLibrary.AddMovie(new Movie("Inception", 2010));
    //    movieLibrary.DisplayMovies();
    //    Console.ReadLine();
    //}


    //Assignment 1
    //Single and multidimensional arrays as properties of a class
    //{
    //    Library library = new Library(3);
    //    library.AddBook(0,"2 States");
    //    library.AddBook(1,"The cost of living");
    //    library.AddBook(2,"Harry Potter");
    //    library.DisplayBooks();

    //    Classroom classroom = new Classroom(2, 3); // Initialize classroom with 2 rows and 3 columns
    //    classroom.AssignStudent(0, 0, "Sachin");
    //    classroom.AssignStudent(0, 1, "Karthik");
    //    classroom.AssignStudent(1, 2, "Ram");
    //    classroom.DisplaySeating();
    //    Console.ReadLine();
    //}
}
}
