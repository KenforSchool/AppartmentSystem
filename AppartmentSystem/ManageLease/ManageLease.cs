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

        private void btn_addLease_Click(object sender, EventArgs e)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            LeaseRepository lease = new LeaseRepository(connectionString);

            double electricity = double.Parse(txtElectricBill.Text);
            double water = double.Parse(txtWaterBill.Text);
            double internet = double.Parse(txt_wifiBill.Text);
            double maintenance = double.Parse(txtRoomBill.Text);
            string room_id = txt_roomNo.Text;
            int room_price = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Rent"].Value);
            DateTime dt = dateTimePicker1.Value;

            var repo = lease.addLease(room_id, electricity, water, internet, room_price,dt);

            if (repo)
            {
                MessageBox.Show("lease have been added successfully");
                txtElectricBill.Clear();
                txtRoomBill.Clear();
                txtWaterBill.Clear();
                txtElectricBill.Clear();
                LoadData();
            }
            else
            {
                MessageBox.Show("Error has occured. Data has not been saved");
            }
        }

        private void ManageLease_Load(object sender, EventArgs e)
        {
            LoadData();
            if (txt_roomNo.Text == "")
            {
                dataGridView1.SelectionChanged += dg_ManageRoom_SelectionChanged;
            }
            else
            {
                dataGridView1.SelectionChanged -= dg_ManageRoom_SelectionChanged;
            }
        }
        private void LoadData()
        {
            var dataAccess = new LeaseRepository(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            string room_id = txt_roomNo.Text;
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
                txt_roomNo.Text = selectedRow.Cells[0].Value.ToString();
            }
        }
    }
}
