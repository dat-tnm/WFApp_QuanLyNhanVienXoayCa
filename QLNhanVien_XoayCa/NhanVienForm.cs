using BLL;
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
    public partial class NhanVienForm : Form
    {
        FormAction _action;
        NhanVienTab _nhanVienTab;
        NhanVien _nhanVien;

        public NhanVienForm()
        {
            InitializeComponent();
        }

        public NhanVienForm(FormAction Action, NhanVien nhanVien = null)
        {
            InitializeComponent();

            if (nhanVien != null)
                _nhanVien = nhanVien;
            else
                _nhanVien = new NhanVien();

            _action = Action;
            switch (_action)
            {
                case FormAction.Create:
                    LoadCreateForm();
                    break;
                case FormAction.Edit:
                    LoadEditForm();
                    break;
                case FormAction.Search:
                    LoadSearchForm();
                    break;
                default:
                    break;
            }

            var cv_BLL = new ChucVu_BLL();
            DataTable dt = cv_BLL.SelectAll();
            cbbChucVu.DataSource = dt;
            cbbChucVu.DisplayMember = "Ten";
            cbbChucVu.ValueMember = "MaCV";

            cbbGioiTinh.Items.Add("Nam");
            cbbGioiTinh.Items.Add("Nữ");
            cbbGioiTinh.Text = "Nam";

            if (nhanVien != null)
            {
                cbbGioiTinh.Text = nhanVien.GioiTinh;

                foreach (DataRow row in dt.Rows)
                {
                    if (nhanVien.MaCV == (string)row[0])
                        cbbChucVu.Text = (string)row[1];
                }
            }

        }

        public void Binding_NhanVienTab(NhanVienTab nhanVienTab)
        {
            _nhanVienTab = nhanVienTab;
        }





        void LoadCreateForm()
        {
            tbMaNV.Enabled = false;
            lbTitle.Text = "Tạo mới hồ sơ nhân viên";
            button1.Text = "Lưu";
        }

        void LoadEditForm()
        {
            lbTitle.Text = "Sửa thông tin nhân viên";
            button1.Text = "Lưu";

            var cv_bll = new ChucVu_BLL();
            ChucVu cv = cv_bll.SelectWhereId(_nhanVien.MaCV);
            cbbChucVu.Text = cv.Ten;

            tbMaNV.Text = _nhanVien.MaNV;
            tbTen.Text = _nhanVien.Ten;
            datePNgaySinh.Value = _nhanVien.NgaySinh;
            tbNoiSinh.Text = _nhanVien.NoiSinh;
            tbSDT.Text = _nhanVien.SDT;
            tbEmail.Text = _nhanVien.Email;
            cbbGioiTinh.Text = _nhanVien.GioiTinh;
            datePNgayVaoLam.Value = _nhanVien.NgayVaoLam;
        }

        void LoadSearchForm()
        {
            lbTitle.Text = "Tìm kiếm - lọc nhân viên";
            button1.Text = "Tìm kiếm";
            checkBNgayVaoLam.Visible = true;
            checkBNgaySinh.Visible = true;
            checkBGioiTinh.Visible = true;
            checkBChucVu.Visible = true;
            tbSDT.Visible = false;
        }

        void GetNhanVien()
        {
            _nhanVien.MaNV = tbMaNV.Text;
            _nhanVien.MaCV = cbbChucVu.SelectedValue.ToString();
            _nhanVien.Ten = tbTen.Text;
            _nhanVien.GioiTinh = cbbGioiTinh.Text;
            _nhanVien.NgaySinh = datePNgaySinh.Value;
            _nhanVien.NoiSinh = tbNoiSinh.Text;
            _nhanVien.SDT = tbSDT.Text;
            _nhanVien.Email = tbEmail.Text;
            _nhanVien.NgayVaoLam = datePNgayVaoLam.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetNhanVien();

            if (_action == FormAction.Create)
            {
                var _nhanVien_BLL = new NhanVien_BLL();
                _nhanVien_BLL.Insert(_nhanVien.MaCV, _nhanVien.Ten, _nhanVien.NgaySinh, _nhanVien.GioiTinh, _nhanVien.NoiSinh, _nhanVien.SDT, _nhanVien.Email, _nhanVien.NgayVaoLam);
                _nhanVienTab.GetAllNhanVien();
            }
            else if (_action == FormAction.Edit)
            {
                var _nhanVien_BLL = new NhanVien_BLL();
                _nhanVien_BLL.Update(_nhanVien.MaNV, _nhanVien.MaCV, _nhanVien.Ten, _nhanVien.NgaySinh, _nhanVien.GioiTinh, _nhanVien.NoiSinh, _nhanVien.SDT, _nhanVien.Email, _nhanVien.NgayVaoLam);
                _nhanVienTab.GetAllNhanVien();
            }
            else
            {
                //searching _action
                string ngaysinh = checkBNgaySinh.Checked ? _nhanVien.NgaySinh.ToShortDateString() : "";
                string ngayvaolam = checkBNgayVaoLam.Checked ? _nhanVien.NgayVaoLam.ToShortDateString() : "";
                string macv = checkBChucVu.Checked ? _nhanVien.MaCV : "";
                string gioitinh;
                if (checkBGioiTinh.Checked)
                    gioitinh = _nhanVien.GioiTinh;
                else
                    gioitinh = "";

                string keyword = _nhanVien.MaNV + "%" 
                    + macv + "%" 
                    + _nhanVien.Ten + "%" 
                    + gioitinh + "%" 
                    + ngaysinh + "%" 
                    + _nhanVien.NoiSinh + "%"
                    + _nhanVien.Email + "%" 
                    + ngayvaolam + "%";
                _nhanVienTab.SearchNhanVien(keyword);
            }

            this.Dispose();
        }
    }

    public enum FormAction
    {
        Create = 1,
        Edit = 2,
        Search = 3
    }
}
