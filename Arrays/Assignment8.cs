using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Input
    {
        public static int GetUserInput()
        {
            int result;
            while (true)
            {
                Console.Write("Please enter an integer: ");
                try
                {
                    result = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The number is too large. Please enter a smaller integer.");
                }
            }
            return result;
        }
    }
}
