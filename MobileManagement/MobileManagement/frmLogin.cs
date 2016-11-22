using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer.AccountLocalhost;
using BusinessLogicLayer;
using BusinessLogicLayer.Business;

namespace MobileManagement
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public AccountBusiness _AccountBusiness;

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _AccountBusiness = new AccountBusiness();
            bool kiemTra = false;
            kiemTra = _AccountBusiness.CheckAccount(txtAccountName.Text.ToString(), txtPassword.Text.ToString());
            if (txtAccountName.Text == "")
            {
                MessageBox.Show("Tên đăng nhập không được trống! Vui lòng nhập Tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Mật khẩu không được trống! Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (kiemTra == false)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng! Vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                this.Hide();
                frmManagerCategory frm = new frmManagerCategory();
                frm.ShowDialog();
                this.Visible = true;
            }
        }
    
    }
}
