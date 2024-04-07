using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.minhtnn
{
    public class MovieDAO
    {
        private static MovieDAO instance = null;
        private static object lockObject = new object();
        public static MovieDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MovieDAO();
                }
                return instance;
            }
        }
        public MovieDAO() { }
        public Movie GetMovieById(int? movieId)
        {
            using var db = new HacoloCinemaContext();
            return db.Movies.SingleOrDefault(f => f.MovieId == movieId);
        }
        public List<Movie> GetMovies()
        {
            using var db = new HacoloCinemaContext();
            return db.Movies.ToList();
        }
    }
}
