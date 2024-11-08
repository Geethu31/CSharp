using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class ExceptionDemo
    {
        public static void DemonstrateFileNotFoundException()
        {
            try
            {
                // Attempt to read a file that does not exist
                Console.WriteLine("Attempting to read a non-existent file");
                string content = File.ReadAllText("non_existent_file.txt");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"FileNotFoundException: {ex.Message}");
            }
        }
        public static void DemonstrateIndexOutOfRangeException()
        {
            try
            {
                // Attempt to access an index that is out of range of the array
                int[] numbers = { 1, 2, 3 }; 
                Console.WriteLine("Attempting to access an index out of range");
                int number = numbers[5]; 
                Console.WriteLine(number);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"IndexOutOfRangeException: {ex.Message}");
            }
        }
    }
}
