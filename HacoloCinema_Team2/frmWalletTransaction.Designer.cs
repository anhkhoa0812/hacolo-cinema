namespace HacoloCinema_Team2
{
    partial class frmWalletTransaction
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
            lblWalletTransactionId = new Label();
            lblTransactionAmount = new Label();
            lblTransactionDate = new Label();
            lblWalletId = new Label();
            txtWalletTransactionId = new TextBox();
            txtTransactionAmount = new TextBox();
            txtWalletId = new TextBox();
            dtpTransactionDate = new DateTimePicker();
            dgvWalletTransaction = new DataGridView();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvWalletTransaction).BeginInit();
            SuspendLayout();
            // 
            // lblWalletTransactionId
            // 
            lblWalletTransactionId.AutoSize = true;
            lblWalletTransactionId.Location = new Point(29, 63);
            lblWalletTransactionId.Name = "lblWalletTransactionId";
            lblWalletTransactionId.Size = new Size(91, 20);
            lblWalletTransactionId.TabIndex = 0;
            lblWalletTransactionId.Text = "ID Giao dịch";
            // 
            // lblTransactionAmount
            // 
            lblTransactionAmount.AutoSize = true;
            lblTransactionAmount.Location = new Point(29, 110);
            lblTransactionAmount.Name = "lblTransactionAmount";
            lblTransactionAmount.Size = new Size(72, 20);
            lblTransactionAmount.TabIndex = 1;
            lblTransactionAmount.Text = "Giao dịch";
            // 
            // lblTransactionDate
            // 
            lblTransactionDate.AutoSize = true;
            lblTransactionDate.Location = new Point(29, 151);
            lblTransactionDate.Name = "lblTransactionDate";
            lblTransactionDate.Size = new Size(111, 20);
            lblTransactionDate.TabIndex = 2;
            lblTransactionDate.Text = "Ngày Giao dịch";
            // 
            // lblWalletId
            // 
            lblWalletId.AutoSize = true;
            lblWalletId.Location = new Point(29, 196);
            lblWalletId.Name = "lblWalletId";
            lblWalletId.Size = new Size(41, 20);
            lblWalletId.TabIndex = 3;
            lblWalletId.Text = "ID Ví";
            // 
            // txtWalletTransactionId
            // 
            txtWalletTransactionId.Location = new Point(146, 56);
            txtWalletTransactionId.Name = "txtWalletTransactionId";
            txtWalletTransactionId.ReadOnly = true;
            txtWalletTransactionId.Size = new Size(145, 27);
            txtWalletTransactionId.TabIndex = 4;
            // 
            // txtTransactionAmount
            // 
            txtTransactionAmount.Location = new Point(146, 103);
            txtTransactionAmount.Name = "txtTransactionAmount";
            txtTransactionAmount.ReadOnly = true;
            txtTransactionAmount.Size = new Size(145, 27);
            txtTransactionAmount.TabIndex = 5;
            // 
            // txtWalletId
            // 
            txtWalletId.Location = new Point(146, 189);
            txtWalletId.Name = "txtWalletId";
            txtWalletId.ReadOnly = true;
            txtWalletId.Size = new Size(145, 27);
            txtWalletId.TabIndex = 6;
            // 
            // dtpTransactionDate
            // 
            dtpTransactionDate.Location = new Point(146, 144);
            dtpTransactionDate.Name = "dtpTransactionDate";
            dtpTransactionDate.Size = new Size(250, 27);
            dtpTransactionDate.TabIndex = 7;
            // 
            // dgvWalletTransaction
            // 
            dgvWalletTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWalletTransaction.Location = new Point(423, 56);
            dgvWalletTransaction.Name = "dgvWalletTransaction";
            dgvWalletTransaction.ReadOnly = true;
            dgvWalletTransaction.RowHeadersWidth = 51;
            dgvWalletTransaction.Size = new Size(350, 330);
            dgvWalletTransaction.TabIndex = 8;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(266, 319);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 34);
            btnBack.TabIndex = 9;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // frmWalletTransaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(dgvWalletTransaction);
            Controls.Add(dtpTransactionDate);
            Controls.Add(txtWalletId);
            Controls.Add(txtTransactionAmount);
            Controls.Add(txtWalletTransactionId);
            Controls.Add(lblWalletId);
            Controls.Add(lblTransactionDate);
            Controls.Add(lblTransactionAmount);
            Controls.Add(lblWalletTransactionId);
            Name = "frmWalletTransaction";
            Text = "frmWalletTransaction";
            Load += frmWalletTransaction_Load;
            ((System.ComponentModel.ISupportInitialize)dgvWalletTransaction).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWalletTransactionId;
        private Label lblTransactionAmount;
        private Label lblTransactionDate;
        private Label lblWalletId;
        private TextBox txtWalletTransactionId;
        private TextBox txtTransactionAmount;
        private TextBox txtWalletId;
        private DateTimePicker dtpTransactionDate;
        private DataGridView dgvWalletTransaction;
        private Button btnBack;
    }
}