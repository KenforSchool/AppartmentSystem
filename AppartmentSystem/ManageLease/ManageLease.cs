using AppartmentSystem.ManageRoom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppartmentSystem
{
    public partial class ManageLease : Form
    {
        public ManageLease()
        {
            InitializeComponent();
            LoadData();
            Addbutton();
        }

        private void btn_updateLease_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_addLease_Click(object sender, EventArgs e)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            LeaseRepository lease = new LeaseRepository(connectionString);

            string room_id = lbl_roomNumberleaseOutput.Text;
            int room_price = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value);
            DateTime moved_in = dateTimePicker1.Value;
            DateTime moved_out = moved_in.AddMonths(1);

            
        }

        private void ManageLease_Load(object sender, EventArgs e)
        {
            LoadData();
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;

            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

        }

        private void LoadData()
        {
            var dataAccess = new LeaseRepository(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            string room_id = lbl_roomNumberleaseOutput.Text;
            try
            {
                DataTable data = dataAccess.GetTenantRoomId(room_id);

                if (data.Rows.Count > 0)
                {
                    dataGridView1.DataSource = data;
                }
                else
                {
                    dataGridView1.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_deleteLease_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a row to delete.");
                return;
            }

            string roomId = dataGridView1.SelectedRows[0].Cells["Room Number"].Value.ToString();

            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                LeaseRepository room = new LeaseRepository(connectionString);

                bool isDeleted = room.DeleteRoom(roomId);

                if (isDeleted)
                {
                    MessageBox.Show("Record deleted successfully!");
                    btn_updateLease_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Error: Record could not be deleted");
                }
            }
        }

        private void btn_editLease_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a row you want to edit.");
                return;
            }

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            string roomId = lbl_roomNumberleaseOutput.Text;
            string tenantName = txtTenantName.Text;
            DateTime moved_in = dateTimePicker1.Value;
            DateTime moved_out = moved_in.AddMonths(1);

            LeaseRepository lease = new LeaseRepository(connectionString);
            bool isUpdated = lease.editRoom(roomId, moved_in, moved_out);

            if (isUpdated)
            {
                MessageBox.Show("Record updated successfully!");
                btn_updateLease_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Error updating record");
            }
        }

        private void lbl_roomNo_Click(object sender, EventArgs e)
        {

        }

        private void Archive()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            string roomId = selectedRow.Cells[0].Value.ToString();
            double room_price = Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[2].Value);
            string tenantName = txtTenantName.Text;
            DateTime moved_in = dateTimePicker1.Value;
            DateTime moved_out = moved_in.AddMonths(1);

            LeaseRepository lease = new LeaseRepository(connectionString);
            bool isUpdated = lease.ArchiveLeaseData(roomId, room_price, moved_in, moved_out);

            if (isUpdated)
            {
                MessageBox.Show("Record send to archive!");
            }
            else
            {
                MessageBox.Show("Redord not save");
            }
        }

        private void btn_archiveLease_Click(object sender, EventArgs e)
        {
            frm_Archive frm_Archive = new frm_Archive();
            frm_Archive.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            LeaseRepository lease = new LeaseRepository(connectionString);

            int renewButtonColumnIndex = dataGridView1.Columns["RenewButton"].Index;
            int leaveButtonColumnIndex = dataGridView1.Columns["LeaveButton"].Index;

            if(e.ColumnIndex == renewButtonColumnIndex && e.RowIndex >= 0)
            {
                string roomNumber = dataGridView1.Rows[e.RowIndex].Cells["Room Number"].Value.ToString();

                if (lease.RenewLease(roomNumber))
                {
                    MessageBox.Show("Lease renewed successfully!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Failed to renew lease. Please try again.");
                }
            }
            else if (e.ColumnIndex == leaveButtonColumnIndex && e.RowIndex >= 0)
            {   
                btn_deleteLease_Click(sender, e);
            }
        }
        
        public void Addbutton()
        {
            DataGridViewButtonColumn renewButtonColumn = new DataGridViewButtonColumn();
            renewButtonColumn.Name = "RenewButton";
            renewButtonColumn.Text = "Renew";
            renewButtonColumn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn leaveButtonColumn = new DataGridViewButtonColumn();
            leaveButtonColumn.Name = "LeaveButton";
            leaveButtonColumn.Text = "Leave";
            leaveButtonColumn.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(renewButtonColumn);
            dataGridView1.Columns.Add(leaveButtonColumn);

            int lastIndex = dataGridView1.Columns.Count - 1;
            dataGridView1.Columns["RenewButton"].DisplayIndex = lastIndex - 1;
            dataGridView1.Columns["LeaveButton"].DisplayIndex = lastIndex;
        }


        //kailangan ayusin yung left btn
    }
}
