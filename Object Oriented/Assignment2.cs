using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented
{
    class Employee
    {
        private string name;
        private decimal salary;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary cannot be negative.");
                }
                else
                {
                    salary = value;
                }
            }
        }
        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }
    }
}
   
