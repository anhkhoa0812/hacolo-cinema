using System;
using System.Collections.Generic;

namespace BussinessObject.Models;

public partial class Combo
{
    public int ComboId { get; set; }

    public string? ComboName { get; set; }

    public decimal? ComboPrice { get; set; }

    public virtual ICollection<OrderDetailCombo> OrderDetailCombos { get; set; } = new List<OrderDetailCombo>();
}
