using BLL;
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
    public partial class UpdateChamCong_Form : Form
    {
        int MaCC;

        string MaPC;
        string MaNV;
        string MaC;
        string MaCV;
        DateTime Ngay;

        public UpdateChamCong_Form()
        {
            InitializeComponent();
        }

        public UpdateChamCong_Form(int maCC, string maNV, DateTime ngay, int MaPC = -1)
        {
            InitializeComponent();

            MaCC = maCC;
            MaNV = maNV;
            Ngay = ngay;

            var cv_bll = new ChucVu_BLL();
            var ca_bll = new Ca_BLL();
            var nv_bll = new NhanVien_BLL();

            tbMaCC.Text = MaCC.ToString();
            tbTenNV.Text = nv_bll.SelectWhereId(MaNV).Ten;
            tbNgay.Text = ngay.ToShortDateString();

            cbbChucVu.DataSource = cv_bll.SelectAll();
            cbbChucVu.DisplayMember = "Ten";
            cbbChucVu.ValueMember = "MaCV";
            cbbCa.DataSource = ca_bll.SelectAll();
            cbbCa.DisplayMember = "Ten";
            cbbCa.ValueMember = "MaC";

            if (MaPC != -1)
            {
                var pc_bll = new PhanCong_BLL();
                var phanCong = pc_bll.SelectWhereId(MaPC);
                if (phanCong == null)
                    return;
                tbTenNV.Text = phanCong.TenNV;
                cbbChucVu.Text = phanCong.TenCV;
                cbbCa.Text = phanCong.TenC;
                this.Text = "Sửa đổi phân ca";
                btnUpdate.Text = "Lưu";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MaCV = cbbChucVu.SelectedValue.ToString();
            MaC = cbbCa.SelectedValue.ToString();

            var cc_bll = new ChamCong_BLL();
            var pc_bll = new PhanCong_BLL();

            var list_pc = pc_bll.SelectWhereLike($"{MaNV}%{MaCV}%{MaC}", Ngay);
            foreach (var item in list_pc)
            {
                pc_bll.Delete(item.MaPC);
            }
            pc_bll.Insert(MaNV, MaCV, MaC, Ngay);

            MaPC = pc_bll.SelectWhereLike($"{MaNV}%{MaCV}%{MaC}", Ngay)[0].MaPC;
            cc_bll.UpdateMaPC(MaCC, MaPC);

            this.Dispose();
        }
    }
}
