using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public struct Circle
    {
        public double Radius;
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius; 
        }
    }
    public class Shape
    {
        public string Name;
        public Shape(string name)
        {
            Name = name;
        }
    }

}
