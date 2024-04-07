using System;
using System.Collections.Generic;

namespace BussinessObject.Models;

public partial class Ticket
{
    public int TicketId { get; set; }

    public int? OrderId { get; set; }

    public int? ShowtimeId { get; set; }

    public int? SeatId { get; set; }

    public decimal? TicketPrice { get; set; }

    public bool? IsSold { get; set; }

    public virtual Order? Order { get; set; }

    public virtual Seat? Seat { get; set; }

    public virtual Showtime? Showtime { get; set; }
}
