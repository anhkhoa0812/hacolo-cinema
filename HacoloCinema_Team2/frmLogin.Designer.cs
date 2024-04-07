namespace SaleManagementWinApp
{
    partial class frmLogin
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
            txtPhone = new TextBox();
            txtPassword = new TextBox();
            btLogin = new Button();
            btExit = new Button();
            cbShowPassword = new CheckBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 33);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "Số điện thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 77);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(154, 30);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(314, 27);
            txtPhone.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(154, 74);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(314, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btLogin
            // 
            btLogin.Location = new Point(154, 147);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(94, 29);
            btLogin.TabIndex = 4;
            btLogin.Text = "Đăng nhập";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // btExit
            // 
            btExit.Location = new Point(374, 147);
            btExit.Name = "btExit";
            btExit.Size = new Size(94, 29);
            btExit.TabIndex = 6;
            btExit.Text = "Thoát";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // cbShowPassword
            // 
            cbShowPassword.AutoSize = true;
            cbShowPassword.Location = new Point(158, 114);
            cbShowPassword.Name = "cbShowPassword";
            cbShowPassword.Size = new Size(127, 24);
            cbShowPassword.TabIndex = 7;
            cbShowPassword.Text = "Hiện mật khẩu";
            cbShowPassword.UseVisualStyleBackColor = true;
            cbShowPassword.CheckedChanged += cbShowPassword_CheckedChanged;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(264, 147);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 185);
            Controls.Add(btnRegister);
            Controls.Add(cbShowPassword);
            Controls.Add(btExit);
            Controls.Add(btLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtPhone);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPhone;
        private TextBox txtPassword;
        private Button btLogin;
        private Button btExit;
        private CheckBox cbShowPassword;
        private Button btnRegister;
    }
}