using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Calculator1
    {
        public static void DivideIntegers()
        {
            try
            {
                Console.Write("Enter the first integer: ");
                int numerator = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the second integer: ");
                int denominator = Convert.ToInt32(Console.ReadLine());

                int result = numerator / denominator;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid integer.");
            }
        }
    }
}
