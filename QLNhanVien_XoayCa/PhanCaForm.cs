using BLL;
using BLL.Model;
using QLNhanVien_XoayCa.Controls;
using QLNhanVien_XoayCa.Controls.SubControls;
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
    public partial class PhanCaForm : Form
    {
        ActionType _actionType;
        PhanCaTab _phanCaTab;

        DateTime _startDateOfWeek;
        DateTime _endDateOfWeek;
        CheckBox[] _checkBoxes;
        PhanCong[] _phanCongs;

        public PhanCaForm(DateTime startDateOfWeek, ActionType actionType)
        {
            InitializeComponent();

            _actionType = actionType;

            _startDateOfWeek = startDateOfWeek;
            _endDateOfWeek = startDateOfWeek.AddDays(6);

            lbTitle.Text += _startDateOfWeek.ToShortDateString() + " ~ " + _endDateOfWeek.ToShortDateString();
            lbT2.Text = _startDateOfWeek.ToShortDateString().Substring(0, 5);
            lbT3.Text = _startDateOfWeek.AddDays(1).ToShortDateString().Substring(0, 5);
            lbT4.Text = _startDateOfWeek.AddDays(2).ToShortDateString().Substring(0, 5);
            lbT5.Text = _startDateOfWeek.AddDays(3).ToShortDateString().Substring(0, 5);
            lbT6.Text = _startDateOfWeek.AddDays(4).ToShortDateString().Substring(0, 5);
            lbT7.Text = _startDateOfWeek.AddDays(5).ToShortDateString().Substring(0, 5);
            lbCN.Text = _startDateOfWeek.AddDays(6).ToShortDateString().Substring(0, 5);

            var nv_bll = new NhanVien_BLL();
            var cv_bll = new ChucVu_BLL();
            var ca_bll = new Ca_BLL();

            cbbNhanVien.DataSource = nv_bll.SelectAll();
            cbbNhanVien.DisplayMember = "Ten";
            cbbNhanVien.ValueMember = "MaNV";

            cbbChucVu.DataSource = cv_bll.SelectAll();
            cbbChucVu.DisplayMember = "Ten";
            cbbChucVu.ValueMember = "MaCV";

            cbbCa.DataSource = ca_bll.SelectAll();
            cbbCa.DisplayMember = "Ten";
            cbbCa.ValueMember = "MaC";

            _checkBoxes = new CheckBox[7] { checkBT2, checkBT3, checkBT4, checkBT5, checkBT6, checkBT7, checkBCN };
            _phanCongs = new PhanCong[7];
        }


        public void LoadFormBy_PhanCaRow(PhanCaRow row)
        {
            var pc_bll = new PhanCong_BLL();
            PhanCong pc;

            List<PhanCong> list_pc;
            for (int i = 0; i < 7; i++)
            {
                list_pc = pc_bll.SelectWhereLike($"{row.MaNV}%{row.MaC}%", row.StartDateOfWeek.AddDays(i));
                pc = list_pc.Count == 0 ? null : list_pc[0];

                if (pc != null)
                {
                    _checkBoxes[i].Checked = true;
                    _phanCongs[i] = pc;
                }
            }

            var nv_bll = new NhanVien_BLL();
            var cv_bll = new ChucVu_BLL();
            var ca_bll = new Ca_BLL();

            cbbNhanVien.Text = nv_bll.SelectWhereId(row.MaNV).Ten;
            cbbChucVu.Text = cv_bll.SelectWhereId(row.MaCV).Ten;
            cbbCa.Text = ca_bll.SelectWhereId(row.MaC).Ten;
        }

        public void BindingTabControl(PhanCaTab PhanCaTab)
        {
            _phanCaTab = PhanCaTab;
        }






        private void btnSave_Click(object sender, EventArgs e)
        {
            var pc_bll = new PhanCong_BLL();

            if (_actionType == ActionType.Edit)
            {
                foreach (PhanCong item in _phanCongs)
                {
                    if (item != null)
                    {
                        pc_bll.Delete(item.MaPC);
                    }
                }
            }
            else
            {
                List<PhanCong> list_pc = pc_bll.SelectIdsWhere(_startDateOfWeek, _startDateOfWeek.AddDays(6));
                foreach (PhanCong pc in list_pc)
                {
                    if (pc.MaNV == cbbNhanVien.SelectedValue.ToString() && pc.MaC == cbbCa.SelectedValue.ToString())
                    {
                        MessageBox.Show("Đã tồn tại dòng có Mã Nhân Viên & Mã Ca & Ngày tương tự,  vui lòng vào chỉnh sửa dòng phân ca", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            for (int i = 0; i < 7; i++)
            {
                if (_checkBoxes[i].Checked)
                {
                    pc_bll.Insert(cbbNhanVien.SelectedValue.ToString(),
                                cbbChucVu.SelectedValue.ToString(),
                                cbbCa.SelectedValue.ToString(), _startDateOfWeek.AddDays(i));
                }
            }

            _phanCaTab.LoadAllRow();

            Dispose();
        }
    }

    public enum ActionType
    {
        Create = 0,
        Edit = 1
    }
}
