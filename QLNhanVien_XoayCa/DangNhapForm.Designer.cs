namespace QLNhanVien_XoayCa
{
    partial class DangNhapForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbTaiKhoan = new System.Windows.Forms.TextBox();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tài khoản";
            // 
            // tbTaiKhoan
            // 
            this.tbTaiKhoan.Location = new System.Drawing.Point(130, 44);
            this.tbTaiKhoan.Name = "tbTaiKhoan";
            this.tbTaiKhoan.Size = new System.Drawing.Size(240, 29);
            this.tbTaiKhoan.TabIndex = 0;
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Location = new System.Drawing.Point(130, 103);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.Size = new System.Drawing.Size(240, 29);
            this.tbMatKhau.TabIndex = 1;
            this.tbMatKhau.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDangNhap.ForeColor = System.Drawing.Color.Black;
            this.btnDangNhap.Location = new System.Drawing.Point(149, 170);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(121, 36);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDangNhap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbMatKhau);
            this.groupBox1.Controls.Add(this.tbTaiKhoan);
            this.groupBox1.Location = new System.Drawing.Point(21, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 230);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(60, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quản lý nhân viên xoay ca";
            // 
            // DangNhapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(447, 361);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DangNhapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTaiKhoan;
        private System.Windows.Forms.TextBox tbMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
    }
}