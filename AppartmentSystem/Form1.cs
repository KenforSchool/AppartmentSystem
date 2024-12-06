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
using System.Data.SqlClient;

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
        //waddup
        private void btn_Login_Click(object sender, EventArgs e)
        {
            // code
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            DatabaseContext conn = new DatabaseContext(connectionString);
            string username, user_password;

            username = txt_Username.Text;
            user_password = txt_Password.Text;

            using (SqlConnection connection = conn.GetConnection())
            {
                //functions
                try
                {
                    connection.Open();

                    string querry = "SELECT COUNT(1) FROM administration_table WHERE username = @username AND password = @password";
                    SqlCommand command = new SqlCommand(querry, connection);

                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", user_password);
                    
                    int result = Convert.ToInt32(command.ExecuteScalar());

                    if (result > 0)
                    {
                        MessageBox.Show("Login Successfull");

                        Frm_Dashboard frm_Dashboard = new Frm_Dashboard();
                        frm_Dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username/Password");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
