using BusinessObjects;
using BussinessObject.Models;
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
using static System.Net.Mime.MediaTypeNames;

namespace SaleManagementWinApp
{
    public partial class frmRegister : Form
    {
        private ICustomerRepository _memberRepository = new CustomerRepository();
        private IWalletRepository _walletRepository = new WalletRepository();
        public frmRegister()
        {
            InitializeComponent();
            LoadInformation();
        }   
        private void LoadInformation()
        {
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        private bool IsEmptyInput()
        {
            return (txtCustomerName.Text.Trim().Equals("")) || (txtCustomerPassword.Text.Trim().Equals("")
                || (txtCustomerEmail.Text.Trim().Equals("")) || (txtPhoneNumber.Text.Trim().Equals("")));
        }
        
        private void btCreate_Click(object sender, EventArgs e)
        {
            if (!IsEmptyInput())
            {
                if (Validation.IsMail(txtCustomerEmail.Text) && !_memberRepository.IsPhoneExist(txtPhoneNumber.Text))
                {
                    Customer customer = new Customer()
                    {
                        CustomerId = _memberRepository.GetNewCustomerId(),
                        CustomerName = txtCustomerName.Text,
                        Email = txtCustomerEmail.Text,
                        Password = txtCustomerPassword.Text,
                        PhoneNumber = txtPhoneNumber.Text,
                    };
                    var add = _memberRepository.AddCustomer(customer);
                    if (add)
                    {
                        _walletRepository.CreateWallet(customer.CustomerId);
                        MessageBox.Show("Tạo thành công!", "Đăng ký", MessageBoxButtons.OK);
                        LoadInformation();
                    }
                    else
                    {
                        MessageBox.Show("Tạo thất bại!", "Đăng ký", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Sai định dạng email hooặc số điện thoại của bạn đã tạo!", "Đăng ký", MessageBoxButtons.OK);
                }
                
            }else
            {
                MessageBox.Show("Bạn phải điền đầy đủ thông tin", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
