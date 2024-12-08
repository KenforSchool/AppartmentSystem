using AppartmentSystem.ManageRoom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
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
        //pwede pang mabago
        private void frm_room_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string selectQuery = "SELECT * FROM room";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dg_ManageRoom.DataSource = table;
            }
        }

        private void btn_addRoom_Click(object sender, EventArgs e)
        {
            //Connection ng database
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            roomAddingDAL add = new roomAddingDAL(connectionString);

            string roomNum = txt_RoomNo.Text;
            //walang design
            string roomPrice = txt_RoomPrice.Text;

            string tenantName = txt_tenant.Text;
            //mali yung design
            DateTime moved_In = DateTime.Now;

            //eto yung kinuha yung process
            bool success = add.AddRoomAndTenant(roomNum, tenantName, , roomPrice, moved_In);

            if(success)
            {
                MessageBox.Show("Room and tenant have been added successfully");
            }
            else
            {
                MessageBox.Show("Error has occured. Data has not been saved");
            }
        }

        private void btn_deleteRoom_Click(object sender, EventArgs e)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            if (dg_ManageRoom.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a row to delete.");
                return;
            }

            string roomId = dg_ManageRoom.SelectedRows[0].Cells["room_id"].Value.ToString();

            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(result == DialogResult.Yes)
            {
                roomAddingDAL room = new roomAddingDAL(connectionString);

                bool isDeleted = room.DeleteRoom(roomId);


                if(isDeleted)
                {
                    MessageBox.Show("Record deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Error: Record could not be deleted");
                }
            }
            
        }

        private void btn_editRoom_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            if (dg_ManageRoom.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a row you want to edit.");
                return;
            }

            DataGridViewRow selectedRow = dg_ManageRoom.SelectedRows[0];

            string roomId = selectedRow.Cells["room_id"].Value.ToString().Trim();
            int roomPrice = Convert.ToInt32(selectedRow.Cells["room_price"].Value);
            string tenantName = selectedRow.Cells["tenant_name"].ToString().Trim();
            string moved_in = selectedRow.Cells["moved_in"].Value.ToString().Trim();

            roomAddingDAL roomADL = new roomAddingDAL(connectionString);
            bool isUpdated = roomADL.EditRoom(roomId, tenantName, roomPrice,moved_in);

            if (isUpdated)
            {
                MessageBox.Show("Record updated successfully!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Error updating record");
            }
        }
        //need ng edit sa grid
        private void LoadData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            roomAddingDAL add = new roomAddingDAL(connectionString);

            string query = @"
                SELECT
                     r.room_id,
                     t.tenant_name,
                     t.moved_in
                FROM room r
                LEFT JOIN tenant t
                ON r.room_id = t.room_id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dg_ManageRoom.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
