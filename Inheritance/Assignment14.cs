using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Person
    {
        public string Name;

        public Person(string name)
        {
            Name = name;
        }
    }

    public class Student : Person
    {
        // Hiding the base class Name property using the new keyword
        public new string Name;

        public Student(string personName, string studentName) : base(personName)
        {
            Name = studentName;
        }

        public void DisplayStudentInfo()
        {
            // Accessing the base class's Name property using base.Name
            Console.WriteLine($"Student's Name: {Name}");
            Console.WriteLine($"Base Class (Person) Name: {base.Name}");
        }
        //}
    }
}
