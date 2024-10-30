using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented
{
    internal class Book
        {
            public string Title;
            public string Author;
            public string ISBN;

            public Book(string title, string author, string isbn)
            {
                Title = title;
                Author = author;
                ISBN = isbn;
            }
            public override string ToString()
            {
                return $"Title: {Title}, Author: {Author}, ISBN: {ISBN}";
            }
        }
        class Library
        {
            private List<Book> books;

            public Library()
            {
                books = new List<Book>();
            }
            public void AddBook(Book book)
            {
                books.Add(book);
                Console.WriteLine($"Book '{book.Title}' added to the library.");
            }

            public void RemoveBook(string isbn)
            {
                var bookToRemove = books.Find(b => b.ISBN == isbn);
                if (bookToRemove != null)
                {
                    books.Remove(bookToRemove);
                    Console.WriteLine($"Book '{bookToRemove.Title}' removed from the library.");
                }
                else
                {
                    Console.WriteLine($"No book found with ISBN: {isbn}");
                }
            }
            public void DisplayBooks()
            {
                if (books.Count == 0)
                {
                    Console.WriteLine("No books in the library.");
                    return;
                }

                Console.WriteLine("Books in the library:");
                foreach (var book in books)
                {
                    Console.WriteLine(book);
                }
            }
        }
    }

    
