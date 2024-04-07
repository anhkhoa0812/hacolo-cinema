using System;
using System.Collections.Generic;

namespace BussinessObject.Models;

public partial class PricingSchedule
{
    public int PricingScheduleId { get; set; }

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public virtual ICollection<Showtime> Showtimes { get; set; } = new List<Showtime>();
}
