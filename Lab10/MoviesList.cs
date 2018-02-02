using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    static class MoviesList
    {
        public static List<Movie> movies = new List<Movie>();


        public static void addMovie(Movie movie)
        {
            movies.Add(movie);
        }

        public static List<Movie> getMovies()
        {
            return movies;
        }
        


    }
}
