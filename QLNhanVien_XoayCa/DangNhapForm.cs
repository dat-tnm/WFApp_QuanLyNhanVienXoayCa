using BLL;
using BLL.Model;
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
    public partial class DangNhapForm : Form
    {
        MyForm _mainForm;

        public DangNhapForm()
        {
            InitializeComponent();

            _mainForm = new MyForm();
            _mainForm.Set_DangNhapForm(this);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Account_BLL acc_bll = new Account_BLL();
            DataTable dt_acc = acc_bll.SelectWhere(tbTaiKhoan.Text);

            if (tbMatKhau.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu !");
                return;
            }

            if (dt_acc.Rows.Count == 0)
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu !");
                return;
            }
            else if (dt_acc.Rows[0][3].ToString() != tbMatKhau.Text)
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu !");
                return;
            }

            CurrentAccount.Username = (string)dt_acc.Rows[0][0];
            CurrentAccount.Role = (string)dt_acc.Rows[0][1];
            CurrentAccount.DisplayName = (string)dt_acc.Rows[0][2];

            _mainForm.RefreshAccountInfo();
            _mainForm.Show();
            this.Hide();
        }

    }
}
