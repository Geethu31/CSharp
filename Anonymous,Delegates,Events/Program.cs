using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Anonymous_Delegates_Events
{
    internal class Program
    {
        static void Main(string[] args)
        { 
          //Assuming db is an instance of the data context connected to the database
           var itEmployees = from emp in db.Employees
                      where emp.Department == "IT"
                      select emp;
            //Display result
            foreach(var employee in itEmployees)
            {
            Console.WriteLine($"ID:{employee.ID}, Name: {employee.Name}, Dpeartment: {employee.Department}");
            }
}

    //---------------------------------------------------------------Assignment 19-----------------------------------------------
    //LINQ TO XML
    //public class Program
    //{
    //    public static void Main()
    //    {
    //        // Create an XML document representing a list of books
    //        XDocument booksXml = new XDocument(
    //            new XElement("Books",
    //                new XElement("Book",
    //                    new XElement("Title", "C# Programming"),
    //                    new XElement("Author", "John Doe"),
    //                    new XElement("YearPublished", 2016)
    //                ),
    //                new XElement("Book",
    //                    new XElement("Title", "SQL"),
    //                    new XElement("Author", "Jane Smith"),
    //                    new XElement("YearPublished", 2020)
    //                ),
    //                new XElement("Book",
    //                    new XElement("Title", "LINQ"),
    //                    new XElement("Author", "Michael Brown"),
    //                    new XElement("YearPublished", 2015)
    //                ),
    //                new XElement("Book",
    //                    new XElement("Title", "Java"),
    //                    new XElement("Author", "Sarah"),
    //                    new XElement("YearPublished", 2017)
    //                )
    //            )
    //        );

    //        // Query the titles of books published after 2015 using LINQ to XML
    //        var booksAfter2015 = from book in booksXml.Descendants("Book")
    //                             where (int)book.Element("YearPublished") > 2015
    //                             select book.Element("Title").Value;

    //        Console.WriteLine("Books Published After 2015:");
    //        foreach (var title in booksAfter2015)
    //        {
    //            Console.WriteLine(title);
    //        }
    //        Console.ReadLine();
    //    }
    


    //--------------------------------------------------Assignment 18----------------------------------------------------------
    //LINQ TO OBJECTS
    //public class Program
    //{
    //    public static void Main()
    //    {
    //        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    //        var sumQuerySyntax = (from num in numbers
    //                              where num % 2 == 0
    //                              select num).Sum();

    //        Console.WriteLine("Sum of even numbers (Query Syntax): " + sumQuerySyntax);

    //        // Method syntax to find the sum of even numbers
    //        var sumMethodSyntax = numbers.Where(num => num % 2 == 0).Sum();

    //        // Display the result from method syntax
    //        Console.WriteLine("Sum of even numbers (Method Syntax): " + sumMethodSyntax);
    //        Console.ReadLine();
    //    }



    //-------------------------------------------------------Assignment 17-----------------------------------------------------
    //LINQ OPERATORS
    //public class Program
    //{
    //    public static void Main()
    //    {
    //        List<string> students = new List<string>
    //    {
    //        "Alice", "Karthik", "Anna", "Alex", "Ram", "Athira", "Aaron", "Sachin"
    //    };

    //        // Query syntax to select names starting with 'A' and order them alphabetically
    //        var resultQuerySyntax = from student in students
    //                                where student.StartsWith("A")
    //                                orderby student
    //                                select student;

    //        // Display the results from query syntax
    //        Console.WriteLine("Query Syntax Results:");
    //        foreach (var student in resultQuerySyntax)
    //        {
    //            Console.WriteLine(student);
    //        }

    //        // Method syntax to select names starting with 'A' and order them alphabetically
    //        var resultMethodSyntax = students.Where(s => s.StartsWith("A")).OrderBy(s => s);

    //        Console.WriteLine("\nMethod Syntax Results:");
    //        foreach (var student in resultMethodSyntax)
    //        {
    //            Console.WriteLine(student);
    //        }
    //        Console.ReadLine();
    //    }




    //---------------------------------------------------Assignment 16----------------------------------------------
    //LINQ QUERY SYNTAX AND METHOD SYNTAX
    //public class Program
    //{
    //    public static void Main()
    //    {
    //        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    //        // Query syntax to retrieve numbers greater than 5
    //        var resultQuerySyntax = from num in numbers
    //                                where num > 5
    //                                select num;

    //        Console.WriteLine("Query Syntax Results:");
    //        foreach (var num in resultQuerySyntax)
    //        {
    //            Console.WriteLine(num);
    //        }

    //        // Method syntax to retrieve numbers greater than 5
    //        var resultMethodSyntax = numbers.Where(num => num > 5);

    //        // Display the results from method syntax
    //        Console.WriteLine("\nMethod Syntax Results:");
    //        foreach (var num in resultMethodSyntax)
    //        {
    //            Console.WriteLine(num);
    //        }
    //        Console.ReadLine();
    //    }



    //------------------------------------------------Assignment 15--------------------------------------------------
    //PARALLEL PROGRAMMING WITH TPL
    //public class Program
    //{
    //    public static async Task Main(string[] args)
    //    {
    //        int[] numbers = { 5, 7, 10, 12 };

    //        // Create a list of tasks to calculate factorials in parallel
    //        Task<long>[] tasks = numbers.Select(n => CalculateFactorialAsync(n)).ToArray();

    //        // Wait for all tasks to complete
    //        long[] results = await Task.WhenAll(tasks);

    //        for (int i = 0; i < numbers.Length; i++)
    //        {
    //            Console.WriteLine($"Factorial of {numbers[i]} is {results[i]}");
    //            Console.ReadLine();
    //        }
    //    }

    //    // Asynchronous method to calculate the factorial of a number
    //    public static async Task<long> CalculateFactorialAsync(int number)
    //    {
    //        // Simulate some delay in the operation to mimic real-world tasks
    //        return await Task.Run(() =>
    //        {
    //            return Factorial(number);
    //        });
    //    }

    //    // Method to calculate the factorial of a number
    //    public static long Factorial(int number)
    //    {
    //        if (number == 0 || number == 1)
    //            return 1;
    //        else
    //            return number * Factorial(number - 1);
    //    }



    //--------------------------------------------------------Assignment 14-----------------------------------------------------------
    //HANDLING EXCEPTIONS IN ASYNCHRONOUS METHODS
    //public class Program
    //{
    //    public static async Task Main(string[] args)
    //    {
    //        // Define an array of integers
    //        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    //        try
    //        {
    //            // Call the asynchronous method to calculate the sum
    //            int sum = await CalculateSumAsync(numbers);

    //            // Display the result
    //            Console.WriteLine($"The sum of the array is: {sum}");
    //        }
    //        catch (Exception ex)
    //        {
    //            // Catch any exceptions that occur during the sum calculation
    //            Console.WriteLine($"An error occurred: {ex.Message}");
    //        }
    //    }

    //    // Asynchronous method to calculate the sum of an array of integers
    //    public static async Task<int> CalculateSumAsync(int[] numbers)
    //    {
    //        // Simulate an asynchronous operation (you can use Task.Delay for a real async process)
    //        return await Task.Run(() =>
    //        {
    //            try
    //            {
    //                // Simulate a potential error (e.g., division by zero, null array)
    //                if (numbers == null)
    //                {
    //                    throw new ArgumentNullException(nameof(numbers), "Array cannot be null");
    //                }

    //                int sum = 0;
    //                foreach (int num in numbers)
    //                {
    //                    sum += num;
    //                }

    //                return sum;
    //            }
    //            catch (Exception ex)
    //            {
    //                // Propagate the exception to the calling method
    //                throw new InvalidOperationException("Error during sum calculation", ex);
    //            }
    //        });
    //    }



    //--------------------------------------------------------Assignment 13----------------------------------------------------
    //TASK AND TASK<T>
    //public class Program
    //{
    //    public static async Task Main(string[] args)
    //    {
    //        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    //        // Call the asynchronous method to calculate the sum
    //        int sum = await CalculateSumAsync(numbers);

    //        Console.WriteLine($"The sum of the array is: {sum}");
    //        Console.ReadLine();
    //    }

    //    // Asynchronous method to calculate the sum of an array of integers
    //    public static async Task<int> CalculateSumAsync(int[] numbers)
    //    {
    //        // asynchronous operation 
    //        return await Task.Run(() =>
    //        {
    //            int sum = 0;
    //            foreach (int num in numbers)
    //            {
    //                sum += num;
    //            }
    //            return sum;
    //        });
    //    }



    //-------------------------------------------------Assignment 12-------------------------------------------------------------------------
    //ASYNC AND AWAIT KEYWORDS
    //public class Program
    //{
    //    public static async Task Main(string[] args)
    //    {
    //        // URL to download data from
    //        string url = "https://github.com/Geethu31/CSharp/blob/master/Arrays%2CStrings/Program.cs";  // You can replace this with any URL

    //        // Call the asynchronous method to download and print content length
    //        await DownloadDataAsync(url);
    //    }

    //    // Asynchronous method to download data from a URL
    //    public static async Task DownloadDataAsync(string url)
    //    {
    //        // Initialize HttpClient
    //        using (HttpClient client = new HttpClient())
    //        {
    //            try
    //            {
    //                // Asynchronously download the content from the URL
    //                HttpResponseMessage response = await client.GetAsync(url);

    //                // Ensure the request was successful
    //                response.EnsureSuccessStatusCode();

    //                // Read the content as a string asynchronously
    //                string content = await response.Content.ReadAsStringAsync();

    //                // Print the length of the content
    //                Console.WriteLine($"Content length: {content.Length} characters");
    //            }
    //            catch (Exception ex)
    //            {
    //                // Handle any exceptions (e.g., network errors)
    //                Console.WriteLine($"An error occurred: {ex.Message}");
    //            }
    //            Console.ReadLine();
    //        }
    //    }



    //------------------------------------------------Assignment 11------------------------------------------
    //ASYNCHRONOUS PROGRAMMING
    //public class Program
    //{
    //    public static async Task Main(string[] args)
    //    {
    //        // Display message before the operation
    //        Console.WriteLine("Operation started");

    //        // Call the long-running operation asynchronously
    //        await LongRunningOperation();

    //        // Display message after the operation completes
    //        Console.WriteLine("Operation completed");
    //        Console.ReadLine();
    //    }

    //    // Simulate a long-running operation using Task.Delay()
    //    public static async Task LongRunningOperation()
    //    {
    //        // Simulate a long-running task (e.g., 5 seconds)
    //        await Task.Delay(5000);  // Delay for 5 seconds

    //        // Optionally, display message after the delay
    //        Console.WriteLine("Long-running operation finished!");
    //    }



    //-------------------------------------------------------Assignment 10--------------------------------------------------------------
    //DELEGATES AS A CALLBACK MECHANISM
    //public class Program
    //{
    //    public delegate int CalculationDelegate(int a, int b);

    //    // Method for addition
    //    public static int Add(int a, int b)
    //    {
    //        return a + b;
    //    }

    //    // Method for subtraction
    //    public static int Subtract(int a, int b)
    //    {
    //        return a - b;
    //    }

    //    // Method that accepts two integers and a delegate to perform the calculation
    //    public static int Calculate(int x, int y, CalculationDelegate operation)
    //    {
    //        return operation(x, y);
    //    }

    //    public static void Main(string[] args)
    //    {
    //        //addition
    //        CalculationDelegate addOperation = Add;
    //        int addResult = Calculate(10, 5, addOperation);
    //        Console.WriteLine($"Addition result: {addResult}");

    //        //subtraction
    //        CalculationDelegate subtractOperation = Subtract;
    //        int subtractResult = Calculate(10, 5, subtractOperation);
    //        Console.WriteLine($"Subtraction result: {subtractResult}");
    //        Console.ReadLine();
    //    }



    //------------------------------------------------Assignment 9-----------------------------------------------------------------
    //LAMBDA EXPRESSIONS TO FILTER AND PROCESS LISTS
    //public class Product
    //{
    //    public string Name;
    //    public decimal Price;
    //}

    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        List<Product> products = new List<Product>
    //    {
    //        new Product { Name = "Laptop", Price = 800 },
    //        new Product { Name = "Smartphone", Price = 600 },
    //        new Product { Name = "Headphones", Price = 30 },
    //        new Product { Name = "Keyboard", Price = 40 },
    //        new Product { Name = "Monitor", Price = 150 },
    //        new Product { Name = "Mouse", Price = 25 }
    //    };

    //        // 1. Filter the list to find products that cost more than $50
    //        var filteredProducts = products.Where(p => p.Price > 50);

    //        // 2. Sort the filtered list by price in descending order
    //        var sortedProducts = filteredProducts.OrderByDescending(p => p.Price);

    //        // 3. Select and display only the names of products from the filtered and sorted list
    //        var productNames = sortedProducts.Select(p => p.Name);

    //        Console.WriteLine("Products costing more than $50, sorted by price (descending):");
    //        foreach (var name in productNames)
    //        {
    //            Console.WriteLine(name);
    //        }
    //        Console.ReadLine();
    //    }



    //-------------------------------------------Assignment 8--------------------------------------------------------
    //DELEGATES TO HOLD METHODS WITH THE SAME SIGNATURE 
    //public class Program
    //    {
    //        public delegate string StringOperationDelegate(string input);

    //        // Method to convert the string to uppercase
    //        public static string ToUpperCase(string input)
    //        {
    //            return input.ToUpper();
    //        }

    //        // Method to reverse the string
    //        public static string ReverseString(string input)
    //        {
    //            char[] charArray = input.ToCharArray();
    //            Array.Reverse(charArray);
    //            return new string(charArray);
    //        }

    //        // Method to add a prefix to the string
    //        public static string AddPrefix(string input)
    //        {
    //            return "Hi " + input;
    //        }

    //        public static void Main(string[] args)
    //        {
    //            // Instantiate the delegate and assign each method to it
    //            StringOperationDelegate operation;

    //            operation = ToUpperCase;
    //            Console.WriteLine("Uppercase: " + operation("Hello"));

    //            operation = ReverseString;
    //            Console.WriteLine("Reversed: " + operation("Hello"));

    //            operation = AddPrefix;
    //            Console.WriteLine("With Prefix: " + operation("Hello"));
    //        Console.ReadLine();
    //        }


    //------------------------------------------------------Assignment 7---------------------------------------------------------------
    //EXPRESSION TREE
    //{
    //    ParameterExpression param1 = Expression.Parameter(typeof(int), "a");
    //    ParameterExpression param2 = Expression.Parameter(typeof(int), "b");

    //    // addition operation
    //    BinaryExpression body = Expression.Add(param1, param2);

    //    //lambda expression tree
    //    Expression<Func<int, int, int>> addExpression = Expression.Lambda<Func<int, int, int>>(body, param1, param2);

    //    // Compile the expression tree into a delegate
    //    Func<int, int, int> addFunc = addExpression.Compile();
    //    int result = addFunc(5, 3);
    //    Console.WriteLine($"The sum of 5 and 3 is: {result}");
    //    Console.ReadLine();
    //}

    //----------------------------------------------------Assignment 6-------------------------------------------------------------------
    //LAMBDA EXPRESSIONS
    //    {
    //    // Define a lambda expression using Func to multiply two integers
    //    Func<int, int, int> multiply = (x, y) => x * y;

    //// Test the lambda expression
    //int result = multiply(5, 3);
    //Console.WriteLine($"The product of 5 and 3 is: {result}");
    //        Console.ReadLine();
    //}


    //----------------------------------------------------Assignment 5--------------------------------------------------------------------
    //ANONYMOUS METHODS
    //public class Program
    //{
    //    // Define the delegate
    //    public delegate void GreetDelegate(string name);

    //    public static void Main(string[] args)
    //    {
    //        // Assign an anonymous method to the delegate
    //        GreetDelegate greet = delegate (string name)
    //        {
    //            Console.WriteLine($"Hello, {name}! Have a good day");
    //        };

    //        // Invoke the delegate with a sample name
    //        greet("Geethu");
    //        Console.ReadLine();
    //    }


    //-----------------------------------------------------Assignment 4--------------------------------------------------------------------
    //EVENTS
    //    public class Download
    //{
    //    public delegate void CompletedEventHandler(object sender, EventArgs e);

    //    // Declare the event using the delegate
    //    public event CompletedEventHandler OnCompleted;
    //    public void StartDownload()
    //    {
    //        Console.WriteLine("Starting download...");

    //        // Simulating a download process with a delay
    //        System.Threading.Thread.Sleep(3000);  // Simulate 3 seconds of download time

    //        // Raise the OnCompleted event after the download is done
    //        OnCompleted?.Invoke(this, EventArgs.Empty);
    //    }
    //}

    //public class Program
    //{
    //    // Event handler method that will respond when download completes
    //    static void DownloadCompleted(object sender, EventArgs e)
    //    {
    //        Console.WriteLine("Download has been successfully completed!");
    //    }

    //    public static void Main(string[] args)
    //    {
    //        Download download = new Download();

    //        // Subscribe to the OnCompleted event
    //        download.OnCompleted += DownloadCompleted;

    //        // Start the download process
    //        download.StartDownload();
    //        Console.ReadLine();
    //    }



    //---------------------------------------------------Assignment 3--------------------------------------------------------------------
    //DELEGATES
    //public class SimpleCalculator
    //        {
    //            public delegate double OperationDelegate(double num1, double num2);
    //            public static double Add(double num1, double num2)
    //            {
    //                return num1 + num2;
    //            }

    //            public static double Subtract(double num1, double num2)
    //            {
    //                return num1 - num2;
    //            }

    //            public static double Multiply(double num1, double num2)
    //            {
    //                return num1 * num2;
    //            }

    //            public static double Divide(double num1, double num2)
    //            {
    //                if (num2 == 0)
    //                {
    //                    Console.WriteLine("Error: Division by zero is not allowed.");
    //                    return 0; // Return 0 as an error result
    //                }
    //                return num1 / num2;
    //            }

    //            public static void Main(string[] args)
    //            {
    //                // 4. Allow the user to input two numbers and choose an operation
    //                Console.WriteLine("Enter the first number:");
    //                double num1 = Convert.ToDouble(Console.ReadLine());

    //                Console.WriteLine("Enter the second number:");
    //                double num2 = Convert.ToDouble(Console.ReadLine());

    //                Console.WriteLine("Choose an operation:");
    //                Console.WriteLine("1: Add");
    //                Console.WriteLine("2: Subtract");
    //                Console.WriteLine("3: Multiply");
    //                Console.WriteLine("4: Divide");

    //                int choice = Convert.ToInt32(Console.ReadLine());

    //                // 3. Use the delegate to call the selected method
    //                OperationDelegate operation = null;

    //                switch (choice)
    //                {
    //                    case 1:
    //                        operation = Add;
    //                        break;
    //                    case 2:
    //                        operation = Subtract;
    //                        break;
    //                    case 3:
    //                        operation = Multiply;
    //                        break;
    //                    case 4:
    //                        operation = Divide;
    //                        break;
    //                    default:
    //                        Console.WriteLine("Invalid choice.");
    //                        return;
    //                }

    //                // Display the result of the operation
    //                double result = operation(num1, num2);
    //                Console.WriteLine($"The result is: {result}");
    //            Console.ReadLine();

    //            }


    //--------------------------------------Assignment 2----------------------------------------------------
    //VAR VARIABLE
    //{
    //    var numbers = new List<int> { 1, 2, 3, 4, 5 };

    //    // Adding a number to the list
    //    numbers.Add(6);

    //    Console.WriteLine("List of numbers:");
    //    foreach (var number in numbers)
    //    {
    //        Console.WriteLine(number);
    //    }
    //    Console.ReadLine();
    //}


    //DYNAMIC VARIABLE
    //    {
    //    // Declaring a dynamic variable
    //    dynamic variable = 10;  // Initially an integer

    //    // Displaying the value and type
    //    Console.WriteLine($"Value: {variable}, Type: {variable.GetType()}");

    //    // Assigning a string to the dynamic variable
    //    variable = "Hello, dynamic!";
    //    Console.WriteLine($"Value: {variable}, Type: {variable.GetType()}");

    //    // Assigning a boolean to the dynamic variable
    //    variable = true;
    //    Console.WriteLine($"Value: {variable}, Type: {variable.GetType()}");
    //        Console.ReadLine();
    //}


    //-------------------------------------Assignment 1------------------------------------------------
    //ANONYMOUS TYPES
    //{
    //        // Creating an anonymous type to represent a book
    //        var book = new
    //        {
    //            Title = "2 States",
    //            Author = "Chetan Bhagat",
    //            Price = 450
    //        };

    //        // Displaying the details of the book
    //        Console.WriteLine($"Book Title: {book.Title}");
    //        Console.WriteLine($"Author: {book.Author}");
    //        Console.WriteLine($"Price: INR {book.Price}");
    //    Console.ReadLine();
    //    }
}
}

