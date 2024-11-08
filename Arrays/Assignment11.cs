using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class AgeValidator
    {
        // Method to validate age
        public void ValidateAge(int age)
        {
            if (age < 18)
            {
                throw new ArgumentException("Age must be 18 or older."); 
            }

            Console.WriteLine("Age is valid.");
        }
    }
}
