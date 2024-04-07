namespace SaleManagementWinApp
{
    partial class frmUpdateCustomer
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
            btnCancel = new Button();
            btUpdate = new Button();
            txtCustomerPassword = new TextBox();
            txtCustomerEmail = new TextBox();
            txtCustomerName = new TextBox();
            lbCustomerPassword = new Label();
            lbCustomerEmail = new Label();
            lbCustomerName = new Label();
            label1 = new Label();
            txtPhoneNumber = new TextBox();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(323, 301);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 57;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btUpdate
            // 
            btUpdate.Location = new Point(211, 301);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(94, 29);
            btUpdate.TabIndex = 56;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // txtCustomerPassword
            // 
            txtCustomerPassword.Enabled = false;
            txtCustomerPassword.Location = new Point(160, 186);
            txtCustomerPassword.Name = "txtCustomerPassword";
            txtCustomerPassword.Size = new Size(257, 27);
            txtCustomerPassword.TabIndex = 50;
            txtCustomerPassword.UseSystemPasswordChar = true;
            // 
            // txtCustomerEmail
            // 
            txtCustomerEmail.Location = new Point(160, 130);
            txtCustomerEmail.Name = "txtCustomerEmail";
            txtCustomerEmail.Size = new Size(257, 27);
            txtCustomerEmail.TabIndex = 49;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(160, 75);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(257, 27);
            txtCustomerName.TabIndex = 48;
            // 
            // lbCustomerPassword
            // 
            lbCustomerPassword.AutoSize = true;
            lbCustomerPassword.Location = new Point(40, 189);
            lbCustomerPassword.Name = "lbCustomerPassword";
            lbCustomerPassword.Size = new Size(73, 20);
            lbCustomerPassword.TabIndex = 43;
            lbCustomerPassword.Text = "Password:";
            // 
            // lbCustomerEmail
            // 
            lbCustomerEmail.AutoSize = true;
            lbCustomerEmail.Location = new Point(40, 133);
            lbCustomerEmail.Name = "lbCustomerEmail";
            lbCustomerEmail.Size = new Size(49, 20);
            lbCustomerEmail.TabIndex = 42;
            lbCustomerEmail.Text = "Email:";
            // 
            // lbCustomerName
            // 
            lbCustomerName.AutoSize = true;
            lbCustomerName.Location = new Point(40, 78);
            lbCustomerName.Name = "lbCustomerName";
            lbCustomerName.Size = new Size(116, 20);
            lbCustomerName.TabIndex = 41;
            lbCustomerName.Text = "Customer name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 250);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 58;
            label1.Text = "Phone number";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Enabled = false;
            txtPhoneNumber.Location = new Point(160, 247);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(257, 27);
            txtPhoneNumber.TabIndex = 59;
            // 
            // frmUpdateCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 366);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btUpdate);
            Controls.Add(txtCustomerPassword);
            Controls.Add(txtCustomerEmail);
            Controls.Add(txtCustomerName);
            Controls.Add(lbCustomerPassword);
            Controls.Add(lbCustomerEmail);
            Controls.Add(lbCustomerName);
            Name = "frmUpdateCustomer";
            Text = "Update customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btUpdate;
        private TextBox txtCustomerPassword;
        private TextBox txtCustomerEmail;
        private TextBox txtCustomerName;
        private Label lbCustomerPassword;
        private Label lbCustomerEmail;
        private Label lbCustomerName;
        private Label label1;
        private TextBox txtPhoneNumber;
    }
}