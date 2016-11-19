﻿using System;
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
            kiemTra = _AccountBusiness.CheckAccount(txtAccountName.Text.ToString(),txtPassword.Text.ToString());
            if(kiemTra == false)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng! Vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                this.Hide();
                frmItem frm = new frmItem();
                frm.Show();
            }
        }
    }
}
