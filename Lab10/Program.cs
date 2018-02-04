using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        public static List<Movie> movieList = new List<Movie>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the movie list app!\n");
            InitMovies();
            GetUserInput();
        }

        private static void InitMovies()
        {
            Movie movie0 = new Movie("Gardians of the Galaxy", "scifi");
            Movie movie1 = new Movie("Shrek", "animated");
            Movie movie2 = new Movie("Titanic", "drama");
            Movie movie3 = new Movie("Saw", "horror");
            Movie movie4 = new Movie("Intersteller", "scifi");
            Movie movie5 = new Movie("Toy Story", "animated");
            Movie movie6 = new Movie("Forest Gump", "drama");
            Movie movie7 = new Movie("The Strangers", "horror");
            Movie movie8 = new Movie("Bright", "scifi");
            Movie movie9 = new Movie("The Green Room", "horror");

            movieList.Add(movie0);
            movieList.Add(movie1);
            movieList.Add(movie2);
            movieList.Add(movie3);
            movieList.Add(movie4);
            movieList.Add(movie5);
            movieList.Add(movie6);
            movieList.Add(movie7);
            movieList.Add(movie8);
            movieList.Add(movie9);
        }

        private static void GetUserInput()
        {
            Console.WriteLine("Available categories: Scifi, Drama, Animated, Horror.");
            Console.Write("What category are you interested in?: ");
            string userInput = Console.ReadLine();

            FigureOutWhichCategory(userInput);
        }

        public static void FigureOutWhichCategory(string userInput)
        {
            switch (userInput.ToLower().Trim())
            {
                case "scifi":
                     PrintMoviesInCategory(Movie.GetMoviesInCategory("scifi", movieList), userInput);
                    break;
                case "horror":
                    PrintMoviesInCategory(Movie.GetMoviesInCategory("horror", movieList), userInput);
                    break;
                case "animated":
                    PrintMoviesInCategory(Movie.GetMoviesInCategory("animated", movieList), userInput);
                    break;
                case "drama":
                    PrintMoviesInCategory(Movie.GetMoviesInCategory("drama", movieList), userInput);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Your input does not match any categories. Please try again. \n");
                    GetUserInput();
                    break;
            }
        }

        private static void PrintMoviesInCategory(List<string> movieTitles, string userInput)
        {
            Console.WriteLine("\nMovies in the {0} category: ", userInput);
            foreach (string movie in movieTitles)
            {
                Console.WriteLine("{0}", movie);
            }

            QuitConsoleApp();
        }

        private static void QuitConsoleApp()
        {
            Console.WriteLine("\n\nPress R to repeat or any other key to exit the app.");
            ConsoleKeyInfo quitKey = Console.ReadKey();

            if (quitKey.Key.ToString().ToLower() == "r")
            {
                Console.Clear();
                GetUserInput();
            }
        }
    }
}
