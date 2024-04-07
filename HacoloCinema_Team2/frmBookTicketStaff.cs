using BussinessObject.Models;
using Repositories.BookTicket;
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
    public partial class frmBookTicketStaff : Form
    {
        List<string> selectedChairs = new List<string>();
        decimal ticketPrice = 0;
        decimal comboPrice = 0;
        decimal totalPrice = 0;
        int showtimeId;
        decimal price;
        IShowtimeRepository showtimeRepository = new ShowtimeRepository();
        IComboRepository comboRepository = new ComboRepository();
        ITicketRepository ticketRepository = new TicketRepository();
        IOrderRepository orderRepository = new OrderRepository();
        public frmBookTicketStaff(int showtimeId)
        {
            InitializeComponent();
            this.showtimeId = showtimeId;
        }

        private void frmBookTicketStaff_Load(object sender, EventArgs e)
        {
            LoadChair();
            LoadMovie();
            LoadCombo();
            LoadPayment();
        }
        private void LoadPayment()
        {
            // Tạo danh sách các mục cho ComboBox
            string[] values = new string[] { "Thanh toán bằng tiền mặt", "Thanh toán bằng chuyển khoản" };
            cboPayment.DataSource = values;
            cboPayment.SelectedIndex = 0;
        }
        private void LoadCombo()
        {
            try
            {
                // Đọc danh sách sản phẩm từ repo
                var comboList = comboRepository.GetCombos();

                // Đặt nguồn dữ liệu cho DataGridView
                dgvCombo.DataSource = comboList;

                dgvCombo.Columns["ComboName"].HeaderText = "Loại combo";
                dgvCombo.Columns["ComboName"].Width = 150;
                
                dgvCombo.Columns["ComboPrice"].HeaderText = "Đơn giá";
                dgvCombo.Columns["ComboPrice"].Width = 150;
                if (dgvCombo.Columns.Contains("ComboPrice"))
                {
                    // Set the format for the StartTime column to 24-hour time
                    dgvCombo.Columns["ComboPrice"].DefaultCellStyle.Format = "#,##0.00\\ VNĐ";
                }
                // Ẩn các cột không cần thiết
                dgvCombo.Columns["ComboId"].Visible = false;
                dgvCombo.Columns["OrderDetailCombos"].Visible = false;

                // Thêm cột checkbox
                if (!dgvCombo.Columns.Contains("IsSelected"))
                {
                    DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                    checkBoxColumn.Name = "IsSelected";
                    checkBoxColumn.HeaderText = "Chọn combo";
                    checkBoxColumn.Width = 100;
                    checkBoxColumn.ReadOnly = false;
                    dgvCombo.Columns.Insert(0, checkBoxColumn);
                }

                // Thêm cột số lượng
                if (!dgvCombo.Columns.Contains("Quantity"))
                {
                    DataGridViewTextBoxColumn quantityColumn = new DataGridViewTextBoxColumn();
                    quantityColumn.Name = "Quantity";
                    quantityColumn.HeaderText = "Nhập số lượng";
                    quantityColumn.Width = 150;
                    quantityColumn.ReadOnly = false;
                    dgvCombo.Columns.Insert(1, quantityColumn);
                }
                SetUpQuantityColumn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of combos");
            }
        }
        private void SetUpQuantityColumn()
        {
            foreach (DataGridViewRow row in dgvCombo.Rows)
            {
                DataGridViewTextBoxCell quantityCell = row.Cells["Quantity"] as DataGridViewTextBoxCell;
                quantityCell.Value = "0"; // Mặc định là 0

                // Đặt Tag của ô số lượng với số lượng tối đa cho phép
                quantityCell.Tag = 10;
            }
        }
        private void LoadMovie()
        {
            var showtimeDetails = showtimeRepository.GetShowtimeDetails(showtimeId);
            if (showtimeDetails != null)
            {
                lblMovieName.Text = showtimeDetails.Movie.MovieName;
                lblTheaterName.Text = showtimeDetails.Theater.TheaterName;
                lblShowTime.Text = showtimeDetails.StartTime.ToString("HH:mm");

                if (showtimeDetails.PricingSchedule != null)
                {
                    price = showtimeDetails.PricingSchedule.Price ?? default;
                }
            }
            else
            {
                // Handle case when showtime details are not found
                MessageBox.Show("Showtime details are not available.");
            }
        }

        private void LoadChair()
        {
            tlbChair.Controls.Clear();
            int ghe = 1;
            char hangCuoi = 'K'; // Ký tự của hàng cuối cùng
            for (int i = 0; i < tlbChair.RowCount; i++)
            {
                char hang;
                if (i == tlbChair.RowCount - 1) // Nếu đây là hàng cuối cùng
                    hang = hangCuoi;
                else
                    hang = (char)('A' + i);

                for (int j = 0; j < tlbChair.ColumnCount; j++)
                {
                    Label lblGhe = new Label();
                    lblGhe.Text = $"{hang}{ghe}";
                    lblGhe.AutoSize = false;
                    lblGhe.Dock = DockStyle.Fill;
                    lblGhe.TextAlign = ContentAlignment.MiddleCenter;
                    lblGhe.Width = lblGhe.Height = 50;
                    if (ticketRepository.IsSeatBooked(showtimeId, lblGhe.Text))
                    {
                        lblGhe.BackColor = Color.Yellow;
                    }
                    else
                    {
                        lblGhe.BackColor = Color.White;
                    }
                    tlbChair.Controls.Add(lblGhe, j, i);
                    ghe++;
                    lblGhe.Click += LblGhe_Click;
                }
                ghe = 1;
            }
        }
        private void LblGhe_Click(object sender, EventArgs e)
        {
            Label lblGhe = sender as Label;

            if (selectedChairs.Count >= 10 && lblGhe.BackColor == Color.White)
            {
                MessageBox.Show("Bạn chỉ có thể chọn tối đa 10 ghế.");
                return;
            }

            if (lblGhe.BackColor == Color.White)
            {
                lblGhe.BackColor = Color.Green;
                selectedChairs.Add(lblGhe.Text);
            }
            else if (lblGhe.BackColor == Color.Green)
            {
                lblGhe.BackColor = Color.White;
                selectedChairs.Remove(lblGhe.Text);
            }
            else if (lblGhe.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế số [" + lblGhe.Text + "] đã có người đặt rồi");
            }

            lblChair.Text = "Ghế " + String.Join(" ", selectedChairs);
            //price per chair from PricingSchedule
            ticketPrice = price * selectedChairs.Count();
            totalPrice = ticketPrice + comboPrice;
            lblTicketPrice.Text = ticketPrice.ToString() + " VNĐ";
            lblTotalPrice.Text = totalPrice.ToString() + " VNĐ";
            btnCheckout.Enabled = selectedChairs.Count > 0;
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Bạn có chắc chắn thanh toán đơn hàng này?", "Thanh toán đơn", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (d == DialogResult.OK)
                {
                    Order newOrder = new Order
                    {
                        OrderId = orderRepository.GetMaxOrderId() + 1, // GetMaxOrderId lấy ID đơn hàng lớn nhất và cộng thêm 1
                        OrderDate = DateTime.Now,
                        // ShippedDate để null vì chưa giao
                        // Total để null hoặc tính toán tổng giá trị đơn hàng nếu cần
                        TotalPrice = Convert.ToDecimal(totalPrice),
                        PaymentId = cboPayment.SelectedIndex == 0 ? 1 : 2,
                        OrderStatus = 3
                    };
                    foreach (DataGridViewRow row in dgvCombo.Rows)
                    {
                        bool isSelected = Convert.ToBoolean(row.Cells["IsSelected"].Value);
                        if (isSelected)
                        {
                            int comboId = Convert.ToInt32(row.Cells["ComboId"].Value);
                            int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);

                            // Tạo OrderDetail mới
                            OrderDetailCombo orderDetailCombo = new OrderDetailCombo
                            {
                                OrderId = newOrder.OrderId, // ID của đơn hàng mới
                                ComboId = comboId,
                                Quantity = quantity
                            };

                            // Thêm vào đơn đặt hàng
                            newOrder.OrderDetailCombos.Add(orderDetailCombo);

                        }
                    }
                    orderRepository.SaveOrder(newOrder);
                    foreach (string chair in selectedChairs)
                    {
                        Ticket ticket = new Ticket
                        {
                            TicketId = ticketRepository.GetMaxTicketId() + 1,
                            OrderId = newOrder.OrderId,
                            ShowtimeId = showtimeId,
                            SeatId = ticketRepository.getSeatBySeatPosition(chair).SeatId,
                            TicketPrice = price,
                            IsSold = true,
                        };
                        ticketRepository.SaveTicket(ticket);
                    }
                    selectedChairs.Clear();
                    LoadChair();
                    LoadMovie();
                    LoadCombo();
                    lblChair.Text = "Ghế";
                    lblTicketPrice.Text = "0.00 VNĐ";
                    lblTotalPrice.Text = "0.00 VNĐ";
                    btnCheckout.Enabled = false;
                }
                // Tạo đơn đặt hàng mới

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while processing the order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCombo_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra để tránh xử lý tiêu đề của cột
            {
                if (e.ColumnIndex == dgvCombo.Columns["IsSelected"].Index || e.ColumnIndex == dgvCombo.Columns["Quantity"].Index)
                {
                    UpdateTotal();
                }
            }
            if (dgvCombo.Columns.Contains("IsSelected") && e.ColumnIndex == dgvCombo.Columns["IsSelected"].Index && e.RowIndex != -1)
            {
                DataGridViewCheckBoxCell checkCell = dgvCombo.Rows[e.RowIndex].Cells["IsSelected"] as DataGridViewCheckBoxCell;
                bool isChecked = (bool)checkCell.Value;

                // Nếu sản phẩm không được chọn, set 'Quantity' về 0
                if (!isChecked)
                {
                    dgvCombo.Rows[e.RowIndex].Cells["Quantity"].Value = 0;
                }
            }
            else if (dgvCombo.Columns.Contains("Quantity") && e.ColumnIndex == dgvCombo.Columns["Quantity"].Index)
            {
                // Kiểm tra giá trị số lượng nhập vào không vượt quá UnitsInStock
                DataGridViewRow row = dgvCombo.Rows[e.RowIndex];
                int quantity;
                if (!int.TryParse(Convert.ToString(row.Cells["Quantity"].Value), out quantity))
                {
                    quantity = 0; // If the value is not valid, set it to 0
                }

                if (quantity > 10)
                {
                    MessageBox.Show("Chỉ được đặt số lượng tối đa là 10");
                    row.Cells["Quantity"].Value = 10; // Đặt lại giá trị nếu vượt quá số lượng tồn kho
                }
            }
        }
        private void UpdateTotal()
        {
            comboPrice = 0;

            foreach (DataGridViewRow row in dgvCombo.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["IsSelected"].Value);
                if (isSelected)
                {
                    int quantity;
                    if (int.TryParse(row.Cells["Quantity"].Value?.ToString(), out quantity))
                    {
                        decimal unitPrice = Convert.ToDecimal(row.Cells["ComboPrice"].Value);
                        comboPrice += quantity * unitPrice;
                    }
                }
            }

            lblComboPrice.Text = comboPrice.ToString("N2") + " VNĐ"; // "N2" formats the number with two decimal places
            totalPrice = comboPrice + ticketPrice;
            lblTotalPrice.Text = totalPrice.ToString("N2") + " VNĐ"; // "N2" formats the number with two decimal places
        }

        private void dgvCombo_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // Check if we are in the "Quantity" column.
            if (dgvCombo.Columns.Contains("Quantity") && dgvCombo.Columns[e.ColumnIndex].Name == "Quantity")
            {
                // Check if the "IsSelected" checkbox is not checked.
                bool isSelected = Convert.ToBoolean(dgvCombo.Rows[e.RowIndex].Cells["IsSelected"].Value);
                if (!isSelected)
                {
                    // Cancel the editing.
                    e.Cancel = true;
                }
            }
        }

        private void dgvCombo_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem ô được chỉnh sửa có phải là cột "Quantity" không
            if (dgvCombo.Columns.Contains("Quantity") && dgvCombo.Columns[e.ColumnIndex].Name == "Quantity")
            {
                int quantity;
                if (int.TryParse(dgvCombo.Rows[e.RowIndex].Cells["Quantity"].Value?.ToString(), out quantity))
                {
                    // Nếu số lượng nhỏ hơn hoặc bằng 0, hiển thị thông báo và set giá trị về 1
                    if (quantity <= 0)
                    {
                        MessageBox.Show("Số lượng không hợp lệ");
                        dgvCombo.Rows[e.RowIndex].Cells["Quantity"].Value = 1;
                    }
                }
                else
                {
                    // Nếu giá trị không phải là số nguyên, hiển thị thông báo và set giá trị về 1
                    MessageBox.Show("Số lượng không hợp lệ");
                    dgvCombo.Rows[e.RowIndex].Cells["Quantity"].Value = 1;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
