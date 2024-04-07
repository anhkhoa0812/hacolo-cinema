using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.BookTicket
{
    public class WalletDAO
    {
        public static Wallet GetWalletByCustomerId(int customerId)
        {
            Wallet wallet = null;
            try
            {
                using (var context = new HacoloCinemaContext())
                {
                    wallet = context.Wallets.SingleOrDefault(w => w.CustomerId == customerId);
                }
                return wallet;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void UpdateWallet(Wallet wallet)
        {
            try
            {
                using (var context = new HacoloCinemaContext())
                {
                    context.Wallets.Update(wallet);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void SaveWalletTransaction(WalletTransaction walletTransaction)
        {
            try
            {
                using (var context = new HacoloCinemaContext())
                {
                    context.WalletTransactions.Add(walletTransaction);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static int GetLargestId()
        {
            using var db = new HacoloCinemaContext();
            int largestId = db.WalletTransactions.Max(wt => (int?)wt.WalletTransactionId) ?? 0;
            return largestId;
        }
    }
}
