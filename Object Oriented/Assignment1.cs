using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented
{
    class Circle
    {

        private double radius;
        public double Radius
        {
            get { return radius; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Radius cannot be negative.");
                }
                else
                {
                    radius = value;
                }
            }
        }
        public Circle(double radius)
        {
            Radius = radius;
        }
    }
}

