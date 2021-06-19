using CrystalDecisions.CrystalReports.Engine;
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
    public partial class PrintForm : Form
    {
        ReportClass _rpt;

        public PrintForm(ReportClass rpt)
        {
            InitializeComponent();

            _rpt = rpt;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = _rpt;
        }
    }
}
