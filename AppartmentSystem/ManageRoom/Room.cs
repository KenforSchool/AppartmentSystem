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
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace AppartmentSystem
{
    public partial class frm_room : Form
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

        public frm_room()
        {
            InitializeComponent();
            btn_editRoom.Enabled = false;
        }

        //pwede pang mabago
        private void frm_room_Load(object sender, EventArgs e)
        {
            LoadData();
            if (txt_RoomNo.Text == "")
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


            btn_addRoom.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_addRoom.Width,
            btn_addRoom.Height, 30, 30));

            btn_deleteRoom.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_deleteRoom.Width,
            btn_deleteRoom.Height, 30, 30));

            btn_editRoom.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_editRoom.Width,
            btn_editRoom.Height, 30, 30));

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string query = @"
                SELECT
                     r.room_id AS 'Room Number',
                     r.room_price AS 'Rent',
                     t.tenant_name AS 'Name',
                     t.move_in AS 'Move In'
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
            try
            {
                
                //Connection ng database
                string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                roomAddingDAL add = new roomAddingDAL(connectionString);
                string roomNum = txt_RoomNo.Text;
                double roomPrice = double.Parse(txt_price.Text);

                string tenantName = txt_tenant.Text;
                DateTime movedIn = dateTimePicker1.Value;
                DateTime moved_out = movedIn.AddMonths(1);

                //eto yung kinuha yung process
                bool success = add.AddRoomAndTenant(roomNum, tenantName, roomPrice, movedIn, moved_out);

                if (success)
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
            catch (FormatException ex)
            {
                DialogResult result = MessageBox.Show(ex.Message,
                "Please try again!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void dg_ManageRoom_SelectionChanged(object sender, EventArgs e)
        {
            if (dg_ManageRoom.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dg_ManageRoom.SelectedRows[0];
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
            dateTimePicker1.MinDate = DateTime.Now;
        }

        private void btn_roomBack_Click(object sender, EventArgs e)
        {
            Frm_Dashboard dashboard = new Frm_Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_RoomNo_Click(object sender, EventArgs e)
        {
            btn_addRoom.Enabled = true;
            btn_editRoom.Enabled = false;
        }

        private void dg_ManageRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_addRoom.Enabled = false;
            btn_editRoom.Enabled = true;
        }

        private void txt_tenant_MouseClick(object sender, MouseEventArgs e)
        {
            btn_addRoom.Enabled = true;
            btn_editRoom.Enabled = true;
        }

        private void txt_price_MouseClick(object sender, MouseEventArgs e)
        {
            btn_addRoom.Enabled = true;
            btn_editRoom.Enabled = true;
        }

        private void txt_RoomNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txt_tenant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dg_ManageRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dg_ManageRoom.CurrentCell != null)
            {

                string roomNumber = dg_ManageRoom.Rows[e.RowIndex].Cells["Room Number"].Value.ToString();
                string tenantName = dg_ManageRoom.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                double roomPrice = Convert.ToDouble(dg_ManageRoom.Rows[e.RowIndex].Cells["Rent"].Value);

                frm_EditRoom edit = new frm_EditRoom();
                edit.setRoomDetails(roomNumber, tenantName, roomPrice);
            }
        }

        private void OpenEditRoomForm(int rowIndex)
        {
            if (dg_ManageRoom.CurrentCell != null && rowIndex >= 0)
            {

                string roomNumber = dg_ManageRoom.Rows[rowIndex].Cells["Room Number"].Value.ToString();
                string tenantName = dg_ManageRoom.Rows[rowIndex].Cells["Name"].Value.ToString();
                double roomPrice = Convert.ToDouble(dg_ManageRoom.Rows[rowIndex].Cells["Rent"].Value);

                frm_EditRoom editForm = new frm_EditRoom();

                editForm.setRoomDetails(roomNumber, tenantName, roomPrice);
                editForm.Show();
            }
        }

        private void btn_editRoom_Click_1(object sender, EventArgs e)
        {
            if (dg_ManageRoom.SelectedRows.Count > 0)
            {
                int rowIndex = dg_ManageRoom.SelectedRows[0].Index;

                OpenEditRoomForm(rowIndex);
            }
            else
            {
                MessageBox.Show("Please select a room to edit.");
            }
        }
    }
}
