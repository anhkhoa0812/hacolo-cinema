using System;
using System.Collections.Generic;

namespace BussinessObject.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int? CustomerId { get; set; }

    public DateTime? OrderDate { get; set; }

    public decimal? TotalPrice { get; set; }

    public int? PaymentId { get; set; }

    public byte? OrderStatus { get; set; }

    public bool IsPrinted { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<OrderDetailCombo> OrderDetailCombos { get; set; } = new List<OrderDetailCombo>();

    public virtual Payment? Payment { get; set; }

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
