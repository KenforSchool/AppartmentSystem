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

namespace AppartmentSystem
{
    public partial class frm_tenantProfile : Form
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

        public frm_tenantProfile()
        {
            InitializeComponent();

            panel_tenantInfo.BackColor = Color.FromArgb(125, Color.Black);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_tenantProfile_Load(object sender, EventArgs e)
        {
            panel_tenantInfo.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, panel_tenantInfo.Width, panel_tenantInfo.Height, 30, 30));

            btn_addManageTenant.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, btn_addManageTenant.Width, btn_addManageTenant.Height, 30, 30));

            btn_cancelManageTenant.Region = Region.FromHrgn(CreateRoundRectRgn
                (0, 0, btn_cancelManageTenant.Width, btn_cancelManageTenant.Height, 30, 30));
        }
    }
}
