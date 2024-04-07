using System;
using System.Collections.Generic;

namespace BussinessObject.Models;

public partial class Wallet
{
    public int WalletId { get; set; }

    public int? CustomerId { get; set; }

    public decimal? WalletBalance { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<WalletTransaction> WalletTransactions { get; set; } = new List<WalletTransaction>();
}
