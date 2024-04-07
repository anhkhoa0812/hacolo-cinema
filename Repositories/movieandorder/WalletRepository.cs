using BussinessObject.Models;
using DataAccessObject.movieandorder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.movieandorder
{
    public class WalletRepository : IWalletRepository
    {
        public Wallet GetWalletByCustomerId(int customerId) => WalletDAO.Instance.GetWalletByCustomerId(customerId);

        public void UpdateWaller(Wallet wallet) => WalletDAO.Instance.UpdateWallet(wallet);
    }
}