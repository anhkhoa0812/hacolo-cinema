using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.movieandorder
{
    public class WalletDAO
    {
        private static WalletDAO instance = null;
        private static object lockObject = new object();

        public static WalletDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new WalletDAO();
                }
                return instance;
            }
        }
        public WalletDAO() { }

        public Wallet GetWalletByCustomerId(int customerId)
        {
            using var db = new HacoloCinemaContext();
            return db.Wallets.FirstOrDefault(w => w.CustomerId == customerId);
        }
        public void UpdateWallet(Wallet wallet)
        {
            using var db = new HacoloCinemaContext();
            db.Wallets.Update(wallet);
            db.SaveChanges();
        }
    }
}
