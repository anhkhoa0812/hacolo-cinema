using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.BookTicket
{
    public class MovieDAO
    {

        public static Movie GetMovieById(int movieId)
        {
            var context = new HacoloCinemaContext();
            return context.Movies.Include(m => m.Genres).Include(m => m.Showtimes).FirstOrDefault(m => m.MovieId == movieId);
        }

        public static IEnumerable<DateOnly> GetShowDatesByMovieId(int movieId)
        {
            var context = new HacoloCinemaContext();
            return context.Showtimes
                .Where(s => s.MovieId == movieId && s.ShowtimeStatus == true)
                .Select(s => s.ShowDate)
                .Distinct()
                .ToList();
        }

        public static IEnumerable<TimeOnly> GetStartTimesByMovieAndDate(int movieId, DateOnly showDate)
        {
            var context = new HacoloCinemaContext();
            return context.Showtimes
                .Where(s => s.MovieId == movieId && s.ShowDate == showDate && s.ShowtimeStatus == true)
                .Select(s => s.StartTime)
                .ToList();
        }

    }
}
