namespace HacoloCinema_Team2
{
    partial class frmShowtimeManagement
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
            lblMovie = new Label();
            lblTheater = new Label();
            txtTheaterId = new TextBox();
            dgvShowTimeList = new DataGridView();
            btnBack = new Button();
            lblShowtimeId = new Label();
            txtShowtimeId = new TextBox();
            btnAddShowTime = new Button();
            txtMovieName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtShowDate = new TextBox();
            txtTime = new TextBox();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvShowTimeList).BeginInit();
            SuspendLayout();
            // 
            // lblMovie
            // 
            lblMovie.AutoSize = true;
            lblMovie.Location = new Point(35, 164);
            lblMovie.Name = "lblMovie";
            lblMovie.Size = new Size(50, 20);
            lblMovie.TabIndex = 0;
            lblMovie.Text = "Movie";
            // 
            // lblTheater
            // 
            lblTheater.AutoSize = true;
            lblTheater.Location = new Point(239, 90);
            lblTheater.Name = "lblTheater";
            lblTheater.Size = new Size(59, 20);
            lblTheater.TabIndex = 1;
            lblTheater.Text = "Theater";
            // 
            // txtTheaterId
            // 
            txtTheaterId.Location = new Point(304, 87);
            txtTheaterId.Name = "txtTheaterId";
            txtTheaterId.ReadOnly = true;
            txtTheaterId.Size = new Size(156, 27);
            txtTheaterId.TabIndex = 4;
            // 
            // dgvShowTimeList
            // 
            dgvShowTimeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowTimeList.Location = new Point(497, 90);
            dgvShowTimeList.Name = "dgvShowTimeList";
            dgvShowTimeList.ReadOnly = true;
            dgvShowTimeList.RowHeadersWidth = 51;
            dgvShowTimeList.Size = new Size(685, 253);
            dgvShowTimeList.TabIndex = 6;
            dgvShowTimeList.CellClick += dgvShowTimeList_CellContentClick;
            dgvShowTimeList.CellContentClick += dgvShowTimeList_CellContentClick;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(1088, 362);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblShowtimeId
            // 
            lblShowtimeId.AutoSize = true;
            lblShowtimeId.Location = new Point(35, 90);
            lblShowtimeId.Name = "lblShowtimeId";
            lblShowtimeId.Size = new Size(24, 20);
            lblShowtimeId.TabIndex = 8;
            lblShowtimeId.Text = "ID";
            // 
            // txtShowtimeId
            // 
            txtShowtimeId.Location = new Point(131, 87);
            txtShowtimeId.Name = "txtShowtimeId";
            txtShowtimeId.ReadOnly = true;
            txtShowtimeId.Size = new Size(48, 27);
            txtShowtimeId.TabIndex = 9;
            // 
            // btnAddShowTime
            // 
            btnAddShowTime.Location = new Point(204, 314);
            btnAddShowTime.Name = "btnAddShowTime";
            btnAddShowTime.Size = new Size(132, 29);
            btnAddShowTime.TabIndex = 10;
            btnAddShowTime.Text = "Add new film";
            btnAddShowTime.UseVisualStyleBackColor = true;
            btnAddShowTime.Click += btnAddShowTime_Click;
            // 
            // txtMovieName
            // 
            txtMovieName.Location = new Point(131, 161);
            txtMovieName.Name = "txtMovieName";
            txtMovieName.ReadOnly = true;
            txtMovieName.Size = new Size(329, 27);
            txtMovieName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 245);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 13;
            label1.Text = "Show date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(328, 245);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 14;
            label2.Text = "Time";
            // 
            // txtShowDate
            // 
            txtShowDate.Location = new Point(131, 242);
            txtShowDate.Name = "txtShowDate";
            txtShowDate.ReadOnly = true;
            txtShowDate.Size = new Size(153, 27);
            txtShowDate.TabIndex = 15;
            // 
            // txtTime
            // 
            txtTime.Location = new Point(376, 242);
            txtTime.Name = "txtTime";
            txtTime.ReadOnly = true;
            txtTime.Size = new Size(84, 27);
            txtTime.TabIndex = 16;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(584, 48);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(209, 27);
            dtpStartDate.TabIndex = 17;
            dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(973, 48);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(209, 27);
            dtpEndDate.TabIndex = 18;
            dtpEndDate.ValueChanged += dtpEndDate_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(497, 53);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 19;
            label3.Text = "Start date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(886, 53);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 20;
            label4.Text = "End date:";
            // 
            // frmShowtimeManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 406);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(txtTime);
            Controls.Add(txtShowDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddShowTime);
            Controls.Add(txtShowtimeId);
            Controls.Add(lblShowtimeId);
            Controls.Add(btnBack);
            Controls.Add(dgvShowTimeList);
            Controls.Add(txtTheaterId);
            Controls.Add(txtMovieName);
            Controls.Add(lblTheater);
            Controls.Add(lblMovie);
            Name = "frmShowtimeManagement";
            Text = "Showtime management";
            Load += frmShowtimeManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvShowTimeList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMovie;
        private Label lblTheater;
        private TextBox txtTheaterId;
        private DataGridView dgvShowTimeList;
        private Button btnBack;
        private Label lblShowtimeId;
        private TextBox txtShowtimeId;
        private Button btnAddShowTime;
        private TextBox txtMovieName;
        private Label label1;
        private Label label2;
        private TextBox txtShowDate;
        private TextBox txtTime;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Label label3;
        private Label label4;
    }
}