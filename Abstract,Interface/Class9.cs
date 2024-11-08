using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface_Partial
{
    public class Book
    {
        public string Title;
        public string Author;

        // Constructor for the Book class
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
        public override string ToString()
        {
            return $"{Title} by {Author}";
        }
    }

    public class Library
    {
        private Book[] books = new Book[3];

        // Indexer to allow access to books by index
        public Book this[int index]
        {
            get => books[index];
            set => books[index] = value;
        }

        // Method to display all books in the library
        public void DisplayAllBooks()
        {
            Console.WriteLine("Books in the Library:");
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine(books[i]?.ToString() ?? "[Empty Slot]");
            }
        }
    }
}

