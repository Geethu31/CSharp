using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Movie
    {
        public string Title;
        public int Year;
        public Movie(string title, int year)
        {
            Title = title;
            Year = year;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Year: {Year}");
        }
    }
    public class MovieLibrary
    {
        private Movie[] movies;
        private static int movieCount;

        // Constructor  with a given size
        public MovieLibrary(int size)
        {
            movies = new Movie[size]; 
            movieCount = 0; 
        }
        public void AddMovie(Movie movie)
        {
            if (movieCount < movies.Length) // Check if there is space in the array
            {
                movies[movieCount] = movie; // Add the Movie object to the array
                movieCount++; 
                Console.WriteLine($"Movie '{movie.Title}' added to the library.");
            }
            else
            {
                Console.WriteLine("Movie library is full. Cannot add more movies."); 
            }
        }
        public void DisplayMovies()
        {
            Console.WriteLine("Movies in the library:");
            for (int i = 0; i < movieCount; i++)
            {
                movies[i].DisplayInfo(); // Call DisplayInfo on each Movie object
            }
        }
    }
}
