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
    public partial class ChamCongTile : UserControl
    {
        public List<PhanCong> ListPhanCong { get; set; }
        public NhanVien NhanVien { get; set; }


        int _maCC;
        bool _isCheckin = true;

        public ChamCongTile()
        {
            InitializeComponent();
        }

        public ChamCongTile(int stt, NhanVien nhanVien, List<PhanCong> phanCongs)
        {
            InitializeComponent();

            NhanVien = nhanVien;
            ListPhanCong = phanCongs;

            var cv_bll = new ChucVu_BLL();

            lbNhanVien.Text = stt + ". " + NhanVien.Ten;
            lbThongTin.Text = $"SDT: {NhanVien.SDT}";
            lbChucVu.Text = $"Chức vụ: {cv_bll.SelectWhereId(NhanVien.MaCV).Ten}";
            lbMaNV.Text = $"Id: {nhanVien.MaNV}";
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            var cc_bll = new ChamCong_BLL();

            if (_isCheckin)
            {
                btnStatus.Text = "Checkout";
                btnStatus.BackColor = Color.DarkRed;
                _isCheckin = false;



                cc_bll.Insert(NhanVien.MaNV, DateTime.Now.TimeOfDay, DateTime.Now);
                _maCC = cc_bll.SelectLastId(NhanVien.MaNV, DateTime.Now);
            }
            else
            {
                btnStatus.Text = "Checkin";
                btnStatus.BackColor = Color.Green;
                _isCheckin = true;

                cc_bll.Update(_maCC, DateTime.Now);
            }
        }
    }
}
