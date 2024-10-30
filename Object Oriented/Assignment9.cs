using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented
{
    public class Rectangle
    {
        public double CalculateArea(double width, double height)
        {
            return width * height;
        }
        public double CalculateArea(double sideLength)
        {
            return sideLength * sideLength;
        }
    }
}
