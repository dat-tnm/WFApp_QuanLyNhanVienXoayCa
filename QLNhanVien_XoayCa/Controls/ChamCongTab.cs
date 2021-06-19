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
using BLL.Model;
using BLL;
using QLNhanVien_XoayCa.Reports;

namespace QLNhanVien_XoayCa.Controls
{
    public partial class ChamCongTab : UserControl
    {
        ChamCong_BLL cc_bll;
        int _rowIndex = -1;
        bool isChanged = false;
        bool isSavedSuccessfully = true;

        List<Ca> _listCa;
        List<NhanVien> _listNhanVien;

        DateTime _selectedDate;

        PrintForm _printForm;

        public ChamCongTab()
        {
            InitializeComponent();

            lbNgay.Text = ConvertDayOfWeek((int)DateTime.Now.DayOfWeek) + DateTime.Now.ToShortDateString();

            LoadAllRow();
            Filter();
            LoadTabPanel2();
        }



        void LoadAllRow()
        {
            flowLayoutPanel1.Controls.Clear();

            var nv_bll = new NhanVien_BLL();
            var ca_bll = new Ca_BLL();
            var pc_bll = new PhanCong_BLL();

            _listNhanVien = nv_bll.SelectAll2();

            int stt = 1;
            foreach (var nv in _listNhanVien)
            {
                List<PhanCong> pc = pc_bll.SelectWhereLike($"{nv.MaNV}%", DateTime.Now);
                var nv_tile = new ChamCongTile(stt++, nv, pc);
                flowLayoutPanel1.Controls.Add(nv_tile);
            }

            _listCa = new List<Ca>() { new Ca() { MaC = "All", Ten = "Tất cả nhân viên" } };
            _listCa.AddRange(ca_bll.SelectAll2());
            cbbCa.DataSource = _listCa;
            cbbCa.DisplayMember = "Ten";
            cbbCa.ValueMember = "MaC";
        }

        string ConvertDayOfWeek(int num)
        {
            switch (num)
            {
                case 0:
                    return "Chủ nhật - ";
                case 1:
                    return "Thứ 2 - ";
                case 2:
                    return "Thứ 3 - ";
                case 3:
                    return "Thứ 4 - ";
                case 4:
                    return "Thứ 5 - ";
                case 5:
                    return "Thứ 6 - ";
                default:
                    return "Thứ 7 - ";
            }
        }

        void Filter()
        {
            string selected_MaC = cbbCa.SelectedValue.ToString();

            if (selected_MaC == "All" && tbTenNV.Text == "")
            {
                foreach (ChamCongTile item in flowLayoutPanel1.Controls)
                {
                    item.Show();
                }
                return;
            }

            if (selected_MaC == "All")
            {
                foreach (ChamCongTile item in flowLayoutPanel1.Controls)
                {
                    if (item.NhanVien.Ten.Contains(tbTenNV.Text))
                        item.Show();
                    else
                        item.Hide();
                }
                return;
            }

            foreach (ChamCongTile item in flowLayoutPanel1.Controls)
            {
                item.Hide();

                if (item.NhanVien.Ten.Contains(tbTenNV.Text))
                {
                    foreach (PhanCong pc in item.ListPhanCong)
                    {
                        if(pc.MaC == selected_MaC)
                        {
                            item.Show();
                            break;
                        }
                    }
                }
            }

        }


        void LoadTabPanel2()
        {
            _selectedDate = DateTime.Now;
            cc_bll = new ChamCong_BLL();

            cbbDisplay_tab2.SelectedIndex = 0;
            lbMonth.Text = $"tháng {_selectedDate.Month} năm {_selectedDate.Year}";
            lbMaCC.Text = "Chưa chọn";

            cbbNhanVien.DataSource = _listNhanVien;
            cbbNhanVien.DisplayMember = "Ten";
            cbbNhanVien.ValueMember = "MaNV";

            var dt = (DataTable)dataGV_ChamCong.DataSource;
            dt.Columns[0].ReadOnly = true;
            dt.Columns[1].ReadOnly = true;
            dt.Columns[2].ReadOnly = true;
            dt.Columns[6].ReadOnly = true;
            dt.Columns[7].ReadOnly = true;
        }

        void LoadDataGridView(int indexDisplay)
        {
            isChanged = false;
            _rowIndex = -1;
            lbMaCC.Text = "Chưa chọn";

            if (indexDisplay == 0)
                dataGV_ChamCong.DataSource = cc_bll.SelectByMonthYear(_selectedDate);
            else
                dataGV_ChamCong.DataSource = cc_bll.SelectMaPCNull(_selectedDate);
        }

        void CheckIsSavedChanges()
        {
            if (isChanged)
            {
                DialogResult rs = MessageBox.Show("Có thay đổi trên bảng mà bạn chưa lưu. Bạn có muốn lưu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rs == DialogResult.Yes)
                {
                    btnSaveDataTable_Click(new object(), new EventArgs());
                }
            }
        }





        #region tab-panel-1-cham-cong
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAllRow();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Filter();
        }
        #endregion



        #region tab-panel-2-lich-su
        private void btnMonthDown_Click(object sender, EventArgs e)
        {
            CheckIsSavedChanges();
            if (!isSavedSuccessfully)
                return;
            _selectedDate = _selectedDate.AddMonths(-1);
            lbMonth.Text = $"tháng {_selectedDate.Month} năm {_selectedDate.Year}";
            LoadDataGridView(cbbDisplay_tab2.SelectedIndex);
        }

        private void btnMonthUp_Click(object sender, EventArgs e)
        {
            CheckIsSavedChanges();
            if (!isSavedSuccessfully)
                return;
            if (_selectedDate.AddMonths(1) > DateTime.Now)
                return;
            _selectedDate = _selectedDate.AddMonths(1);
            lbMonth.Text = $"tháng {_selectedDate.Month} năm {_selectedDate.Year}";
            LoadDataGridView(cbbDisplay_tab2.SelectedIndex);
        }

        private void cbbDisplay_tab2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataGridView(cbbDisplay_tab2.SelectedIndex);
        }

        private void dataGV_ChamCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            _rowIndex = e.RowIndex;

            lbMaCC.Text = dataGV_ChamCong[0, _rowIndex].Value.ToString();
        }

        private void btnRefresh_tab2_Click(object sender, EventArgs e)
        {
            CheckIsSavedChanges();
            if (!isSavedSuccessfully)
                return;
            LoadDataGridView(cbbDisplay_tab2.SelectedIndex);
        }

        private void btnDelete_tab2_Click(object sender, EventArgs e)
        {
            if (_selectedDate.Year > DateTime.Now.AddYears(-2).Year)
            {
                MessageBox.Show("Chỉ được xóa dữ liệu 2 năm trước !");
                return;
            }

            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu 2 năm trước!", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                cc_bll.Delete(_selectedDate.Month);
            }
        }

        private void btnUpdateMaPC_Click(object sender, EventArgs e)
        {
            if (_rowIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn dòng chấm công nào !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            UpdateChamCong_Form updateChamCong_Form;
            if (dataGV_ChamCong[6, _rowIndex].Value.ToString() != "")
                updateChamCong_Form = new UpdateChamCong_Form((int)dataGV_ChamCong[0, _rowIndex].Value, (string)dataGV_ChamCong[1, _rowIndex].Value, (DateTime)dataGV_ChamCong[3, _rowIndex].Value, (int)dataGV_ChamCong[6, _rowIndex].Value);
            else
                updateChamCong_Form = new UpdateChamCong_Form((int)dataGV_ChamCong[0, _rowIndex].Value, (string)dataGV_ChamCong[1, _rowIndex].Value, (DateTime)dataGV_ChamCong[3, _rowIndex].Value);
            updateChamCong_Form.Show();
        }

        #endregion

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (_printForm == null || _printForm.IsDisposed)
            {
                LichSuChamCong rpt = new LichSuChamCong();
                rpt.SetDataSource(cc_bll.SelectByMonthYear(_selectedDate));
                _printForm = new PrintForm(rpt);
                _printForm.Show();
            }
        }

        private void btnSaveDataTable_Click(object sender, EventArgs e)
        {
            if (!isChanged)
            {
                return;
            }

            //var nv_bll = new NhanVien_BLL();
            var dt = (DataTable)dataGV_ChamCong.DataSource;
            string maNV;
            DateTime ngay;
            TimeSpan gioVao;
            TimeSpan gioRa;
            foreach (DataRow row in dt.Rows)
            {
                if (row.RowState != DataRowState.Unchanged)
                {
                    isSavedSuccessfully = false;
                    if (row[1].ToString() == string.Empty || row[3].ToString() == string.Empty || row[4].ToString() == string.Empty || row[5].ToString() == string.Empty)
                    {
                        MessageBox.Show("Không được bỏ trống MaNV, Ngày, Giờ Vào, Giờ Ra! \nLưu không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        row.RowError = "Không được bỏ trống MaNV, Ngày, Giờ Vào, Giờ Ra!";
                        return;
                    }
                    //if (nv_bll.SelectWhereId(row[1].ToString()).MaNV == "")
                    //{
                    //    MessageBox.Show($"Không tồn tại mã nhân viên {row[1].ToString()}. \nLưu không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    row.SetColumnError(1, "Không tồn tại mã nhân viên này!");
                    //    return;
                    //}
                    ngay = (DateTime)row[3];
                    if (ngay.Month != _selectedDate.Month || ngay.Year != _selectedDate.Year)
                    {
                        string error_msg = $"Bảng này chỉ thêm, sửa dòng trong tháng {_selectedDate.Month} năm {_selectedDate.Year}";
                        MessageBox.Show(error_msg + "\nLưu không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        row.SetColumnError(3, error_msg);
                        return;
                    }

                    maNV = row[1].ToString();
                    gioVao = (TimeSpan)row[4];
                    gioRa = (TimeSpan)row[5];

                    switch (row.RowState)
                    {
                        case DataRowState.Added:
                            cc_bll.Insert(maNV, gioVao, gioRa, ngay);
                            break;
                        case DataRowState.Modified:
                            if (row[0].ToString() == string.Empty)
                                cc_bll.Insert(maNV, gioVao, gioRa, ngay);
                            else
                                cc_bll.Update((int)row[0], maNV, gioVao, gioRa, ngay);
                            break;
                        default:
                            break;
                    }
                }
            }

            isSavedSuccessfully = true;
            isChanged = false;
            btnRefresh_tab2_Click(sender, e);
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            isChanged = true;

            var dt = (DataTable)dataGV_ChamCong.DataSource;
            string MaNV = ((NhanVien)cbbNhanVien.SelectedItem).MaNV;
            string TenNV = ((NhanVien)cbbNhanVien.SelectedItem).Ten;
            DateTime Ngay = DateTime.Now;
            TimeSpan GioVao = DateTime.Now.TimeOfDay;
            TimeSpan GioRa = DateTime.Now.TimeOfDay;
            dt.Rows.Add(null, MaNV, TenNV, Ngay, GioVao, GioRa);
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            if (_rowIndex < 0)
            {
                MessageBox.Show("Bạn chưa chọn dòng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var dt = (DataTable)dataGV_ChamCong.DataSource;

            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (rs == DialogResult.No)
            {
                return;
            }

            string MaCC = dt.Rows[_rowIndex][0].ToString();
            if (MaCC != string.Empty)
            {
                cc_bll.DeleteById(int.Parse(MaCC));
            }
            dt.Rows.RemoveAt(_rowIndex);
        }

        private void dataGV_ChamCong_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            isChanged = true;
        }
    }
}
