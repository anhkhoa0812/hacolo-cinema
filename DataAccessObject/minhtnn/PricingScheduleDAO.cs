using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.minhtnn
{
    public class PricingScheduleDAO
    {
        private static PricingScheduleDAO instance;
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

        public List<PricingSchedule> GetPricingSchedules()
        {
            using var db = new HacoloCinemaContext();
            return db.PricingSchedules.ToList();
        }
    }
}
