using BussinessObject.Models;
using DataAccessObject.minhtnn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.mintnn
{
    public class PricingScheduleRepository : IPricingScheduleRepository
    {
        public List<PricingSchedule> GetPricingSchedules()
            => PricingScheduleDAO.Instance.GetPricingSchedules();
    }
}
