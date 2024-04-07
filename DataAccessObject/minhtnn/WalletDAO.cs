using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.minhtnn
{
    public class WalletDAO
    {
        public static WalletDAO instance;
        private static object lockObjecy = new object();
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

        public bool HaveWallet(int customerId)
        {
            using var db = new HacoloCinemaContext();
            var wallet = db.Wallets.SingleOrDefault(f => f.CustomerId == customerId);
            return wallet != null;
        }
        public int AutoGenerateWalletId()
        {
            using var db = new HacoloCinemaContext();
            return db.Wallets.Max(f => f.WalletId) + 1;
        }
        public bool CreateWallet(int customerId)
        {
            using var db = new HacoloCinemaContext();
            Wallet wallet = new Wallet()
            {
                CustomerId = customerId,
                WalletId = db.Wallets.Max(f => f.WalletId) + 1,
                WalletBalance = 0,
            };
            db.Wallets.Add(wallet);
            var change = db.SaveChanges();
            return change > 0;
        }
        public static int GetLargestId()
        {
            using var db = new HacoloCinemaContext();
            int largestId = db.WalletTransactions.Max(wt => (int?)wt.WalletTransactionId) ?? 0;
            return largestId;
        }
    }
}
