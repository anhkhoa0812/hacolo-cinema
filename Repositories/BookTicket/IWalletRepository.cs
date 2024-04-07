using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.BookTicket
{
    public interface  IWalletRepository
    {
        public Wallet GetWalletByCustomerId(int customerId);
        public void UpdateWallet(Wallet wallet);
        public void SaveWalletTransaction(WalletTransaction walletTransaction);
        public int GetLargestId();
    }
}
