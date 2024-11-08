using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface_Partial
{
    public partial class Employee
    {
        public decimal BaseSalary;
        partial void CalculateSalary();
    }
    public partial class Employee
    {
        partial void CalculateSalary()
        {
            Console.WriteLine($"Calculating salary based on the base salary of {BaseSalary}");
        }
        public void ShowSalary()
        {
            CalculateSalary(); 
        }
    }
}
