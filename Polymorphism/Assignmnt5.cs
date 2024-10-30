using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Employee
    {
        private static int totalEmployees = 0;
        public Employee()
        {
            totalEmployees++;
        }
        public virtual void ShowDetails()
        {
            Console.WriteLine("Employee Details.");
        }
        public static void DisplayTotalEmployees()
        {
            Console.WriteLine($"Total Employees: {totalEmployees}");
        }
    }

    // Derived class Manager
    public class Manager : Employee
    {
        public override void ShowDetails()
        {
            Console.WriteLine("Manager Details: Responsible for overseeing teams");
        }
    }

    // Derived class Developer
    public class Developer : Employee
    {
        public override void ShowDetails()
        {
            Console.WriteLine("Developer Details: Responsible for writing code");
        }
    }
}
