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
    public partial class PhanCaRow : UserControl
    {
        public string MaNV { get; set; }
        public string MaCV { get; set; }
        public string MaC { get; set; }
        public DateTime StartDateOfWeek { get; set; }

        Color _color;
        PhanCaTab _tabControl;

        PhanCong[] _phanCongs;
        Button[] _buttons;
        NhanVien _nv;
        ChucVu _cv;

        public PhanCaRow()
        {
            InitializeComponent();
        }

        public PhanCaRow(Color Color, string MaNV, string MaCV, string MaC, DateTime startDateOfWeek)
        {
            InitializeComponent();

            _color = Color;

            this.MaC = MaC;
            this.MaNV = MaNV;
            this.MaCV = MaCV;

            var pc_bll = new PhanCong_BLL();
            var nv_bll = new NhanVien_BLL();
            var cv_bll = new ChucVu_BLL();

            _nv = nv_bll.SelectWhereId(MaNV);
            _cv = cv_bll.SelectWhereId(MaCV);
            StartDateOfWeek = startDateOfWeek;

            _buttons = new Button[7] { btnCN, btnT2, btnT3, btnT4, btnT5, btnT6, btnT7};
            _phanCongs = new PhanCong[7];

            List<PhanCong> list_pc;
            for (int i = 0; i < 7; i++)
            {
                list_pc = pc_bll.SelectWhereLike($"%{MaNV}%{MaC}%", StartDateOfWeek.AddDays(i));
                _phanCongs[i] = list_pc.Count == 0 ? new PhanCong() : list_pc[0];
            }

            LoadData();
        }

        public void BindingTabControl(PhanCaTab tabControl)
        {
            _tabControl = tabControl;
        }




        void LoadData()
        {
            tb1.Text = $"{_nv.Ten}\nchức vụ:{_cv.Ten}";
            for (int i = 0; i < 7; i++)
            {
                if (_phanCongs[i].MaPC != null)
                {
                    _buttons[i].Enabled = true;
                    _buttons[i].BackColor = _color;
                }
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            _tabControl.SelectRow(this);
        }

        private void tableLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            _tabControl.SelectRow(this);
        }
    }
}
