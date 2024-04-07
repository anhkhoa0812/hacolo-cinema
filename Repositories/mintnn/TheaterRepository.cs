using BussinessObject.Models;
using DataAccessObject.minhtnn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.mintnn
{
    public class TheaterRepository : ITheaterRepository
    {
        public TimeOnly GetTheaterNextShowTime(int theaterId, DateOnly showDate)
            => TheaterDAO.Instance.GetTheaterNextShowTime(theaterId, showDate);

        public List<Theater> GetTheaters()
            => TheaterDAO.Instance.GetTheaters();

    }
}
