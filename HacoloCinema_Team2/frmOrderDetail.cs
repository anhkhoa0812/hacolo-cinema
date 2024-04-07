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
    public partial class frmOrderDetail : Form
    {
        ITicketRepository ticketRepo = new TicketRepository();
        IOrderDetailCombosRepository orderDetailCombosRepo = new OrderDetailCombosRepository();
        int orderId;
        public frmOrderDetail(int orderId)
        {
            InitializeComponent();
            this.orderId = orderId;
           
        }

        private void LoadTicket()
        {
            var list = ticketRepo.GetTicketsByOrderId(orderId);
            BindingSource ticketBindingSource = new BindingSource();
            ticketBindingSource.DataSource = list;

            txtTicketId.DataBindings.Clear();
            txtMovieName.DataBindings.Clear();
            txtTicketPrice.DataBindings.Clear();
            txtTheaterName.DataBindings.Clear();
            txtStartTime.DataBindings.Clear();
            txtSeatPosition.DataBindings.Clear();

            txtTicketId.DataBindings.Add("Text", ticketBindingSource, "TicketId");
            txtMovieName.DataBindings.Add("Text", ticketBindingSource, "Showtime.Movie.MovieName");
            txtTicketPrice.DataBindings.Add("Text", ticketBindingSource, "TicketPrice");
            txtTheaterName.DataBindings.Add("Text", ticketBindingSource, "Showtime.Theater.TheaterName");
            txtStartTime.DataBindings.Add("Text", ticketBindingSource, "Showtime.StartTime");
            txtSeatPosition.DataBindings.Add("Text", ticketBindingSource, "Seat.SeatPosition");
            dtpShowDate.DataBindings.Add("Text", ticketBindingSource, "Showtime.ShowDate", true, DataSourceUpdateMode.OnValidation, "", "MM/dd/yy")
                .DataSourceUpdateMode = DataSourceUpdateMode.OnValidation;

            dgvTicket.DataSource = null;
            dgvTicket.DataSource = ticketBindingSource;
        }

        private void LoadCombo()
        {
            var list = orderDetailCombosRepo.GetOrderDetailCombosByOrderId(orderId);
            BindingSource comboBindingSource = new BindingSource();
            comboBindingSource.DataSource = list;

            txtComboId.DataBindings.Clear();
            txtComboName.DataBindings.Clear();
            txtComboPrice.DataBindings.Clear();
            txtQuantity.DataBindings.Clear();


            txtComboId.DataBindings.Add("Text", comboBindingSource, "Combo.ComboId");
            txtComboName.DataBindings.Add("Text", comboBindingSource, "Combo.ComboName");
            txtComboPrice.DataBindings.Add("Text", comboBindingSource, "Combo.ComboPrice");
            txtQuantity.DataBindings.Add("Text", comboBindingSource, "Quantity");

            dgvCombo.DataSource = null;
            dgvCombo.DataSource = comboBindingSource;
        }

        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            LoadTicket();
            LoadCombo();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
