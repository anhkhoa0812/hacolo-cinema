namespace HacoloCinema_Team2
{
    partial class frmBookTicketCustomer
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
            tlbChair = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            grbInfo = new GroupBox();
            lblChair = new Label();
            lblShowTime = new Label();
            lblTheaterName = new Label();
            lblMovieName = new Label();
            grbTicketPrice = new GroupBox();
            lblTicketPrice = new Label();
            btnContinue = new Button();
            btnBack = new Button();
            dgvCombo = new DataGridView();
            groupBox2 = new GroupBox();
            lblComboPrice = new Label();
            grbTotalPrice = new GroupBox();
            lblTotalPrice = new Label();
            groupBox1.SuspendLayout();
            grbInfo.SuspendLayout();
            grbTicketPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCombo).BeginInit();
            groupBox2.SuspendLayout();
            grbTotalPrice.SuspendLayout();
            SuspendLayout();
            // 
            // tlbChair
            // 
            tlbChair.ColumnCount = 10;
            tlbChair.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlbChair.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlbChair.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlbChair.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlbChair.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlbChair.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlbChair.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlbChair.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlbChair.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlbChair.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlbChair.Dock = DockStyle.Fill;
            tlbChair.Location = new Point(3, 23);
            tlbChair.Margin = new Padding(4, 5, 4, 5);
            tlbChair.Name = "tlbChair";
            tlbChair.RowCount = 10;
            tlbChair.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlbChair.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlbChair.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlbChair.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlbChair.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlbChair.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlbChair.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlbChair.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlbChair.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlbChair.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlbChair.Size = new Size(514, 364);
            tlbChair.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tlbChair);
            groupBox1.Location = new Point(9, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(520, 390);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Màn ảnh";
            // 
            // grbInfo
            // 
            grbInfo.Controls.Add(lblChair);
            grbInfo.Controls.Add(lblShowTime);
            grbInfo.Controls.Add(lblTheaterName);
            grbInfo.Controls.Add(lblMovieName);
            grbInfo.Location = new Point(550, 21);
            grbInfo.Name = "grbInfo";
            grbInfo.Size = new Size(541, 224);
            grbInfo.TabIndex = 2;
            grbInfo.TabStop = false;
            grbInfo.Text = "Thông tin";
            // 
            // lblChair
            // 
            lblChair.AutoSize = true;
            lblChair.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChair.Location = new Point(24, 173);
            lblChair.Name = "lblChair";
            lblChair.Size = new Size(41, 23);
            lblChair.TabIndex = 3;
            lblChair.Text = "Ghế";
            // 
            // lblShowTime
            // 
            lblShowTime.AutoSize = true;
            lblShowTime.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblShowTime.Location = new Point(24, 126);
            lblShowTime.Name = "lblShowTime";
            lblShowTime.Size = new Size(90, 23);
            lblShowTime.TabIndex = 2;
            lblShowTime.Text = "Suất chiếu";
            // 
            // lblTheaterName
            // 
            lblTheaterName.AutoSize = true;
            lblTheaterName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTheaterName.Location = new Point(24, 81);
            lblTheaterName.Name = "lblTheaterName";
            lblTheaterName.Size = new Size(66, 23);
            lblTheaterName.TabIndex = 1;
            lblTheaterName.Text = "Tên rạp";
            // 
            // lblMovieName
            // 
            lblMovieName.AutoSize = true;
            lblMovieName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieName.Location = new Point(24, 34);
            lblMovieName.Name = "lblMovieName";
            lblMovieName.Size = new Size(80, 23);
            lblMovieName.TabIndex = 0;
            lblMovieName.Text = "Tên phim";
            // 
            // grbTicketPrice
            // 
            grbTicketPrice.Controls.Add(lblTicketPrice);
            grbTicketPrice.Location = new Point(550, 251);
            grbTicketPrice.Name = "grbTicketPrice";
            grbTicketPrice.Size = new Size(541, 160);
            grbTicketPrice.TabIndex = 3;
            grbTicketPrice.TabStop = false;
            grbTicketPrice.Text = "Tổng tiền vé xem phim";
            // 
            // lblTicketPrice
            // 
            lblTicketPrice.AutoSize = true;
            lblTicketPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTicketPrice.Location = new Point(24, 40);
            lblTicketPrice.Name = "lblTicketPrice";
            lblTicketPrice.Size = new Size(115, 31);
            lblTicketPrice.TabIndex = 4;
            lblTicketPrice.Text = "0.00 VNĐ";
            // 
            // btnContinue
            // 
            btnContinue.Enabled = false;
            btnContinue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnContinue.Location = new Point(9, 619);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(133, 48);
            btnContinue.TabIndex = 4;
            btnContinue.Text = "Tiếp tục";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Click += btnContinue_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(222, 619);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(123, 48);
            btnBack.TabIndex = 5;
            btnBack.Text = "Quay về";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgvCombo
            // 
            dgvCombo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCombo.Location = new Point(9, 417);
            dgvCombo.Name = "dgvCombo";
            dgvCombo.RowHeadersWidth = 51;
            dgvCombo.Size = new Size(518, 189);
            dgvCombo.TabIndex = 10;
            dgvCombo.CellBeginEdit += dgvCombo_CellBeginEdit;
            dgvCombo.CellEndEdit += dgvCombo_CellEndEdit;
            dgvCombo.CellValueChanged += dgvCombo_CellValueChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblComboPrice);
            groupBox2.Location = new Point(550, 417);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(541, 189);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tổng tiền combo bắp nước";
            // 
            // lblComboPrice
            // 
            lblComboPrice.AutoSize = true;
            lblComboPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComboPrice.Location = new Point(24, 40);
            lblComboPrice.Name = "lblComboPrice";
            lblComboPrice.Size = new Size(115, 31);
            lblComboPrice.TabIndex = 4;
            lblComboPrice.Text = "0.00 VNĐ";
            // 
            // grbTotalPrice
            // 
            grbTotalPrice.Controls.Add(lblTotalPrice);
            grbTotalPrice.Location = new Point(550, 619);
            grbTotalPrice.Name = "grbTotalPrice";
            grbTotalPrice.Size = new Size(541, 105);
            grbTotalPrice.TabIndex = 6;
            grbTotalPrice.TabStop = false;
            grbTotalPrice.Text = "Tổng tiền";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPrice.Location = new Point(24, 40);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(143, 38);
            lblTotalPrice.TabIndex = 4;
            lblTotalPrice.Text = "0.00 VNĐ";
            // 
            // frmBookTicketCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 743);
            Controls.Add(grbTotalPrice);
            Controls.Add(groupBox2);
            Controls.Add(dgvCombo);
            Controls.Add(btnBack);
            Controls.Add(btnContinue);
            Controls.Add(grbTicketPrice);
            Controls.Add(grbInfo);
            Controls.Add(groupBox1);
            Name = "frmBookTicketCustomer";
            Text = "Đặt vé";
            Load += frmBookTicket_Load;
            groupBox1.ResumeLayout(false);
            grbInfo.ResumeLayout(false);
            grbInfo.PerformLayout();
            grbTicketPrice.ResumeLayout(false);
            grbTicketPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCombo).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            grbTotalPrice.ResumeLayout(false);
            grbTotalPrice.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlbChair;
        private GroupBox groupBox1;
        private GroupBox grbInfo;
        private Label lblMovieName;
        private GroupBox grbTicketPrice;
        private Label lblTicketPrice;
        private Label lblChair;
        private Label lblShowTime;
        private Label lblTheaterName;
        private Button btnContinue;
        private Button btnBack;
        private DataGridView dgvCombo;
        private GroupBox groupBox2;
        private Label lblComboPrice;
        private GroupBox grbTotalPrice;
        private Label lblTotalPrice;
    }
}