using System;
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
    public partial class Frm_SignUp : Form
    {
        public Frm_SignUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_signup_Click(object sender, EventArgs e)
        {
            // Show the FrmLogin form again
            FrmLogin loginForm = new FrmLogin();
            loginForm.Show();

            // Close the current form
            this.Close();
        }
    }
}
