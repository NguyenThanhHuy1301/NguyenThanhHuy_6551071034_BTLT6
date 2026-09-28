namespace C5_Cau1_GiaoDoAn
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtHoTen = new TextBox();
            txtSDT = new TextBox();
            txtEmail = new TextBox();
            txtMatKhau = new TextBox();
            txtXacNhanMK = new TextBox();
            btnDangKy = new Button();
            btnHuy = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 21);
            label1.Name = "label1";
            label1.Size = new Size(318, 38);
            label1.TabIndex = 0;
            label1.Text = "Đăng ký tài khoản mới";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 73);
            label2.Name = "label2";
            label2.Size = new Size(214, 20);
            label2.TabIndex = 1;
            label2.Text = "Vui lòng nhập đầy đủ thông tin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(220, 114);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 2;
            label3.Text = "Họ tên:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(177, 160);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 3;
            label4.Text = "Số điện thoại:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(228, 207);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 4;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(202, 259);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 5;
            label6.Text = "Mật Khẩu:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(134, 305);
            label7.Name = "label7";
            label7.Size = new Size(143, 20);
            label7.TabIndex = 6;
            label7.Text = "Xác Nhập Mật Khẩu:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(283, 107);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(261, 27);
            txtHoTen.TabIndex = 7;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(283, 153);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(261, 27);
            txtSDT.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(283, 200);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(261, 27);
            txtEmail.TabIndex = 9;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(283, 252);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(261, 27);
            txtMatKhau.TabIndex = 10;
            // 
            // txtXacNhanMK
            // 
            txtXacNhanMK.Location = new Point(283, 298);
            txtXacNhanMK.Name = "txtXacNhanMK";
            txtXacNhanMK.Size = new Size(261, 27);
            txtXacNhanMK.TabIndex = 11;
            txtXacNhanMK.TextChanged += txtXacNhanMK_TextChanged;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = SystemColors.Highlight;
            btnDangKy.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangKy.ForeColor = SystemColors.ButtonHighlight;
            btnDangKy.Location = new Point(283, 362);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(98, 34);
            btnDangKy.TabIndex = 12;
            btnDangKy.Text = "Đăng Ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = SystemColors.ActiveBorder;
            btnHuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.Location = new Point(450, 366);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 13;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHuy);
            Controls.Add(btnDangKy);
            Controls.Add(txtXacNhanMK);
            Controls.Add(txtMatKhau);
            Controls.Add(txtEmail);
            Controls.Add(txtSDT);
            Controls.Add(txtHoTen);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtHoTen;
        private TextBox txtSDT;
        private TextBox txtEmail;
        private TextBox txtMatKhau;
        private TextBox txtXacNhanMK;
        private Button btnDangKy;
        private Button btnHuy;
        private ErrorProvider errorProvider1;
    }
}
