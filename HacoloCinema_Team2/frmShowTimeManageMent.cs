using BussinessObject.Models;
using DataAccessObject;
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
    public partial class frmShowtimeManagement : Form
    {
        IShowtimeRepository _showtimeRepository = new ShowtimeRepository();
        public frmShowtimeManagement()
        {
            InitializeComponent();
        }
        public List<Showtime> GetAllShowtime()
        {
            return _showtimeRepository.GetShowtimes();
        }
        private void LoadShowtimes()
        {
            try
            {
                var showtimesList = GetAllShowtime().Select(c => new
                {
                    ShowtimeID = c.ShowtimeId,
                    ShowtimeDate = c.ShowDate,
                    ShowtimeTime = c.StartTime,
                    MovieName = c.Movie?.MovieName,
                    TheaterName = c.Theater?.TheaterName,
                    Status = c.ShowtimeStatus ? "Release" : "Upcoming",
                }).ToList();
                BindingSource source = new BindingSource();
                source.DataSource = showtimesList;


                txtShowtimeId.DataBindings.Clear();
                txtTheaterId.DataBindings.Clear();
                txtMovieName.DataBindings.Clear();
                txtShowDate.DataBindings.Clear();
                txtTime.DataBindings.Clear();

                txtShowtimeId.DataBindings.Add("Text", source, "ShowtimeID");
                txtShowDate.DataBindings.Add("Text", source, "ShowtimeDate");
                txtMovieName.DataBindings.Add("Text", source, "MovieName");
                txtTheaterId.DataBindings.Add("Text", source, "TheaterName");
                txtTime.DataBindings.Add("Text", source, "ShowtimeTime");

                dgvShowTimeList.DataSource = null;
                dgvShowTimeList.DataSource = showtimesList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load showtimes");
            }
        }
        private void LoadShowtimes(object sender, EventArgs e)
        {
            try
            {
                var showtimesList = GetAllShowtime().Select(c => new
                {
                    ShowtimeID = c.ShowtimeId,
                    ShowtimeDate = c.ShowDate,
                    ShowtimeTime = c.StartTime,
                    MovieName = c.Movie?.MovieName,
                    TheaterName = c.Theater?.TheaterName,
                    Status = c.ShowtimeStatus ? "Release" : "Upcoming",
                }).ToList();
                BindingSource source = new BindingSource();
                source.DataSource = showtimesList;


                txtShowtimeId.DataBindings.Clear();
                txtTheaterId.DataBindings.Clear();
                txtMovieName.DataBindings.Clear();
                txtShowDate.DataBindings.Clear();
                txtTime.DataBindings.Clear();

                txtShowtimeId.DataBindings.Add("Text", source, "ShowtimeID");
                txtShowDate.DataBindings.Add("Text", source, "ShowtimeDate");
                txtMovieName.DataBindings.Add("Text", source, "MovieName");
                txtTheaterId.DataBindings.Add("Text", source, "TheaterName");
                txtTime.DataBindings.Add("Text", source, "ShowtimeTime");

                dgvShowTimeList.DataSource = null;
                dgvShowTimeList.DataSource = showtimesList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load showtimes");
            }
        }
        private void frmShowtimeManagement_Load(object sender, EventArgs e)
        {
            _showtimeRepository.UpdateShowtimeStatus();
            var showtimesList = GetAllShowtime();
            LoadShowtimes();
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.CustomFormat = " ";
            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.CustomFormat = " ";
        }

        private void dgvShowTimeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ClearText();
                DataGridViewRow row = this.dgvShowTimeList.Rows[e.RowIndex];
                txtShowtimeId.Text = row.Cells["ShowtimeID"].Value.ToString();
                txtMovieName.Text = row.Cells["MovieName"].Value.ToString();
                txtShowDate.Text = row.Cells["ShowtimeDate"].Value.ToString();
                txtTheaterId.Text = row.Cells["TheaterName"].Value.ToString();
                txtTime.Text = row.Cells["ShowtimeTime"].Value.ToString();
            }
        }
        private void ClearText()
        {
            txtShowtimeId.Text = "";
            txtTheaterId.Text = "";
            txtMovieName.Text = "";
            txtShowDate.Text = "";
            txtTime.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddShowTime_Click(object sender, EventArgs e)
        {
            frmAddShowTime frmAddShowTime = new frmAddShowTime();
            frmAddShowTime.Cancel += LoadShowtimes;
            frmAddShowTime.ShowDialog();
        }
        private void LoadShowtimeByStartEndDate(DateTime startDate, DateTime endDate)
        {
            var showtimesList = GetAllShowtime().Where(f =>
                    (f.ShowDate >= DateOnly.FromDateTime(startDate))
                    && (f.ShowDate <= DateOnly.FromDateTime(endDate))).OrderByDescending(f => f.ShowDate).Select(c => new
                    {
                        ShowtimeID = c.ShowtimeId,
                        ShowtimeDate = c.ShowDate,
                        ShowtimeTime = c.StartTime,
                        MovieName = c.Movie?.MovieName,
                        TheaterName = c.Theater?.TheaterName,
                        Status = c.ShowtimeStatus ? "Release" : "Upcoming",
                    }).ToList();
            BindingSource source = new BindingSource();
            source.DataSource = showtimesList;


            txtShowtimeId.DataBindings.Clear();
            txtTheaterId.DataBindings.Clear();
            txtMovieName.DataBindings.Clear();
            txtShowDate.DataBindings.Clear();
            txtTime.DataBindings.Clear();

            txtShowtimeId.DataBindings.Add("Text", source, "ShowtimeID");
            txtShowDate.DataBindings.Add("Text", source, "ShowtimeDate");
            txtMovieName.DataBindings.Add("Text", source, "MovieName");
            txtTheaterId.DataBindings.Add("Text", source, "TheaterName");
            txtTime.DataBindings.Add("Text", source, "ShowtimeTime");

            dgvShowTimeList.DataSource = null;
            dgvShowTimeList.DataSource = showtimesList;
        }
        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {

            if (dtpStartDate.Checked && dtpEndDate.Checked)
            {
                dtpStartDate.CustomFormat = "dd/MM/yyyy";
                if (dtpStartDate.Value <= dtpEndDate.Value)
                {
                    LoadShowtimeByStartEndDate(dtpStartDate.Value, dtpEndDate.Value);
                }
                else
                {
                    MessageBox.Show("Invalid period of time", "Showtime management"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            
            if (dtpStartDate.Checked && dtpEndDate.Checked)
            {
                dtpEndDate.CustomFormat = "dd/MM/yyyy";
                if (dtpStartDate.Value <= dtpEndDate.Value)
                {
                    LoadShowtimeByStartEndDate(dtpStartDate.Value, dtpEndDate.Value);
                }
                else
                {
                    MessageBox.Show("Invalid period of time", "Showtime management"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
