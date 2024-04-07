using System;
using System.Collections.Generic;

namespace BussinessObject.Models;

public partial class Showtime
{
    public int ShowtimeId { get; set; }

    public int MovieId { get; set; }

    public int TheaterId { get; set; }

    public int? PricingScheduleId { get; set; }

    public DateOnly ShowDate { get; set; }

    public TimeOnly StartTime { get; set; }

    public bool ShowtimeStatus { get; set; }

    public virtual Movie Movie { get; set; } = null!;

    public virtual PricingSchedule? PricingSchedule { get; set; }

    public virtual Theater Theater { get; set; } = null!;

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
