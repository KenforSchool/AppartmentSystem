using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppartmentSystem.ManageRoom
{
    public partial class frm_EditRoom : Form
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

        public string RoomNumber { get; set; }
        public string TenantName { get; set; }
        public double RoomPrice { get; set; }

        public frm_EditRoom()
        {
            InitializeComponent();
        }

        private void frm_EditRoom_Load(object sender, EventArgs e)
        {
            btn_editRoomSave.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_editRoomSave.Width, btn_editRoomSave.Height, 30, 30));
            btn_editRoomLog.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_editRoomLog.Width, btn_editRoomLog.Height, 30, 30));
            btn_editRoomCancel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_editRoomCancel.Width, btn_editRoomCancel.Height, 30, 30));
        }

        public void setRoomDetails(string roomName, string tenantName, double rent)
        {
            RoomNumber = roomName;
            textBox1.Text = roomName;

            TenantName = tenantName;
            txt_editRoomtenant.Text = tenantName;

            RoomPrice = rent;
            txt_editRoomprice.Text = rent.ToString();
           
        }

        private void btn_editRoomSave_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                roomAddingDAL add = new roomAddingDAL(connectionString);

                string roomNumber = textBox1.Text;
                string tenantName = txt_editRoomtenant.Text;
                int rent = Convert.ToInt32(txt_editRoomprice.Text);

                string action = "Edit";
                DateTime dateTime = DateTime.Now;

                bool successEdit = add.EditLog(roomNumber, rent, tenantName);
                bool logs = add.SaveLog(action, roomNumber, dateTime);

                if (successEdit)
                {
                    MessageBox.Show("Succesfully edit", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if(logs)
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
