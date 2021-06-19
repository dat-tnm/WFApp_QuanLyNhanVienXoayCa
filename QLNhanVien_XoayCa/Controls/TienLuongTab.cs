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
using QLNhanVien_XoayCa.Reports;

namespace QLNhanVien_XoayCa.Controls
{
    public partial class TienLuongTab : UserControl
    {
        BangLuong_BLL bl_bll;
        ChamCong_BLL cc_bll;

        DateTime _selectedDate;

        PrintForm _printForm;

        public TienLuongTab()
        {
            InitializeComponent();

            bl_bll = new BangLuong_BLL();
            cc_bll = new ChamCong_BLL();
            _selectedDate = DateTime.Now;

            lbMonth.Text = $"tháng {_selectedDate.Month} năm {_selectedDate.Year}";

            LoadDataGridView();
        }


        void LoadDataGridView()
        {
            dataGV_BangLuong.DataSource = bl_bll.SelectByMonthYear(_selectedDate);
        }








        private void btnMonthDown_Click(object sender, EventArgs e)
        {
            _selectedDate = _selectedDate.AddMonths(-1);
            lbMonth.Text = $"tháng {_selectedDate.Month} năm {_selectedDate.Year}";
            LoadDataGridView();
        }

        private void btnMonthUp_Click(object sender, EventArgs e)
        {
            _selectedDate = _selectedDate.AddMonths(1);
            lbMonth.Text = $"tháng {_selectedDate.Month} năm {_selectedDate.Year}";
            LoadDataGridView();
        }

        private void btnRefresh_tab2_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void btnUpdateBangLuong_Click(object sender, EventArgs e)
        {
            if (((DataTable)dataGV_BangLuong.DataSource).Rows.Count > 0)
            {
                DialogResult kq = MessageBox.Show("Đã có bảng lương tháng này, nếu tính lương lại sẽ xóa bảng lương cũ, bạn có muốn tiếp tục?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (kq == DialogResult.No)
                    return;

                bl_bll.DeleteByMonthYear(_selectedDate);
            }


            //Tính va update số giờ làm cho mỗi dòng chấm công
            DataTable table = cc_bll.SelectDiffTimeTable(_selectedDate);

            int MaCC;
            double SoGiayLam;
            int DiffStart, DiffEnd, DiffCa;
            foreach (DataRow row in table.Rows)
            {
                MaCC = (int)row[0];
                DiffCa = (int)row[1];
                DiffStart = (int)row[2];
                DiffEnd = (int)row[3];
                if (DiffStart > 0)
                {
                    if (DiffEnd > 0)
                        SoGiayLam = DiffCa - DiffEnd;
                    else
                        SoGiayLam = DiffCa;
                }
                else
                {
                    if (DiffEnd > 0)
                        SoGiayLam = DiffCa + DiffStart - DiffEnd;
                    else
                        SoGiayLam = DiffCa + DiffStart;
                }

                cc_bll.UpdateSoGioLam(MaCC, Math.Round(SoGiayLam / 3600, 2));
            }
            //update bảng chấm công hoàn tất


            bl_bll.CalculateByMonthYear(_selectedDate);
            LoadDataGridView();

            MessageBox.Show("Đã tính lương xong !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGV_BangLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            tbMaBL.Text = dataGV_BangLuong[0, e.RowIndex].Value.ToString();
            tbThang.Text = dataGV_BangLuong[3, e.RowIndex].Value.ToString();
            tbNam.Text = dataGV_BangLuong[4, e.RowIndex].Value.ToString();
            tbTenNV.Text = dataGV_BangLuong[2, e.RowIndex].Value.ToString();
            tbTongGioLam.Text = dataGV_BangLuong[5, e.RowIndex].Value.ToString();
            tbLuong.Text = dataGV_BangLuong[6, e.RowIndex].Value.ToString();
            tbThuong.Text = dataGV_BangLuong[7, e.RowIndex].Value.ToString();
            tbGhiChu.Text = dataGV_BangLuong[8, e.RowIndex].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tbMaBL.Text == "")
            {
                MessageBox.Show("Hãy chọn 1 dòng để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double thuong;

            if (!double.TryParse(tbThuong.Text, out thuong))
            {
                MessageBox.Show("Hệ số lương phải là kiểu số thực - dương !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bl_bll.Update(int.Parse(tbMaBL.Text), thuong, tbGhiChu.Text);
            LoadDataGridView();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (_printForm == null || _printForm.IsDisposed)
            {
                BC_BangLuong rpt = new BC_BangLuong();
                rpt.SetDataSource(bl_bll.SelectByMonthYear(_selectedDate));
                _printForm = new PrintForm(rpt);
                _printForm.Show();
            }
        }
    }
}
