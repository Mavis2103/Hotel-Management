﻿using HotelManagement.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.CTControls;

namespace HotelManagement.GUI
{
    public partial class FormDangNhap : Form
    {
        private FormLogin formLoginParent;
        public FormDangNhap(FormLogin formMain)
        {
            InitializeComponent();
            formLoginParent = formMain;
        }
        
        private void labelForgotPassword_Click(object sender, EventArgs e)
        {
            formLoginParent.openChildForm(new FormQuenMatKhauLayOTP(formLoginParent));
            formLoginParent.bringControlBoxAndTBTLabelToFront();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (TaiKhoanBUS.Instance.checkLogin(this.textBoxUsername.Texts, textBoxPassword.Texts))
            {
                FormMain formMain = new FormMain(TaiKhoanBUS.Instance.GetTKDangNhap(textBoxUsername.Texts));
                formLoginParent.Hide();
                formMain.ShowDialog();
                formLoginParent.Close();
            }
            else
            {
                CTMessageBox.Show("Sai thông tin đăng nhập! Vui lòng kiểm tra lại.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    

        }
    }
}
