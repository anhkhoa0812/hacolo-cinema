using System;
using System.Collections.Generic;

namespace BussinessObject.Models;

public partial class Seat
{
    public int SeatId { get; set; }

    public string? SeatPosition { get; set; }

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
