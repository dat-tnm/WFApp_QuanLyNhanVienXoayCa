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
    public partial class ChucVuForm : Form
    {
        ChucVu_BLL _cv_bll;
        int _rowIndex;

        public ChucVuForm()
        {
            InitializeComponent();

            _cv_bll = new ChucVu_BLL();
            LoadDataGridView();
        }

        void LoadDataGridView()
        {
            dataGridView1.DataSource = _cv_bll.SelectAll();
        }





        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMaCV.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbTenCV.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbMaCV.Clear();
            tbTenCV.Clear();
            btnSave.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _cv_bll.Insert(tbTenCV.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("2 trường Mã CV, Tên chức vụ không thể trống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadDataGridView();
            btnSave.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _cv_bll.Update(tbMaCV.Text, tbTenCV.Text);
            LoadDataGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _cv_bll.Delete(tbMaCV.Text);
            tbMaCV.Clear();
            tbTenCV.Clear();
            LoadDataGridView();
        }
    }
}
