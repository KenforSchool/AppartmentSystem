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
            if (string.IsNullOrWhiteSpace(txt_roomNo.Text) ||
                string.IsNullOrWhiteSpace(txtElectricBill.Text) ||
                string.IsNullOrWhiteSpace(txtWaterBill.Text) ||
                string.IsNullOrWhiteSpace(txt_wifiBill.Text) ||
                string.IsNullOrWhiteSpace(txtRoomBill.Text) ||
                string.IsNullOrWhiteSpace(txtTenantName.Text))
            {
                MessageBox.Show("All fields are required. Please fill in all values.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtElectricBill.Text, out int electricityBill) ||
                !int.TryParse(txtWaterBill.Text, out int waterBill) ||
                !int.TryParse(txt_wifiBill.Text, out int internetBill) ||
                !int.TryParse(txtRoomBill.Text, out int roomPrice))
            {
                MessageBox.Show("Please enter valid numeric values for the bills and room price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            string roomId = txt_roomNo.Text.Trim();

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            LeaseRepository lease = new LeaseRepository(connectionString);

            bool isSuccess = lease.addLease(roomId,  electricityBill, waterBill, );

            try
            {
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
