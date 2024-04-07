using BussinessObject.Models;
using DataAccessObject.movieandorder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.movieandorder
{
    public class MovieRepository : IMovieRepository
    {
        public void AddGenreToMovie(Genre genre, Movie movie) => MoviesDAO.Instance.AddGenreToMovie(genre, movie);

        public void DeleteMovieById(int id) => MoviesDAO.Instance.RemoveMovie(id);
        public bool ExistById(int id) => MoviesDAO.Instance.ExistById(id);
        public List<Movie> GetAll() => MoviesDAO.Instance.GetMoviesList();

        public int GetLargestId() => MoviesDAO.Instance.GetLargestId();

        public Movie GetMovieById(int id) => MoviesDAO.Instance.GetGenreById(id);

        public void SaveMovie(Movie m) => MoviesDAO.Instance.SaveMovie(m);

        public void UpdateMovie(Movie movie) => MoviesDAO.Instance.UpdateMovie(movie);

        public void UpdateStatusMovie(int movieId, bool? status) => MoviesDAO.Instance.UpdateStatusMovie(movieId, status);
    }
}
