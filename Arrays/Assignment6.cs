using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Calculator
    {
        public static void Divide(int numerator, int denominator, out int quotient, out int remainder)
        {
            quotient = numerator / denominator; 
             remainder = numerator % denominator; 
        }
    }
}
