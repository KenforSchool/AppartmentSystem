﻿using System;
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
using AppartmentSystem;
using System.Diagnostics;

namespace AppartmentSystem
{
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {
            InitializeComponent();
            panel_login.BackColor = Color.FromArgb(125, Color.Black);
            lbl_Login.BackColor = Color.FromArgb(125, Color.Black);
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
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            DatabaseContext dbContext = new DatabaseContext(connectionString);

            string username, user_password;
            username = txt_Username.Text;
            user_password = txt_Password.Text;

            using (SqlConnection connection = dbContext.GetConnection())
            {
                try
                {
                    connection.Open();

                    string querry = "SELECT COUNT(1) FROM administration_table WHERE username = @username AND _password = @password";
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
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

    }

  
}
