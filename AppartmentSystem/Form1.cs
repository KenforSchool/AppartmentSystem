﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppartmentSystem
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
          
            Frm_SignUp signUpForm = new Frm_SignUp();
            signUpForm.Show();
            this.Hide(); 
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
