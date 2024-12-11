﻿using AppartmentSystem.Maintenance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppartmentSystem
{
    public partial class Frm_Dashboard : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
             int nLeft,
             int nTop,
             int nRight,
             int nBottom,
             int nWidthEllipse,
             int nHeightEllipse
              );

        public Frm_Dashboard()
        {
            InitializeComponent();
            //panel_headDashboard.BackColor = Color.FromArgb(125, Color.Black);
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_Dashboard_Load(object sender, EventArgs e)
        {
            //GetActiveRoomCount();
            //GetInActiveRoomCount();

            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;

            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

            btn_AssignMaintenance.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_AssignMaintenance.Width, btn_AssignMaintenance.Height, 30, 30));
            btn_financialData.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_financialData.Width, btn_financialData.Height, 30, 30));
            btn_manageLeases.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_manageLeases.Width, btn_manageLeases.Height, 30, 30));
            btn_manageRoom.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_manageRoom.Width, btn_manageRoom.Height, 30, 30));
        }

        private void btn_manageRoom_Click(object sender, EventArgs e)
        {
                frm_room frm_Room = new frm_room();
                frm_Room.Show();
                this.Hide();
        }

        private void GetActiveRoomCount()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Rooms WHERE IsActive = 1";
                    SqlCommand command = new SqlCommand(query, connection);

                    int activeRoomCount = (int)command.ExecuteScalar();

                    lbl_ActiveRoomOutput.Text = activeRoomCount.ToString();
                    lbl_ActiveRoomOutput.Text = $"Active Rooms: {activeRoomCount}";
                }
                catch (Exception ex)
                {
                    // Handle any errors
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void GetInActiveRoomCount()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Rooms WHERE IsActive = 0";
                    SqlCommand command = new SqlCommand(query, connection);

                    int InactiveRoomCount = (int)command.ExecuteScalar();

                    lbl_InactiveRoomOutput.Text = InactiveRoomCount.ToString();
                    lbl_InactiveRoomOutput.Text = $"inactive Rooms: {InactiveRoomCount}";
                }
                catch (Exception ex)
                {
                    // Handle any errors
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void panel_dockleft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_ActiveRoomOutput_Click(object sender, EventArgs e)
        {

        }

        private void btn_manageLeases_Click(object sender, EventArgs e)
        {
            ManageLease lease = new ManageLease();
            lease.Show();
            this.Close();
        }

        private void panel_headDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_financialData_Click(object sender, EventArgs e)
        {
            frm_financialData financialData = new frm_financialData();
            financialData.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_addMaintenance maintenance = new frm_addMaintenance();
            maintenance.Show();
            this.Close();
        }
    }
}
