using BussinessObject.Models;
using Microsoft.Identity.Client.NativeInterop;
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
    public partial class frmMovie : Form
    {
        IMovieRepository movieRepo = new MovieRepository();
        IGenreRepository genreRepo = new GenreRepository();
        public frmMovie()
        {
            InitializeComponent();
        }

        private void frmMovie_Load(object sender, EventArgs e)
        {
            LoadMovieList();
            LoadGenre();
            UpdateImage();
        }

        private void LoadMovieList()
        {
            try
            {
                var movieList = movieRepo.GetAll();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = movieList;

                txtMovieId.DataBindings.Clear();
                txtMovieName.DataBindings.Clear();
                txtDuration.DataBindings.Clear();
                txtCast.DataBindings.Clear();
                txtDirector.DataBindings.Clear();
                txtLimitAge.DataBindings.Clear();
                txtDescription.DataBindings.Clear();
                dtpReleaseDay.DataBindings.Clear();
                ptbImage.DataBindings.Clear();
                txtStatus.DataBindings.Clear();


                txtMovieId.DataBindings.Add("Text", bindingSource, "MovieId");
                txtMovieName.DataBindings.Add("Text", bindingSource, "MovieName");
                txtDuration.DataBindings.Add("Text", bindingSource, "Duration");
                txtCast.DataBindings.Add("Text", bindingSource, "Cast");
                txtDirector.DataBindings.Add("Text", bindingSource, "Director");
                txtLimitAge.DataBindings.Add("Text", bindingSource, "LimitAge");
                txtDescription.DataBindings.Add("Text", bindingSource, "Description");
                dtpReleaseDay.DataBindings.Add("text", bindingSource, "ReleaseDay", true, DataSourceUpdateMode.OnValidation, "", "MM/dd/yy")
                    .DataSourceUpdateMode = DataSourceUpdateMode.OnValidation;
                ptbImage.DataBindings.Add("Image", bindingSource, "Image", true, DataSourceUpdateMode.OnPropertyChanged);
                txtStatus.DataBindings.Add("Text", bindingSource, "Status");
                dgvMovies.DataSource = bindingSource;


            }
            catch (Exception e)
            {

                MessageBox.Show("Error when load the data" + e.Message, "Error");
            }

        }
        private void LoadGenre()
        {
            try
            {
                lbxGenre.DataSource = null;
                lbxGenre.Items.Clear();
                var currentMovie = (Movie)((BindingSource)dgvMovies.DataSource).Current;
                if (currentMovie != null)
                {
                    ShowGenresForMovie(currentMovie);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error when load the genre" + e.Message, "Error");

            }
        }
        private void ShowGenresForMovie(Movie movie)
        {
            try
            {
                if (movie != null)
                {
                    if (movie.Genres != null && movie.Genres.Count > 0)
                    {
                        lbxGenre.DataSource = movie.Genres;
                        lbxGenre.DisplayMember = "GenreName";
                    }
                    else
                    {
                        lbxGenre.DataSource = null;
                        lbxGenre.Items.Clear();
                        lbxGenre.Items.Add("No genres available for this movie");
                    }
                }
                else
                {
                    lbxGenre.DataSource = null;
                    lbxGenre.Items.Clear();
                    lbxGenre.Items.Add("Invalid movie selection");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading genres: " + ex.Message, "Error");
            }
        }



        private void UpdateImage()
        {
            if (dgvMovies.CurrentRow != null)
            {
                var currentMovie = (Movie)((BindingSource)dgvMovies.DataSource).Current;

                if (currentMovie.Image != null && currentMovie.Image.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(currentMovie.Image))
                    {

                        ptbImage.Image = Image.FromStream(ms);

                        ptbImage.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
                else
                {
                    ptbImage.Image = null;
                }
            }
        }


        private void dgvMovies_SelectionChanged(object sender, EventArgs e)
        {
            LoadGenre();
            UpdateImage();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to Delete this movie?",
                "Hacolo Cinema",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                int movieId = int.Parse(txtMovieId.Text.Trim());
                if (movieId >= 0)
                {
                    movieRepo.DeleteMovieById(movieId);
                    LoadMovieList();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddMovie frmAddMovie = new frmAddMovie();
            frmAddMovie.ShowDialog();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Bạn có chắc chắn muốn cập nhập trạng thái?",
                "Hacolo Cinema",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (d == DialogResult.OK)
            {
                try
                {

                    int movieId;
                    if (!int.TryParse(txtMovieId.Text.Trim(), out movieId))
                    {
                        MessageBox.Show("Lỗi khi lấy ID của Phim", "Lỗi");
                        return;
                    }
                    var movie = movieRepo.GetMovieById(movieId);
                    if (movie != null)
                    {
                        bool? newStatus = !movie.Status;
                        movieRepo.UpdateStatusMovie(movieId, newStatus);

                        MessageBox.Show("Cập nhật trạng thái thành công", "Hacolo Cinema");
                        LoadMovieList();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Lỗi khi cập nhật trạng thái: " + ex.Message, "Lỗi");
                    if (ex.InnerException != null)
                    {
                        MessageBox.Show("Inner Exception: " + ex.InnerException.Message, "Lỗi");
                    }

                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
