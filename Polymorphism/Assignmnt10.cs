using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public abstract class Animal
    {
        public readonly string Species; // Readonly property

        public Animal(string species)
        {
            Species = species; // Initialize readonly property
        }

        // Abstract method to be overridden by derived classes
        public abstract void MakeSound();
    }

    // Derived class Dog
    public class Dog : Animal
    {
        public Dog() : base("Dog") // Setting readonly property in the base class
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Species} says: Woof Woof!");
        }
    }

    // Derived class Cat
    public class Cat : Animal
    {
        public Cat() : base("Cat") // Setting readonly property in the base class
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Species} says: Meow Meow!");
        }
    }
}
