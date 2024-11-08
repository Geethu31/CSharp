using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class NegativeNumberException1 : Exception
    {
        public NegativeNumberException1() { }

        public NegativeNumberException1(string message) : base(message) { }
    }
    public class NumberValidator
    {
        // Method to check if a number is positive
        public void ValidatePositiveNumber(int number)
        {
            if (number < 0)
            {
                throw new NegativeNumberException1("Negative numbers are not permitted."); // Throw custom exception
            }

            Console.WriteLine($"The number {number} is valid.");
        }
    }
}
