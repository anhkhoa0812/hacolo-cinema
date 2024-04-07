using BussinessObject.Models;
using DataAccessObject.minhtnn;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class ShowtimeDAO
    {
        private static ShowtimeDAO instance = null;
        private MovieDAO MovieDAO = new MovieDAO();
        private static object lockObject = new object();
        public ShowtimeDAO() { }
        public static ShowtimeDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ShowtimeDAO();
                }
                return instance; 
            }
        }
        public List<Showtime> GetShowtimes()
        {
            using var db = new HacoloCinemaContext();
            return db.Showtimes.Include(f => f.Theater).Include(f => f.Movie).ToList();
        }
        public Showtime GetShowtimeById(int? showtimeId)
        {
            using var db = new HacoloCinemaContext();
            return db.Showtimes.Include(f => f.Tickets).Include(f => f.Movie).SingleOrDefault(f => f.ShowtimeId == showtimeId);
        }
        public int GenerateShowTimeIdAutomatically()
        {
            using var db = new HacoloCinemaContext();
            return db.Showtimes.Max(f => f.ShowtimeId) + 1;
        }

        public bool IsShowTimeIntersection(Showtime showtime)
        {
            var showtimeStartTime = showtime.StartTime;
            var endDate = TimeOnly.Parse("11:59 PM");
            var showtimeEndTime = showtime.StartTime.Add(new TimeSpan(0, MovieDAO.GetMovieById(showtime.MovieId).Duration + 15, 0));
            var showtimeList = GetShowtimes();
            foreach (var isshowtime in showtimeList)
            {
                TimeOnly startTime = isshowtime.StartTime;
                TimeOnly endTime = isshowtime.StartTime.Add(new TimeSpan(0, isshowtime.Movie.Duration, 0));
                if (((showtimeStartTime < endTime) && (showtimeEndTime > startTime)))
                {
                    if (showtime.ShowDate.Equals(isshowtime.ShowDate) && (showtime.TheaterId == isshowtime.TheaterId))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool AddShowtime(Showtime showtime)
        {
            using var db = new HacoloCinemaContext();
            db.Showtimes.Add(showtime);
            var change = db.SaveChanges();
            return change > 0;
        }
        public bool UpdateShowtimeStatus()
        {
            using var db = new HacoloCinemaContext();
            var showtimes = GetShowtimes();
            DateTime dateTime = DateTime.Now;
            //DateTime dateTime = DateTime.Parse("3/24/2024 5:00 PM");

            foreach (var showtime in showtimes)
            {
                if (showtime.ShowDate <= DateOnly.FromDateTime(dateTime) 
                    && showtime.StartTime <= TimeOnly.FromDateTime(dateTime))
                {
                    showtime.ShowtimeStatus = true;
                    db.Showtimes.Update(showtime);
                }
                else
                {
                    showtime.ShowtimeStatus = false;
                    db.Showtimes.Update(showtime);
                }
            }
            var change = db.SaveChanges();
            return change > 0;
        }
    }
}
