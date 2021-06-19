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
    public partial class QLTaiKhoanForm : Form
    {
        MyForm _mainForm;
        Account_BLL acc_bll;

        public QLTaiKhoanForm()
        {
            InitializeComponent();

            acc_bll = new Account_BLL();
        }

        public QLTaiKhoanForm(MyForm mainForm, bool isChangePasswordMode)
        {
            InitializeComponent();

            acc_bll = new Account_BLL();
            _mainForm = mainForm;

            if (isChangePasswordMode)
                groupB_DoiMatKhau.Show();
            else
            {
                groupB_DoiThongTin.Show();
                tbDisplayName.Text = CurrentAccount.DisplayName;
            }

        }

        private void btnLuuDMK_Click(object sender, EventArgs e)
        {
            if (tbMKcu.Text != acc_bll.SelectWhere(CurrentAccount.Username).Rows[0][3].ToString())
            {
                MessageBox.Show("Sai mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbMKmoi.Text == tbMKcu.Text)
            {
                MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbMKmoi.Text != tbMKmoi2.Text)
            {
                MessageBox.Show("Mật khẩu mới nhập lại không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            acc_bll.UpdatePassword(CurrentAccount.Username, tbMKmoi.Text);
            groupB_DoiMatKhau.Hide();
            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDoiThongTin_Click(object sender, EventArgs e)
        {
            if (groupB_DoiThongTin.Visible)
                groupB_DoiThongTin.Hide();
            else
                groupB_DoiThongTin.Show();
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            if (tbDisplayName.Text == CurrentAccount.DisplayName)
            {
                MessageBox.Show("Bạn đang sử dụng tên hiển thị này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbDisplayName.Text == "")
            {
                MessageBox.Show("Tên hiển thị không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            acc_bll.Update(CurrentAccount.Username, tbDisplayName.Text);
            groupB_DoiThongTin.Hide();
            MessageBox.Show("Đổi thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CurrentAccount.DisplayName = tbDisplayName.Text;
            _mainForm.RefreshAccountInfo();
        }
    }
}
