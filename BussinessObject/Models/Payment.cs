using System;
using System.Collections.Generic;

namespace BussinessObject.Models;

public partial class Payment
{
    public int PaymentId { get; set; }

    public string? PaymentMethod { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
