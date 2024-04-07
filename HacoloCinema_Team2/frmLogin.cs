using HacoloCinema_Team2;
using Repositories;
using Repositories.mintnn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagementWinApp
{
    public partial class frmLogin : Form
    {
        private ICustomerRepository _memberRepository = new CustomerRepository();
        public frmLogin()
        {
            InitializeComponent();
        }
        private bool IsEmpty()
        {
            return ((txtPhone.Text.Trim().Equals("")) || (txtPassword.Text.Trim().Equals("")));
        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            if (!IsEmpty())
            {
                frmMain frmMain = new frmMain();
                var customer = _memberRepository.GetCustomerByPhoneAndPassword(txtPhone.Text.Trim(), txtPassword.Text.Trim());
                if (customer != null)
                {
                    frmMain.Customer = customer;
                    MessageBox.Show("Chào mừng tới HacoloCinema", "Login", MessageBoxButtons.OK);
                    this.Hide();
                    frmMain.ShowDialog();
                }
                else if (customer == null)
                {
                    var admin = _memberRepository.GetAdmin();
                    if (txtPhone.Text.Trim().Equals(admin.Email) && txtPassword.Text.Trim().Equals(admin.Password))
                    {
                        frmMain.Admin = admin;
                        MessageBox.Show("Chào mừng admin", "Login", MessageBoxButtons.OK);
                        this.Hide();
                        frmMain.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Sai email hoặc mật khẩu!", "Login", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Sai email hoặc mật khẩu!", "Login", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu trống!", "Login", MessageBoxButtons.OK);
            }

        }
        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Bạn có muốn thoát?", "Login", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.ShowDialog();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Bạn có muốn thoát?", "Login", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
