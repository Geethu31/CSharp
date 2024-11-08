using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException() { }

        public NegativeNumberException(string message) : base(message) { }
    }
    public class NumberChecker
    {
        // Method to check if a number is negative
        public void CheckNumber(int number)
        {
            if (number < 0)
            {
                throw new NegativeNumberException("Input cannot be a negative number."); // Throw custom exception
            }

            Console.WriteLine("Valid input: " + number); // Print valid input
        }
    }
}
