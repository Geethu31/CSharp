using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented
{
    public class University
    {
        // List to store department objects
        private List<Department> departments = new List<Department>();

        // Method to add a department
        public void AddDepartment(string departmentName)
        {
            departments.Add(new Department(departmentName));
            Console.WriteLine($"Department {departmentName} added");
        }

        // Method to add a course to a specific department
        public void AddCourse(string departmentName, string courseName, string courseCode, int credits)
        {
            Department department = departments.Find(d => d.Name == departmentName);
            if (department != null)
            {
                department.AddCourse(courseName, courseCode, credits);
                Console.WriteLine($"Course {courseName} added to department {departmentName}");
            }
            else
            {
                Console.WriteLine($"Department {departmentName} not found");
            }
        }
        public void DisplayCourseDetails()
        {
            foreach (Department department in departments)
            {
                Console.WriteLine($"Department: {department.Name}");
                foreach (Department.Course course in department.Courses)
                {
                    Console.WriteLine($"Course: {course.CourseName}, Code: {course.CourseCode}, Credits: {course.Credits}");
                }
            }
        }

        // Nested Department class
        public class Department
        {
            public string Name;
            public List<Course> Courses;

            public Department(string name)
            {
                Name = name;
                Courses = new List<Course>();
            }

            // Method to add a course to the department
            public void AddCourse(string courseName, string courseCode, int credits)
            {
                Courses.Add(new Course(courseName, courseCode, credits));
            }

            // Nested Course class
            public class Course
            {
                public string CourseName;
                public string CourseCode;
                public int Credits;

                public Course(string courseName, string courseCode, int credits)
                {
                    CourseName = courseName;
                    CourseCode = courseCode;
                    Credits = credits;
                }
            }
        }
    }
}
