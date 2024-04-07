using BussinessObject.Models;
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
    public partial class frmPhimDangChieu : Form
    {
        int customerId = 0;
        IMovieRepository movieRepo = new MovieRepository();
        public frmPhimDangChieu(int customerId)
        {
            InitializeComponent();
            AddControlsToPanel();
            LoadMovie();
            this.customerId = customerId;
        }
        private void AddControlsToPanel()
        {
            // Add some controls to the panel
            Panel my_panel = new Panel();
            VScrollBar vScroller = new VScrollBar();
            vScroller.Dock = DockStyle.Right;
            vScroller.Width = 30;
            vScroller.Height = 200;
            vScroller.Name = "VScrollBar2";
            my_panel.Controls.Add(vScroller);
        }

        private void LoadMovie()
        {
            var list = movieRepo.GetAll().Where(m => m.Status == true).ToList();
            for (int i = 1; i <= 8; i++)
            {
                GroupBox groupBox = Controls.Find("groupBox" + i, true).FirstOrDefault() as GroupBox;
                if (groupBox != null)
                {
                    if (i <= list.Count)
                    {
                        // Get the labels within the current GroupBox
                        Label labelMovieName = groupBox.Controls.Find("lblMovieName" + i, true).FirstOrDefault() as Label;
                        Label labelGenre = groupBox.Controls.Find("lblGenre" + i, true).FirstOrDefault() as Label;
                        Label labelDuration = groupBox.Controls.Find("lblDuration" + i, true).FirstOrDefault() as Label;
                        Label labelLimitAge = groupBox.Controls.Find("lblLimitAge" + i, true).FirstOrDefault() as Label;
                        PictureBox pictureBox = groupBox.Controls.Find("pictureBox" + i, true).FirstOrDefault() as PictureBox;
                        Button button = groupBox.Controls.Find("button" + i, true).FirstOrDefault() as Button;
                        Movie movie = list[i - 1];


                        if (movie != null)
                        {
                            labelMovieName.Text = movie.MovieName;
                            string genreNames = string.Join(", ", movie.Genres.Select(g => g.GenreName));
                            labelGenre.Text = genreNames;
                            labelDuration.Text = movie.Duration.ToString();
                            labelLimitAge.Text = movie.LimitAge.ToString();
                            if (movie.Image != null && movie.Image.Length > 0)
                            {
                                using (MemoryStream ms = new MemoryStream(movie.Image))
                                {

                                    pictureBox.Image = Image.FromStream(ms);

                                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                                }
                            }
                            button.Click += (sender, e) =>
                            {

                                int movieId = movie.MovieId;
                                OpenMovieDetailsForm(movieId, customerId);
                            };

                        }
                    }
                    else
                    {
                        // Hide the GroupBox if it's not needed
                        groupBox.Visible = false;
                    }
                }
            }


        }
        private void OpenMovieDetailsForm(int movieId, int customerId)
        {
            frmDetailMovie frmDetailMovie = new frmDetailMovie(movieId, customerId);
            frmDetailMovie.ShowDialog();
        }

        private void frmH_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
