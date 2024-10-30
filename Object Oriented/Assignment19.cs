using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented
{
    public record Student(string Name, int Age, string Grade);
}
public static void DisplayStudent(Student student)
{
    Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Grade: {student.Grade}");
}
