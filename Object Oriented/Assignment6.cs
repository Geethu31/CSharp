using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented
{
    public class Item
    {
        public string Name;

        private int stock;
        public int Stock
        {
            get { return stock; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Stock cannot be negative.");
                }
                else
                {
                    stock = value;
                }
            }
        }

        private decimal price;
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Price cannot be negative.");
                }
                else
                {
                    price = value;
                }
            }
        }

        public Item(string name, int stock, decimal price)
        {
            Name = name;
            Stock = stock;
            Price = price;
        }
    }

    public class Inventory
    {
        private List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            items.Add(item);
            Console.WriteLine($"Item '{item.Name}' added to inventory.");
        }

        public void RemoveItem(string name)
        {
            var itemToRemove = items.Find(i => i.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (itemToRemove != null)
            {
                items.Remove(itemToRemove);
                Console.WriteLine($"Item '{itemToRemove.Name}' removed from inventory.");
            }
            else
            {
                Console.WriteLine($"No item found with name: {name}");
            }
        }

        public void UpdateItem(string name, int newStock, decimal newPrice)
        {
            var itemToUpdate = items.Find(i => i.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (itemToUpdate != null)
            {
                itemToUpdate.Stock = newStock;
                itemToUpdate.Price = newPrice;
                Console.WriteLine($"Item '{itemToUpdate.Name}' updated successfully.");
            }
            else
            {
                Console.WriteLine($"No item found with name: {name}");
            }
        }

        public void DisplayItems()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("No items in inventory.");
                return;
            }

            Console.WriteLine("Items in inventory:");
            foreach (var item in items)
            {
                Console.WriteLine($"Item: {item.Name}, Stock: {item.Stock}, Price: {item.Price}");
            }
        }
    }
}