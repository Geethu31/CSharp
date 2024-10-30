using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Calculator
    {
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        public static double Multiply(int a, double b)
        {
            return a * b;
        }
        public static double Multiply(double a, int b)
        {
            return a * b;
        }
    }
}
