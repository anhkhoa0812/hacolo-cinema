namespace HacoloCinema_Team2
{
    partial class frmMovie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMovieId = new Label();
            lblMovieName = new Label();
            lblDuration = new Label();
            lblCast = new Label();
            lblDirector = new Label();
            lblLimitAge = new Label();
            lblDescription = new Label();
            lelGenre = new Label();
            txtMovieName = new TextBox();
            txtDuration = new TextBox();
            txtCast = new TextBox();
            txtDirector = new TextBox();
            txtLimitAge = new TextBox();
            txtDescription = new TextBox();
            dgvMovies = new DataGridView();
            lblImage = new Label();
            ptbImage = new PictureBox();
            lblReleaseDay = new Label();
            dtpReleaseDay = new DateTimePicker();
            btnBack = new Button();
            btnAdd = new Button();
            lbxGenre = new ListBox();
            txtMovieId = new TextBox();
            lblStatus = new Label();
            txtStatus = new TextBox();
            btnStatus = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMovies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbImage).BeginInit();
            SuspendLayout();
            // 
            // lblMovieId
            // 
            lblMovieId.AutoSize = true;
            lblMovieId.Location = new Point(26, 84);
            lblMovieId.Name = "lblMovieId";
            lblMovieId.Size = new Size(24, 20);
            lblMovieId.TabIndex = 0;
            lblMovieId.Text = "ID";
            // 
            // lblMovieName
            // 
            lblMovieName.AutoSize = true;
            lblMovieName.Location = new Point(219, 84);
            lblMovieName.Name = "lblMovieName";
            lblMovieName.Size = new Size(69, 20);
            lblMovieName.TabIndex = 1;
            lblMovieName.Text = "Tên Phim";
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(26, 142);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(81, 20);
            lblDuration.TabIndex = 2;
            lblDuration.Text = "Thời lượng";
            // 
            // lblCast
            // 
            lblCast.AutoSize = true;
            lblCast.Location = new Point(219, 142);
            lblCast.Name = "lblCast";
            lblCast.Size = new Size(71, 20);
            lblCast.TabIndex = 3;
            lblCast.Text = "Diễn viên";
            // 
            // lblDirector
            // 
            lblDirector.AutoSize = true;
            lblDirector.Location = new Point(26, 196);
            lblDirector.Name = "lblDirector";
            lblDirector.Size = new Size(70, 20);
            lblDirector.TabIndex = 4;
            lblDirector.Text = "Đạo diễn";
            // 
            // lblLimitAge
            // 
            lblLimitAge.AutoSize = true;
            lblLimitAge.Location = new Point(233, 196);
            lblLimitAge.Name = "lblLimitAge";
            lblLimitAge.Size = new Size(116, 20);
            lblLimitAge.TabIndex = 5;
            lblLimitAge.Text = "Giới hạn độ tuổi";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(26, 249);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(48, 20);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Mô tả";
            // 
            // lelGenre
            // 
            lelGenre.AutoSize = true;
            lelGenre.Location = new Point(26, 391);
            lelGenre.Name = "lelGenre";
            lelGenre.Size = new Size(65, 20);
            lelGenre.TabIndex = 7;
            lelGenre.Text = "Thể Loại";
            // 
            // txtMovieName
            // 
            txtMovieName.Location = new Point(294, 77);
            txtMovieName.Name = "txtMovieName";
            txtMovieName.Size = new Size(190, 27);
            txtMovieName.TabIndex = 9;
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(113, 135);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(76, 27);
            txtDuration.TabIndex = 10;
            // 
            // txtCast
            // 
            txtCast.Location = new Point(296, 135);
            txtCast.Name = "txtCast";
            txtCast.Size = new Size(125, 27);
            txtCast.TabIndex = 11;
            // 
            // txtDirector
            // 
            txtDirector.Location = new Point(97, 189);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(125, 27);
            txtDirector.TabIndex = 12;
            // 
            // txtLimitAge
            // 
            txtLimitAge.Location = new Point(355, 189);
            txtLimitAge.Name = "txtLimitAge";
            txtLimitAge.Size = new Size(58, 27);
            txtLimitAge.TabIndex = 13;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(80, 242);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(210, 27);
            txtDescription.TabIndex = 14;
            // 
            // dgvMovies
            // 
            dgvMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovies.Location = new Point(536, 34);
            dgvMovies.Name = "dgvMovies";
            dgvMovies.RowHeadersWidth = 51;
            dgvMovies.Size = new Size(503, 426);
            dgvMovies.TabIndex = 16;
            dgvMovies.SelectionChanged += dgvMovies_SelectionChanged;
            // 
            // lblImage
            // 
            lblImage.AutoSize = true;
            lblImage.Location = new Point(281, 391);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(68, 20);
            lblImage.TabIndex = 17;
            lblImage.Text = "Hình ảnh";
            // 
            // ptbImage
            // 
            ptbImage.Location = new Point(355, 391);
            ptbImage.Name = "ptbImage";
            ptbImage.Size = new Size(153, 114);
            ptbImage.TabIndex = 18;
            ptbImage.TabStop = false;
            // 
            // lblReleaseDay
            // 
            lblReleaseDay.AutoSize = true;
            lblReleaseDay.Location = new Point(26, 340);
            lblReleaseDay.Name = "lblReleaseDay";
            lblReleaseDay.Size = new Size(124, 20);
            lblReleaseDay.TabIndex = 19;
            lblReleaseDay.Text = "Ngày Công Chiếu";
            // 
            // dtpReleaseDay
            // 
            dtpReleaseDay.Location = new Point(156, 333);
            dtpReleaseDay.Name = "dtpReleaseDay";
            dtpReleaseDay.Size = new Size(250, 27);
            dtpReleaseDay.TabIndex = 20;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(839, 473);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(176, 29);
            btnBack.TabIndex = 23;
            btnBack.Text = "Quay Lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(571, 473);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(191, 29);
            btnAdd.TabIndex = 24;
            btnAdd.Text = "Thêm Phim";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lbxGenre
            // 
            lbxGenre.FormattingEnabled = true;
            lbxGenre.Location = new Point(97, 391);
            lbxGenre.Name = "lbxGenre";
            lbxGenre.Size = new Size(150, 104);
            lbxGenre.TabIndex = 25;
            // 
            // txtMovieId
            // 
            txtMovieId.Location = new Point(56, 77);
            txtMovieId.Name = "txtMovieId";
            txtMovieId.Size = new Size(74, 27);
            txtMovieId.TabIndex = 8;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(296, 249);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(75, 20);
            lblStatus.TabIndex = 26;
            lblStatus.Text = "Trạng thái";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(377, 242);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(125, 27);
            txtStatus.TabIndex = 27;
            // 
            // btnStatus
            // 
            btnStatus.Location = new Point(355, 286);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new Size(147, 29);
            btnStatus.TabIndex = 28;
            btnStatus.Text = "Cập nhật trạng thái";
            btnStatus.UseVisualStyleBackColor = true;
            btnStatus.Click += btnStatus_Click;
            // 
            // frmMovie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 517);
            Controls.Add(btnStatus);
            Controls.Add(txtStatus);
            Controls.Add(lblStatus);
            Controls.Add(lbxGenre);
            Controls.Add(btnAdd);
            Controls.Add(btnBack);
            Controls.Add(dtpReleaseDay);
            Controls.Add(lblReleaseDay);
            Controls.Add(ptbImage);
            Controls.Add(lblImage);
            Controls.Add(dgvMovies);
            Controls.Add(txtDescription);
            Controls.Add(txtLimitAge);
            Controls.Add(txtDirector);
            Controls.Add(txtCast);
            Controls.Add(txtDuration);
            Controls.Add(txtMovieName);
            Controls.Add(txtMovieId);
            Controls.Add(lelGenre);
            Controls.Add(lblDescription);
            Controls.Add(lblLimitAge);
            Controls.Add(lblDirector);
            Controls.Add(lblCast);
            Controls.Add(lblDuration);
            Controls.Add(lblMovieName);
            Controls.Add(lblMovieId);
            Name = "frmMovie";
            Text = "frmMovie";
            Load += frmMovie_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMovies).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMovieId;
        private Label lblMovieName;
        private Label lblDuration;
        private Label lblCast;
        private Label lblDirector;
        private Label lblLimitAge;
        private Label lblDescription;
        private Label lelGenre;
        private TextBox txtMovieName;
        private TextBox txtDuration;
        private TextBox txtCast;
        private TextBox txtDirector;
        private TextBox txtLimitAge;
        private TextBox txtDescription;
        private DataGridView dgvMovies;
        private Label lblImage;
        private PictureBox ptbImage;
        private Label lblReleaseDay;
        private DateTimePicker dtpReleaseDay;
        private Button btnBack;
        private Button btnAdd;
        private ListBox lbxGenre;
        private TextBox txtMovieId;
        private Label lblStatus;
        private TextBox txtStatus;
        private Button btnStatus;
    }
}