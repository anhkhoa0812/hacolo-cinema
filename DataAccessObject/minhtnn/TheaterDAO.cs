using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.minhtnn
{
    public class TheaterDAO
    {
        private static TheaterDAO instance;
        private static object lockObject = new object();
        private ShowtimeDAO showtimeDAO = new ShowtimeDAO();
        private MovieDAO movieDAO = new MovieDAO();
        public static TheaterDAO Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new TheaterDAO();
                }
                return instance; 
            }
        }
        public TheaterDAO() { }
        public List<Theater> GetTheaters()
        {
            using var db = new HacoloCinemaContext();
            return db.Theaters.ToList();
        }
        public Theater GetTheaterById(int id)
        {
            using var db = new HacoloCinemaContext();
            return db.Theaters.Include(f => f.Showtimes).SingleOrDefault(f => f.TheaterId == id);
        }
        public TimeOnly GetTheaterNextShowTime(int theaterId, DateOnly showDate)
        {
            var theater = GetTheaterById(theaterId);
            var time = new TimeOnly();

            var showtimesFromTheater = showtimeDAO.GetShowtimes().Where(f => f.TheaterId == theaterId && f.ShowDate.Equals(showDate)).ToList();
            if (showtimesFromTheater != null && showtimesFromTheater.Count > 0)
            {
                var chooseShowtime = showtimesFromTheater.OrderByDescending(f => f.StartTime).FirstOrDefault();
                TimeSpan timeSpan = new TimeSpan(0, movieDAO.GetMovieById(chooseShowtime.MovieId).Duration + 15, 0);
                TimeOnly endTime = chooseShowtime.StartTime.Add(timeSpan);
                return endTime;
            }
            return TimeOnly.Parse("7:00 AM");
        }


    }
}
