using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.BookTicket
{
    public interface IShowtimeRepository
    {
        public int? GetShowtimeIdByDateTime(DateOnly showDate, TimeOnly startTime);
        public Showtime? GetShowtimeDetails(int showtimeId);
    }
}
