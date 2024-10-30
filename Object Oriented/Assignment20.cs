using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented
{
    public class ShoppingCart
    {
        // Nested Product class
        public class Product
        {
            public string Name;
            public decimal Price;
            public int Quantity;

            public Product(string name, decimal price, int quantity)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
            }
        }

        // List to hold Product objects
        private List<Product> products;

        // Constructor to initialize the shopping cart
        public ShoppingCart()
        {
            products = new List<Product>();
        }
        public void AddProduct(string name, decimal price, int quantity)
        {
            Product product = new Product(name, price, quantity);
            products.Add(product);
            Console.WriteLine($"Added {quantity} x {name},Price = {price}");
        }
        public decimal CalculateTotalPrice()
        {
            decimal total = 0;

            foreach (var product in products)
            {
                total += product.Price * product.Quantity;
            }

            return total;
        }
        public void DisplayProducts()
        {
            Console.WriteLine("Products in the cart:");
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name}: {product.Quantity} x {product.Price} = {product.Quantity * product.Price}");
            }
        }
    }
}
