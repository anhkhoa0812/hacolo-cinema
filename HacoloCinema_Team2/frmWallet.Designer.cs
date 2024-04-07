namespace HacoloCinema_Team2
{
    partial class frmWallet
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
            lblBalance = new Label();
            btnAddMoney = new Button();
            btnWithdrawMoney = new Button();
            btnWalletTransaction = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(75, 45);
            label1.Name = "label1";
            label1.Size = new Size(76, 31);
            label1.TabIndex = 0;
            label1.Text = "Số dư";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBalance.Location = new Point(75, 90);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(268, 46);
            lblBalance.TabIndex = 1;
            lblBalance.Text = "12.1341234 VND";
            // 
            // btnAddMoney
            // 
            btnAddMoney.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddMoney.Location = new Point(180, 154);
            btnAddMoney.Name = "btnAddMoney";
            btnAddMoney.Size = new Size(95, 40);
            btnAddMoney.TabIndex = 2;
            btnAddMoney.Text = "Nạp Tiền";
            btnAddMoney.UseVisualStyleBackColor = true;
            btnAddMoney.Click += btnAddMoney_Click;
            // 
            // btnWithdrawMoney
            // 
            btnWithdrawMoney.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWithdrawMoney.Location = new Point(294, 154);
            btnWithdrawMoney.Name = "btnWithdrawMoney";
            btnWithdrawMoney.Size = new Size(94, 40);
            btnWithdrawMoney.TabIndex = 3;
            btnWithdrawMoney.Text = "Rút Tiền";
            btnWithdrawMoney.UseVisualStyleBackColor = true;
            btnWithdrawMoney.Click += btnWithdrawMoney_Click;
            // 
            // btnWalletTransaction
            // 
            btnWalletTransaction.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWalletTransaction.Location = new Point(28, 154);
            btnWalletTransaction.Name = "btnWalletTransaction";
            btnWalletTransaction.Size = new Size(135, 40);
            btnWalletTransaction.TabIndex = 4;
            btnWalletTransaction.Text = "Lịch sử giao dịch";
            btnWalletTransaction.UseVisualStyleBackColor = true;
            btnWalletTransaction.Click += btnWalletTransaction_Click;
            // 
            // frmWallet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 254);
            Controls.Add(btnWalletTransaction);
            Controls.Add(btnWithdrawMoney);
            Controls.Add(btnAddMoney);
            Controls.Add(lblBalance);
            Controls.Add(label1);
            Name = "frmWallet";
            Text = "frmWallet";
            Load += frmWallet_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblBalance;
        private Button btnAddMoney;
        private Button btnWithdrawMoney;
        private Button btnWalletTransaction;
    }
}