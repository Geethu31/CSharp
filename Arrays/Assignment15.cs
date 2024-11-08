using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException() { }

        public InvalidAgeException(string message) : base(message) { }
    }
    public class FileProcessor
    {
        // Method to read content from a file
        public void ReadFileContent(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string content = reader.ReadToEnd(); // Read the entire content
                    Console.WriteLine(content);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File not found: {filePath}"); // Handle file not found
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}"); // Handle other exceptions
            }
        }
    }

    // Class for performing math operations
    public class MathOperations
    {
        // Method to divide two numbers
        public double Divide(int a, int b)
        {
            try
            {
                return a / b; // Attempt division
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero"); // Handle divide by zero
                return 0; // Return a default value if division fails
            }
        }
    }

    // Class for managing person information
    public class Person
    {
        private int age; // Private field for age

        public int Age // Public property for accessing age
        {
            get { return age; }
            set
            {
                SetAge(value); // Call SetAge method when setting age
            }
        }

        // Method to set age and validate
        public void SetAge(int age)
        {
            if (age < 0 || age > 120)
            {
                throw new InvalidAgeException("Invalid age provided"); // Throw custom exception for invalid age
            }

            this.age = age; // Set the age if valid
        }
    }
}