using BussinessObject.Models;
using DataAccessObject.minhtnn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.mintnn
{
    public class MovieRepository : IMovieRepository
    {
        public Movie GetMovieById(int? movieId)
            => MovieDAO.Instance.GetMovieById(movieId);

        public List<Movie> GetMovies()
            => MovieDAO.Instance.GetMovies();
    }
}
