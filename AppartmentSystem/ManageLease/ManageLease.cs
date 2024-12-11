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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppartmentSystem
{
    public partial class ManageLease : Form
    {
        public ManageLease()
        {
            InitializeComponent();
            panel_sample.BackColor = Color.FromArgb(125, Color.Black);


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

            int leaseId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
            string roomNumber = dataGridView1.Rows[e.RowIndex].Cells["Room Number"].Value.ToString();
            string tenantName = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            string status = e.ColumnIndex == renewButtonColumnIndex ? "Renewed" : "Left";
            DateTime dateNow = DateTime.Now;

            if (e.RowIndex >= 0)
            {

                // Validate: Only one action per day
                if (!lease.CanPerformActionToday(leaseId))
                {
                    return;
                }

                if (e.ColumnIndex == renewButtonColumnIndex)
                {

                    if (lease.RenewLease(leaseId, dateNow))
                    {
                        if (lease.AddToHistory(leaseId, tenantName, status, dateNow))
                        {
                            MessageBox.Show("Lease renewed successfully!");
                            LoadData();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to renew lease. Please try again.");
                    }
                }
                else if (e.ColumnIndex == leaveButtonColumnIndex)
                {
                    if (lease.TenantLeft(leaseId))
                    {
                        if (lease.AddToHistory(leaseId, tenantName, status, dateNow))
                        {
                            MessageBox.Show("Tenant left the apartment!");
                            LoadData();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to process tenant leaving. Please try again.");
                    }
                }
            }
        }
        
        public void Addbutton()
        {
            DataGridViewButtonColumn renewButtonColumn = new DataGridViewButtonColumn();
            renewButtonColumn.Name = "RenewButton";
            renewButtonColumn.HeaderText = string.Empty;
            renewButtonColumn.Text = "Renew";
            renewButtonColumn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn leaveButtonColumn = new DataGridViewButtonColumn();
            leaveButtonColumn.Name = "LeaveButton";
            leaveButtonColumn.HeaderText= string.Empty;
            leaveButtonColumn.Text = "Leave";
            leaveButtonColumn.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(renewButtonColumn);
            dataGridView1.Columns.Add(leaveButtonColumn);

            int lastIndex = dataGridView1.Columns.Count - 1;
            dataGridView1.Columns["RenewButton"].DisplayIndex = lastIndex - 1;
            dataGridView1.Columns["LeaveButton"].DisplayIndex = lastIndex;
        }

        private void txtTenantName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_mlBack_Click(object sender, EventArgs e)
        {
            Frm_Dashboard dashboard = new Frm_Dashboard();
            dashboard.Show();
            this.Close();
        }

        //kailangan ayusin yung left btn
    }
}
