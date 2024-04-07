using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.movieandorder
{
    public interface IGenreRepository
    {
        List<Genre> GetAll();

        Genre GetGenreByName(string name);
        void AddMovieToGenres(Genre genre, Movie movie);

        List<Genre> GetGenreByMovie(Movie movie);
    }
}
