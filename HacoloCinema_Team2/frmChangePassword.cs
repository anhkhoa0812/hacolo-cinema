using BussinessObject.Models;
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

namespace HacoloCinema_Team2
{
    public partial class frmChangePassword : Form
    {
        private ICustomerRepository _customerRepository = new CustomerRepository();
        public Customer Customer { get; set; }
        public frmChangePassword(Customer customer)
        {
            InitializeComponent();
            this.Customer = customer;
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(this.Customer.Password);
            if (txtOldPassword.Text.Trim().Equals(this.Customer.Password))
                
            {
                if (txtConfirmPassword.Text.Trim().Equals(txtNewPassword.Text.Trim()))
                {
                    this.Customer.Password = txtNewPassword.Text.Trim();
                    if (_customerRepository.UpdateCustomer(this.Customer))
                    {
                        MessageBox.Show("Đổi thành công", "Đổi mật khẩu");
                    }
                    else
                    {
                        MessageBox.Show("Đổi thất bại", "Đổi mật khẩu");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới và mật khẩu xác nhận không giống nhau", "Đổi mật khẩu");
                }
            }
            else
            {
                MessageBox.Show("Sai mật khẩu cũ", "Đổi mật khẩu");
            }
        }
    }
}
