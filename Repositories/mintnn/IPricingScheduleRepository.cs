using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.mintnn
{
    public interface IPricingScheduleRepository
    {
        List<PricingSchedule> GetPricingSchedules();
    }
}
