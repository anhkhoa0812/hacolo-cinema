using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.movieandorder
{
    public class TheaterDAO
    {
        private static TheaterDAO instance = null;
        private static object lockObject = new object();

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

        public List<Theater> GetTheatersList()
        {
            using var db = new HacoloCinemaContext();
            return db.Theaters.ToList();
        }
    }
}
