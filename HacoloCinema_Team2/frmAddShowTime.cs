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

namespace HacoloCinema_Team2
{
    public partial class frmAddShowTime : Form
    {
        private ITheaterRepository _theaterRepository = new TheaterRepository();
        private IShowtimeRepository _showtimeRepository = new ShowtimeRepository();
        private IMovieRepository _movieRepository = new MovieRepository();
        private IPricingScheduleRepository _pricingScheduleRepository = new PricingScheduleRepository();
        public delegate void CancelEventHandler(object sender, EventArgs e);
        public event CancelEventHandler Cancel;
        private List<Movie> Movies { get; set; }
        private int ShowtimeId { get; set; }
        public frmAddShowTime()
        {
            InitializeComponent();
            this.ShowtimeId = _showtimeRepository.GenerateShowTimeIdAutomatically();
        }

        private void frmAddShowTime_Load(object sender, EventArgs e)
        {
            txtShowtimeId.Text = ShowtimeId.ToString();
            LoadMovieIntoCmbMovie();
            LoadTheaterIntoCmbTheater();
            LoadPricingScheduleIntoCmb();
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = " ";
        }

        private void LoadTheaterIntoCmbTheater()
        {
            var theaters = _theaterRepository.GetTheaters();
            cmbTheater.Items.Clear();
            cmbTheater.DataSource = theaters;
            cmbTheater.DisplayMember = "TheaterName";
            cmbTheater.Text = "Select theater";

        }
        private void LoadMovieIntoCmbMovie()
        {
            var movies = _movieRepository.GetMovies();
            this.Movies = movies;
            cmbMovie.DataSource = null;
            cmbMovie.DataSource = movies;
            cmbMovie.DisplayMember = "MovieName";
            cmbMovie.Text = "Select movie";
        }
        private void LoadPricingScheduleIntoCmb()
        {
            var pricingschedules = _pricingScheduleRepository.GetPricingSchedules();
            cmbPricingShedule.DataSource = null;
            cmbPricingShedule.DataSource = pricingschedules;
            cmbPricingShedule.DisplayMember = "Description";
            cmbPricingShedule.Text = "Select pricing schedule";
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel?.Invoke(this, new EventArgs());
            this.Close();
        }
        private void txtSearchFilmValue_TextChanged(object sender, EventArgs e)
        {
            cmbMovie.DataSource = null;
            var movies = _movieRepository.GetMovies();

            if (!txtSearchFilmValue.Text.Trim().Equals("")
                && !txtSearchFilmValue.Text.Equals("Select movie"))
            {
                this.Movies = movies.Where(f => f.MovieName.Contains(txtSearchFilmValue.Text.Trim())).ToList();
            }
            else
            {
                this.Movies = movies;
            }
            cmbMovie.DataSource = this.Movies;
            cmbMovie.DisplayMember = "MovieName";
            cmbMovie.Text = "Select movie";
        }

        private void chkSortDesendingByDate_CheckedChanged(object sender, EventArgs e)
        {
            var movies = this.Movies;
            if (chkSortDesendingByDate.Checked)
            {
                this.Movies = movies.OrderByDescending(f => f.ReleaseDay).ToList();
                chkSortDesendingByDate.Enabled = false;
            }
            cmbMovie.DataSource = this.Movies;
            cmbMovie.DisplayMember = "MovieName";
            cmbMovie.Text = "Select movie";
        }
        public bool IsEmpty()
        {
            return (txtShowtimeId.Text.Trim().Equals("") || (cmbMovie.Text.Trim().Equals("Select movie"))||
                (cmbPricingShedule.Text.Trim().Equals("Select pricing schedule")) || cmbTheater.Text.Trim().Equals("Select theater") ||
                dtpDate.Text.Trim().Equals("")|| (cmbPricingShedule.SelectedIndex == -1) ||
                txtTime.Text.Trim().Equals("") || (cmbMovie.SelectedIndex == -1) || (cmbTheater.SelectedIndex == -1));
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!IsEmpty())
            {
                var movie = (Movie)cmbMovie.SelectedItem;
                var theater = (Theater)cmbTheater.SelectedItem;
                var pricingschedule = (PricingSchedule)cmbPricingShedule.SelectedItem;
                Showtime showtime = new Showtime()
                {
                    ShowtimeId = this.ShowtimeId,
                    MovieId = movie.MovieId,
                    TheaterId = theater.TheaterId,
                    PricingScheduleId = pricingschedule.PricingScheduleId,
                    ShowDate = DateOnly.FromDateTime(dtpDate.Value),
                    StartTime = TimeOnly.Parse(txtTime.Text),
                    ShowtimeStatus = true,
                };
                var check = _showtimeRepository.IsShowTimeIntersection(showtime);
                if (!check)
                {
                    var change = _showtimeRepository.AddShowtime(showtime);
                    if (change)
                    {
                        MessageBox.Show("Save successfully!", "Add showtime", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.ShowtimeId = _showtimeRepository.GenerateShowTimeIdAutomatically();
                        txtShowtimeId.Text = this.ShowtimeId.ToString();
                        if (cmbTheater.SelectedIndex != -1 && dtpDate != null)
                        {
                            DateOnly showDate = DateOnly.FromDateTime(dtpDate.Value.Date);
                            var selectedTheater = (Theater)cmbTheater.SelectedItem;
                            txtTime.Text = _theaterRepository.GetTheaterNextShowTime(selectedTheater.TheaterId, showDate).ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Fail to save!", "Add showtime", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                else
                {
                    MessageBox.Show("Showtimes conflict!", "Add showtime", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("All fields are required!", "Add showtime", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbTheater_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTheater.SelectedIndex != -1 && dtpDate != null)
            {
                DateOnly showDate = DateOnly.FromDateTime(dtpDate.Value.Date);
                var theater = (Theater)cmbTheater.SelectedItem;
                txtTime.Text = _theaterRepository.GetTheaterNextShowTime(theater.TheaterId, showDate).ToString();
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDate.Checked)
            {
                if (dtpDate.Value > DateTime.Now)
                {
                    dtpDate.CustomFormat = "dd/MM/yyyy";
                    if (cmbTheater.SelectedIndex != -1 && !dtpDate.Text.Trim().Equals(""))
                    {
                        DateOnly showDate = DateOnly.FromDateTime(dtpDate.Value.Date);
                        var theater = (Theater)cmbTheater.SelectedItem;
                        txtTime.Text = _theaterRepository.GetTheaterNextShowTime(theater.TheaterId, showDate).ToString();
                    }
                }
                else
                {
                     MessageBox.Show("Chọn ngày ở quá khứ", "Thêm giờ chiếu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtpDate.Value = DateTime.Now.AddDays(1);
                }
            }
            else
            {
                dtpDate.CustomFormat = "";
            }
        }
    }
}
