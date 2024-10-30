using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public interface IMovable
    {
        void Move(int distance);
    }
    public interface IDrawable
    {
        void Draw();
    }

    // Class that implements both IMovable and IDrawable interfaces
    public class Car : IMovable, IDrawable
    {
        public string Model;
        public int Position;

        public Car(string model)
        {
            Model = model;
            Position = 0; 
        }

        // Implementation of Move method from IMovable interface
        public void Move(int distance)
        {
            Position += distance;
            Console.WriteLine($"{Model} moved {distance} units to position {Position}");
        }

        // Implementation of Draw method from IDrawable interface
        public void Draw()
        {
            Console.WriteLine($"Drawing {Model} at position {Position}");
        }
    }
}
