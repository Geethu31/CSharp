using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented
{
        //public class Product
        //{
        //    public string Name;

        //    private decimal price;
        //    public decimal Price
        //    {
        //        get { return price; }
        //        set
        //        {
        //            if (value < 0)
        //            {
        //                Console.WriteLine("Price cannot be negative.");
        //            }
        //            else
        //            {
        //                price = value;
        //            }
        //        }
        //    }

        //    private int stock;
        //    public int Stock
        //    {
        //        get { return stock; }
        //        set
        //        {
        //            if (value < 0)
        //            {
        //                Console.WriteLine("Stock cannot be negative.");
        //            }
        //            else
        //            {
        //                stock = value;
        //            }
        //        }
        //    }

        //    public Product(string name, decimal price, int stock)
        //    {
        //        Name = name;
        //        Price = price;
        //        Stock = stock;
        //    }
        //}

        //public class Order
        //{
        //    public string ProductName;
        //    public int Quantity;
        //    public decimal TotalPrice;

        //    public Order(string productName, int quantity, decimal totalPrice)
        //    {
        //        ProductName = productName;
        //        Quantity = quantity;
        //        TotalPrice = totalPrice;
        //    }
        //}

        //public class ECommerceSystem
        //{
        //    private List<Product> products = new List<Product>();
        //    private List<Order> orders = new List<Order>();

        //    public void AddProduct(Product product)
        //    {
        //        products.Add(product);
        //        Console.WriteLine($"Product '{product.Name}' added to inventory.");
        //    }

        //    public void CreateOrder(string productName, int quantity)
        //    {
        //        var product = products.Find(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));
        //        if (product != null)
        //        {
        //            if (product.Stock >= quantity)
        //            {
        //                product.Stock -= quantity;
        //                var totalPrice = quantity * product.Price;
        //                var order = new Order(product.Name, quantity, totalPrice);
        //                orders.Add(order);
        //                Console.WriteLine($"Order created for {quantity} of '{product.Name}'. Total price: {totalPrice}");
        //            }
        //            else
        //            {
        //                Console.WriteLine($"Insufficient stock for '{product.Name}'. Available: {product.Stock}, Requested: {quantity}");
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine($"Product '{productName}' not found.");
        //        }
        //    }

        //    public void UpdateProductStock(string productName, int newStock)
        //    {
        //        var product = products.Find(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));
        //        if (product != null)
        //        {
        //            product.Stock = newStock;
        //            Console.WriteLine($"Stock for '{product.Name}' updated to {product.Stock}.");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"Product '{productName}' not found.");
        //        }
        //    }

        //    public void DisplayProducts()
        //    {
        //        if (products.Count == 0)
        //        {
        //            Console.WriteLine("No products available.");
        //            return;
        //        }

        //        Console.WriteLine("Available Products:");
        //        foreach (var product in products)
        //        {
        //            Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
        //        }
        //    }

        //    public void DisplayOrders()
        //    {
        //        if (orders.Count == 0)
        //        {
        //            Console.WriteLine("No orders have been placed.");
        //            return;
        //        }

        //        Console.WriteLine("Orders:");
        //        foreach (var order in orders)
        //        {
        //            Console.WriteLine($"Product: {order.ProductName}, Quantity: {order.Quantity}, Total Price: {order.TotalPrice}");
        //        }
        //    }
        //}
    }

