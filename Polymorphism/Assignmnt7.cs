using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    //public class Shape
    //{
    //    // Method Overloading (Early Binding)
    //    public void Draw()
    //    {
    //        Console.WriteLine("Drawing a generic shape.");
    //    }

    //    public void Draw(int radius)
    //    {
    //        Console.WriteLine($"Drawing a circle with radius: {radius}");
    //    }

    //    public void Draw(int width, int height)
    //    {
    //        Console.WriteLine($"Drawing a rectangle with width: {width} and height: {height}");
    //    }

    //    // Mark the Draw method as virtual to allow overriding
    //    public virtual void DrawShape()
    //    {
    //        Console.WriteLine("Drawing a shape.");
    //    }
    //}

    //// Derived class
    //public class Circle : Shape
    //{
    //    // Method Overriding (Late Binding)
    //    public override void DrawShape()
    //    {
    //        Console.WriteLine("Drawing a circle.");
    //    }
    //}

    //// Another derived class
    //public class Rectangle : Shape
    //{
    //    // Method Overriding (Late Binding)
    //    public override void DrawShape()
    //    {
    //        Console.WriteLine("Drawing a rectangle.");
    //    }
    //}
}
