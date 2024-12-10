using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    }
}
