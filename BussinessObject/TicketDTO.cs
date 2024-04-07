using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject
{
    public class TicketDTO
    {
        public string? MovieName { get; set; }
        public DateOnly? ShowDate { get; set; }
        public TimeOnly? StartTime { get; set; }
        public string? SeatPosition { get; set; }
        public decimal? TicketPrice { get; set; }
    }
}
