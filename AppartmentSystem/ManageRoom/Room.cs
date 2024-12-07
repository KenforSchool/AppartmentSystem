using AppartmentSystem.ManageRoom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppartmentSystem
{
    public partial class frm_room : Form
    {
        public frm_room()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_room_Load(object sender, EventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void btn_addRoom_Click(object sender, EventArgs e)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            roomAddingDAL add = new roomAddingDAL(connectionString);

            string roomNum = txt_RoomNo.Text;
            string roomPrice = txt_RoomPrice.Text;

            string tenantName = txt_tenant.Text;
            DateTime moved_In = DateTime.Now;

            bool success = add.AddRoomAndTenant(roomNum, tenantName, moved_In, roomPrice);

            if(success)
            {
                MessageBox.Show("Room and tenant have been added successfully");
            }
            else
            {
                MessageBox.Show("Error has occured. Data has not been saved");
            }
        }
    }
}
