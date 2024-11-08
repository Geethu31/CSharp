using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface_Partial
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class DeveloperAttribute : Attribute
    {
        public string DeveloperName;
        public string LastModifiedDate;

        public DeveloperAttribute(string developerName, string lastModifiedDate)
        {
            DeveloperName = developerName;
            LastModifiedDate = lastModifiedDate;
        }
    }

    [Developer("Sachin", "30-10-2024")]
    public class Calculator
    {
        [Developer("Sachin", "29-10-2024")]
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
