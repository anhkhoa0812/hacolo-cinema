using BussinessObject.Models;
using DataAccessObject.movieandorder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.movieandorder
{
    public class GenreRepository : IGenreRepository
    {
        public void AddMovieToGenres(Genre genre, Movie movie) => GenreDAO.Instance.AddMovieToGenres(genre, movie);

        public List<Genre> GetAll() => GenreDAO.Instance.GetGenresList();

        public List<Genre> GetGenreByMovie(Movie movie) => GenreDAO.Instance.GetGenresByMovieId(movie);

        public Genre GetGenreByName(string name) => GenreDAO.Instance.GetGenreByName(name);
    }
}
