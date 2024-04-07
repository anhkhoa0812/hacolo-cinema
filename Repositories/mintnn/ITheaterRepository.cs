using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.mintnn
{
    public interface ITheaterRepository
    {
        List<Theater> GetTheaters();
        TimeOnly GetTheaterNextShowTime(int theaterId, DateOnly showDate);
    }
}
