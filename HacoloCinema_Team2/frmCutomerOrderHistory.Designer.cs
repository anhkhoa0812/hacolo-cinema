namespace HacoloCinema_Team2
{
    partial class frmCutomerOrderHistory
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
            lblCustomerName = new Label();
            lblOrderId = new Label();
            cmbOrders = new ComboBox();
            lblOrderTotal = new Label();
            txtOrderTotal = new TextBox();
            dgvOrderDetail = new DataGridView();
            btnBack = new Button();
            dgvTickets = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).BeginInit();
            SuspendLayout();
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI", 16F);
            lblCustomerName.Location = new Point(24, 35);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(131, 37);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "Customer";
            // 
            // lblOrderId
            // 
            lblOrderId.AutoSize = true;
            lblOrderId.Location = new Point(24, 99);
            lblOrderId.Name = "lblOrderId";
            lblOrderId.Size = new Size(64, 20);
            lblOrderId.TabIndex = 1;
            lblOrderId.Text = "Order id";
            // 
            // cmbOrders
            // 
            cmbOrders.FormattingEnabled = true;
            cmbOrders.Location = new Point(108, 96);
            cmbOrders.Name = "cmbOrders";
            cmbOrders.Size = new Size(162, 28);
            cmbOrders.TabIndex = 2;
            cmbOrders.SelectedIndexChanged += cmbOrders_SelectedIndexChanged;
            // 
            // lblOrderTotal
            // 
            lblOrderTotal.AutoSize = true;
            lblOrderTotal.Location = new Point(24, 163);
            lblOrderTotal.Name = "lblOrderTotal";
            lblOrderTotal.Size = new Size(42, 20);
            lblOrderTotal.TabIndex = 3;
            lblOrderTotal.Text = "Total";
            // 
            // txtOrderTotal
            // 
            txtOrderTotal.Location = new Point(108, 160);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.Size = new Size(162, 27);
            txtOrderTotal.TabIndex = 4;
            // 
            // dgvOrderDetail
            // 
            dgvOrderDetail.BorderStyle = BorderStyle.None;
            dgvOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetail.Location = new Point(315, 96);
            dgvOrderDetail.Name = "dgvOrderDetail";
            dgvOrderDetail.RowHeadersWidth = 51;
            dgvOrderDetail.Size = new Size(749, 196);
            dgvOrderDetail.TabIndex = 5;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(970, 491);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dgvTickets
            // 
            dgvTickets.BorderStyle = BorderStyle.None;
            dgvTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTickets.Location = new Point(315, 292);
            dgvTickets.Name = "dgvTickets";
            dgvTickets.RowHeadersWidth = 51;
            dgvTickets.Size = new Size(749, 188);
            dgvTickets.TabIndex = 7;
            // 
            // frmCutomerOrderHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 532);
            Controls.Add(dgvTickets);
            Controls.Add(btnBack);
            Controls.Add(dgvOrderDetail);
            Controls.Add(txtOrderTotal);
            Controls.Add(lblOrderTotal);
            Controls.Add(cmbOrders);
            Controls.Add(lblOrderId);
            Controls.Add(lblCustomerName);
            Name = "frmCutomerOrderHistory";
            Text = "Cutomer's order history";
            Load += CutomerOrderHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomerName;
        private Label lblOrderId;
        private ComboBox cmbOrders;
        private Label lblOrderTotal;
        private TextBox txtOrderTotal;
        private DataGridView dgvOrderDetail;
        private Button btnBack;
        private DataGridView dgvTickets;
    }
}