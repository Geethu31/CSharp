using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface_Partial
{
    public abstract class Bird
    {
        public abstract void Fly();
    }

    // Interface ISwim with a method Swim
    public interface ISwim
    {
        void Swim();
    }

    // Class Duck inherits from Bird and implements ISwim
    public class Duck : Bird, ISwim
    {
        public override void Fly()
        {
            Console.WriteLine("Duck is flying short distances");
        }

        public void Swim()
        {
            Console.WriteLine("Duck is swimming on the surface");
        }
    }

    // Class Penguin inherits from Bird and implements ISwim
    public class Penguin : Bird, ISwim
    {
        public override void Fly()
        {
            Console.WriteLine("Penguins cannot fly");
        }

        public void Swim()
        {
            Console.WriteLine("Penguin is swimming underwater");
        }
    }

}
