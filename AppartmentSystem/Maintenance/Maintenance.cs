using AppartmentSystem.Maintenance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppartmentSystem
{
    public partial class Frm_Maintenance : Form
    {
        public Frm_Maintenance()
        {
            InitializeComponent();
        }

        private void Maintenance_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;

            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void btn_addMaintenance_Click(object sender, EventArgs e)
        {
            frm_addMaintenance Frm_AddMaintenance = new frm_addMaintenance();
            Frm_AddMaintenance.Show();
            this.Hide();





        }

        private void btn_maintenanceBack_Click(object sender, EventArgs e)
        {

        }
    }
}
