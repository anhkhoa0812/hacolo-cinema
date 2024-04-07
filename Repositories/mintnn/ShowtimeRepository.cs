using BussinessObject.Models;
using DataAccessObject;
using DataAccessObject.minhtnn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.mintnn
{
    public class ShowtimeRepository : IShowtimeRepository
    {
        public bool AddShowtime(Showtime showtime)
            => ShowtimeDAO.Instance.AddShowtime(showtime);

        public int GenerateShowTimeIdAutomatically()
            => ShowtimeDAO.Instance.GenerateShowTimeIdAutomatically();

        public Showtime GetShowtimeById(int? showtimeId)
            => ShowtimeDAO.Instance.GetShowtimeById(showtimeId);

        public List<Showtime> GetShowtimes()
            => ShowtimeDAO.Instance.GetShowtimes();

        public bool IsShowTimeIntersection(Showtime showtime)
            => ShowtimeDAO.Instance.IsShowTimeIntersection(showtime);

        public bool UpdateShowtimeStatus()
            => ShowtimeDAO.Instance.UpdateShowtimeStatus();
    }
}
