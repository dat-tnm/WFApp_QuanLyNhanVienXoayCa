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
    public partial class NhanVienTab : UserControl
    {
        NhanVienRow Selected_nvRow;
        NhanVien_BLL nv_bll;

        public NhanVienTab()
        {
            InitializeComponent();

            nv_bll = new NhanVien_BLL();
            GetAllNhanVien();
        }
        
        //public method
        //
        //
        public void NhanVienRow_Select(NhanVienRow nvRow)
        {
            if (Selected_nvRow == null)
            {
                nvRow.BackColor = Color.Purple;
                Selected_nvRow = nvRow;
            }
            else if (Selected_nvRow != nvRow)
            {
                Selected_nvRow.BackColor = Color.White;
                nvRow.BackColor = Color.Purple;
                Selected_nvRow = nvRow;
            }
            else
            {
                Selected_nvRow.BackColor = Color.White;
                Selected_nvRow = null;
            }
        }

        public void GetAllNhanVien() 
        {
            Selected_nvRow = null;

            var dataTable = nv_bll.SelectAll();
            string stt;
            flowLayoutPanel1.Controls.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                stt = (flowLayoutPanel1.Controls.Count + 1).ToString();
                var nv_row = new NhanVienRow(stt, row.ItemArray);
                nv_row.Binding_NhanVienTab(this);
                flowLayoutPanel1.Controls.Add(nv_row);
            }
        }

        public void SearchNhanVien(string keyword)
        {
            Selected_nvRow = null;

            var nv_bll = new NhanVien_BLL();
            var dataTable = nv_bll.SelectWhereLike(keyword);
            string stt;
            flowLayoutPanel1.Controls.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                stt = (flowLayoutPanel1.Controls.Count + 1).ToString();
                var nv_row = new NhanVienRow(stt, row.ItemArray);
                nv_row.Binding_NhanVienTab(this);
                flowLayoutPanel1.Controls.Add(nv_row);
            }

            btnSearchCancel.Visible = true;
        }
        //
        //
        ///


        private void btnAdd_Click(object sender, EventArgs e)
        {
            var nvForm = new NhanVienForm(FormAction.Create);
            nvForm.Binding_NhanVienTab(this);
            nvForm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Selected_nvRow == null)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nvForm = new NhanVienForm(FormAction.Edit, Selected_nvRow.nhanVien);
            nvForm.Binding_NhanVienTab(this);
            nvForm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Selected_nvRow == null)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này ?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            nv_bll.Delete(Selected_nvRow.nhanVien.MaNV);
            Selected_nvRow = null;
            GetAllNhanVien();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var nvForm = new NhanVienForm(FormAction.Search);
            nvForm.Binding_NhanVienTab(this);
            nvForm.Show();
        }

        private void btnSearchCancel_Click(object sender, EventArgs e)
        {
            GetAllNhanVien();
            btnSearchCancel.Visible = false;
        }

    }
}
