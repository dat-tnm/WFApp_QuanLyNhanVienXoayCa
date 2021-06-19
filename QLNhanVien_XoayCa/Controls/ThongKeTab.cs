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
    public partial class ThongKeTab : UserControl
    {
        ThongKe_BLL tk_bll;
        DateTime date;

        public ThongKeTab()
        {
            InitializeComponent();

            tk_bll = new ThongKe_BLL();
            date = DateTime.Now;
            lbYear.Text = $"Năm: {date.Year}";
            ReLoad();
        }

        void ReLoad()
        {
            TK_DiTre rpt_DiTre = new TK_DiTre();
            rpt_DiTre.SetDataSource(tk_bll.TK_DiTre(date));
            crystalReportViewer1.ReportSource = rpt_DiTre;

            TK_TongChiTra2 rpt_TongChiTra = new TK_TongChiTra2();
            rpt_TongChiTra.SetDataSource(tk_bll.TK_TongChiTra(date));
            crystalReportViewer2.ReportSource = rpt_TongChiTra;
        }




        private void btnRefreshDT_Click(object sender, EventArgs e)
        {
            ReLoad();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            date = date.AddYears(-1);
            lbYear.Text = $"Năm: {date.Year}";
            ReLoad();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            date = date.AddYears(1);
            lbYear.Text = $"Năm: {date.Year}";
            ReLoad();
        }
    }
}
