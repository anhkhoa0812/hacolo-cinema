using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.movieandorder
{
    public class WalletTransactionDAO
    {
        public static WalletTransactionDAO instance = null;
        private static object lockObject = new object();

        public static WalletTransactionDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new WalletTransactionDAO();
                }
                return instance;
            }
        }

        public WalletTransactionDAO() { }

        public void CreateWalletTransaction(WalletTransaction walletTransaction)
        {
            using var db = new HacoloCinemaContext();
            db.WalletTransactions.Add(walletTransaction);
            db.SaveChanges();
        }

        public int GetLargestId()
        {
            using var db = new HacoloCinemaContext();
            int largestId = db.WalletTransactions.Max(wt => (int?)wt.WalletTransactionId) ?? 0;
            return largestId;
        }

        public List<WalletTransaction> GetWalletTransactionsByWalletId(int walletId)
        {
            using var db = new HacoloCinemaContext();
            return db.WalletTransactions.ToList().Where(wt => wt.WalletId == walletId).ToList();
        }
    }
}
