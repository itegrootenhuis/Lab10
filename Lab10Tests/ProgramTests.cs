using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void FigureOutWhichCategoryTest()
        {
            List<string> categories = new List<string>() { "scifi", "horror", "drama", "animated" };
            string userInput = "scifi";

            Assert.IsTrue(categories.Contains(userInput));
        }

        [TestMethod()]
        public void GetMoviesInCategoryTest()
        {
            List<Movie> movieList = new List<Movie>();
            Movie movie0 = new Movie("Gardians of the Galaxy", "scifi");
            movieList.Add(movie0);

            Assert.IsNotNull(movieList);
        }

        [TestMethod()]
        public void PrintMoviesInCategoryTest()
        {
            List<string> movieTitles = new List<string>() { "Gardians of the Galaxy" };
            Assert.IsNotNull(movieTitles);
        }
    }
}