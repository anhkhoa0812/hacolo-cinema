using BussinessObject.Models;
using DataAccessObject;
using Repositories;
using Repositories.movieandorder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HacoloCinema_Team2
{
    public partial class frmWalletAction : Form
    {
        IWalletRepository walletRepo = new WalletRepository();
        IWalletTransactionRepository walletTransactionRepo = new WalletTransactionRepository();
        int id;
        string text;
        public frmWalletAction(int id, string text)
        {
            InitializeComponent();
            this.id = id;
            if (text == "Nạp Tiền")
            {
                btnAction.Text = "Nạp";
            }
            else if (text == "Rút Tiền")
            {
                btnAction.Text = "Rút";
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (txtMoney.Text != "")
            {
                decimal money;
                if (!decimal.TryParse(txtMoney.Text, out money))
                {
                    MessageBox.Show("Invalid data", "Error");
                }
                var wallet = walletRepo.GetWalletByCustomerId(id);
                if (wallet != null)
                {
                    decimal moneyToAdd = decimal.Parse(txtMoney.Text);
                    if (moneyToAdd > 0)
                    {
                        if (btnAction.Text == "Nạp")
                        {
                            wallet.WalletBalance += money;
                            walletRepo.UpdateWaller(wallet);
                            var walletTransaction = new WalletTransaction()
                            {
                                WalletTransactionId = walletTransactionRepo.GetLargeId() + 1,
                                TransactionAmount = money,
                                TransactionDate = DateTime.Now,
                                WalletId = id
                            };
                            walletTransactionRepo.CreateWalletTransaction(walletTransaction);
                            MessageBox.Show("Nạp Thành Công", "Hacolo Cinema");
                        }
                        else if (btnAction.Text == "Rút")
                        {
                            if (wallet.WalletBalance < money)
                            {
                                MessageBox.Show("Số dư của bạn không đủ để rút", "Error");
                            }
                            else
                            {
                                wallet.WalletBalance -= money;
                                walletRepo.UpdateWaller(wallet);
                                var walletTransaction = new WalletTransaction()
                                {
                                    WalletTransactionId = walletTransactionRepo.GetLargeId() + 1,
                                    TransactionAmount = -money,
                                    TransactionDate = DateTime.Now,
                                    WalletId = id
                                };
                                walletTransactionRepo.CreateWalletTransaction(walletTransaction);
                                MessageBox.Show("Rút Thành Công", "Hacolo Cinema");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Số tiền không hợp lệ", "Lỗi");
                    }




                }
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
