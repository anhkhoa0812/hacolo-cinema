namespace HacoloCinema_Team2
{
    partial class frmAddShowTime
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtShowtimeId = new TextBox();
            txtTime = new TextBox();
            btnAdd = new Button();
            btnCancel = new Button();
            cmbTheater = new ComboBox();
            cmbMovie = new ComboBox();
            lblSearchFilm = new Label();
            chkSortDesendingByDate = new CheckBox();
            txtSearchFilmValue = new TextBox();
            cmbPricingShedule = new ComboBox();
            dtpDate = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 71);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 176);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Movie";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 229);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 2;
            label3.Text = "Pricing schedule";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(356, 74);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 3;
            label4.Text = "Theater";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 287);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 4;
            label5.Text = "Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 337);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 5;
            label6.Text = "Time";
            // 
            // txtShowtimeId
            // 
            txtShowtimeId.Enabled = false;
            txtShowtimeId.Location = new Point(182, 71);
            txtShowtimeId.Name = "txtShowtimeId";
            txtShowtimeId.Size = new Size(147, 27);
            txtShowtimeId.TabIndex = 7;
            // 
            // txtTime
            // 
            txtTime.Enabled = false;
            txtTime.Location = new Point(182, 334);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(368, 27);
            txtTime.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(337, 397);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(456, 397);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbTheater
            // 
            cmbTheater.FormattingEnabled = true;
            cmbTheater.Location = new Point(425, 71);
            cmbTheater.Name = "cmbTheater";
            cmbTheater.Size = new Size(125, 28);
            cmbTheater.TabIndex = 15;
            cmbTheater.SelectedIndexChanged += cmbTheater_SelectedIndexChanged;
            // 
            // cmbMovie
            // 
            cmbMovie.FormattingEnabled = true;
            cmbMovie.Location = new Point(182, 173);
            cmbMovie.Name = "cmbMovie";
            cmbMovie.Size = new Size(368, 28);
            cmbMovie.TabIndex = 16;
            // 
            // lblSearchFilm
            // 
            lblSearchFilm.AutoSize = true;
            lblSearchFilm.Location = new Point(51, 123);
            lblSearchFilm.Name = "lblSearchFilm";
            lblSearchFilm.Size = new Size(83, 20);
            lblSearchFilm.TabIndex = 17;
            lblSearchFilm.Text = "Search film";
            // 
            // chkSortDesendingByDate
            // 
            chkSortDesendingByDate.AutoSize = true;
            chkSortDesendingByDate.Location = new Point(365, 123);
            chkSortDesendingByDate.Name = "chkSortDesendingByDate";
            chkSortDesendingByDate.Size = new Size(185, 24);
            chkSortDesendingByDate.TabIndex = 18;
            chkSortDesendingByDate.Text = "Sort desending by date";
            chkSortDesendingByDate.UseVisualStyleBackColor = true;
            chkSortDesendingByDate.CheckedChanged += chkSortDesendingByDate_CheckedChanged;
            // 
            // txtSearchFilmValue
            // 
            txtSearchFilmValue.Location = new Point(182, 120);
            txtSearchFilmValue.Name = "txtSearchFilmValue";
            txtSearchFilmValue.Size = new Size(147, 27);
            txtSearchFilmValue.TabIndex = 19;
            txtSearchFilmValue.TextChanged += txtSearchFilmValue_TextChanged;
            // 
            // cmbPricingShedule
            // 
            cmbPricingShedule.FormattingEnabled = true;
            cmbPricingShedule.Location = new Point(182, 226);
            cmbPricingShedule.Name = "cmbPricingShedule";
            cmbPricingShedule.Size = new Size(368, 28);
            cmbPricingShedule.TabIndex = 20;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(182, 282);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(368, 27);
            dtpDate.TabIndex = 21;
            dtpDate.ValueChanged += dtpDate_ValueChanged;
            // 
            // frmAddShowTime
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 438);
            Controls.Add(dtpDate);
            Controls.Add(cmbPricingShedule);
            Controls.Add(txtSearchFilmValue);
            Controls.Add(chkSortDesendingByDate);
            Controls.Add(lblSearchFilm);
            Controls.Add(cmbMovie);
            Controls.Add(cmbTheater);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(txtTime);
            Controls.Add(txtShowtimeId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAddShowTime";
            Text = "Add showtime";
            Load += frmAddShowTime_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtShowtimeId;
        private TextBox txtMovie;
        private TextBox txtTime;
        private Button btnAdd;
        private Button btnCancel;
        private ComboBox cmbTheater;
        private ComboBox cmbMovie;
        private Label lblSearchFilm;
        private CheckBox chkSortDesendingByDate;
        private TextBox txtSearchFilmValue;
        private ComboBox cmbPricingShedule;
        private DateTimePicker dtpDate;
    }
}