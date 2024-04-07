using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.mintnn
{
    public interface IShowtimeRepository
    {
        Showtime GetShowtimeById(int? showtimeId);
        List<Showtime> GetShowtimes();
        int GenerateShowTimeIdAutomatically();
        bool IsShowTimeIntersection(Showtime showtime);
        bool AddShowtime(Showtime showtime);
        bool UpdateShowtimeStatus();
    }
}
