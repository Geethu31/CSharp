using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented
{
    class Program
    {
        public static Student CreateStudent((string Name, int Age, string Grade) studentTuple)
        {
            return new Student(studentTuple.Name, studentTuple.Age, studentTuple.Grade);
        }
        static void Main(string[] args)
        {
            // 2. Initialize a tuple with student details
            var studentTuple1 = ("Alice", 20, "A");
            var studentTuple2 = ("Bob", 22, "B");

            // 3. Convert tuples to Student records using the CreateStudent method
            Student student1 = CreateStudent(studentTuple1);
            Student student2 = CreateStudent(studentTuple2);

            // 4. Display the details of the students
            Console.WriteLine("Student Details:");
            DisplayStudent(student1);
            DisplayStudent(student2);
            Console.ReadLine();
        }


        //Assignment 22
        //{
        //    University university = new University();

        //    //Adding departments
        //    university.AddDepartment("Computer Science");
        //    university.AddDepartment("Mathematics");

        //    //Adding courses to departments
        //    university.AddCourse("Computer Science", "Algorithms", "CS101", 3);
        //    university.AddCourse("Computer Science", "Data Structures", "CS102", 4);
        //    university.AddCourse("Mathematics", "Calculus", "MATH101", 3);

        //    //Displaying course details
        //    university.DisplayCourseDetails();
        //    Console.ReadLine();
        //}


        //Assignment 21
        //{
        //    Bank bank = new Bank();

        //    // Adding customers
        //    bank.AddCustomer("Alice");
        //    bank.AddCustomer("Bob");

        //    // Adding accounts to customers
        //    bank.AddAccount("Alice", 1001, 5000m);
        //    bank.AddAccount("Alice", 1002, 1500m);
        //    bank.AddAccount("Bob", 1003, 3000m);
        //    bank.DisplayCustomerDetails();
        //    Console.ReadLine();
        //}

        //Assignment 20
        //{
        //    // Create a ShoppingCart instance
        //    ShoppingCart cart = new ShoppingCart();

        //    // Adding products to the cart
        //    cart.AddProduct("Laptop", 999.99m, 1);
        //    cart.AddProduct("Smartphone", 799.99m, 2);
        //    cart.AddProduct("Headphones", 199.99m, 3);

        //    // Display the products and the total price
        //    cart.DisplayProducts();
        //    decimal totalPrice = cart.CalculateTotalPrice();
        //    Console.WriteLine($"Total Price: {totalPrice}");
        //    Console.ReadLine();
        //}


        //Assignment 18
        //{
        //    //1.Constructor Initialization
        //    Product product1 = new Product("Laptop", 999.99m, "Electronics");

        //    //2.Object Initializer Syntax
        //    Product product2 = new Product
        //    {
        //        Name = "Smartphone",
        //        Price = 599.99m,
        //        Category = "Electronics"
        //    };

        //    //3.Static Factory Method
        //    Product product3 = Product.CreateProduct("Tablet", 299.99m, "Electronics");

        //    //4. Anonymous Types
        //    var anonymousProduct = new
        //    {
        //        Name = "Smartwatch",
        //        Price = 199.99m,
        //        Category = "Wearables"
        //    };
        //    // Display details of each product
        //    Console.WriteLine("Product Details:\n");
        //    product1.DisplayDetails();
        //    product2.DisplayDetails();
        //    product3.DisplayDetails();

        //    // Display anonymous product details
        //    Console.WriteLine($"Anonymous Product: {anonymousProduct.Name}, Price: {anonymousProduct.Price}, Category: {anonymousProduct.Category}");

        //    // 5. Reflection
        //    Type type = typeof(Product);
        //    Product product5 = (Product)Activator.CreateInstance(type);
        //    product5.Name = "Headphones";
        //    product5.Price = 150m;
        //    product5.Category = "Accessories";
        //    product5.DisplayDetails();

        //    // 6. Default values in constructor
        //    Product product6 = new Product();
        //    product6.DisplayDetails();
        //    Console.ReadLine();
        //}


        //Assignment 17
        //    {
        //        List<Product> productList = new List<Product>
        //{
        //    new Product("Laptop"),
        //    new Product("Smartphone", 799.99m),
        //    new Product("Tablet", 499.99m, 10),
        //    new Product("Smartwatch", 199.99m, 15)
        //};
        //        Console.WriteLine("Product Details:");
        //        foreach (var product in productList)
        //        {
        //            product.DisplayDetails();
        //        }
        //        Console.ReadLine();
        //    }


        //Assignment 16
        //{
        //    List<Car> carList = new List<Car>
        //        {
        //            new Car("BMW"),
        //            new Car("Audi", "A4"),
        //            new Car("Mercedes", "C-Class", 2022),
        //            new Car("Chevrolet", "Corvette", 2023, 84999.99m)
        //        };

        //    Console.WriteLine("Car Details:");
        //    foreach (var car in carList)
        //    {
        //        car.DisplayDetails();
        //    }
        //    carList[1].UpdatePrice(39999.99m);
        //    Console.WriteLine("\nUpdated Car 2 Details:");
        //    carList[1].DisplayDetails();
        //    Console.ReadLine();
        //}

        //Assignment 15
        //{
        //    Person person1 = new Person("Sachin", 25);
        //    Console.WriteLine("Person 1:");
        //    person1.Display();
        //    Person person2 = new Person(person1);
        //    Console.WriteLine("Person 2 (Copied using copy constructor):");
        //    person2.Display();

        //    person2.Name = "Karthik";
        //    person2.Age = 30;

        //    Console.WriteLine("Person 1:");
        //    person1.Display();

        //    Console.WriteLine("Person 2 (After modification):");
        //    person2.Display();
        //    Console.ReadLine();
        //}

        //Assignment 14
        //{
        //    Configuration user1Config = new Configuration("English");
        //    user1Config.DisplayConfiguration();
        //    Console.ReadLine();
        //}

        //Assignment 13
        //{
        //    Console.WriteLine($"The value of Pi is: {MathOperations.Pi}");
        //    double radius = 5;
        //    double area = MathOperations.CalculateCircleArea(radius);
        //    Console.WriteLine($"Area of a circle is {area}");
        //    Console.ReadLine();
        //}

        //Assignment 12
        //{
        //    Car car1 = new Car("Toyota");

        //    Car car2 = new Car("Honda");


        //    Car car3 = new Car("Ford");

        //    Car.GetCarCount();

        //    Console.ReadLine();
        //}

        //Assignment 11
        //{
        //    Bank account1 = new Bank(500);
        //    account1.DisplayAccountDetails();
        //    Bank account2 = new Bank(2000);
        //    account2.DisplayAccountDetails();
        //    Console.ReadLine();
        //}

        //Assignment 10
        //{
        //    Time time = new Time();
        //    time.SetTime(10, 30);
        //    time.DisplayTime();
        //    time.SetTime(3600);
        //    time.DisplayTime();
        //    Console.ReadLine();
        //}

        //Assignment 9
        //{
        //    Rectangle rectangle = new Rectangle();
        //    double rectangleArea = rectangle.CalculateArea(5, 10);
        //    Console.WriteLine($"Area of the rectangle: {rectangleArea}");
        //    double squareArea = rectangle.CalculateArea(4);
        //    Console.WriteLine($"Area of the square: {squareArea}");

        //    Console.ReadLine();
        //}

        //Assignment 8
        //{
        //    Print printer = new Print();
        //    printer.PrintData("Good day!");
        //    printer.PrintData(31);
        //    int[] numbers = { 1, 2, 3, 4, 5 };
        //    printer.PrintData(numbers);
        //    Console.ReadLine();
        //}

        //Assignment 7
        //{
        //    ECommerceSystem ecommerceSystem = new ECommerceSystem();
        //    ecommerceSystem.AddProduct(new Product("Laptop", 999.99m, 10));
        //    ecommerceSystem.AddProduct(new Product("Mouse", 19.99m, 50));
        //    ecommerceSystem.AddProduct(new Product("Keyboard", 49.99m, 25));
        //    ecommerceSystem.DisplayProducts();
        //    ecommerceSystem.CreateOrder("Mouse", 5);
        //    ecommerceSystem.CreateOrder("Laptop", 12);
        //    ecommerceSystem.CreateOrder("Keyboard", 1);
        //    ecommerceSystem.UpdateProductStock("Mouse", 100);
        //    ecommerceSystem.UpdateProductStock("Keyboard", 50);
        //    ecommerceSystem.DisplayProducts();
        //    ecommerceSystem.DisplayOrders();

        //    Console.ReadLine();
        //}

        //Assignment 6
        //{
        //    Inventory inventory = new Inventory();
        //    inventory.AddItem(new Item("Laptop", 10, 999.99m));
        //    inventory.AddItem(new Item("Mouse", 50, 19.99m));
        //    inventory.AddItem(new Item("Keyboard", 25, 49.99m));
        //    inventory.DisplayItems();
        //    inventory.UpdateItem("Mouse", newStock: 45, newPrice: 17.99m);
        //    inventory.RemoveItem("Keyboard");
        //    inventory.DisplayItems();

        //    Console.ReadLine();
        //}

        //Assignment 5
        //{
        //    Student student1 = new Student("John", "S123");

        //    student1.AddMark(85);
        //    student1.AddMark(90);
        //    student1.AddMark(78);
        //    student1.AddMark(92);

        //    student1.DisplayStudentInfo();
        //    Console.ReadLine();
        //}

        //Assignment 4
        //{
        //    BankAccount account = new BankAccount("123456789", "John Doe");
        //    account.Deposit(1000);
        //    account.Withdraw(500);
        //    account.Withdraw(600);
        //    Console.WriteLine($"Final balance is {account.Balance}");
        //    Console.ReadLine();
        //}

        //Assignment 3
        //Library library = new Library();

        //library.AddBook(new Book("1984", "George Orwell", "978-0451524935"));
        //library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "978-0061120084"));
        //library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "978-0743273565"));
        //library.DisplayBooks();
        //library.RemoveBook("978-0743273565");
        //Console.ReadLine();









        //Assignment 2
        //{
        //    try
        //    {
        //        Employee employee = new Employee("John Doe", 50000m);
        //        employee.Salary = 60000m;
        //        Console.WriteLine($"Employee Name: {employee.Name}, Salary: {employee.Salary}");

        //        employee.Salary = -10000m;
        //    }
        //    catch (ArgumentException ex)
        //    {
        //        Console.WriteLine($"Error: {ex.Message}");
        //    }
        //    Console.ReadLine();
        //}





        //Assignment 1
        //{
        //    Circle circle = new Circle(5);
        //    circle.Radius = -10;
        //    Console.WriteLine($"Circle Radius: {circle.Radius}");
        //    Console.ReadLine();
        //}
    }
}




