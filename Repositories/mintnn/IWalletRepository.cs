using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.mintnn
{
    public interface IWalletRepository
    {
        bool HaveWallet(int customerId);
        bool CreateWallet(int customerId);
    }
}
