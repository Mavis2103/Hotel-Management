﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.GUI
{
    public partial class FormSoDoPhong : Form
    {
        private FormMain formMain;
        public FormSoDoPhong()
        {
            InitializeComponent();
        }
        public FormSoDoPhong(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }
    }
}
