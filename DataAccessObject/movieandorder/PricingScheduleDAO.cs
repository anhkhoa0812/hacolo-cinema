using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.movieandorder
{
    public class PricingScheduleDAO
    {
        private static PricingScheduleDAO instance = null;
        private static object lockObject = new object();

        public static PricingScheduleDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PricingScheduleDAO();
                }
                return instance;
            }
        }
        public PricingScheduleDAO() { }

        public List<PricingSchedule> GetPricingSchedulesList()
        {
            using var db = new HacoloCinemaContext();
            return db.PricingSchedules.ToList();
        }
    }
}
