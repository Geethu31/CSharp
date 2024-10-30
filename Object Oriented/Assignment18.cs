using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented
{
    public class Product
    {
        public string Name;
        public decimal Price;
        public string Category;

        // Constructor that initializes all properties
        public Product(string name, decimal price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        // Static method to create a Product object
        public static Product CreateProduct(string name, decimal price, string category)
        {
            return new Product(name, price, category);
        }

        // Constructor with default values
        public Product() : this("Default Product", 0.0m, "General")
        {
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Product Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Category: {Category}");
        }
    }
}