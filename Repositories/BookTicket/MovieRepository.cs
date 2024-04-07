using BussinessObject.Models;
using DataAccessObject.BookTicket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.BookTicket
{
    public class MovieRepository : IMovieRepository
    {
        public Movie GetMovieById(int movieId) => MovieDAO.GetMovieById(movieId);

        public IEnumerable<DateOnly> GetShowDatesByMovieId(int movieId) => MovieDAO.GetShowDatesByMovieId(movieId);

        public IEnumerable<TimeOnly> GetStartTimesByMovieAndDate(int movieId, DateOnly showDate) => MovieDAO.GetStartTimesByMovieAndDate(movieId, showDate);
    }
}
