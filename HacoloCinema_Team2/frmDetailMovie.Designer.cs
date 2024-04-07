namespace HacoloCinema_Team2
{
    partial class frmDetailMovie
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
            pictureBox1 = new PictureBox();
            lblMovieName = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            txtDescription = new RichTextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(43, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(322, 464);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblMovieName
            // 
            lblMovieName.AutoSize = true;
            lblMovieName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMovieName.Location = new Point(21, 23);
            lblMovieName.Name = "lblMovieName";
            lblMovieName.Size = new Size(144, 31);
            lblMovieName.TabIndex = 1;
            lblMovieName.Text = "MovieName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 63);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 2;
            label2.Text = "Thể loại:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 92);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 3;
            label3.Text = "Thời lượng:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 126);
            label5.Name = "label5";
            label5.Size = new Size(125, 20);
            label5.TabIndex = 5;
            label5.Text = "Ngày khởi chiếu:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblMovieName);
            groupBox1.Location = new Point(403, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(495, 464);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phim";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(23, 288);
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(454, 156);
            txtDescription.TabIndex = 17;
            txtDescription.Text = "";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(21, 247);
            label13.Name = "label13";
            label13.Size = new Size(78, 20);
            label13.TabIndex = 16;
            label13.Text = "Nội dung:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(21, 216);
            label12.Name = "label12";
            label12.Size = new Size(75, 20);
            label12.TabIndex = 14;
            label12.Text = "Đạo diễn:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(21, 187);
            label11.Name = "label11";
            label11.Size = new Size(78, 20);
            label11.TabIndex = 13;
            label11.Text = "Diễn viên:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(157, 216);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 12;
            label8.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(157, 187);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 11;
            label9.Text = "label9";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(157, 158);
            label10.Name = "label10";
            label10.Size = new Size(58, 20);
            label10.TabIndex = 10;
            label10.Text = "label10";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(21, 158);
            label7.Name = "label7";
            label7.Size = new Size(124, 20);
            label7.TabIndex = 9;
            label7.Text = "Độ tuổi giới hạn:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(157, 126);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 8;
            label6.Text = "label6";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(157, 92);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 7;
            label4.Text = "label4";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 63);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(43, 536);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(228, 536);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(405, 536);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Chọn ghế";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmDetailMovie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 642);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "frmDetailMovie";
            Text = "Thông tin phim";
            Load += frmDetailMovie_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblMovieName;
        private Label label2;
        private Label label3;
        private Label label5;
        private GroupBox groupBox1;
        private Label label4;
        private Label label1;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label7;
        private Label label6;
        private RichTextBox txtDescription;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button1;
    }
}