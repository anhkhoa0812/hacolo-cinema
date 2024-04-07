using System;
using System.Collections.Generic;

namespace BussinessObject.Models;

public partial class WalletTransaction
{
    public int WalletTransactionId { get; set; }

    public int? WalletId { get; set; }

    public decimal? TransactionAmount { get; set; }

    public DateTime? TransactionDate { get; set; }

    public virtual Wallet? Wallet { get; set; }
}
