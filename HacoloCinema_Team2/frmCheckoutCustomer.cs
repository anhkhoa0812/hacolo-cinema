using BussinessObject.Models;
using Repositories.BookTicket;
using Microsoft.EntityFrameworkCore;
using Repositories;
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
    public partial class frmCheckoutCustomer : Form
    {
        int orderId;
        int customerId;
        decimal? balanceWallet = 0;
        decimal? totalPrice = 0;
        IOrderRepository orderRepository = new OrderRepository();
        ITicketRepository ticketRepository = new TicketRepository();
        IOrderDetailComboRepository orderDetailComboRepository = new OrderDetailComboRepository();
        IWalletRepository walletRepository = new WalletRepository();
        public frmCheckoutCustomer(int orderId, int customerId)
        {
            InitializeComponent();
            InitializeCountdownTimer();
            this.orderId = orderId;
            this.customerId = customerId;
        }
        private void InitializeCountdownTimer()
        {
            countdownTimer = new System.Windows.Forms.Timer();
            countdownTimer.Interval = 1000; // Timer will tick every second.
            countdownTimer.Tick += new EventHandler(CountdownTimer_Tick);
            countdownTimer.Start();
        }

        private TimeSpan timeLeft = TimeSpan.FromMinutes(5); // Set the countdown time here.

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            if (timeLeft.TotalSeconds <= 0)
            {
                countdownTimer.Stop();
                label4.Text = "00:00"; // Update the label to show the time is up.
                CancelOrder();
                MessageBox.Show("Thời gian giữ ghế của bạn đã hết");
                this.Close(); // Close the form.
            }
            else
            {
                timeLeft = timeLeft.Subtract(TimeSpan.FromSeconds(1));
                label4.Text = timeLeft.ToString("mm':'ss"); // Update the label to show the remaining time.
            }
        }

        private void frmCheckoutCustomer_Load(object sender, EventArgs e)
        {
            LoadTicketList();
            LoadComboList();
            Order order = orderRepository.getOrderById(orderId);
            totalPrice = order.TotalPrice;
            
            lblTotalPrice.Text = totalPrice?.ToString("N2") + " VND";
            
            Wallet wallet = walletRepository.GetWalletByCustomerId(customerId);
            balanceWallet = wallet.WalletBalance;
            lblBalanceAccount.Text = "Số tiền trong ví: " + wallet.WalletBalance?.ToString("N2") + " VNĐ";
        }
        private void LoadTicketList()
        {
            var ticketList = ticketRepository.GetTicketsByOrderId(orderId);
            dgvTicketList.DataSource = ticketList;
            dgvTicketList.Columns["MovieName"].HeaderText = "Tên phim";
            dgvTicketList.Columns["MovieName"].Width = 120;
            dgvTicketList.Columns["ShowDate"].HeaderText = "Ngày";
            dgvTicketList.Columns["ShowDate"].Width = 100;
            dgvTicketList.Columns["StartTime"].HeaderText = "Thời gian chiếu";
            dgvTicketList.Columns["StartTime"].Width = 170;
            if (dgvTicketList.Columns.Contains("StartTime"))
            {
                // Set the format for the StartTime column to 24-hour time
                dgvTicketList.Columns["StartTime"].DefaultCellStyle.Format = "HH:mm";
            }
            dgvTicketList.Columns["SeatPosition"].HeaderText = "Ghế";
            dgvTicketList.Columns["SeatPosition"].Width = 100;
            dgvTicketList.Columns["TicketPrice"].HeaderText = "Giá vé";
            dgvTicketList.Columns["TicketPrice"].Width = 120;
            if (dgvTicketList.Columns.Contains("TicketPrice"))
            {
                // Set the format for the StartTime column to 24-hour time
                dgvTicketList.Columns["TicketPrice"].DefaultCellStyle.Format = "#,##0.00\\ VNĐ";
            }
        }
        private void LoadComboList()
        {
            var comboList = orderDetailComboRepository.GetOrderDetailCombosByOrderId(orderId);
            dgvComboList.DataSource = comboList;
            dgvComboList.Columns["ComboName"].HeaderText = "Loại combo";
            dgvComboList.Columns["ComboName"].Width = 150;
            dgvComboList.Columns["ComboPrice"].HeaderText = "Đơn giá";
            dgvComboList.Columns["ComboPrice"].Width = 150;
            dgvComboList.Columns["Quantity"].HeaderText = "Số lượng";
            dgvComboList.Columns["Quantity"].Width = 150;
        }
        private void CancelOrder()
        {
            List<Ticket> ticketList = ticketRepository.GetTicketListByOrderId(orderId);
            foreach (Ticket ticket in ticketList)
            {
                ticket.IsSold = false;
                ticketRepository.UpdateTicket(ticket);
            }
            Order order = orderRepository.getOrderById(orderId);
            order.OrderStatus = 2;
            orderRepository.UpdateOrder(order);
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if(balanceWallet >= totalPrice)
            {
                DialogResult d = MessageBox.Show("Bạn có chắc chắn muốn thanh toán hóa đơn", "Thanh toán đơn", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (d == DialogResult.OK)
                {
                    Wallet wallet = walletRepository.GetWalletByCustomerId(customerId);
                    wallet.WalletBalance = balanceWallet - totalPrice;
                    WalletTransaction walletTransaction = new WalletTransaction()
                    {
                        WalletTransactionId = walletRepository.GetLargestId() + 1,
                        WalletId = wallet.WalletId,
                        TransactionAmount = -totalPrice,
                        TransactionDate = DateTime.Now
                    };
                    walletRepository.UpdateWallet(wallet);
                    walletRepository.SaveWalletTransaction(walletTransaction);
                    Order order = orderRepository.getOrderById(orderId);
                    order.OrderStatus = 3;
                    orderRepository.UpdateOrder(order);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Số dư trong ví bạn không đủ!! Vui lòng nạp thêm", "Ví không đủ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có chắc chắn muốn hủy đơn", "Hủy đơn vé", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                CancelOrder();
                this.Close();
            }
        }
    }
}
