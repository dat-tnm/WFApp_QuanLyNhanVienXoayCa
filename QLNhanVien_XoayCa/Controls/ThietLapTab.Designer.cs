namespace QLNhanVien_XoayCa.Controls
{
    partial class ThietLapTab
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPCa = new System.Windows.Forms.TabPage();
            this.timeP_GioKetThuc = new System.Windows.Forms.DateTimePicker();
            this.timeP_GioBatDau = new System.Windows.Forms.DateTimePicker();
            this.btnClearCa = new System.Windows.Forms.Button();
            this.btnAddCa = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbTenCa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMaC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteCa = new System.Windows.Forms.Button();
            this.btnEditCa = new System.Windows.Forms.Button();
            this.dataGV_Ca = new System.Windows.Forms.DataGridView();
            this.tabPChucVu = new System.Windows.Forms.TabPage();
            this.btnClearCV = new System.Windows.Forms.Button();
            this.btnAddCV = new System.Windows.Forms.Button();
            this.tbTenCV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaCV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeleteCV = new System.Windows.Forms.Button();
            this.btnEditCV = new System.Windows.Forms.Button();
            this.dataGV_ChucVu = new System.Windows.Forms.DataGridView();
            this.tabPHeSoLuong = new System.Windows.Forms.TabPage();
            this.cbbChucVu = new System.Windows.Forms.ComboBox();
            this.cbbCa = new System.Windows.Forms.ComboBox();
            this.tbHeSoLuong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddHSL = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDeleteHSL = new System.Windows.Forms.Button();
            this.btnEditHSL = new System.Windows.Forms.Button();
            this.dataGV_HeSoLuong = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPCa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Ca)).BeginInit();
            this.tabPChucVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_ChucVu)).BeginInit();
            this.tabPHeSoLuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_HeSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPCa);
            this.tabControl1.Controls.Add(this.tabPChucVu);
            this.tabControl1.Controls.Add(this.tabPHeSoLuong);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(8, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1135, 808);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPCa
            // 
            this.tabPCa.BackColor = System.Drawing.Color.White;
            this.tabPCa.Controls.Add(this.timeP_GioKetThuc);
            this.tabPCa.Controls.Add(this.timeP_GioBatDau);
            this.tabPCa.Controls.Add(this.btnClearCa);
            this.tabPCa.Controls.Add(this.btnAddCa);
            this.tabPCa.Controls.Add(this.label8);
            this.tabPCa.Controls.Add(this.label9);
            this.tabPCa.Controls.Add(this.tbTenCa);
            this.tabPCa.Controls.Add(this.label3);
            this.tabPCa.Controls.Add(this.tbMaC);
            this.tabPCa.Controls.Add(this.label1);
            this.tabPCa.Controls.Add(this.btnDeleteCa);
            this.tabPCa.Controls.Add(this.btnEditCa);
            this.tabPCa.Controls.Add(this.dataGV_Ca);
            this.tabPCa.ForeColor = System.Drawing.Color.Black;
            this.tabPCa.Location = new System.Drawing.Point(4, 29);
            this.tabPCa.Name = "tabPCa";
            this.tabPCa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPCa.Size = new System.Drawing.Size(1127, 775);
            this.tabPCa.TabIndex = 1;
            this.tabPCa.Text = "Ca làm việc";
            // 
            // timeP_GioKetThuc
            // 
            this.timeP_GioKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeP_GioKetThuc.Location = new System.Drawing.Point(284, 158);
            this.timeP_GioKetThuc.Name = "timeP_GioKetThuc";
            this.timeP_GioKetThuc.Size = new System.Drawing.Size(205, 26);
            this.timeP_GioKetThuc.TabIndex = 41;
            // 
            // timeP_GioBatDau
            // 
            this.timeP_GioBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeP_GioBatDau.Location = new System.Drawing.Point(284, 96);
            this.timeP_GioBatDau.Name = "timeP_GioBatDau";
            this.timeP_GioBatDau.Size = new System.Drawing.Size(205, 26);
            this.timeP_GioBatDau.TabIndex = 40;
            // 
            // btnClearCa
            // 
            this.btnClearCa.Location = new System.Drawing.Point(542, 73);
            this.btnClearCa.Name = "btnClearCa";
            this.btnClearCa.Size = new System.Drawing.Size(86, 35);
            this.btnClearCa.TabIndex = 39;
            this.btnClearCa.Text = "Tạo mới";
            this.btnClearCa.UseVisualStyleBackColor = true;
            this.btnClearCa.Click += new System.EventHandler(this.btnClearCa_Click);
            // 
            // btnAddCa
            // 
            this.btnAddCa.Location = new System.Drawing.Point(634, 73);
            this.btnAddCa.Name = "btnAddCa";
            this.btnAddCa.Size = new System.Drawing.Size(86, 35);
            this.btnAddCa.TabIndex = 38;
            this.btnAddCa.Text = "Thêm";
            this.btnAddCa.UseVisualStyleBackColor = true;
            this.btnAddCa.Click += new System.EventHandler(this.btnAddCa_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Giờ bắt đầu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(280, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "Giờ kết thúc";
            // 
            // tbTenCa
            // 
            this.tbTenCa.Location = new System.Drawing.Point(10, 158);
            this.tbTenCa.Name = "tbTenCa";
            this.tbTenCa.Size = new System.Drawing.Size(210, 26);
            this.tbTenCa.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Tên ca";
            // 
            // tbMaC
            // 
            this.tbMaC.Enabled = false;
            this.tbMaC.Location = new System.Drawing.Point(10, 96);
            this.tbMaC.Name = "tbMaC";
            this.tbMaC.Size = new System.Drawing.Size(210, 26);
            this.tbMaC.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã ca";
            // 
            // btnDeleteCa
            // 
            this.btnDeleteCa.Location = new System.Drawing.Point(634, 154);
            this.btnDeleteCa.Name = "btnDeleteCa";
            this.btnDeleteCa.Size = new System.Drawing.Size(86, 35);
            this.btnDeleteCa.TabIndex = 25;
            this.btnDeleteCa.Text = "Xóa";
            this.btnDeleteCa.UseVisualStyleBackColor = true;
            this.btnDeleteCa.Click += new System.EventHandler(this.btnDeleteCa_Click);
            // 
            // btnEditCa
            // 
            this.btnEditCa.Location = new System.Drawing.Point(634, 113);
            this.btnEditCa.Name = "btnEditCa";
            this.btnEditCa.Size = new System.Drawing.Size(86, 35);
            this.btnEditCa.TabIndex = 24;
            this.btnEditCa.Text = "Sửa";
            this.btnEditCa.UseVisualStyleBackColor = true;
            this.btnEditCa.Click += new System.EventHandler(this.btnEditCa_Click);
            // 
            // dataGV_Ca
            // 
            this.dataGV_Ca.AllowUserToAddRows = false;
            this.dataGV_Ca.AllowUserToDeleteRows = false;
            this.dataGV_Ca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_Ca.Location = new System.Drawing.Point(6, 195);
            this.dataGV_Ca.Name = "dataGV_Ca";
            this.dataGV_Ca.ReadOnly = true;
            this.dataGV_Ca.Size = new System.Drawing.Size(984, 468);
            this.dataGV_Ca.TabIndex = 0;
            this.dataGV_Ca.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_Ca_CellContentClick);
            // 
            // tabPChucVu
            // 
            this.tabPChucVu.Controls.Add(this.btnClearCV);
            this.tabPChucVu.Controls.Add(this.btnAddCV);
            this.tabPChucVu.Controls.Add(this.tbTenCV);
            this.tabPChucVu.Controls.Add(this.label2);
            this.tabPChucVu.Controls.Add(this.tbMaCV);
            this.tabPChucVu.Controls.Add(this.label4);
            this.tabPChucVu.Controls.Add(this.btnDeleteCV);
            this.tabPChucVu.Controls.Add(this.btnEditCV);
            this.tabPChucVu.Controls.Add(this.dataGV_ChucVu);
            this.tabPChucVu.Location = new System.Drawing.Point(4, 29);
            this.tabPChucVu.Name = "tabPChucVu";
            this.tabPChucVu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPChucVu.Size = new System.Drawing.Size(1127, 775);
            this.tabPChucVu.TabIndex = 2;
            this.tabPChucVu.Text = "Chức vụ";
            this.tabPChucVu.UseVisualStyleBackColor = true;
            // 
            // btnClearCV
            // 
            this.btnClearCV.Location = new System.Drawing.Point(450, 73);
            this.btnClearCV.Name = "btnClearCV";
            this.btnClearCV.Size = new System.Drawing.Size(86, 35);
            this.btnClearCV.TabIndex = 60;
            this.btnClearCV.Text = "Làm mới";
            this.btnClearCV.UseVisualStyleBackColor = true;
            this.btnClearCV.Click += new System.EventHandler(this.btnClearCV_Click);
            // 
            // btnAddCV
            // 
            this.btnAddCV.Location = new System.Drawing.Point(542, 73);
            this.btnAddCV.Name = "btnAddCV";
            this.btnAddCV.Size = new System.Drawing.Size(86, 35);
            this.btnAddCV.TabIndex = 47;
            this.btnAddCV.Text = "Thêm";
            this.btnAddCV.UseVisualStyleBackColor = true;
            this.btnAddCV.Click += new System.EventHandler(this.btnAddCV_Click);
            // 
            // tbTenCV
            // 
            this.tbTenCV.Location = new System.Drawing.Point(107, 129);
            this.tbTenCV.Name = "tbTenCV";
            this.tbTenCV.Size = new System.Drawing.Size(210, 26);
            this.tbTenCV.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Tên chức vụ";
            // 
            // tbMaCV
            // 
            this.tbMaCV.Enabled = false;
            this.tbMaCV.Location = new System.Drawing.Point(107, 77);
            this.tbMaCV.Name = "tbMaCV";
            this.tbMaCV.Size = new System.Drawing.Size(210, 26);
            this.tbMaCV.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Mã chức vụ";
            // 
            // btnDeleteCV
            // 
            this.btnDeleteCV.Location = new System.Drawing.Point(542, 154);
            this.btnDeleteCV.Name = "btnDeleteCV";
            this.btnDeleteCV.Size = new System.Drawing.Size(86, 35);
            this.btnDeleteCV.TabIndex = 42;
            this.btnDeleteCV.Text = "Xóa";
            this.btnDeleteCV.UseVisualStyleBackColor = true;
            this.btnDeleteCV.Click += new System.EventHandler(this.btnDeleteCV_Click);
            // 
            // btnEditCV
            // 
            this.btnEditCV.Location = new System.Drawing.Point(542, 113);
            this.btnEditCV.Name = "btnEditCV";
            this.btnEditCV.Size = new System.Drawing.Size(86, 35);
            this.btnEditCV.TabIndex = 41;
            this.btnEditCV.Text = "Sửa";
            this.btnEditCV.UseVisualStyleBackColor = true;
            this.btnEditCV.Click += new System.EventHandler(this.btnEditCV_Click);
            // 
            // dataGV_ChucVu
            // 
            this.dataGV_ChucVu.AllowUserToAddRows = false;
            this.dataGV_ChucVu.AllowUserToDeleteRows = false;
            this.dataGV_ChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_ChucVu.Location = new System.Drawing.Point(6, 195);
            this.dataGV_ChucVu.Name = "dataGV_ChucVu";
            this.dataGV_ChucVu.ReadOnly = true;
            this.dataGV_ChucVu.Size = new System.Drawing.Size(984, 468);
            this.dataGV_ChucVu.TabIndex = 39;
            this.dataGV_ChucVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_ChucVu_CellContentClick);
            // 
            // tabPHeSoLuong
            // 
            this.tabPHeSoLuong.Controls.Add(this.cbbChucVu);
            this.tabPHeSoLuong.Controls.Add(this.cbbCa);
            this.tabPHeSoLuong.Controls.Add(this.tbHeSoLuong);
            this.tabPHeSoLuong.Controls.Add(this.label7);
            this.tabPHeSoLuong.Controls.Add(this.btnAddHSL);
            this.tabPHeSoLuong.Controls.Add(this.label5);
            this.tabPHeSoLuong.Controls.Add(this.label6);
            this.tabPHeSoLuong.Controls.Add(this.btnDeleteHSL);
            this.tabPHeSoLuong.Controls.Add(this.btnEditHSL);
            this.tabPHeSoLuong.Controls.Add(this.dataGV_HeSoLuong);
            this.tabPHeSoLuong.Location = new System.Drawing.Point(4, 29);
            this.tabPHeSoLuong.Name = "tabPHeSoLuong";
            this.tabPHeSoLuong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPHeSoLuong.Size = new System.Drawing.Size(1127, 775);
            this.tabPHeSoLuong.TabIndex = 3;
            this.tabPHeSoLuong.Text = "Hệ số lương";
            this.tabPHeSoLuong.UseVisualStyleBackColor = true;
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChucVu.FormattingEnabled = true;
            this.cbbChucVu.Location = new System.Drawing.Point(107, 117);
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.Size = new System.Drawing.Size(210, 28);
            this.cbbChucVu.TabIndex = 61;
            // 
            // cbbCa
            // 
            this.cbbCa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCa.FormattingEnabled = true;
            this.cbbCa.Location = new System.Drawing.Point(107, 77);
            this.cbbCa.Name = "cbbCa";
            this.cbbCa.Size = new System.Drawing.Size(210, 28);
            this.cbbCa.TabIndex = 60;
            // 
            // tbHeSoLuong
            // 
            this.tbHeSoLuong.Location = new System.Drawing.Point(107, 154);
            this.tbHeSoLuong.Name = "tbHeSoLuong";
            this.tbHeSoLuong.Size = new System.Drawing.Size(210, 26);
            this.tbHeSoLuong.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 57;
            this.label7.Text = "Hệ số lương";
            // 
            // btnAddHSL
            // 
            this.btnAddHSL.Location = new System.Drawing.Point(542, 73);
            this.btnAddHSL.Name = "btnAddHSL";
            this.btnAddHSL.Size = new System.Drawing.Size(86, 35);
            this.btnAddHSL.TabIndex = 56;
            this.btnAddHSL.Text = "Thêm";
            this.btnAddHSL.UseVisualStyleBackColor = true;
            this.btnAddHSL.Click += new System.EventHandler(this.btnAddHSL_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "Chức vụ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "Ca";
            // 
            // btnDeleteHSL
            // 
            this.btnDeleteHSL.Location = new System.Drawing.Point(542, 154);
            this.btnDeleteHSL.Name = "btnDeleteHSL";
            this.btnDeleteHSL.Size = new System.Drawing.Size(86, 35);
            this.btnDeleteHSL.TabIndex = 51;
            this.btnDeleteHSL.Text = "Xóa";
            this.btnDeleteHSL.UseVisualStyleBackColor = true;
            this.btnDeleteHSL.Click += new System.EventHandler(this.btnDeleteHSL_Click);
            // 
            // btnEditHSL
            // 
            this.btnEditHSL.Location = new System.Drawing.Point(542, 113);
            this.btnEditHSL.Name = "btnEditHSL";
            this.btnEditHSL.Size = new System.Drawing.Size(86, 35);
            this.btnEditHSL.TabIndex = 50;
            this.btnEditHSL.Text = "Sửa";
            this.btnEditHSL.UseVisualStyleBackColor = true;
            this.btnEditHSL.Click += new System.EventHandler(this.btnEditHSL_Click);
            // 
            // dataGV_HeSoLuong
            // 
            this.dataGV_HeSoLuong.AllowUserToAddRows = false;
            this.dataGV_HeSoLuong.AllowUserToDeleteRows = false;
            this.dataGV_HeSoLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_HeSoLuong.Location = new System.Drawing.Point(6, 195);
            this.dataGV_HeSoLuong.Name = "dataGV_HeSoLuong";
            this.dataGV_HeSoLuong.ReadOnly = true;
            this.dataGV_HeSoLuong.Size = new System.Drawing.Size(984, 468);
            this.dataGV_HeSoLuong.TabIndex = 48;
            this.dataGV_HeSoLuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_HeSoLuong_CellContentClick);
            // 
            // ThietLapTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ThietLapTab";
            this.Size = new System.Drawing.Size(1135, 808);
            this.tabControl1.ResumeLayout(false);
            this.tabPCa.ResumeLayout(false);
            this.tabPCa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Ca)).EndInit();
            this.tabPChucVu.ResumeLayout(false);
            this.tabPChucVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_ChucVu)).EndInit();
            this.tabPHeSoLuong.ResumeLayout(false);
            this.tabPHeSoLuong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_HeSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPCa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbTenCa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMaC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteCa;
        private System.Windows.Forms.Button btnEditCa;
        private System.Windows.Forms.DataGridView dataGV_Ca;
        private System.Windows.Forms.TabPage tabPChucVu;
        private System.Windows.Forms.Button btnAddCa;
        private System.Windows.Forms.Button btnAddCV;
        private System.Windows.Forms.TextBox tbTenCV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaCV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteCV;
        private System.Windows.Forms.Button btnEditCV;
        private System.Windows.Forms.DataGridView dataGV_ChucVu;
        private System.Windows.Forms.Button btnClearCV;
        private System.Windows.Forms.TabPage tabPHeSoLuong;
        private System.Windows.Forms.TextBox tbHeSoLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddHSL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDeleteHSL;
        private System.Windows.Forms.Button btnEditHSL;
        private System.Windows.Forms.DataGridView dataGV_HeSoLuong;
        private System.Windows.Forms.Button btnClearCa;
        private System.Windows.Forms.ComboBox cbbChucVu;
        private System.Windows.Forms.ComboBox cbbCa;
        private System.Windows.Forms.DateTimePicker timeP_GioKetThuc;
        private System.Windows.Forms.DateTimePicker timeP_GioBatDau;
    }
}
