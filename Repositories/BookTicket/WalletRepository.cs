using BussinessObject.Models;
using DataAccessObject.BookTicket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.BookTicket
{
    public class WalletRepository : IWalletRepository
    {
        public int GetLargestId() => WalletDAO.GetLargestId();

        public Wallet GetWalletByCustomerId(int customerId) => WalletDAO.GetWalletByCustomerId(customerId);

        public void SaveWalletTransaction(WalletTransaction walletTransaction) => WalletDAO.SaveWalletTransaction(walletTransaction);

        public void UpdateWallet(Wallet wallet) => WalletDAO.UpdateWallet(wallet);
    }
}
