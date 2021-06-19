using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanVien_XoayCa.Controls.SubControls
{
    public partial class CaRow : UserControl
    {
        public string MaC { get; set; }

        public CaRow()
        {
            InitializeComponent();
        }

        public CaRow(string maC)
        {
            InitializeComponent();

            MaC = maC;
        }

        public void SetText(string text)
        {
            groupBox1.Text = text;
        }

        public void AddRow(PhanCaRow row)
        {
            this.Height += row.Height + 30;
            groupBox1.Height += row.Height + 30;
            flowLayoutPanel1.Height += row.Height + 30;

            flowLayoutPanel1.Controls.Add(row);
        }

        public void AddTile(ChamCongTile tile)
        {
            flowLayoutPanel1.Controls.Add(tile);

            int newHeight = (flowLayoutPanel1.Controls.Count / 4 + 1) * 140;

            this.Height = newHeight + 10;
            groupBox1.Height = newHeight + 6;
            flowLayoutPanel1.Height = newHeight;
        }
    }
}
