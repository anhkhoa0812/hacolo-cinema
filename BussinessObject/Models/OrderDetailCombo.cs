using System;
using System.Collections.Generic;

namespace BussinessObject.Models;

public partial class OrderDetailCombo
{
    public int OrderId { get; set; }

    public int ComboId { get; set; }

    public int? Quantity { get; set; }

    public virtual Combo Combo { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;
}
