using System;
using System.Collections.Generic;

namespace Lab_10_Movie_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> grandCircusVideo = new List<Movie>
            {
                new Movie("inception", "scifi"),
                new Movie("the martian", "scifi"),
                new Movie("interstellar", "scifi"),
                new Movie("step brothers", "comedy"),
                new Movie("iron man", "action"),
                new Movie("dumb and dumber", "comedy"),
                new Movie("superbad", "comedy"),
                new Movie("die hard", "action"),
                new Movie("the terminator", "action"),
                new Movie("the matrix", "scifi")

            };
            char userContinue = 'y';
            while (userContinue == 'y')
            {
                Console.WriteLine("Here is a list of movie categories to choose from: ");
                Movie.PrintMovieCategories(grandCircusVideo);

                Console.WriteLine("Please enter a movie category to see a list of movies:");
                string categorySelected = Console.ReadLine().ToLower();

                Movie.PrintMoviesByCategory(grandCircusVideo, categorySelected);

                Console.WriteLine("Would you like to choose another category? [y/n]");
                userContinue = char.Parse(Console.ReadLine().ToLower());

                if (userContinue != 'y' && userContinue != 'n')
                {
                    Console.WriteLine("Invalid input. Please enter [y] to search for another movie, [n] to quit. [y/n]");
                    userContinue = char.Parse(Console.ReadLine().ToLower());
                }

                if (userContinue == 'n')
                {
                    Console.WriteLine("Thanks for using Grand Circus Video Online! Goodbye!!");
                    break;
                }
            }
            


            
        }
    }
}
