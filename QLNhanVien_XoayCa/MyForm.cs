using BLL.Model;
using QLNhanVien_XoayCa.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanVien_XoayCa
{
    public partial class MyForm : Form
    {
        UserControl currentTab;

        HomeTab homeTab;
        NhanVienTab nhanVienTab;
        PhanCaTab phanCaTab;
        ChamCongTab chamCongTab;
        TienLuongTab tienLuongTab;
        ThietLapTab thietLapTab;
        ThongKeTab thongKeTab;
        DangNhapForm dangNhapForm;
        ExcelAnalysisTab excelAnalysisTab;

        public MyForm()
        {
            InitializeComponent();

            homeTab = new HomeTab();
            panel1.Controls.Add(homeTab);
            currentTab = homeTab;

            this.Disposed += Form_Dispose;
            foreach (Button item in flowLayoutPanel1.Controls)
            {
                item.Click += all_btnTab_Click;
            }
        }

        public void RefreshAccountInfo()
        {
            tsMenuItem_TaiKhoan.Text = CurrentAccount.DisplayName;
        }

        public void Set_DangNhapForm(DangNhapForm dnform)
        {
            dangNhapForm = dnform;
        }

        public void SignOut()
        {
            dangNhapForm.Show();
            this.Hide();
        }




        private void Form_Dispose(object sender, EventArgs e)
        {
            dangNhapForm.Dispose();
        }

        private void MyForm_Load(object sender, EventArgs e)
        {
        }

        private void all_btnTab_Click(object sender, EventArgs e)
        {
            foreach (Button item in flowLayoutPanel1.Controls)
            {
                item.Enabled = true;
            }

            ((Button)sender).Enabled = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentTab == homeTab)
                return;

            currentTab.Hide();
            currentTab = homeTab;
            currentTab.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            if (currentTab == nhanVienTab)
                return;

            if (nhanVienTab == null)
            {
                nhanVienTab = new NhanVienTab();
                panel1.Controls.Add(nhanVienTab);
            }

            currentTab.Hide();
            currentTab = nhanVienTab;
            currentTab.Show();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            if (currentTab == chamCongTab)
                return;

            if (chamCongTab == null)
            {
                chamCongTab = new ChamCongTab();
                panel1.Controls.Add(chamCongTab);
            }

            currentTab.Hide();
            currentTab = chamCongTab;
            currentTab.Show();
        }

        private void btnPhanCa_Click(object sender, EventArgs e)
        {
            if (currentTab == phanCaTab)
                return;

            if (phanCaTab == null)
            {
                phanCaTab = new PhanCaTab();
                panel1.Controls.Add(phanCaTab);
            }

            currentTab.Hide();
            currentTab = phanCaTab;
            currentTab.Show();
        }

        private void btnTienLuong_Click(object sender, EventArgs e)
        {
            if (currentTab == tienLuongTab)
                return;

            if (tienLuongTab == null)
            {
                tienLuongTab = new TienLuongTab();
                panel1.Controls.Add(tienLuongTab);
            }

            currentTab.Hide();
            currentTab = tienLuongTab;
            currentTab.Show();
        }

        private void btnThietLap_Click(object sender, EventArgs e)
        {
            if (currentTab == thietLapTab)
                return;

            if (thietLapTab == null)
            {
                thietLapTab = new ThietLapTab();
                panel1.Controls.Add(thietLapTab);
            }

            currentTab.Hide();
            currentTab = thietLapTab;
            currentTab.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (currentTab == thongKeTab)
                return;

            if (thongKeTab == null)
            {
                thongKeTab = new ThongKeTab();
                panel1.Controls.Add(thongKeTab);
            }

            currentTab.Hide();
            currentTab = thongKeTab;
            currentTab.Show();
        }

        private void tsMenuItem_DangXuat_Click(object sender, EventArgs e)
        {
            dangNhapForm.Show();
            this.Hide();
        }

        private void tsMenuItem_DoiMatKhau_Click(object sender, EventArgs e)
        {
            var qlTaiKhoanForm = new QLTaiKhoanForm(this, true);
            qlTaiKhoanForm.Show();
        }

        private void tsmItem_DoiThongTin_Click(object sender, EventArgs e)
        {
            var qlTaiKhoanForm = new QLTaiKhoanForm(this, false);
            qlTaiKhoanForm.Show();
        }

        private void btnExcelAnalysis_Click(object sender, EventArgs e)
        {
            if (currentTab == excelAnalysisTab)
                return;

            if (excelAnalysisTab == null)
            {
                excelAnalysisTab = new ExcelAnalysisTab();
                panel1.Controls.Add(excelAnalysisTab);
            }

            currentTab.Hide();
            currentTab = excelAnalysisTab;
            currentTab.Show();
        }
    }
}
