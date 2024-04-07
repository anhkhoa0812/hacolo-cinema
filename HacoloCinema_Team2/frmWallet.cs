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

    public partial class frmWallet : Form
    {
        IWalletRepository walletRepo = new WalletRepository();
        int id = 0;
        public frmWallet(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        private void LoadWallet()
        {
            var wallet = walletRepo.GetWalletByCustomerId(id);
            if(wallet != null)
            {
                lblBalance.Text = wallet.WalletBalance.ToString();
            }
            
        }

        private void frmWallet_Load(object sender, EventArgs e)
        {
            LoadWallet();
        }

        private void btnWithdrawMoney_Click(object sender, EventArgs e)
        {
            frmWalletAction frmWalletAction = new frmWalletAction(id, btnWithdrawMoney.Text);
            frmWalletAction.ShowDialog();
        }

        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            frmWalletAction frmWalletAction = new frmWalletAction(id, btnAddMoney.Text);
            frmWalletAction.ShowDialog();
        }

        private void btnWalletTransaction_Click(object sender, EventArgs e)
        {
            frmWalletTransaction frmWalletTransaction = new frmWalletTransaction(id);
            frmWalletTransaction.ShowDialog();
        }
    }


}
