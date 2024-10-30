using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented
{
//    internal class Student
//    {
//        public string Name;
//        public string ID;
//        private List<double> marks;

//        public Student(string name, string id)
//        {
//            Name = name;
//            ID = id;
//            marks = new List<double>();
//        }
//        public void AddMark(double mark)
//        {
//            if (mark < 0 || mark > 100)
//            {
//                Console.WriteLine("Marks must be between 0 and 100.");
//                return;
//            }
//            marks.Add(mark);
//            Console.WriteLine($"Mark {mark} added");
//        }
//        public double CalculateAverageGrade()
//        {
//            if (marks.Count == 0)
//            {
//                Console.WriteLine("No marks available to calculate average");
//                return 0;
//            }

//            double total = 0;
//            foreach (var mark in marks)
//            {
//                total += mark;
//            }
//            return total / marks.Count;
//        }
//        public void DisplayStudentInfo()
//        {
//            Console.WriteLine($"Student ID: {ID}, Name: {Name}, Average Grade: {CalculateAverageGrade()}");
//        }
//    }
}
