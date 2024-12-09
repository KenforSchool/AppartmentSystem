using AppartmentSystem.ManageRoom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        private void btn_updateLease_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_addLease_Click(object sender, EventArgs e)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            LeaseRepository lease = new LeaseRepository(connectionString);

            double electricity = double.Parse(txtElectricBill.Text);
            double water = double.Parse(txtWaterBill.Text);
            double internet = double.Parse(txt_wifiBill.Text);
            double maintenance = double.Parse(txtRoomBill.Text);
            string room_id = lbl_roomNumberlease.Text;
            int room_price = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value);
            DateTime moved_in = dateTimePicker1.Value;
            DateTime moved_out = moved_in.AddMonths(1);

            var repo = lease.addLease(room_id, electricity, water, internet, room_price, moved_in, moved_out);

            if (repo)
            {
                MessageBox.Show("lease have been added successfully");
                txtElectricBill.Clear();
                txtRoomBill.Clear();
                txtWaterBill.Clear();
                txtElectricBill.Clear();
                btn_updateLease_Click(sender, e);
                
            }
            else
            {
                MessageBox.Show("Error has occured. Data has not been saved");
            }
        }

        private void ManageLease_Load(object sender, EventArgs e)
        {
            LoadData();
            if (lbl_roomNumberlease.Text == "")
            {
                dataGridView1.SelectionChanged += dg_ManageRoom_SelectionChanged;
            }
            else
            {
                dataGridView1.SelectionChanged -= dg_ManageRoom_SelectionChanged;
            }
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;

            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

        }

        private void LoadData()
        {
            var dataAccess = new LeaseRepository(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            string room_id = lbl_roomNumberlease.Text;
            try
            {
                DataTable data = dataAccess.GetTenantRoomId(room_id);

                if (data.Rows.Count > 0)
                {
                    dataGridView1.DataSource = data;
                }
                else
                {
                    MessageBox.Show("No data found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dg_ManageRoom_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Pass values to TextBox controls
                lbl_roomNumberlease.Text = selectedRow.Cells[1].Value.ToString();
                txtTenantName.Text = selectedRow.Cells[2].Value.ToString();
                textBox1.Text = selectedRow.Cells[0].Value.ToString();
                txtElectricBill.Text = selectedRow.Cells[4].Value.ToString();
                //txtRoomBill.Text = selectedRow.Cells[0].Value.ToString();
                txtWaterBill.Text = selectedRow.Cells[5].Value.ToString();
                txt_wifiBill.Text = selectedRow.Cells[6].Value.ToString();
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

            string roomId = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                LeaseRepository room = new LeaseRepository(connectionString);

                bool isDeleted = room.DeleteRoom(roomId);
                Archive();

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

            string roomId = lbl_roomNumberlease.Text;
            double electricityBill = double.Parse(txtElectricBill.Text);
            double internetBill = double.Parse(txt_wifiBill.Text);
            double waterBill = double.Parse(txtWaterBill.Text);
            double maintenanceBill = double.Parse(txtRoomBill.Text);
            string tenantName = txtTenantName.Text;
            DateTime moved_in = dateTimePicker1.Value;
            DateTime moved_out = moved_in.AddMonths(1);

            LeaseRepository lease = new LeaseRepository(connectionString);
            bool isUpdated = lease.editRoom(roomId,electricityBill,waterBill,internetBill, moved_in, moved_out);

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

            string roomId = lbl_roomNumberlease.Text;
            double electricityBill = double.Parse(txtElectricBill.Text);
            double internetBill = double.Parse(txt_wifiBill.Text);
            double waterBill = double.Parse(txtWaterBill.Text);
            //double maintenanceBill = double.Parse(txtRoomBill.Text);
            double room_price = Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[3].Value);
            string tenantName = txtTenantName.Text;
            DateTime moved_in = dateTimePicker1.Value;
            DateTime moved_out = moved_in.AddMonths(1);

            LeaseRepository lease = new LeaseRepository(connectionString);
            bool isUpdated = lease.ArchiveLeaseData(roomId,electricityBill,waterBill,internetBill, room_price, moved_in, moved_out);

            if (isUpdated)
            {
                MessageBox.Show("Record send to archive!");
            }
            else
            {
                MessageBox.Show("Redord not save");
            }
        }
    }
}
