using BussinessObject.Models;
using DataAccessObject.BookTicket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.BookTicket
{
    public class ShowtimeRepository : IShowtimeRepository
    {
        public Showtime? GetShowtimeDetails(int showtimeId) => ShowtimeDAO.GetShowtimeDetails(showtimeId);

        public int? GetShowtimeIdByDateTime(DateOnly showDate, TimeOnly startTime) => ShowtimeDAO.GetShowtimeIdByDateTime(showDate, startTime);
    }
}
