using BussinessObject.Models;
using DataAccessObject.movieandorder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.movieandorder
{
    public class PricingScheduleRepository : IPricingScheduleRepository
    {
        public List<PricingSchedule> GetAll() => PricingScheduleDAO.Instance.GetPricingSchedulesList();
    }
}
