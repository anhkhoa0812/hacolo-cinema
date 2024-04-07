using System;
using System.Collections.Generic;

namespace BussinessObject.Models;

public partial class Movie
{
    public int MovieId { get; set; }

    public string? MovieName { get; set; }

    public string? Description { get; set; }

    public int Duration { get; set; }

    public DateOnly? ReleaseDay { get; set; }

    public int? LimitAge { get; set; }

    public string? Cast { get; set; }

    public string? Director { get; set; }

    public bool? Status { get; set; }

    public byte[]? Image { get; set; }

    public virtual ICollection<Showtime> Showtimes { get; set; } = new List<Showtime>();

    public virtual ICollection<Genre> Genres { get; set; } = new List<Genre>();
}
