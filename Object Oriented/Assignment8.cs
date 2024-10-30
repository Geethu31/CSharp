using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented
{
    public class Print
    {
        public void PrintData(string data)
        {
            Console.WriteLine($"String: {data}");
        }
        public void PrintData(int data)
        {
            Console.WriteLine($"Integer: {data}");
        }

        public void PrintData(int[] dataArray)
        {
            Console.Write("Array of Integers: ");
            foreach (var number in dataArray)
            {
                Console.Write(number + " ");
            }
        }
    }
}
