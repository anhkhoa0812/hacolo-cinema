using System;
using System.Collections.Generic;

namespace BussinessObject.Models;

public partial class Theater
{
    public int TheaterId { get; set; }

    public string? TheaterName { get; set; }

    public virtual ICollection<Showtime> Showtimes { get; set; } = new List<Showtime>();
}
