using System;
using System.Collections.Generic;
using static System.Console;

namespace Filmek {
    public class Program {
        public static void Main(string[] args) {
            var myMovie = new Movie("True Lies", 1994, 7.2);
            WriteLine(myMovie.ToString());

            var movies = new List<Movie> {
                myMovie,
                new Movie("Terminator", 1984, 8.0),
                new Movie("Aliens", 1986, 8.3),
                new Movie("True Lies", 1994, 7.2)
            };

            foreach (Movie movie in movies) {
                WriteLine(movie);
            }
        }
    }
}