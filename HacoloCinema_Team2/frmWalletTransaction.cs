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
    public partial class frmWalletTransaction : Form
    {
        IWalletRepository walletRepo = new WalletRepository();
        IWalletTransactionRepository walletTransactionRepo = new WalletTransactionRepository();
        int id;
        public frmWalletTransaction(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void LoadWalletTransactionList()
        {
            var wallet = walletRepo.GetWalletByCustomerId(id);
            if (wallet != null)
            {
                var list = walletTransactionRepo.GetWalletTransactionsByWalletId(wallet.WalletId);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = list;

                txtWalletTransactionId.DataBindings.Clear();
                txtTransactionAmount.DataBindings.Clear();
                txtWalletId.DataBindings.Clear();

                txtWalletTransactionId.DataBindings.Add("Text", bindingSource, "WalletTransactionId");
                txtTransactionAmount.DataBindings.Add("Text", bindingSource, "TransactionAmount");
                txtWalletId.DataBindings.Add("Text", bindingSource, "WalletId");
                dtpTransactionDate.DataBindings.Add("text", bindingSource, "TransactionDate", true, DataSourceUpdateMode.OnValidation, "", "MM/dd/yy")
                .DataSourceUpdateMode = DataSourceUpdateMode.OnValidation;

                dgvWalletTransaction.DataSource = null;
                dgvWalletTransaction.DataSource = bindingSource;
            }
        }

        private void frmWalletTransaction_Load(object sender, EventArgs e)
        {
            LoadWalletTransactionList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
