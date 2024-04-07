using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.movieandorder
{
    public interface IWalletRepository
    {
        Wallet GetWalletByCustomerId(int customerId);

        void UpdateWaller(Wallet wallet);
    }
}
