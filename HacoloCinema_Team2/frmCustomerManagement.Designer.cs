namespace HacoloCinema_Team2
{
    partial class frmCustomerManagement
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
            dgvCustomerList = new DataGridView();
            lblCustomerId = new Label();
            lblCustomerName = new Label();
            lblEmail = new Label();
            lblPhoneNumber = new Label();
            txtCustomerId = new TextBox();
            txtCustomerName = new TextBox();
            txtCustomerEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            lblSearch = new Label();
            txtSearchValue = new TextBox();
            cmbFilter = new ComboBox();
            btnOrderHistory = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerList).BeginInit();
            SuspendLayout();
            // 
            // dgvCustomerList
            // 
            dgvCustomerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerList.Location = new Point(447, 117);
            dgvCustomerList.Name = "dgvCustomerList";
            dgvCustomerList.RowHeadersWidth = 51;
            dgvCustomerList.Size = new Size(523, 243);
            dgvCustomerList.TabIndex = 0;
            dgvCustomerList.CellClick += dgvCustomerList_CellContentClick;
            dgvCustomerList.CellContentClick += dgvCustomerList_CellContentClick;
            // 
            // lblCustomerId
            // 
            lblCustomerId.AutoSize = true;
            lblCustomerId.Location = new Point(31, 56);
            lblCustomerId.Name = "lblCustomerId";
            lblCustomerId.Size = new Size(22, 20);
            lblCustomerId.TabIndex = 1;
            lblCustomerId.Text = "Id";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(31, 120);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(49, 20);
            lblCustomerName.TabIndex = 2;
            lblCustomerName.Text = "Name";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(31, 189);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(31, 260);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(105, 20);
            lblPhoneNumber.TabIndex = 5;
            lblPhoneNumber.Text = "Phone number";
            // 
            // txtCustomerId
            // 
            txtCustomerId.Location = new Point(142, 53);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(227, 27);
            txtCustomerId.TabIndex = 6;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(142, 117);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(227, 27);
            txtCustomerName.TabIndex = 7;
            // 
            // txtCustomerEmail
            // 
            txtCustomerEmail.Location = new Point(142, 186);
            txtCustomerEmail.Name = "txtCustomerEmail";
            txtCustomerEmail.Size = new Size(227, 27);
            txtCustomerEmail.TabIndex = 8;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(142, 257);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(227, 27);
            txtPhoneNumber.TabIndex = 9;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(447, 56);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(53, 20);
            lblSearch.TabIndex = 10;
            lblSearch.Text = "Search";
            // 
            // txtSearchValue
            // 
            txtSearchValue.Location = new Point(506, 52);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.Size = new Size(138, 27);
            txtSearchValue.TabIndex = 11;
            txtSearchValue.TextChanged += txtSearchValue_TextChanged;
            // 
            // cmbFilter
            // 
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Location = new Point(819, 56);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(151, 28);
            cmbFilter.TabIndex = 12;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // btnOrderHistory
            // 
            btnOrderHistory.Location = new Point(231, 331);
            btnOrderHistory.Name = "btnOrderHistory";
            btnOrderHistory.Size = new Size(138, 29);
            btnOrderHistory.TabIndex = 14;
            btnOrderHistory.Text = "View order history";
            btnOrderHistory.UseVisualStyleBackColor = true;
            btnOrderHistory.Click += btnOrderHistory_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(876, 382);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 16;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // frmCustomerManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 423);
            Controls.Add(btnBack);
            Controls.Add(btnOrderHistory);
            Controls.Add(cmbFilter);
            Controls.Add(txtSearchValue);
            Controls.Add(lblSearch);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtCustomerEmail);
            Controls.Add(txtCustomerName);
            Controls.Add(txtCustomerId);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblEmail);
            Controls.Add(lblCustomerName);
            Controls.Add(lblCustomerId);
            Controls.Add(dgvCustomerList);
            Name = "frmCustomerManagement";
            Text = "Customers management";
            Load += frmCustomerManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomerList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCustomerList;
        private Label lblCustomerId;
        private Label lblCustomerName;
        private Label lblEmail;
        private Label lblPhoneNumber;
        private TextBox txtCustomerId;
        private TextBox txtCustomerName;
        private TextBox txtCustomerEmail;
        private TextBox txtPhoneNumber;
        private Label lblSearch;
        private TextBox txtSearchValue;
        private ComboBox cmbFilter;
        private Button btnAdd;
        private Button btnOrderHistory;
        private Button btnBack;
    }
}