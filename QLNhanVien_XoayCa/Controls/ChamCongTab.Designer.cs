namespace QLNhanVien_XoayCa.Controls
{
    partial class ChamCongTab
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
            this.tabPChamCong = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbTenNV = new System.Windows.Forms.TextBox();
            this.cbbCa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lbNgay = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPLichSuCC = new System.Windows.Forms.TabPage();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.cbbNhanVien = new System.Windows.Forms.ComboBox();
            this.btnSaveDataTable = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lbMaCC = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdateMaPC = new System.Windows.Forms.Button();
            this.cbbDisplay_tab2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete_tab2 = new System.Windows.Forms.Button();
            this.btnRefresh_tab2 = new System.Windows.Forms.Button();
            this.lbMonth = new System.Windows.Forms.Label();
            this.btnMonthDown = new System.Windows.Forms.Button();
            this.btnMonthUp = new System.Windows.Forms.Button();
            this.dataGV_ChamCong = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPChamCong.SuspendLayout();
            this.tabPLichSuCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_ChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPChamCong);
            this.tabControl1.Controls.Add(this.tabPLichSuCC);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1135, 808);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPChamCong
            // 
            this.tabPChamCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tabPChamCong.Controls.Add(this.btnSearch);
            this.tabPChamCong.Controls.Add(this.tbTenNV);
            this.tabPChamCong.Controls.Add(this.cbbCa);
            this.tabPChamCong.Controls.Add(this.label5);
            this.tabPChamCong.Controls.Add(this.label2);
            this.tabPChamCong.Controls.Add(this.btnRefresh);
            this.tabPChamCong.Controls.Add(this.lbNgay);
            this.tabPChamCong.Controls.Add(this.flowLayoutPanel1);
            this.tabPChamCong.Controls.Add(this.label1);
            this.tabPChamCong.ForeColor = System.Drawing.Color.White;
            this.tabPChamCong.Location = new System.Drawing.Point(4, 29);
            this.tabPChamCong.Name = "tabPChamCong";
            this.tabPChamCong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPChamCong.Size = new System.Drawing.Size(1127, 775);
            this.tabPChamCong.TabIndex = 0;
            this.tabPChamCong.Text = "Chấm công";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(955, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 26);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbTenNV
            // 
            this.tbTenNV.Location = new System.Drawing.Point(668, 39);
            this.tbTenNV.Name = "tbTenNV";
            this.tbTenNV.Size = new System.Drawing.Size(281, 26);
            this.tbTenNV.TabIndex = 10;
            // 
            // cbbCa
            // 
            this.cbbCa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCa.FormattingEnabled = true;
            this.cbbCa.Location = new System.Drawing.Point(668, 4);
            this.cbbCa.Name = "cbbCa";
            this.cbbCa.Size = new System.Drawing.Size(281, 28);
            this.cbbCa.TabIndex = 9;
            this.cbbCa.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(510, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tìm kiếm nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lọc theo ca:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(414, 7);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 58);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lbNgay
            // 
            this.lbNgay.AutoSize = true;
            this.lbNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgay.ForeColor = System.Drawing.Color.White;
            this.lbNgay.Location = new System.Drawing.Point(102, 13);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(60, 24);
            this.lbNgay.TabIndex = 3;
            this.lbNgay.Text = "label2";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 71);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1110, 584);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hôm nay -";
            // 
            // tabPLichSuCC
            // 
            this.tabPLichSuCC.BackColor = System.Drawing.Color.White;
            this.tabPLichSuCC.Controls.Add(this.btnDeleteRow);
            this.tabPLichSuCC.Controls.Add(this.label6);
            this.tabPLichSuCC.Controls.Add(this.btnAddRow);
            this.tabPLichSuCC.Controls.Add(this.cbbNhanVien);
            this.tabPLichSuCC.Controls.Add(this.btnSaveDataTable);
            this.tabPLichSuCC.Controls.Add(this.btnPrint);
            this.tabPLichSuCC.Controls.Add(this.lbMaCC);
            this.tabPLichSuCC.Controls.Add(this.label4);
            this.tabPLichSuCC.Controls.Add(this.btnUpdateMaPC);
            this.tabPLichSuCC.Controls.Add(this.cbbDisplay_tab2);
            this.tabPLichSuCC.Controls.Add(this.label3);
            this.tabPLichSuCC.Controls.Add(this.btnDelete_tab2);
            this.tabPLichSuCC.Controls.Add(this.btnRefresh_tab2);
            this.tabPLichSuCC.Controls.Add(this.lbMonth);
            this.tabPLichSuCC.Controls.Add(this.btnMonthDown);
            this.tabPLichSuCC.Controls.Add(this.btnMonthUp);
            this.tabPLichSuCC.Controls.Add(this.dataGV_ChamCong);
            this.tabPLichSuCC.ForeColor = System.Drawing.Color.Black;
            this.tabPLichSuCC.Location = new System.Drawing.Point(4, 29);
            this.tabPLichSuCC.Name = "tabPLichSuCC";
            this.tabPLichSuCC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPLichSuCC.Size = new System.Drawing.Size(1127, 775);
            this.tabPLichSuCC.TabIndex = 1;
            this.tabPLichSuCC.Text = "Lịch sử chấm công";
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.Location = new System.Drawing.Point(950, 99);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(159, 28);
            this.btnDeleteRow.TabIndex = 28;
            this.btnDeleteRow.Text = "Xóa dòng";
            this.btnDeleteRow.UseVisualStyleBackColor = true;
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(490, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Nhân viên:";
            // 
            // btnAddRow
            // 
            this.btnAddRow.Location = new System.Drawing.Point(818, 99);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(126, 28);
            this.btnAddRow.TabIndex = 26;
            this.btnAddRow.Text = "+ Tạo dòng mới";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // cbbNhanVien
            // 
            this.cbbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNhanVien.FormattingEnabled = true;
            this.cbbNhanVien.Items.AddRange(new object[] {
            "Tất cả",
            "Chấm công chưa phân ca"});
            this.cbbNhanVien.Location = new System.Drawing.Point(579, 99);
            this.cbbNhanVien.Name = "cbbNhanVien";
            this.cbbNhanVien.Size = new System.Drawing.Size(233, 28);
            this.cbbNhanVien.TabIndex = 25;
            // 
            // btnSaveDataTable
            // 
            this.btnSaveDataTable.Location = new System.Drawing.Point(952, 133);
            this.btnSaveDataTable.Name = "btnSaveDataTable";
            this.btnSaveDataTable.Size = new System.Drawing.Size(159, 28);
            this.btnSaveDataTable.TabIndex = 24;
            this.btnSaveDataTable.Text = "Lưu bảng CC";
            this.btnSaveDataTable.UseVisualStyleBackColor = true;
            this.btnSaveDataTable.Click += new System.EventHandler(this.btnSaveDataTable_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(950, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(161, 28);
            this.btnPrint.TabIndex = 23;
            this.btnPrint.Text = "In bảng chấm công";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lbMaCC
            // 
            this.lbMaCC.AutoSize = true;
            this.lbMaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaCC.Location = new System.Drawing.Point(130, 76);
            this.lbMaCC.Name = "lbMaCC";
            this.lbMaCC.Size = new System.Drawing.Size(57, 20);
            this.lbMaCC.TabIndex = 22;
            this.lbMaCC.Text = "label6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Mã chấm công:";
            // 
            // btnUpdateMaPC
            // 
            this.btnUpdateMaPC.Location = new System.Drawing.Point(952, 167);
            this.btnUpdateMaPC.Name = "btnUpdateMaPC";
            this.btnUpdateMaPC.Size = new System.Drawing.Size(161, 28);
            this.btnUpdateMaPC.TabIndex = 20;
            this.btnUpdateMaPC.Text = "Cập nhật phân ca";
            this.btnUpdateMaPC.UseVisualStyleBackColor = true;
            this.btnUpdateMaPC.Click += new System.EventHandler(this.btnUpdateMaPC_Click);
            // 
            // cbbDisplay_tab2
            // 
            this.cbbDisplay_tab2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDisplay_tab2.FormattingEnabled = true;
            this.cbbDisplay_tab2.Items.AddRange(new object[] {
            "Tất cả",
            "Chấm công chưa phân ca"});
            this.cbbDisplay_tab2.Location = new System.Drawing.Point(112, 99);
            this.cbbDisplay_tab2.Name = "cbbDisplay_tab2";
            this.cbbDisplay_tab2.Size = new System.Drawing.Size(270, 28);
            this.cbbDisplay_tab2.TabIndex = 19;
            this.cbbDisplay_tab2.SelectedIndexChanged += new System.EventHandler(this.cbbDisplay_tab2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Hiển thị theo:";
            // 
            // btnDelete_tab2
            // 
            this.btnDelete_tab2.Location = new System.Drawing.Point(950, 37);
            this.btnDelete_tab2.Name = "btnDelete_tab2";
            this.btnDelete_tab2.Size = new System.Drawing.Size(161, 28);
            this.btnDelete_tab2.TabIndex = 17;
            this.btnDelete_tab2.Text = "Xóa lịch sử tháng";
            this.btnDelete_tab2.UseVisualStyleBackColor = true;
            this.btnDelete_tab2.Click += new System.EventHandler(this.btnDelete_tab2_Click);
            // 
            // btnRefresh_tab2
            // 
            this.btnRefresh_tab2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRefresh_tab2.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh_tab2.Location = new System.Drawing.Point(6, 6);
            this.btnRefresh_tab2.Name = "btnRefresh_tab2";
            this.btnRefresh_tab2.Size = new System.Drawing.Size(77, 50);
            this.btnRefresh_tab2.TabIndex = 16;
            this.btnRefresh_tab2.Text = "Refresh";
            this.btnRefresh_tab2.UseVisualStyleBackColor = false;
            this.btnRefresh_tab2.Click += new System.EventHandler(this.btnRefresh_tab2_Click);
            // 
            // lbMonth
            // 
            this.lbMonth.AutoSize = true;
            this.lbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonth.Location = new System.Drawing.Point(294, 13);
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Size = new System.Drawing.Size(60, 24);
            this.lbMonth.TabIndex = 13;
            this.lbMonth.Text = "label1";
            // 
            // btnMonthDown
            // 
            this.btnMonthDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMonthDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthDown.Location = new System.Drawing.Point(234, 6);
            this.btnMonthDown.Name = "btnMonthDown";
            this.btnMonthDown.Size = new System.Drawing.Size(41, 37);
            this.btnMonthDown.TabIndex = 14;
            this.btnMonthDown.Text = "<";
            this.btnMonthDown.UseVisualStyleBackColor = false;
            this.btnMonthDown.Click += new System.EventHandler(this.btnMonthDown_Click);
            // 
            // btnMonthUp
            // 
            this.btnMonthUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMonthUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthUp.Location = new System.Drawing.Point(528, 6);
            this.btnMonthUp.Name = "btnMonthUp";
            this.btnMonthUp.Size = new System.Drawing.Size(41, 37);
            this.btnMonthUp.TabIndex = 15;
            this.btnMonthUp.Text = ">";
            this.btnMonthUp.UseVisualStyleBackColor = false;
            this.btnMonthUp.Click += new System.EventHandler(this.btnMonthUp_Click);
            // 
            // dataGV_ChamCong
            // 
            this.dataGV_ChamCong.AllowUserToAddRows = false;
            this.dataGV_ChamCong.AllowUserToDeleteRows = false;
            this.dataGV_ChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_ChamCong.Location = new System.Drawing.Point(6, 133);
            this.dataGV_ChamCong.Name = "dataGV_ChamCong";
            this.dataGV_ChamCong.Size = new System.Drawing.Size(938, 451);
            this.dataGV_ChamCong.TabIndex = 0;
            this.dataGV_ChamCong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_ChamCong_CellClick);
            this.dataGV_ChamCong.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_ChamCong_CellValueChanged);
            // 
            // ChamCongTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChamCongTab";
            this.Size = new System.Drawing.Size(1156, 832);
            this.tabControl1.ResumeLayout(false);
            this.tabPChamCong.ResumeLayout(false);
            this.tabPChamCong.PerformLayout();
            this.tabPLichSuCC.ResumeLayout(false);
            this.tabPLichSuCC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_ChamCong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPChamCong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPLichSuCC;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox tbTenNV;
        private System.Windows.Forms.ComboBox cbbCa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGV_ChamCong;
        private System.Windows.Forms.Label lbMonth;
        private System.Windows.Forms.Button btnMonthDown;
        private System.Windows.Forms.Button btnMonthUp;
        private System.Windows.Forms.Label lbMaCC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdateMaPC;
        private System.Windows.Forms.ComboBox cbbDisplay_tab2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete_tab2;
        private System.Windows.Forms.Button btnRefresh_tab2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSaveDataTable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.ComboBox cbbNhanVien;
        private System.Windows.Forms.Button btnDeleteRow;
    }
}
