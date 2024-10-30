using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Vehicle
    {
        public string Brand;

        // Constructor for Vehicle class
        public Vehicle(string brand)
        {
            Brand = brand;
        }

        public void DisplayBrand()
        {
            Console.WriteLine($"Vehicle Brand: {Brand}");
        }
    }

    public class Car : Vehicle
    {
        public string Model;

        // Constructor for Car class that calls the base class constructor
        public Car(string brand, string model) : base(brand)
        {
            Model = model;
        }

        public void DisplayCarInfo()
        {
            DisplayBrand(); // Calling method from base class
            Console.WriteLine($"Car Model: {Model}");
        }
    }
}
