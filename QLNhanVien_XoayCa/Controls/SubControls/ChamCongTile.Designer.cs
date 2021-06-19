namespace QLNhanVien_XoayCa.Controls.SubControls
{
    partial class ChamCongTile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbNhanVien = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbThongTin = new System.Windows.Forms.Label();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.btnStatus = new System.Windows.Forms.Button();
            this.lbMaNV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNhanVien
            // 
            this.lbNhanVien.AutoSize = true;
            this.lbNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhanVien.ForeColor = System.Drawing.Color.Maroon;
            this.lbNhanVien.Location = new System.Drawing.Point(3, 6);
            this.lbNhanVien.Name = "lbNhanVien";
            this.lbNhanVien.Size = new System.Drawing.Size(68, 20);
            this.lbNhanVien.TabIndex = 0;
            this.lbNhanVien.Text = "Tên NV";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLNhanVien_XoayCa.Properties.Resources.contact_icon;
            this.pictureBox1.Location = new System.Drawing.Point(3, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 66);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbThongTin
            // 
            this.lbThongTin.AutoSize = true;
            this.lbThongTin.Location = new System.Drawing.Point(75, 69);
            this.lbThongTin.Name = "lbThongTin";
            this.lbThongTin.Size = new System.Drawing.Size(75, 20);
            this.lbThongTin.TabIndex = 2;
            this.lbThongTin.Text = "ThongTin";
            // 
            // lbChucVu
            // 
            this.lbChucVu.AutoSize = true;
            this.lbChucVu.Location = new System.Drawing.Point(75, 49);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(66, 20);
            this.lbChucVu.TabIndex = 3;
            this.lbChucVu.Text = "ChucVu";
            // 
            // btnStatus
            // 
            this.btnStatus.BackColor = System.Drawing.Color.Green;
            this.btnStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatus.ForeColor = System.Drawing.Color.White;
            this.btnStatus.Location = new System.Drawing.Point(156, 92);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(98, 30);
            this.btnStatus.TabIndex = 4;
            this.btnStatus.Text = "Checkin";
            this.btnStatus.UseVisualStyleBackColor = false;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Location = new System.Drawing.Point(75, 29);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(53, 20);
            this.lbMaNV.TabIndex = 5;
            this.lbMaNV.Text = "MaNV";
            // 
            // ChamCongTile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbMaNV);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.lbChucVu);
            this.Controls.Add(this.lbThongTin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbNhanVien);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChamCongTile";
            this.Size = new System.Drawing.Size(257, 125);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNhanVien;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbThongTin;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Label lbMaNV;
    }
}
