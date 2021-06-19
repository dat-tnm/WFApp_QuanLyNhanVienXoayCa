using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace QLNhanVien_XoayCa.Controls
{
    public partial class ThietLapTab : UserControl
    {
        Ca_BLL ca_bll;
        ChucVu_BLL cv_bll;
        HeSoLuong_BLL hsl_bll;

        public ThietLapTab()
        {
            InitializeComponent();

            ca_bll = new Ca_BLL();
            cv_bll = new ChucVu_BLL();
            hsl_bll = new HeSoLuong_BLL();

            LoadTabPage_Ca();
            LoadTabPage_ChucVu();
            LoadTabPage_HeSoLuong();
        }

        void LoadTabPage_Ca()
        {
            tbMaC.Enabled = false;

            dataGV_Ca.DataSource = ca_bll.SelectAll();
        }

        void LoadTabPage_ChucVu()
        {
            tbMaCV.Enabled = false;

            dataGV_ChucVu.DataSource = cv_bll.SelectAll();
        }

        void LoadTabPage_HeSoLuong()
        {
            cbbCa.DataSource = ca_bll.SelectAll();
            cbbCa.DisplayMember = "Ten";
            cbbCa.ValueMember = "MaC";

            cbbChucVu.DataSource = cv_bll.SelectAll();
            cbbChucVu.DisplayMember = "Ten";
            cbbChucVu.ValueMember = "MaCV";

            dataGV_HeSoLuong.DataSource = hsl_bll.SelectAll();
        }






        #region tabPage_Ca

        private void dataGV_Ca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            tbMaC.Text = dataGV_Ca.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbTenCa.Text = dataGV_Ca.Rows[e.RowIndex].Cells[1].Value.ToString();
            timeP_GioBatDau.Value = DateTime.Parse(dataGV_Ca.Rows[e.RowIndex].Cells[2].Value.ToString());
            timeP_GioKetThuc.Value = DateTime.Parse(dataGV_Ca.Rows[e.RowIndex].Cells[3].Value.ToString());
        }

        private void btnClearCa_Click(object sender, EventArgs e)
        {
            tbMaC.Clear();
            tbTenCa.Clear();
        }

        private void btnAddCa_Click(object sender, EventArgs e)
        {
            if (tbMaC.Text != "")
            {
                MessageBox.Show("Hãy nhấn nút 'tạo mới' trước khi 'thêm'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbTenCa.Text == "")
            {
                MessageBox.Show("Không được bỏ trống 'tên ca'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ca_bll.Insert(tbTenCa.Text, timeP_GioBatDau.Value, timeP_GioKetThuc.Value);
            dataGV_Ca.DataSource = ca_bll.SelectAll();
            LoadTabPage_HeSoLuong();
        }

        private void btnEditCa_Click(object sender, EventArgs e)
        {
            if (tbMaC.Text == "")
            {
                MessageBox.Show("Hãy chọn một dòng để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ca_bll.Update(tbMaC.Text, tbTenCa.Text, timeP_GioBatDau.Value, timeP_GioKetThuc.Value);
            dataGV_Ca.DataSource = ca_bll.SelectAll();
            LoadTabPage_HeSoLuong();
        }

        private void btnDeleteCa_Click(object sender, EventArgs e)
        {
            if (tbMaC.Text == "")
            {
                MessageBox.Show("Hãy chọn một dòng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.No)
            {
                return;
            }

            ca_bll.Delete(tbMaC.Text);
            dataGV_Ca.DataSource = ca_bll.SelectAll();
            btnClearCa_Click(sender, e);
            LoadTabPage_HeSoLuong();
        }
        #endregion




        #region tabPage_ChucVu
        private void dataGV_ChucVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            tbMaCV.Text = dataGV_ChucVu.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbTenCV.Text = dataGV_ChucVu.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnClearCV_Click(object sender, EventArgs e)
        {
            tbMaCV.Clear();
            tbTenCV.Clear();
        }

        private void btnAddCV_Click(object sender, EventArgs e)
        {
            if (tbMaCV.Text != "")
            {
                MessageBox.Show("Hãy nhấn nút 'tạo mới' trước khi 'thêm'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbTenCV.Text == "")
            {
                MessageBox.Show("Không được bỏ trống 'tên chức vụ'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cv_bll.Insert(tbTenCV.Text);
            dataGV_ChucVu.DataSource = cv_bll.SelectAll();
            LoadTabPage_HeSoLuong();
        }

        private void btnEditCV_Click(object sender, EventArgs e)
        {
            if (tbMaCV.Text == "")
            {
                MessageBox.Show("Hãy chọn một dòng để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cv_bll.Update(tbMaCV.Text, tbTenCV.Text);
            dataGV_ChucVu.DataSource = cv_bll.SelectAll();
            LoadTabPage_HeSoLuong();
        }

        private void btnDeleteCV_Click(object sender, EventArgs e)
        {
            if (tbMaCV.Text == "")
            {
                MessageBox.Show("Hãy chọn một dòng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.No)
            {
                return;
            }

            cv_bll.Delete(tbMaCV.Text);
            dataGV_ChucVu.DataSource = cv_bll.SelectAll();
            btnClearCV_Click(sender, e);
            LoadTabPage_HeSoLuong();
        }



        #endregion



        #region tabPage_HeSoLuong
        private void dataGV_HeSoLuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            cbbChucVu.Text = dataGV_HeSoLuong.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbbCa.Text = dataGV_HeSoLuong.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbHeSoLuong.Text = dataGV_HeSoLuong.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnAddHSL_Click(object sender, EventArgs e)
        {
            string mac = cbbCa.SelectedValue.ToString();
            string macv = cbbChucVu.SelectedValue.ToString();
            double hsl;

            if (hsl_bll.SelectWhereId(macv, mac).Rows.Count > 0)
            {
                MessageBox.Show("Đã có hệ số lương cho ca và chức vụ này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(tbHeSoLuong.Text, out hsl) || hsl < 0)
            {
                MessageBox.Show("Hệ số lương phải là kiểu số thực - dương !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            hsl_bll.Insert(macv, mac, hsl);
            dataGV_HeSoLuong.DataSource = hsl_bll.SelectAll();
        }

        private void btnEditHSL_Click(object sender, EventArgs e)
        {
            string mac = cbbCa.SelectedValue.ToString();
            string macv = cbbChucVu.SelectedValue.ToString();
            double hsl;

            if (hsl_bll.SelectWhereId(macv, mac).Rows.Count == 0)
            {
                MessageBox.Show("Chưa có hệ số lương cho ca và chức vụ này, không thể sửa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(tbHeSoLuong.Text, out hsl) || hsl < 0)
            {
                MessageBox.Show("Hệ số lương phải là kiểu số thực - dương !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            hsl_bll.Update(macv, mac, hsl);
            dataGV_HeSoLuong.DataSource = hsl_bll.SelectAll();
        }

        private void btnDeleteHSL_Click(object sender, EventArgs e)
        {
            string mac = cbbCa.SelectedValue.ToString();
            string macv = cbbChucVu.SelectedValue.ToString();

            if (hsl_bll.SelectWhereId(macv, mac).Rows.Count == 0)
            {
                MessageBox.Show("Chưa có hệ số lương cho ca và chức vụ này, không thể xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            hsl_bll.Delete(macv, mac);
            dataGV_HeSoLuong.DataSource = hsl_bll.SelectAll();
        }
        #endregion
    }
}
