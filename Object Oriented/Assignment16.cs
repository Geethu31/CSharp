using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented
{
    public class Car
    {
        public string Make;
        public string Model;
        public int Year;
        public decimal Price;

        // Constructor that initializes only the make
        public Car(string make)
        {
            Make = make;
        }

        // Constructor that initializes make and model
        public Car(string make, string model) : this(make)
        {
            Model = model;
        }

        // Constructor that initializes make, model, and year
        public Car(string make, string model, int year) : this(make, model)
        {
            Year = year;
        }

        // Constructor that initializes all fields
        public Car(string make, string model, int year, decimal price) : this(make, model, year)
        {
            Price = price;
        }
        public void UpdatePrice(decimal newPrice)
        {
            Price = newPrice;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}, Price: {Price}");
        }
    }
}

