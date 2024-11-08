using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface_Partial
{
    public enum CarType
    {
        Sedan,
        SUV,
        Truck,
        Coupe
    }
    public class Car2
    {
        public CarType Type { get; set; }

        public Car2(CarType type)
        {
            Type = type;
        }
        public void DisplayCarTypeMessage(CarType type)
        {
            switch (type)
            {
                case CarType.Sedan:
                    Console.WriteLine("The Sedan is known for its comfort and efficiency");
                    break;
                case CarType.SUV:
                    Console.WriteLine("The SUV offers great space and off-road capability");
                    break;
                case CarType.Truck:
                    Console.WriteLine("The Truck is ideal for heavy-duty tasks and cargo");
                    break;
                case CarType.Coupe:
                    Console.WriteLine("The Coupe is a sporty, compact car");
                    break;
                default:
                    Console.WriteLine("Unknown car type");
                    break;
            }
        }
    }
}
