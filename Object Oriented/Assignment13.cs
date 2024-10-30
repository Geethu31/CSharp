using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented
{
    public class MathOperations
    {
        public static double Pi;
        static MathOperations()
        {
            Pi = 3.14159;  
        }
        public static double CalculateCircleArea(double radius)
        {
            return Pi * radius * radius;
        }
    }
}

