using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Model;
using BLL;

namespace QLNhanVien_XoayCa.Controls.SubControls
{
    public partial class NhanVienRow : UserControl
    {
        NhanVienTab _nhanVienTab;

        public NhanVien nhanVien;

        public NhanVienRow()
        {
            InitializeComponent();
        }

        public NhanVienRow(string stt, object[] items)
        {
            InitializeComponent();

            nhanVien = new NhanVien(items);
            LoadData(stt);
        }

        public void Binding_NhanVienTab(NhanVienTab nhanVienTab) 
        {
            _nhanVienTab = nhanVienTab;
        }

        void LoadData(string stt)
        {
            Image img = Image.FromFile(@"E:\\ICONS\\contact-icon.png");
            Bitmap objBitmap = new Bitmap(img, new Size(90,90));
            pictureBox1.Image = objBitmap;

            var cv_bll = new ChucVu_BLL();
            string TenCV = cv_bll.SelectWhereId(nhanVien.MaCV).Ten;

            tbStt.Text = stt;
            tbAbout.Text = "Tên: " + nhanVien.Ten + "\n Ngày sinh: " + nhanVien.NgaySinh.ToShortDateString() + "\n Giới tính: " + nhanVien.GioiTinh;
            tbWork.Text = "Chức vụ: " + TenCV + "\n Ngày vào làm: " + nhanVien.NgayVaoLam.ToShortDateString();
            tbContact.Text = "SDT: " + nhanVien.SDT + "\n Email: " + nhanVien.Email;
            tbMaNV.Text = nhanVien.MaNV;
        }

        private void NhanVienRow_Click(object sender, EventArgs e)
        {
            _nhanVienTab.NhanVienRow_Select(this);
        }
    }
}
