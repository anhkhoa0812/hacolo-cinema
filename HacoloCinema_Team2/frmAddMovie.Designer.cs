namespace HacoloCinema_Team2
{
    partial class frmAddMovie
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
            lblMovieName = new Label();
            lblDescription = new Label();
            lblReleaseDay = new Label();
            lblLimitAge = new Label();
            lblCast = new Label();
            lblDirector = new Label();
            lblGenre = new Label();
            txtMovieName = new TextBox();
            txtDescription = new TextBox();
            txtCast = new TextBox();
            txtLimitAge = new TextBox();
            txtDirector = new TextBox();
            btnAdd = new Button();
            btnBack = new Button();
            label3 = new Label();
            lblImage = new Label();
            btnImage = new Button();
            dtpReleaseDay = new DateTimePicker();
            lblDuration = new Label();
            txtDuration = new TextBox();
            clbGenre = new CheckedListBox();
            ptxImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptxImage).BeginInit();
            SuspendLayout();
            // 
            // lblMovieName
            // 
            lblMovieName.AutoSize = true;
            lblMovieName.Location = new Point(72, 151);
            lblMovieName.Name = "lblMovieName";
            lblMovieName.Size = new Size(69, 20);
            lblMovieName.TabIndex = 0;
            lblMovieName.Text = "Tên Phim";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(77, 348);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(48, 20);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Mô tả";
            // 
            // lblReleaseDay
            // 
            lblReleaseDay.AutoSize = true;
            lblReleaseDay.Location = new Point(72, 211);
            lblReleaseDay.Name = "lblReleaseDay";
            lblReleaseDay.Size = new Size(124, 20);
            lblReleaseDay.TabIndex = 3;
            lblReleaseDay.Text = "Ngày Công Chiếu";
            // 
            // lblLimitAge
            // 
            lblLimitAge.AutoSize = true;
            lblLimitAge.Location = new Point(77, 307);
            lblLimitAge.Name = "lblLimitAge";
            lblLimitAge.Size = new Size(116, 20);
            lblLimitAge.TabIndex = 4;
            lblLimitAge.Text = "Giới hạn độ tuổi";
            // 
            // lblCast
            // 
            lblCast.AutoSize = true;
            lblCast.Location = new Point(72, 264);
            lblCast.Name = "lblCast";
            lblCast.Size = new Size(71, 20);
            lblCast.TabIndex = 5;
            lblCast.Text = "Diễn viên";
            // 
            // lblDirector
            // 
            lblDirector.AutoSize = true;
            lblDirector.Location = new Point(363, 264);
            lblDirector.Name = "lblDirector";
            lblDirector.Size = new Size(70, 20);
            lblDirector.TabIndex = 6;
            lblDirector.Text = "Đạo diễn";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Location = new Point(363, 348);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(62, 20);
            lblGenre.TabIndex = 7;
            lblGenre.Text = "Thể loại";
            // 
            // txtMovieName
            // 
            txtMovieName.Location = new Point(205, 144);
            txtMovieName.Name = "txtMovieName";
            txtMovieName.Size = new Size(151, 27);
            txtMovieName.TabIndex = 8;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(205, 341);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(151, 27);
            txtDescription.TabIndex = 9;
            // 
            // txtCast
            // 
            txtCast.Location = new Point(205, 257);
            txtCast.Name = "txtCast";
            txtCast.Size = new Size(151, 27);
            txtCast.TabIndex = 12;
            // 
            // txtLimitAge
            // 
            txtLimitAge.Location = new Point(210, 300);
            txtLimitAge.Name = "txtLimitAge";
            txtLimitAge.Size = new Size(47, 27);
            txtLimitAge.TabIndex = 13;
            // 
            // txtDirector
            // 
            txtDirector.Location = new Point(439, 257);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(151, 27);
            txtDirector.TabIndex = 14;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(532, 484);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(668, 484);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 17;
            btnBack.Text = "Quay Lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(283, 5);
            label3.Name = "label3";
            label3.Size = new Size(192, 41);
            label3.TabIndex = 18;
            label3.Text = "THÊM PHIM";
            // 
            // lblImage
            // 
            lblImage.AutoSize = true;
            lblImage.Location = new Point(75, 394);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(68, 20);
            lblImage.TabIndex = 19;
            lblImage.Text = "Hình ảnh";
            // 
            // btnImage
            // 
            btnImage.Location = new Point(55, 484);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(118, 29);
            btnImage.TabIndex = 20;
            btnImage.Text = "Chọn hình ảnh";
            btnImage.UseVisualStyleBackColor = true;
            btnImage.Click += btnImage_Click;
            // 
            // dtpReleaseDay
            // 
            dtpReleaseDay.Location = new Point(202, 203);
            dtpReleaseDay.Name = "dtpReleaseDay";
            dtpReleaseDay.Size = new Size(253, 27);
            dtpReleaseDay.TabIndex = 23;
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(363, 151);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(81, 20);
            lblDuration.TabIndex = 24;
            lblDuration.Text = "Thời lượng";
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(450, 144);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(151, 27);
            txtDuration.TabIndex = 25;
            // 
            // clbGenre
            // 
            clbGenre.FormattingEnabled = true;
            clbGenre.HorizontalScrollbar = true;
            clbGenre.Location = new Point(439, 348);
            clbGenre.Name = "clbGenre";
            clbGenre.Size = new Size(150, 114);
            clbGenre.TabIndex = 27;
            // 
            // ptxImage
            // 
            ptxImage.Location = new Point(202, 394);
            ptxImage.Name = "ptxImage";
            ptxImage.Size = new Size(154, 87);
            ptxImage.TabIndex = 28;
            ptxImage.TabStop = false;
            // 
            // frmAddMovie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 529);
            Controls.Add(ptxImage);
            Controls.Add(clbGenre);
            Controls.Add(txtDuration);
            Controls.Add(lblDuration);
            Controls.Add(dtpReleaseDay);
            Controls.Add(btnImage);
            Controls.Add(lblImage);
            Controls.Add(label3);
            Controls.Add(btnBack);
            Controls.Add(btnAdd);
            Controls.Add(txtDirector);
            Controls.Add(txtLimitAge);
            Controls.Add(txtCast);
            Controls.Add(txtDescription);
            Controls.Add(txtMovieName);
            Controls.Add(lblGenre);
            Controls.Add(lblDirector);
            Controls.Add(lblCast);
            Controls.Add(lblLimitAge);
            Controls.Add(lblReleaseDay);
            Controls.Add(lblDescription);
            Controls.Add(lblMovieName);
            Name = "frmAddMovie";
            Text = "frmAddMovie";
            Load += frmAddMovie_Load;
            ((System.ComponentModel.ISupportInitialize)ptxImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMovieName;
        private Label lblDescription;
        private Label lblReleaseDay;
        private Label lblLimitAge;
        private Label lblCast;
        private Label lblDirector;
        private Label lblGenre;
        private TextBox txtMovieName;
        private TextBox txtDescription;
        private TextBox txtCast;
        private TextBox txtLimitAge;
        private TextBox txtDirector;
        private Button btnAdd;
        private Button btnBack;
        private Label label3;
        private Label lblImage;
        private Button btnImage;
        private Label lblMovieId;
        private TextBox txtMovieId;
        private DateTimePicker dtpReleaseDay;
        private Label lblDuration;
        private TextBox txtDuration;
        private PictureBox ptbImage;
        private CheckedListBox clbGenre;
        private PictureBox ptxImage;
    }
}