namespace HacoloCinema_Team2
{
    partial class frmCheckoutCustomer
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
            components = new System.ComponentModel.Container();
            grbInfo = new GroupBox();
            label4 = new Label();
            lblHeader2 = new Label();
            lblTotalPrice = new Label();
            lblHeader1 = new Label();
            grbTicketPrice = new GroupBox();
            dgvTicketList = new DataGridView();
            grbCombo = new GroupBox();
            dgvComboList = new DataGridView();
            btnCheckout = new Button();
            btnCancel = new Button();
            countdownTimer = new System.Windows.Forms.Timer(components);
            lblBalanceAccount = new Label();
            grbInfo.SuspendLayout();
            grbTicketPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTicketList).BeginInit();
            grbCombo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvComboList).BeginInit();
            SuspendLayout();
            // 
            // grbInfo
            // 
            grbInfo.Controls.Add(label4);
            grbInfo.Controls.Add(lblHeader2);
            grbInfo.Controls.Add(lblTotalPrice);
            grbInfo.Controls.Add(lblHeader1);
            grbInfo.Location = new Point(87, 39);
            grbInfo.Name = "grbInfo";
            grbInfo.Size = new Size(606, 103);
            grbInfo.TabIndex = 0;
            grbInfo.TabStop = false;
            grbInfo.Text = "Thanh toán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(413, 52);
            label4.Name = "label4";
            label4.Size = new Size(72, 31);
            label4.TabIndex = 3;
            label4.Text = "05:00";
            // 
            // lblHeader2
            // 
            lblHeader2.AutoSize = true;
            lblHeader2.Location = new Point(413, 23);
            lblHeader2.Name = "lblHeader2";
            lblHeader2.Size = new Size(126, 20);
            lblHeader2.TabIndex = 2;
            lblHeader2.Text = "Thời gian giữ ghế";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPrice.Location = new Point(21, 52);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(108, 31);
            lblTotalPrice.TabIndex = 1;
            lblTotalPrice.Text = "Tổng giá";
            // 
            // lblHeader1
            // 
            lblHeader1.AutoSize = true;
            lblHeader1.Location = new Point(21, 23);
            lblHeader1.Name = "lblHeader1";
            lblHeader1.Size = new Size(110, 20);
            lblHeader1.TabIndex = 0;
            lblHeader1.Text = "Tổng đơn hàng";
            // 
            // grbTicketPrice
            // 
            grbTicketPrice.Controls.Add(dgvTicketList);
            grbTicketPrice.Location = new Point(89, 160);
            grbTicketPrice.Name = "grbTicketPrice";
            grbTicketPrice.Size = new Size(604, 174);
            grbTicketPrice.TabIndex = 1;
            grbTicketPrice.TabStop = false;
            grbTicketPrice.Text = "Vé phim";
            // 
            // dgvTicketList
            // 
            dgvTicketList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTicketList.Location = new Point(9, 23);
            dgvTicketList.Name = "dgvTicketList";
            dgvTicketList.RowHeadersWidth = 51;
            dgvTicketList.Size = new Size(589, 144);
            dgvTicketList.TabIndex = 0;
            // 
            // grbCombo
            // 
            grbCombo.Controls.Add(dgvComboList);
            grbCombo.Location = new Point(89, 351);
            grbCombo.Name = "grbCombo";
            grbCombo.Size = new Size(604, 174);
            grbCombo.TabIndex = 2;
            grbCombo.TabStop = false;
            grbCombo.Text = "Combo bắp nước";
            // 
            // dgvComboList
            // 
            dgvComboList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComboList.Location = new Point(9, 23);
            dgvComboList.Name = "dgvComboList";
            dgvComboList.RowHeadersWidth = 51;
            dgvComboList.Size = new Size(589, 144);
            dgvComboList.TabIndex = 0;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(170, 585);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(166, 36);
            btnCheckout.TabIndex = 3;
            btnCheckout.Text = "Thanh toán";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(441, 585);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(166, 36);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblBalanceAccount
            // 
            lblBalanceAccount.AutoSize = true;
            lblBalanceAccount.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalanceAccount.Location = new Point(218, 540);
            lblBalanceAccount.Name = "lblBalanceAccount";
            lblBalanceAccount.Size = new Size(146, 25);
            lblBalanceAccount.TabIndex = 5;
            lblBalanceAccount.Text = "Số tiền trong ví:";
            // 
            // frmCheckoutCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 636);
            ControlBox = false;
            Controls.Add(lblBalanceAccount);
            Controls.Add(btnCancel);
            Controls.Add(btnCheckout);
            Controls.Add(grbCombo);
            Controls.Add(grbTicketPrice);
            Controls.Add(grbInfo);
            Name = "frmCheckoutCustomer";
            Text = "Thanh toán";
            Load += frmCheckoutCustomer_Load;
            grbInfo.ResumeLayout(false);
            grbInfo.PerformLayout();
            grbTicketPrice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTicketList).EndInit();
            grbCombo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvComboList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbInfo;
        private Label label4;
        private Label lblHeader2;
        private Label lblTotalPrice;
        private Label lblHeader1;
        private GroupBox grbTicketPrice;
        private DataGridView dgvTicketList;
        private GroupBox grbCombo;
        private DataGridView dgvComboList;
        private Button btnCheckout;
        private Button btnCancel;
        private System.Windows.Forms.Timer countdownTimer;
        private Label lblBalanceAccount;
    }
}