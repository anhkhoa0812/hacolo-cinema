using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.movieandorder
{
    public class GenreDAO
    {
        private static GenreDAO instance = null;
        private static object lockObject = new object();

        public static GenreDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GenreDAO();
                }
                return instance;
            }
        }

        public GenreDAO() { }

        public List<Genre> GetGenresList()
        {
            using var db = new HacoloCinemaContext();
            return db.Genres.ToList();
        }

        public Genre GetGenreByName(string name)
        {
            using var db = new HacoloCinemaContext();
            return db.Genres.FirstOrDefault(g => g.GenreName == name);
        }
        public void AddMovieToGenres(Genre genre, Movie movie)
        {
            using var db = new HacoloCinemaContext();
            db.Attach(genre);
            db.Attach(movie);
            genre.Movies.Add(movie);
            db.SaveChanges();
        }

        public List<Genre> GetGenresByMovieId(Movie movie)
        {
            using var db = new HacoloCinemaContext();
            return db.Genres.ToList().Where(g => g.Movies.Contains(movie)).ToList();
        }
    }
}
