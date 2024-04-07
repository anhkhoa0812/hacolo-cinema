using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.BookTicket
{
    public interface IMovieRepository
    {
        public Movie GetMovieById(int movieId);
        public IEnumerable<DateOnly> GetShowDatesByMovieId(int movieId);
        public IEnumerable<TimeOnly> GetStartTimesByMovieAndDate(int movieId, DateOnly showDate);
    }
}
