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

namespace AppartmentSystem.Maintenance
{
    public partial class frm_addMaintenance : Form
    {
        public frm_addMaintenance()
        {
            InitializeComponent();
            LoadRoomComboBox();
        }

        private void frm_addMaintenance_Load(object sender, EventArgs e)
        {
            // for fullscreen
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;

            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cb_roomaddMaintenance_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_addmaintenanceSave_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                MaintenanceDAL maintenance = new MaintenanceDAL(connectionString);

                string expenseType = cb_addExpenseType.Text;
                double amount = Convert.ToDouble(txt_addAmount.Text);
                DateTime dateCreated = DateTime.Now;
                DateTime dateEnd = dp_addMaintenance.Value.Date;
                string description = txt_addDescription.Text;
                string roomNumber = cb_roomaddMaintenance.Text;

                bool success = maintenance.addMaintenanceBill(roomNumber, amount, expenseType, description, dateCreated);

                if (success)
                {
                    MessageBox.Show("Room and tenant have been added successfully");
                    txt_addAmount.Clear();
                    txt_addDescription.Clear();
                }
                else
                {
                    MessageBox.Show("Error has occured. Data has not been saved");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadRoomComboBox()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            MaintenanceDAL maintenance = new MaintenanceDAL(connectionString);

            var roomList = maintenance.getRoomList();
            cb_roomaddMaintenance.DisplayMember = "room_id";
            cb_roomaddMaintenance.ValueMember = "room_id";
            cb_roomaddMaintenance.DataSource = roomList;

            cb_addExpenseType.Items.Add("Maintenance");
            cb_addExpenseType.Items.Add("Utilities");
            cb_addExpenseType.Items.Add("Admin");
        }
    }
}
