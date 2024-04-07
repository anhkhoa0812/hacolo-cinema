using BussinessObject.Models;
using Repositories;
using Repositories.movieandorder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encoder = System.Drawing.Imaging.Encoder;

namespace HacoloCinema_Team2
{
    public partial class frmAddMovie : Form
    {
        IMovieRepository movieRepo = new MovieRepository();
        IGenreRepository genreRepo = new GenreRepository();
        public frmAddMovie()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dtpReleaseDay.Value;
            var movie = new Movie
            {
                MovieId = movieRepo.GetLargestId() + 1,
                MovieName = txtMovieName.Text,
                ReleaseDay = new DateOnly(dateTime.Year, dateTime.Month, dateTime.Day),
                Cast = txtCast.Text,
                Director = txtDirector.Text,
                LimitAge = int.Parse(txtLimitAge.Text),
                Duration = int.Parse(txtDuration.Text),
                Description = txtDescription.Text,
                Image = ImageToBytes(ptxImage.Image),
                Status = false
            };
            if (checkNullInput())
            {
                MessageBox.Show("All fields are required", "Error");
                return;
            }
            
            else
            {
                movieRepo.SaveMovie(movie);
                
                foreach (var genre in GetSelectedGenres())
                {
                    if (movieRepo.ExistById(movie.MovieId))
                    {
                        //genreRepo.AddMovieToGenres(genre, movie);
                        movieRepo.AddGenreToMovie(genre, movie);
                    }
                    else
                    {
                        MessageBox.Show("Error when add Genre", "Error");
                    }
                }
                MessageBox.Show("Add movie successfully", "Hacolo Cinema");
            }

        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                if (openFileDialog.FileName != null)
                {
                    ptxImage.SizeMode = PictureBoxSizeMode.Zoom;
                    // Create a new Bitmap with the FileName
                    Bitmap bitmap = new Bitmap(openFileDialog.FileName);
                    ptxImage.Image = bitmap;

                }

            }
        }
        private byte[] ImageToBytes(Image image)
        {
            EncoderParameter qualityParam = new EncoderParameter(Encoder.Quality, 80L); // Adjust the quality value as needed (0-100)


            ImageCodecInfo jpegCodec = GetEncoderInfo(ImageFormat.Jpeg);
            if (jpegCodec == null)
            {
                throw new Exception("JPEG encoder not found");
            }

            EncoderParameters encoderParams = new EncoderParameters(1);
            encoderParams.Param[0] = qualityParam;


            Image resizedImage = ResizeImage(image, maxWidth: 800, maxHeight: 600); // Adjust maximum dimensions as needed


            using (MemoryStream ms = new MemoryStream())
            {
                resizedImage.Save(ms, jpegCodec, encoderParams);
                return ms.ToArray();
            }
        }

        private Image ResizeImage(Image image, int maxWidth, int maxHeight)
        {

            int newWidth, newHeight;
            if (image.Width > image.Height)
            {
                newWidth = maxWidth;
                newHeight = (int)((double)image.Height / image.Width * maxWidth);
            }
            else
            {
                newWidth = (int)((double)image.Width / image.Height * maxHeight);
                newHeight = maxHeight;
            }


            Bitmap resizedImage = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            return resizedImage;
        }

        private ImageCodecInfo GetEncoderInfo(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        private bool checkNullInput()
        {
            if (txtMovieName.Text.Trim() == ""
                || txtCast.Text.Trim() == "" || txtDirector.Text.Trim() == ""
                || txtLimitAge.Text.Trim() == "" || txtDuration.Text.Trim() == ""
                || txtDescription.Text.Trim() == "" || ptxImage.Image == null
                || clbGenre.CheckedItems == null)
            {
                return true;
            }
            else { return false; }
        }

        private void LoadGenreList()
        {
            try
            {
                var genreList = genreRepo.GetAll();
                clbGenre.Items.Clear();

                foreach (var genre in genreList)
                {
                    clbGenre.Items.Add(genre.GenreName);

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }
        private List<Genre> GetSelectedGenres()
        {
            try
            {
                List<Genre> selectedGenres = new List<Genre>();
                List<string> checkedGenreNames = GetCheckedGenreNames(clbGenre);
                if (checkedGenreNames.Count >= 0)
                {
                    foreach (string genreName in checkedGenreNames)
                    {
                        var genre = genreRepo.GetGenreByName(genreName);
                        if (genre != null)
                        {
                            selectedGenres.Add(genre);
                        }
                    }
                }
                return selectedGenres;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "Error");
                return null;

            }
        }
        private List<string> GetCheckedGenreNames(CheckedListBox checkedListBox)
        {
            try
            {
                List<string> checkedGenreNames = new List<string>();

                foreach (int index in checkedListBox.CheckedIndices)
                {
                    string genreName = checkedListBox.Items[index].ToString();
                    if (genreName != null)
                    {
                        checkedGenreNames.Add(genreName);
                    }
                }

                return checkedGenreNames;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "Error");
                return null;
            }
        }

        private void frmAddMovie_Load(object sender, EventArgs e)
        {
            LoadGenreList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
