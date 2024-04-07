using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessObject.movieandorder
{
    public class MoviesDAO
    {
        private static MoviesDAO instance = null;
        private static object lockObject = new object();

        public static MoviesDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MoviesDAO();
                }
                return instance;
            }
        }

        public List<Movie> GetMoviesList()
        {
            using var db = new HacoloCinemaContext();
            return db.Movies.Include(m => m.Genres).ToList();
        }

        public void SaveMovie(Movie movie)
        {
            using var db = new HacoloCinemaContext();
            db.Movies.Add(movie);
            db.SaveChanges();
        }

        public bool ExistById(int id)
        {
            using var db = new HacoloCinemaContext();
            Movie movie = db.Movies.FirstOrDefault(m => m.MovieId == id);
            return movie != null;
        }

        public void AddGenreToMovie(Genre genre, Movie movie)
        {
            using var db = new HacoloCinemaContext();

            db.Attach(genre);
            db.Attach(movie);
            movie.Genres.Add(genre);
            db.SaveChanges();
        }

        public Movie GetGenreById(int id)
        {
            using var db = new HacoloCinemaContext();

            Movie movie = db.Movies.FirstOrDefault(m => m.MovieId == id);

            if (movie != null)
            {
                db.Entry(movie).Collection(m => m.Genres).Load();
            }

            return movie;
        }

        public void RemoveMovie(int id)
        {
            using var db = new HacoloCinemaContext();
            Movie movie = db.Movies.Include(m => m.Genres)
                .FirstOrDefault(m => m.MovieId == id);
            if (movie != null)
            {
                foreach (var genre in movie.Genres.ToList())
                {
                    movie.Genres.Remove(genre);
                }
                db.Movies.Remove(movie);
                db.SaveChanges();
            }
        }

        public void UpdateMovie(Movie movie)
        {
            using var db = new HacoloCinemaContext();
            db.Movies.Update(movie);
            db.SaveChanges();
        }

        public void UpdateStatusMovie(int movieId, bool? status)
        {
            using var db = new HacoloCinemaContext();
            var movie = db.Movies.FirstOrDefault(m => m.MovieId == movieId);
            if (movie != null)
            {
                movie.Status = status;
                db.SaveChanges();
            }
        }
        public int GetLargestId()
        {
            using var db = new HacoloCinemaContext();
            int largestId = db.Movies.Max(wt => (int?)wt.MovieId) ?? 0;
            return largestId;
        }







    }
}
