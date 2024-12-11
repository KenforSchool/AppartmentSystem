using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppartmentSystem.Maintenance
{
    public partial class frm_addMaintenance : Form
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

        public frm_addMaintenance()
        {
            InitializeComponent();
        }

        private void frm_addMaintenance_Load(object sender, EventArgs e)
        {
            btn_addmaintenanceSave.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_addmaintenanceSave.Width, btn_addmaintenanceSave.Height, 30, 30));
            btn_addMaintenanceInfo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_addMaintenanceInfo.Width, btn_addMaintenanceInfo.Height, 30, 30));
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cb_roomaddMaintenance_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
