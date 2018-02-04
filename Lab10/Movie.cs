using System.Collections.Generic;

namespace Lab10
{
    internal class Movie
    {
        private string title;
        private string category;

        public Movie(string title, string category)
        {
            this.title = title;
            this.category = category;
        }

        public static List<string> GetMoviesInCategory(string category, List<Movie> moviesList)
        {
            List<string> response = new List<string>();

            foreach (var movie in moviesList)
            {
                if (movie.category == category)
                {
                    response.Add(movie.title);
                }
            }

            return response;
        }
    }
}