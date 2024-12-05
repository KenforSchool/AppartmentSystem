using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace AppartmentSystem
{
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            DatabaseContext conn = new DatabaseContext(connectionString);
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

        private void btn_Login_Click(object sender, EventArgs e)
        {
            // code           
            string username, user_password;

            username = txt_Username.Text;
            user_password = txt_Password.Text;

            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

            }

            Frm_Dashboard frm_Dashboard = new Frm_Dashboard();
            frm_Dashboard.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
