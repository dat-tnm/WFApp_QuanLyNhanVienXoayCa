namespace QLNhanVien_XoayCa.Controls
{
    partial class ThongKeTab
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
            this.tabP_DiTre = new System.Windows.Forms.TabPage();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabP_TongChiTra = new System.Windows.Forms.TabPage();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lbYear = new System.Windows.Forms.Label();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.tabP_DiTre.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabP_TongChiTra.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabP_DiTre
            // 
            this.tabP_DiTre.BackColor = System.Drawing.Color.White;
            this.tabP_DiTre.Controls.Add(this.crystalReportViewer1);
            this.tabP_DiTre.ForeColor = System.Drawing.Color.Black;
            this.tabP_DiTre.Location = new System.Drawing.Point(4, 29);
            this.tabP_DiTre.Name = "tabP_DiTre";
            this.tabP_DiTre.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_DiTre.Size = new System.Drawing.Size(1127, 717);
            this.tabP_DiTre.TabIndex = 1;
            this.tabP_DiTre.Text = "Đi trễ";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1104, 683);
            this.crystalReportViewer1.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRefresh.Location = new System.Drawing.Point(3, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 57);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefreshDT_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabP_DiTre);
            this.tabControl1.Controls.Add(this.tabP_TongChiTra);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(8, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1135, 750);
            this.tabControl1.TabIndex = 2;
            // 
            // tabP_TongChiTra
            // 
            this.tabP_TongChiTra.Controls.Add(this.crystalReportViewer2);
            this.tabP_TongChiTra.Location = new System.Drawing.Point(4, 29);
            this.tabP_TongChiTra.Name = "tabP_TongChiTra";
            this.tabP_TongChiTra.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_TongChiTra.Size = new System.Drawing.Size(1127, 717);
            this.tabP_TongChiTra.TabIndex = 2;
            this.tabP_TongChiTra.Text = "Tổng chi trả";
            this.tabP_TongChiTra.UseVisualStyleBackColor = true;
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = -1;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.Size = new System.Drawing.Size(1104, 683);
            this.crystalReportViewer2.TabIndex = 4;
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYear.ForeColor = System.Drawing.Color.White;
            this.lbYear.Location = new System.Drawing.Point(354, 25);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(57, 20);
            this.lbYear.TabIndex = 3;
            this.lbYear.Text = "label1";
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(297, 16);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(41, 31);
            this.btnDown.TabIndex = 4;
            this.btnDown.Text = "<";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(515, 16);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(41, 31);
            this.btnUp.TabIndex = 5;
            this.btnUp.Text = ">";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // ThongKeTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.btnRefresh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ThongKeTab";
            this.Size = new System.Drawing.Size(1135, 808);
            this.tabP_DiTre.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabP_TongChiTra.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabP_DiTre;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabP_TongChiTra;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Label lbYear;
    }
}
