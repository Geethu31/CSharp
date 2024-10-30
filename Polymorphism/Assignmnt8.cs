using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public abstract class Shape
    {
        public abstract double Area();
    }

    public interface IShape
    {
        double Perimeter();
    }

    // Circle class implementing IShape and inheriting from Shape
    public class Circle : Shape, IShape
    {
        public double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        // Overriding the Area method from Shape
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        // Implementing the Perimeter method from IShape
        public double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    // Rectangle class implementing IShape and inheriting from Shape
    public class Rectangle : Shape, IShape
    {
        public double Width;
        public double Height;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Overriding the Area method from Shape
        public override double Area()
        {
            return Width * Height;
        }

        // Implementing the Perimeter method from IShape
        public double Perimeter()
        {
            return 2 * (Width + Height);
        }
    }
}
