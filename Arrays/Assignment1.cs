using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Classroom
    {
        private string[,] seats;

        public Classroom(int rows, int columns)
        {
            seats = new string[rows, columns];
        }

        public void AssignStudent(int row, int column, string studentName)
        {
            if (row >= 0 && row < seats.GetLength(0) && column >= 0 && column < seats.GetLength(1))
            {
                seats[row, column] = studentName;
            }
            else
            {
                Console.WriteLine("Invalid seat position.");
            }
        }

        public void DisplaySeating()
        {
            Console.WriteLine("Classroom Seating Arrangement:");
            for (int i = 0; i < seats.GetLength(0); i++)
            {
                for (int j = 0; j < seats.GetLength(1); j++)
                {
                    Console.Write(seats[i, j] ?? "Empty");
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
        }
    }


    public class Library
    {
        private string[] bookTitles;

        public Library(int capacity)
        {
            bookTitles = new string[capacity];
        }

        public void AddBook(int index, string title)
        {
            if (index >= 0 && index < bookTitles.Length)
            {
                bookTitles[index] = title;
            }
            else
            {
                Console.WriteLine("Index out of range.");
            }
        }

        public void DisplayBooks()
        { 
            Console.WriteLine("Books in the Library:");
            foreach (var title in bookTitles)
            {
                if (!string.IsNullOrEmpty(title))
                {
                    Console.WriteLine(title);
                }
            }
        }
    }
}
