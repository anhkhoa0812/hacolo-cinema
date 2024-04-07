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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HacoloCinema_Team2
{
    public partial class frmCustomerManagement : Form
    {
        private ICustomerRepository _customerRepository = new CustomerRepository();
        private IOrderRepository _orderRepository = new OrderRepository();
        private readonly List<string> filterOptions = new List<string> { "", "A-Z", "Z-A" };
        public frmCustomerManagement()
        {
            InitializeComponent();
        }
        private void frmCustomerManagement_Load(object sender, EventArgs e)
        {
            dgvCustomerList.ReadOnly = true;
            LoadCmbFilter();
            LoadCustomers(GetCustomers());
            ReadOnlyText(true);
        }
        private List<Customer> GetCustomers()
        {
            return _customerRepository.GetCustomers();
        }
        private List<Order> GetOrdersByCustomerId(int customerId)
        {
            return _orderRepository.GetOrdersByCustomerId(customerId);
        }
        private List<Customer> GetCustomersByName(string name)
        {
            return _customerRepository.GetCustomerByName(name);
        }
        private void LoadCmbFilter()
        {
            cmbFilter.Items.Clear();
            cmbFilter.DataSource = filterOptions;
        }
        private void LoadCustomers(List<Customer> customerList)
        {
            try
            {
                BindingSource source = new BindingSource();
                source.DataSource = customerList;

                txtCustomerId.DataBindings.Clear();
                txtCustomerName.DataBindings.Clear();
                txtCustomerEmail.DataBindings.Clear();
                txtPhoneNumber.DataBindings.Clear();

                txtCustomerId.DataBindings.Add("Text", source, "CustomerId");
                txtCustomerName.DataBindings.Add("Text", source, "CustomerName");
                txtCustomerEmail.DataBindings.Add("Text", source, "Email");
                txtPhoneNumber.DataBindings.Add("Text", source, "PhoneNumber");
                dgvCustomerList.DataSource = null;
                dgvCustomerList.DataSource = customerList;
                dgvCustomerList.Columns["Password"].Visible = false;
                dgvCustomerList.Columns["Orders"].Visible = false;
                dgvCustomerList.Columns["Wallets"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load customers");
            }
        }
        private void dgvCustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ClearText();
                DataGridViewRow row = this.dgvCustomerList.Rows[e.RowIndex];
                txtCustomerId.Text = row.Cells["CustomerId"].Value.ToString();
                txtCustomerName.Text = row.Cells["CustomerName"].Value.ToString();
                txtCustomerEmail.Text = row.Cells["Email"].Value.ToString();
                txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCustomerManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void txtSearchValue_TextChanged(object sender, EventArgs e)
        {
            if (!(txtSearchValue.Text.Trim().Equals("")))
            {
                //ClearText();
                LoadCustomers(GetCustomersByName(txtSearchValue.Text));
            }
            else
            {
                LoadCustomers(GetCustomers());
                cmbFilter.SelectedIndex = 0;
            }
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            var customerList = new List<Customer>();
            if (!(txtSearchValue.Text.Trim().Equals("")))
            {
                customerList = GetCustomersByName(txtSearchValue.Text);
            }
            else
            {
                customerList = GetCustomers();
            }
            if (customerList.Count > 0)
            {
                if (cmbFilter.SelectedIndex == 1)
                {
                    LoadCustomers(customerList.OrderBy(f => f.CustomerName).ToList());
                }
                else if (cmbFilter.SelectedIndex == 2)
                {
                    LoadCustomers(customerList.OrderByDescending(f => f.CustomerName).ToList());
                }
            }
        }
        public void ClearText()
        {
            txtCustomerId.Text = "";
            txtCustomerName.Text = "";
            txtCustomerEmail.Text = "";
            txtPhoneNumber.Text = "";
        }
        private void ReadOnlyText(bool status)
        {
            txtCustomerId.ReadOnly = status;
            txtCustomerName.ReadOnly = status;
            txtCustomerEmail.ReadOnly = status;
            txtPhoneNumber.ReadOnly = status;
        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            var customerOrder = _orderRepository.GetOrdersByCustomerId(int.Parse(txtCustomerId.Text));
            if ( customerOrder.Count > 0 )
            {
                frmCutomerOrderHistory frmCutomerOrderHistory = new frmCutomerOrderHistory();
                frmCutomerOrderHistory.CustomerId = int.Parse(txtCustomerId.Text);
                frmCutomerOrderHistory.ShowDialog();
            }
            else
            {
                MessageBox.Show("Khách hàng không có đơn hàng nào!", "Quản lý khách hàng", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            
        }
    }
}
