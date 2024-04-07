using Repositories;
using Repositories.movieandorder;
using System;
using System.Collections;
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
    public partial class frmOrder : Form
        {
            IOrderRepository orderRepo = new OrderRepository();
            BindingSource bindingSource;
            public frmOrder()
            {
                InitializeComponent();
            }

            private void LoadOrder()
            {
                var list = orderRepo.GetAll();
                bindingSource = new BindingSource();
                bindingSource.DataSource = list;

                txtOrderId.DataBindings.Clear();
                txtCustomerName.DataBindings.Clear();
                txtOrderStatus.DataBindings.Clear();
                txtPaymentMethod.DataBindings.Clear();
                txtTotalPrice.DataBindings.Clear();
                dtpOrderDate.DataBindings.Clear();

                txtOrderId.DataBindings.Add("Text", bindingSource, "OrderId");
                txtCustomerName.DataBindings.Add("Text", bindingSource, "Customer.CustomerName");
                txtOrderStatus.DataBindings.Add("Text", bindingSource, "OrderStatus");
                txtPaymentMethod.DataBindings.Add("Text", bindingSource, "Payment.PaymentMethod");
                txtTotalPrice.DataBindings.Add("Text", bindingSource, "TotalPrice");
                dtpOrderDate.DataBindings.Add("text", bindingSource, "OrderDate", true, DataSourceUpdateMode.OnValidation, "", "MM/dd/yy")
                   .DataSourceUpdateMode = DataSourceUpdateMode.OnValidation;

                dgvOrder.DataSource = null;
                dgvOrder.DataSource = bindingSource;
            dgvOrder.Columns["Customer"].Visible = false;
            dgvOrder.Columns["OrderDetailCombos"].Visible = false;
            dgvOrder.Columns["Payment"].Visible = false;
            dgvOrder.Columns["Tickets"].Visible = false;
        }

            private void frmOrder_Load(object sender, EventArgs e)
            {
                LoadOrder();
            }

            private void btnDetail_Click(object sender, EventArgs e)
            {
                frmOrderDetail frmOrderDetail = new frmOrderDetail(int.Parse(txtOrderId.Text));
                frmOrderDetail.ShowDialog();
            }

            private void btnPrint_Click(object sender, EventArgs e)
            { 
                try
                {
                    var order = orderRepo.GetOrderById(int.Parse(txtOrderId.Text));
                    if (order != null)
                    {
                        order.IsPrinted = true;
                        orderRepo.UpdateOrder(order);
                        MessageBox.Show("Print successfully", "Hacolo Cinema");
                        LoadOrder();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error when Print ticket: " + ex.Message, "Error");
                }
            }

            private void dgvOrder_SelectionChanged(object sender, EventArgs e)
            {
                var order = orderRepo.GetOrderById(int.Parse(txtOrderId.Text));
                if(order != null)
                {
                    if (order.IsPrinted)
                    {
                        btnPrint.Enabled = false;
                    }
                    else
                    {
                        btnPrint.Enabled = true;
                    }
                }
            }
        }
    }
