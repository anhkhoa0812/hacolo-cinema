namespace HacoloCinema_Team2
{
    partial class frmOrder
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
            lblOrderId = new Label();
            lblOrderDate = new Label();
            lblCustomerName = new Label();
            lblTotalPrice = new Label();
            lblPaymentMethod = new Label();
            lblOrderStatus = new Label();
            txtOrderId = new TextBox();
            txtCustomerName = new TextBox();
            txtTotalPrice = new TextBox();
            txtPaymentMethod = new TextBox();
            txtOrderStatus = new TextBox();
            dgvOrder = new DataGridView();
            dtpOrderDate = new DateTimePicker();
            btnDetail = new Button();
            btnPrint = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // lblOrderId
            // 
            lblOrderId.AutoSize = true;
            lblOrderId.Location = new Point(12, 33);
            lblOrderId.Name = "lblOrderId";
            lblOrderId.Size = new Size(72, 20);
            lblOrderId.TabIndex = 0;
            lblOrderId.Text = "ID Đặt Vé";
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Location = new Point(12, 79);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(92, 20);
            lblOrderDate.TabIndex = 1;
            lblOrderDate.Text = "Ngày Đặt Vé";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(12, 128);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(116, 20);
            lblCustomerName.TabIndex = 2;
            lblCustomerName.Text = "Tên Khách Hàng";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(12, 178);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(75, 20);
            lblTotalPrice.TabIndex = 4;
            lblTotalPrice.Text = "Tổng Tiền";
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Location = new Point(12, 234);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(168, 20);
            lblPaymentMethod.TabIndex = 5;
            lblPaymentMethod.Text = "Phương thức thanh toán";
            // 
            // lblOrderStatus
            // 
            lblOrderStatus.AutoSize = true;
            lblOrderStatus.Location = new Point(12, 285);
            lblOrderStatus.Name = "lblOrderStatus";
            lblOrderStatus.Size = new Size(120, 20);
            lblOrderStatus.TabIndex = 6;
            lblOrderStatus.Text = "Trạng thái đặt vé";
            // 
            // txtOrderId
            // 
            txtOrderId.Location = new Point(184, 26);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(175, 27);
            txtOrderId.TabIndex = 7;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(184, 121);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(175, 27);
            txtCustomerName.TabIndex = 9;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(184, 171);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(175, 27);
            txtTotalPrice.TabIndex = 10;
            // 
            // txtPaymentMethod
            // 
            txtPaymentMethod.Location = new Point(184, 227);
            txtPaymentMethod.Name = "txtPaymentMethod";
            txtPaymentMethod.Size = new Size(173, 27);
            txtPaymentMethod.TabIndex = 11;
            // 
            // txtOrderStatus
            // 
            txtOrderStatus.Location = new Point(182, 278);
            txtOrderStatus.Name = "txtOrderStatus";
            txtOrderStatus.Size = new Size(175, 27);
            txtOrderStatus.TabIndex = 12;
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(440, 33);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.Size = new Size(348, 362);
            dgvOrder.TabIndex = 14;
            dgvOrder.SelectionChanged += dgvOrder_SelectionChanged;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(184, 72);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(250, 27);
            dtpOrderDate.TabIndex = 15;
            // 
            // btnDetail
            // 
            btnDetail.Location = new Point(255, 366);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(102, 29);
            btnDetail.TabIndex = 16;
            btnDetail.Text = "Xem Chi Tiết";
            btnDetail.UseVisualStyleBackColor = true;
            btnDetail.Click += btnDetail_Click;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(155, 366);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(94, 29);
            btnPrint.TabIndex = 17;
            btnPrint.Text = "In Vé";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // frmOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 437);
            Controls.Add(btnPrint);
            Controls.Add(btnDetail);
            Controls.Add(dtpOrderDate);
            Controls.Add(dgvOrder);
            Controls.Add(txtOrderStatus);
            Controls.Add(txtPaymentMethod);
            Controls.Add(txtTotalPrice);
            Controls.Add(txtCustomerName);
            Controls.Add(txtOrderId);
            Controls.Add(lblOrderStatus);
            Controls.Add(lblPaymentMethod);
            Controls.Add(lblTotalPrice);
            Controls.Add(lblCustomerName);
            Controls.Add(lblOrderDate);
            Controls.Add(lblOrderId);
            Name = "frmOrder";
            Text = "frmOrder";
            Load += frmOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrderId;
        private Label lblOrderDate;
        private Label lblCustomerName;
        private Label lblTotalPrice;
        private Label lblPaymentMethod;
        private Label lblOrderStatus;
        private TextBox txtOrderId;
        private TextBox txtCustomerName;
        private TextBox txtTotalPrice;
        private TextBox txtPaymentMethod;
        private TextBox txtOrderStatus;
        private DataGridView dgvOrder;
        private DateTimePicker dtpOrderDate;
        private Button btnDetail;
        private Button btnPrint;
    }
}