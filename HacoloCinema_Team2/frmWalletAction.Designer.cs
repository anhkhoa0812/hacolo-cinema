namespace HacoloCinema_Team2
{
    partial class frmWalletAction
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
            lblMoney = new Label();
            txtMoney = new TextBox();
            btnAction = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblMoney
            // 
            lblMoney.AutoSize = true;
            lblMoney.Location = new Point(64, 56);
            lblMoney.Name = "lblMoney";
            lblMoney.Size = new Size(93, 20);
            lblMoney.TabIndex = 0;
            lblMoney.Text = "Nhập số tiền";
            // 
            // txtMoney
            // 
            txtMoney.Location = new Point(172, 49);
            txtMoney.Name = "txtMoney";
            txtMoney.Size = new Size(158, 27);
            txtMoney.TabIndex = 1;
            // 
            // btnAction
            // 
            btnAction.Location = new Point(136, 99);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(94, 29);
            btnAction.TabIndex = 2;
            btnAction.Text = "button1";
            btnAction.UseVisualStyleBackColor = true;
            btnAction.Click += btnAction_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(236, 99);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 3;
            btnBack.Text = "Quay Lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // frmWalletAction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 174);
            Controls.Add(btnBack);
            Controls.Add(btnAction);
            Controls.Add(txtMoney);
            Controls.Add(lblMoney);
            Name = "frmWalletAction";
            Text = "  ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMoney;
        private TextBox txtMoney;
        private Button btnAction;
        private Button btnBack;
    }
}