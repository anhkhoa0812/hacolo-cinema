using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.movieandorder
{
    public interface IMovieRepository
    {
        List<Movie> GetAll();
        void SaveMovie(Movie m);

        bool ExistById(int id);

        void AddGenreToMovie(Genre genre, Movie movie);

        Movie GetMovieById(int id);

        void DeleteMovieById(int id);

        void UpdateMovie(Movie movie);

        void UpdateStatusMovie(int movieId, bool? status);

        int GetLargestId();
    }
}
