using BussinessObject.Models;
using DataAccessObject.movieandorder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.movieandorder
{
    public class WalletTransactionRepository : IWalletTransactionRepository
    {
        public void CreateWalletTransaction(WalletTransaction walletTransaction) => WalletTransactionDAO
            .Instance.CreateWalletTransaction(walletTransaction);

        public int GetLargeId() => WalletTransactionDAO.Instance.GetLargestId();

        public List<WalletTransaction> GetWalletTransactionsByWalletId(int walletId) => WalletTransactionDAO
            .Instance.GetWalletTransactionsByWalletId(walletId);
    }
}
