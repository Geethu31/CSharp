using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface_Partial
{
    public interface IDrive
    {
        void Drive(); 
    }
    public class Car1 : IDrive
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving smoothly on the road.");
        }
    }
    public class Truck : IDrive
    {
        public void Drive()
        {
            Console.WriteLine("Truck is carrying a heavy load.");
        }
    }
}
