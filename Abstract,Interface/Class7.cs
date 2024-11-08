using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface_Partial
{
    public partial class Person
    {
        public string Name;
    }

    public partial class Person
    {
        public void ShowDetails()
        {
            Console.WriteLine($"Person's Name: {Name}");
        }
    }
}
