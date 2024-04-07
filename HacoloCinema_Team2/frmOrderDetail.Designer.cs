namespace HacoloCinema_Team2
{
    partial class frmOrderDetail
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
            panel1 = new Panel();
            txtQuantity = new TextBox();
            txtComboPrice = new TextBox();
            txtComboName = new TextBox();
            txtComboId = new TextBox();
            btnBack = new Button();
            lblQuantity = new Label();
            lblComboPrice = new Label();
            lblComboName = new Label();
            lblComboId = new Label();
            dtpShowDate = new DateTimePicker();
            txtSeatPosition = new TextBox();
            txtStartTime = new TextBox();
            txtTheaterName = new TextBox();
            txtTicketPrice = new TextBox();
            txtMovieName = new TextBox();
            txtTicketId = new TextBox();
            lblSeatPosition = new Label();
            label6 = new Label();
            lblShowDate = new Label();
            lblTheaterName = new Label();
            lblTicketPrice = new Label();
            lblMovieName = new Label();
            lblTicketId = new Label();
            dgvCombo = new DataGridView();
            dgvTicket = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCombo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTicket).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(txtQuantity);
            panel1.Controls.Add(txtComboPrice);
            panel1.Controls.Add(txtComboName);
            panel1.Controls.Add(txtComboId);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(lblQuantity);
            panel1.Controls.Add(lblComboPrice);
            panel1.Controls.Add(lblComboName);
            panel1.Controls.Add(lblComboId);
            panel1.Controls.Add(dtpShowDate);
            panel1.Controls.Add(txtSeatPosition);
            panel1.Controls.Add(txtStartTime);
            panel1.Controls.Add(txtTheaterName);
            panel1.Controls.Add(txtTicketPrice);
            panel1.Controls.Add(txtMovieName);
            panel1.Controls.Add(txtTicketId);
            panel1.Controls.Add(lblSeatPosition);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lblShowDate);
            panel1.Controls.Add(lblTheaterName);
            panel1.Controls.Add(lblTicketPrice);
            panel1.Controls.Add(lblMovieName);
            panel1.Controls.Add(lblTicketId);
            panel1.Controls.Add(dgvCombo);
            panel1.Controls.Add(dgvTicket);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1048, 523);
            panel1.TabIndex = 0;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(119, 662);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 27);
            txtQuantity.TabIndex = 41;
            // 
            // txtComboPrice
            // 
            txtComboPrice.Location = new Point(119, 618);
            txtComboPrice.Name = "txtComboPrice";
            txtComboPrice.Size = new Size(125, 27);
            txtComboPrice.TabIndex = 40;
            // 
            // txtComboName
            // 
            txtComboName.Location = new Point(119, 568);
            txtComboName.Name = "txtComboName";
            txtComboName.Size = new Size(125, 27);
            txtComboName.TabIndex = 39;
            // 
            // txtComboId
            // 
            txtComboId.Location = new Point(119, 518);
            txtComboId.Name = "txtComboId";
            txtComboId.Size = new Size(125, 27);
            txtComboId.TabIndex = 38;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(792, 799);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(108, 44);
            btnBack.TabIndex = 37;
            btnBack.Text = "Quay Lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(26, 669);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(72, 20);
            lblQuantity.TabIndex = 35;
            lblQuantity.Text = "Số Lượng";
            // 
            // lblComboPrice
            // 
            lblComboPrice.AutoSize = true;
            lblComboPrice.Location = new Point(26, 625);
            lblComboPrice.Name = "lblComboPrice";
            lblComboPrice.Size = new Size(84, 20);
            lblComboPrice.TabIndex = 34;
            lblComboPrice.Text = "Giá Combo";
            // 
            // lblComboName
            // 
            lblComboName.AutoSize = true;
            lblComboName.Location = new Point(25, 575);
            lblComboName.Name = "lblComboName";
            lblComboName.Size = new Size(85, 20);
            lblComboName.TabIndex = 33;
            lblComboName.Text = "Tên Combo";
            // 
            // lblComboId
            // 
            lblComboId.AutoSize = true;
            lblComboId.Location = new Point(25, 525);
            lblComboId.Name = "lblComboId";
            lblComboId.Size = new Size(77, 20);
            lblComboId.TabIndex = 32;
            lblComboId.Text = "ID Combo";
            // 
            // dtpShowDate
            // 
            dtpShowDate.Location = new Point(119, 260);
            dtpShowDate.Name = "dtpShowDate";
            dtpShowDate.Size = new Size(250, 27);
            dtpShowDate.TabIndex = 31;
            // 
            // txtSeatPosition
            // 
            txtSeatPosition.Location = new Point(119, 367);
            txtSeatPosition.Name = "txtSeatPosition";
            txtSeatPosition.Size = new Size(125, 27);
            txtSeatPosition.TabIndex = 30;
            // 
            // txtStartTime
            // 
            txtStartTime.Location = new Point(119, 315);
            txtStartTime.Name = "txtStartTime";
            txtStartTime.Size = new Size(125, 27);
            txtStartTime.TabIndex = 29;
            // 
            // txtTheaterName
            // 
            txtTheaterName.Location = new Point(119, 203);
            txtTheaterName.Name = "txtTheaterName";
            txtTheaterName.Size = new Size(125, 27);
            txtTheaterName.TabIndex = 28;
            // 
            // txtTicketPrice
            // 
            txtTicketPrice.Location = new Point(119, 156);
            txtTicketPrice.Name = "txtTicketPrice";
            txtTicketPrice.Size = new Size(125, 27);
            txtTicketPrice.TabIndex = 27;
            // 
            // txtMovieName
            // 
            txtMovieName.Location = new Point(119, 115);
            txtMovieName.Name = "txtMovieName";
            txtMovieName.Size = new Size(125, 27);
            txtMovieName.TabIndex = 26;
            // 
            // txtTicketId
            // 
            txtTicketId.Location = new Point(119, 68);
            txtTicketId.Name = "txtTicketId";
            txtTicketId.Size = new Size(125, 27);
            txtTicketId.TabIndex = 25;
            // 
            // lblSeatPosition
            // 
            lblSeatPosition.AutoSize = true;
            lblSeatPosition.Location = new Point(26, 374);
            lblSeatPosition.Name = "lblSeatPosition";
            lblSeatPosition.Size = new Size(35, 20);
            lblSeatPosition.TabIndex = 24;
            lblSeatPosition.Text = "Ghế";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 322);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 23;
            label6.Text = "Suất chiếu";
            // 
            // lblShowDate
            // 
            lblShowDate.AutoSize = true;
            lblShowDate.Location = new Point(25, 267);
            lblShowDate.Name = "lblShowDate";
            lblShowDate.Size = new Size(85, 20);
            lblShowDate.TabIndex = 22;
            lblShowDate.Text = "Ngày Chiếu";
            // 
            // lblTheaterName
            // 
            lblTheaterName.AutoSize = true;
            lblTheaterName.Location = new Point(25, 210);
            lblTheaterName.Name = "lblTheaterName";
            lblTheaterName.Size = new Size(35, 20);
            lblTheaterName.TabIndex = 21;
            lblTheaterName.Text = "Rạp";
            // 
            // lblTicketPrice
            // 
            lblTicketPrice.AutoSize = true;
            lblTicketPrice.Location = new Point(26, 163);
            lblTicketPrice.Name = "lblTicketPrice";
            lblTicketPrice.Size = new Size(51, 20);
            lblTicketPrice.TabIndex = 20;
            lblTicketPrice.Text = "Giá Vé";
            // 
            // lblMovieName
            // 
            lblMovieName.AutoSize = true;
            lblMovieName.Location = new Point(25, 122);
            lblMovieName.Name = "lblMovieName";
            lblMovieName.Size = new Size(69, 20);
            lblMovieName.TabIndex = 19;
            lblMovieName.Text = "Tên Phim";
            // 
            // lblTicketId
            // 
            lblTicketId.AutoSize = true;
            lblTicketId.Location = new Point(25, 75);
            lblTicketId.Name = "lblTicketId";
            lblTicketId.Size = new Size(44, 20);
            lblTicketId.TabIndex = 18;
            lblTicketId.Text = "ID Vé";
            // 
            // dgvCombo
            // 
            dgvCombo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCombo.Location = new Point(389, 495);
            dgvCombo.Name = "dgvCombo";
            dgvCombo.RowHeadersWidth = 51;
            dgvCombo.Size = new Size(511, 280);
            dgvCombo.TabIndex = 17;
            // 
            // dgvTicket
            // 
            dgvTicket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTicket.Location = new Point(389, 68);
            dgvTicket.Name = "dgvTicket";
            dgvTicket.RowHeadersWidth = 51;
            dgvTicket.Size = new Size(511, 326);
            dgvTicket.TabIndex = 16;
            // 
            // frmOrderDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 521);
            Controls.Add(panel1);
            Name = "frmOrderDetail";
            Text = "frmOrderDetail";
            Load += frmOrderDetail_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCombo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTicket).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DateTimePicker dtpShowDate;
        private TextBox txtSeatPosition;
        private TextBox txtStartTime;
        private TextBox txtTheaterName;
        private TextBox txtTicketPrice;
        private TextBox txtMovieName;
        private TextBox txtTicketId;
        private Label lblSeatPosition;
        private Label label6;
        private Label lblShowDate;
        private Label lblTheaterName;
        private Label lblTicketPrice;
        private Label lblMovieName;
        private Label lblTicketId;
        private DataGridView dgvCombo;
        private DataGridView dgvTicket;
        private Label lblComboName;
        private Label lblComboId;
        private Button btnBack;
        private Label lblQuantity;
        private Label lblComboPrice;
        private TextBox txtQuantity;
        private TextBox txtComboPrice;
        private TextBox txtComboName;
        private TextBox txtComboId;
    }
}