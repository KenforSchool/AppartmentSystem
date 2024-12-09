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
using System.Net.NetworkInformation;
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
            if (lbl_roomNumberOutput.Text == "")
            {
                dg_ManageRoom.SelectionChanged += dg_ManageRoom_SelectionChanged;
            }
            else
            {
                dg_ManageRoom.SelectionChanged -= dg_ManageRoom_SelectionChanged;
            }
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;

            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = @"
                SELECT
                     r.room_id,
                     r.room_price,
                     t.tenant_name,
                     t.move_in
                FROM room r
                LEFT JOIN tenant t
                ON r.room_id = t.room_id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
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
            double roomPrice = double.Parse(txt_price.Text);

            string tenantName = txt_tenant.Text;
            //mali yung design
            DateTime movedIn = dateTimePicker1.Value;

            //eto yung kinuha yung process
            bool success = add.AddRoomAndTenant(roomNum, tenantName, roomPrice, movedIn);

            if(success)
            {
                MessageBox.Show("Room and tenant have been added successfully");
                txt_price.Clear();
                txt_tenant.Clear();
                txt_RoomNo.Clear();
                btn_Update_Click(sender, e);
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

            string roomId = dg_ManageRoom.SelectedRows[0].Cells[0].Value.ToString();

            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(result == DialogResult.Yes)
            {
                roomAddingDAL room = new roomAddingDAL(connectionString);

                bool isDeleted = room.DeleteRoom(roomId);


                if(isDeleted)
                {
                    MessageBox.Show("Record deleted successfully!");
                    btn_Update_Click(sender, e);
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

            string roomId = txt_RoomNo.Text;
            double roomPrice = int.Parse(txt_price.Text);
            string tenantName = txt_tenant.Text;
            DateTime moved_in = dateTimePicker1.Value;

            roomAddingDAL roomADL = new roomAddingDAL(connectionString);
            bool isUpdated = roomADL.EditRoom(roomId, tenantName, roomPrice, moved_in);

            if (isUpdated)
            {
                MessageBox.Show("Record updated successfully!");
                btn_Update_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Error updating record");
            }
        }

        private void dg_ManageRoom_SelectionChanged(object sender, EventArgs e)
        {
            if (dg_ManageRoom.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dg_ManageRoom.SelectedRows[0];

                // Pass values to TextBox controls
                txt_RoomNo.Text = selectedRow.Cells[0].Value.ToString();
            }
        }
        //need ng edit sa grid
        private void LoadData()
        {
            var dataAccess = new roomAddingDAL(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            try
            {
                DataTable data = dataAccess.GetRoomTable();

                if (data.Rows.Count > 0)
                {
                    dg_ManageRoom.DataSource = data;
                }
                else
                {
                    MessageBox.Show("No data found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dg_ManageRoom.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_roomBack_Click(object sender, EventArgs e)
        {

        }
    }
}
