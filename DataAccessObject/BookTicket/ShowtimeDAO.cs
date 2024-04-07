using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.BookTicket
{
    public class ShowtimeDAO
    {
        public static int? GetShowtimeIdByDateTime(DateOnly showDate, TimeOnly startTime)
        {
            using (var context = new HacoloCinemaContext())
            {
                var showtime = context.Showtimes
                                      .FirstOrDefault(st => st.ShowDate == showDate && st.StartTime == startTime);
                return showtime?.ShowtimeId;
            }
        }
        public static Showtime? GetShowtimeDetails(int showtimeId)
        {
            using (var context = new HacoloCinemaContext())
            {
                return context.Showtimes
                              .Include(st => st.PricingSchedule)
                              .Include(st => st.Movie)
                              .Include(st => st.Theater)
                              .FirstOrDefault(st => st.ShowtimeId == showtimeId);
            }
        }
    }
}
