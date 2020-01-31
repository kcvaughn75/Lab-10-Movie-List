using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_10_Movie_List
{
    class Movie
    {
        private string title;
        private string category;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public Movie()
        {

        }

        public Movie(string _title, string _category)
        {
            title = _title;
            category = _category;
        }

        private static List<string> GetListOfMovieCategories(List<Movie> movieList)
        {     //creating object\/
            List<string> movieCategory = new List<string>();
            foreach (Movie movie in movieList)
            {
                if (!movieCategory.Contains(movie.Category))
                {
                    movieCategory.Add(movie.Category);
                }
            }
            return movieCategory;
        }

        public static void PrintMovieCategories(List<Movie> movieList)
        {
            List<string> movieCategories = GetListOfMovieCategories(movieList);
            foreach (string category in movieCategories)
            {
                Console.WriteLine($"{category}, ");
            }
            Console.WriteLine();
        }

        public static void PrintMoviesByCategory(List<Movie> movieList, string categorySelected)
        {
            foreach (Movie movie in movieList)
            {
                if (categorySelected == movie.category)
                {
                    if (movie.category == "scifi")
                    {
                        Console.WriteLine($"{movie.title}");
                    }
                    if (movie.category == "action")
                    {
                        Console.WriteLine($"{movie.title}");
                    }
                    if (movie.category == "comedy")
                    {
                        Console.WriteLine($"{movie.title}");
                    }
                }
            }
        }
    }
}
