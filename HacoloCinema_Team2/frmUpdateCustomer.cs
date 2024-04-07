using BusinessObjects;
using BussinessObject.Models;
using HacoloCinema_Team2;
using Repositories.mintnn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagementWinApp
{
    public partial class frmUpdateCustomer : Form
    {
        ICustomerRepository _memberRepository = new CustomerRepository();
        public delegate void CancelEventHandler(object sender, EventArgs e);
        public event CancelEventHandler Cancel;
        public Customer Customer { get; set; }
        public frmUpdateCustomer(Customer customer)
        {
            InitializeComponent();
            Customer = customer;
            LoadCustomer();
        }
        public void LoadCustomer()
        {
            txtCustomerName.Text = this.Customer.CustomerName;
            txtCustomerPassword.Text = this.Customer.Password;
            txtCustomerEmail.Text = this.Customer.Email;
            txtPhoneNumber.Text = this.Customer.PhoneNumber;
        }
        private bool IsEmptyInput()
        {
            return (txtCustomerName.Text.Trim().Equals("")) || (txtCustomerPassword.Text.Trim().Equals("")
               || txtPhoneNumber.Text.Trim().Equals("") || txtCustomerEmail.Text.Trim().Equals(""));
        }
        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (!IsEmptyInput())
            {
                Customer customer = new Customer()
                {
                    CustomerId = this.Customer.CustomerId,
                    CustomerName = txtCustomerName.Text.Trim(),
                    Email = txtCustomerEmail.Text.Trim(),
                    Password = txtCustomerPassword.Text.Trim(),
                    PhoneNumber = txtPhoneNumber.Text.Trim(),
                };
                var update = _memberRepository.UpdateCustomer(customer);
                if (update)
                {
                    MessageBox.Show("Update successfully!", "Update customer", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Failed to update!", "Update customer", MessageBoxButtons.OK);
                }

            }
            else
            {
                MessageBox.Show("All fields are required!", "Update customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel?.Invoke(this, new EventArgs());
            this.Close();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChangePassword = new frmChangePassword(this.Customer);
            frmChangePassword.ShowDialog();
        }
    }
}
