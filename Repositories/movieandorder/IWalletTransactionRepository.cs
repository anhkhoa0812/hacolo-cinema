using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.movieandorder
{
    public interface IWalletTransactionRepository
    {
        void CreateWalletTransaction(WalletTransaction walletTransaction);

        int GetLargeId();

        List<WalletTransaction> GetWalletTransactionsByWalletId(int walletId);
    }
}
