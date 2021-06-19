using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNhanVien_XoayCa.Controls.SubControls;
using BLL;
using BLL.Model;

namespace QLNhanVien_XoayCa.Controls
{
    public partial class PhanCaTab : UserControl
    {
        PhanCaRow _selectedRow;

        Color[] _colors = new Color[2] { Color.Green, Color.Blue };

        DateTime _startDateOfWeek;
        DateTime _startWeekNow;
        List<Ca> _listCa;
        List<PhanCong> _listPhanCong;

        public PhanCaTab()
        {
            InitializeComponent();

            _startDateOfWeek = DateTime.Now.AddDays(-(double)DateTime.Now.DayOfWeek);
            _startWeekNow = DateTime.Now.AddDays(-(double)DateTime.Now.DayOfWeek);

            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;

            LoadAllRow();
        }



        //public method
        //
        //
        public void SelectRow(PhanCaRow row)
        {
            if (_selectedRow == null)
            {
                row.BackColor = Color.Purple;
                _selectedRow = row;
            }
            else if (_selectedRow != row)
            {
                _selectedRow.BackColor = Color.White;
                row.BackColor = Color.Purple;
                _selectedRow = row;
            }
            else
            {
                _selectedRow.BackColor = Color.White;
                _selectedRow = null;
            }
        }

        public void LoadAllRow()
        {
            var ca_bll = new Ca_BLL();
            var pc_bll = new PhanCong_BLL();

            _listCa = ca_bll.SelectAll2();
            _listPhanCong = pc_bll.SelectIdsWhere(_startDateOfWeek, _startDateOfWeek.AddDays(6));

            _selectedRow = null;
            flowLayoutPanel1.Controls.Clear();

            int i = 0;
            foreach (var ca in _listCa)
            {
                CaRow ca_row = new CaRow(ca.MaC);
                ca_row.SetText(ca.Ten);
                flowLayoutPanel1.Controls.Add(ca_row);

                foreach (var pc in _listPhanCong)
                {
                    if (pc.MaC == ca.MaC)
                    {
                        PhanCaRow pc_row = new PhanCaRow(_colors[i], pc.MaNV, pc.MaCV, pc.MaC, _startDateOfWeek);
                        pc_row.BindingTabControl(this);
                        ca_row.AddRow(pc_row);
                    }
                }
                i = i == 0 ? 1 : 0;
            }

            lbWeek.Text = _startDateOfWeek.ToShortDateString() + " - " + _startDateOfWeek.AddDays(6).ToShortDateString();
        }







        private void btnAdd_Click(object sender, EventArgs e)
        {
            var pcForm = new PhanCaForm(_startDateOfWeek, ActionType.Create);
            pcForm.BindingTabControl(this);
            pcForm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedRow == null)
            {
                MessageBox.Show("Bạn chưa chọn dòng để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var pcForm = new PhanCaForm(_startDateOfWeek, ActionType.Edit);
            pcForm.BindingTabControl(this);
            pcForm.LoadFormBy_PhanCaRow(_selectedRow);
            pcForm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedRow == null)
            {
                MessageBox.Show("Bạn chưa chọn dòng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này ?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            var pc_bll = new PhanCong_BLL();
            pc_bll.DeleteRange(_selectedRow.MaNV, _selectedRow.MaC, _selectedRow.StartDateOfWeek, _selectedRow.StartDateOfWeek.AddDays(6));

            LoadAllRow();
        }

        private void btnWeekDown_Click(object sender, EventArgs e)
        {
            _startDateOfWeek = _startDateOfWeek.AddDays(-7);
            LoadAllRow();

            if (_startDateOfWeek <= _startWeekNow)
            {
                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnWeekUp_Click(object sender, EventArgs e)
        {
            _startDateOfWeek = _startDateOfWeek.AddDays(7);
            LoadAllRow();

            if (_startDateOfWeek > _startWeekNow)
            {
                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAllRow();
        }
    }
}
