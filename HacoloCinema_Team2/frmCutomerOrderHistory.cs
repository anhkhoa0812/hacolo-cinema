using BussinessObject.Models;
using Repositories;
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

namespace HacoloCinema_Team2
{
    public partial class frmCutomerOrderHistory : Form
    {
        private IOrderRepository _orderRepository = new OrderRepository();
        private IOrderDetailRepository _orderDetailRepository = new OrderDetailRRepository();
        private ITicketRepository _ticketRepository = new TicketRepository();
        private IShowtimeRepository _showtimeRepository = new ShowtimeRepository();
        private IMovieRepository _movieRepository = new MovieRepository();
        public int CustomerId { get; set; }
        public frmCutomerOrderHistory()
        {
            InitializeComponent();
        }
        private List<Order> GetOrdersByCustomerId(int customerId)
        {
            return _orderRepository.GetOrdersByCustomerId(customerId);
        }
        private List<OrderDetailCombo> GetOrderDetailCombosByOrderId(int orderId)
        {
            return _orderDetailRepository.GetOrderDetailCombosByOrderId(orderId);
        }
        private void LoadOrderToCmbOrder()
        {
            cmbOrders.Items.Clear();
            cmbOrders.DataSource = GetOrdersByCustomerId(this.CustomerId);
            cmbOrders.DisplayMember = "OrderId";
            cmbOrders.SelectedIndex = 0;
        }
        private void LoadOrderDetail(int orderId)
        {
            try
            {
                var orderDetails = GetOrderDetailCombosByOrderId(orderId)
                    .Select(c => new
                    {
                        ComboId = c.ComboId,
                        ComboName = c.Combo?.ComboName,
                        Quantity = c.Quantity,
                        Price = c.Combo?.ComboPrice,
                        Sum = c.Quantity * c.Combo.ComboPrice,
                    }).ToList();
                BindingSource source = new BindingSource();
                source.DataSource = orderDetails;

                dgvOrderDetail.DataSource = orderDetails;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load customers");
            }
        }
        private void LoadTickets(int orderId)
        {
            try
            {
                var orderDetailsTicket = _ticketRepository.GetTicketsByOrderId(orderId).
                    Select(c => new
                    {
                        TicketId = c.TicketId,
                        OnAir = _showtimeRepository.GetShowtimeById(c.ShowtimeId).StartTime,
                        SeatName = _ticketRepository.GetTicketById(c.TicketId).Seat?.SeatPosition,
                        Movie = _movieRepository.GetMovieById(_showtimeRepository.GetShowtimeById(c.ShowtimeId).MovieId).MovieName,
                        Price = c.TicketPrice,
                    }).ToList();
                BindingSource source = new BindingSource();
                source.DataSource = orderDetailsTicket;

                dgvTickets.DataSource = orderDetailsTicket;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load customers");
            }
        }
        private void CutomerOrderHistory_Load(object sender, EventArgs e)
        {
            LoadOrderToCmbOrder();
            var cmbIndexValue = (Order)cmbOrders.SelectedItem;
            LoadOrderDetail(cmbIndexValue.OrderId);
            LoadTickets(cmbIndexValue.OrderId);
            txtOrderTotal.Text = _orderRepository.GetOrderPrice(cmbIndexValue.OrderId).ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cmbIndexValue = (Order)cmbOrders.SelectedItem;
            LoadOrderDetail(cmbIndexValue.OrderId);
            LoadTickets(cmbIndexValue.OrderId);
            txtOrderTotal.Text = _orderRepository.GetOrderPrice(cmbIndexValue.OrderId).ToString();
        }
    }
}
