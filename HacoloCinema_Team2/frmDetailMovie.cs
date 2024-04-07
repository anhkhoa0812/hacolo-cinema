using BussinessObject.Models;
using DataAccessObject;
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
    public partial class frmDetailMovie : Form
    {
        private IMovieRepository movieRepository = new MovieRepository();
        private IShowtimeRepository showtimeRepository = new ShowtimeRepository();
        private Movie currentMovie;
        private int movieId;
        int customerId = 0;
        public frmDetailMovie(int movieId, int customerId)
        {
            InitializeComponent();
            this.movieId = movieId;
            this.customerId = customerId;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
            {
                // Parse the selected DateOnly directly from comboBox1
                DateOnly showDate = (DateOnly)comboBox1.SelectedItem;

                // Parse the selected time (string) back to TimeOnly from comboBox2
                TimeOnly startTime;
                if (TimeOnly.TryParse(comboBox2.SelectedItem.ToString(), out startTime))
                {
                    // Get showtimeId using both showDate and startTime
                    int? showtimeId = showtimeRepository.GetShowtimeIdByDateTime(showDate, startTime);

                    // Proceed to open the booking form if a valid showtimeId was found
                    if (showtimeId.HasValue)
                    {
                        //neu la customer thi vo form nay
                        if (customerId != 0)
                        {
                            frmBookTicketCustomer frmBookTicket = new frmBookTicketCustomer(showtimeId.Value, customerId);
                            frmBookTicket.ShowDialog();
                        }else
                        {
                            frmBookTicketStaff frm = new frmBookTicketStaff(showtimeId.Value);
                            frm.ShowDialog();
                        }
                        
                        //neu la admin thi vo form nay
                        //frmBookTicketStaff
                    }
                    else
                    {
                        MessageBox.Show("No showtime found for the selected date and time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid time format selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a date and time.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmDetailMovie_Load(object sender, EventArgs e)
        {
            LoadMovieDetails(movieId);
        }
        private void LoadMovieDetails(int movieId)
        {
            currentMovie = movieRepository.GetMovieById(movieId);

            // Assume that you have labels or other controls to set these values
            lblMovieName.Text = currentMovie.MovieName;
            label1.Text = string.Join(", ", currentMovie.Genres.Select(g => g.GenreName));
            label4.Text = currentMovie.Duration.ToString();
            label6.Text = currentMovie.ReleaseDay.HasValue ? currentMovie.ReleaseDay.Value.ToString("yyyy-MM-dd") : "N/A";
            label10.Text = currentMovie.LimitAge.ToString();
            label9.Text = currentMovie.Cast;
            label8.Text = currentMovie.Director;
            txtDescription.Text = currentMovie.Description;

            // Load show dates into comboBox1
            comboBox1.DataSource = movieRepository.GetShowDatesByMovieId(movieId).ToList();
            comboBox1.DisplayMember = "LongDateString"; // Format as needed
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is DateOnly showDate)
            {
                // Load start times into comboBox2 based on the selected show date
                var startTimes = movieRepository.GetStartTimesByMovieAndDate(currentMovie.MovieId, showDate)
                                          .Select(t => t.ToString("HH:mm")) // Convert TimeOnly to string in 24-hour format
                                          .ToList();

                comboBox2.DataSource = startTimes;
            }
        }
    }
}
