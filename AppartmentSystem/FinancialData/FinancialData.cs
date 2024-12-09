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
    public partial class frm_financialData : Form
    {
        public frm_financialData()
        {
            InitializeComponent();
        }

        private void btn_fdUpdate_Click(object sender, EventArgs e)
        {

        }

        private void frm_financialData_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;

            this.Location = new Point(0, 0);
            this.Size = new Size(w, h); 
        }

        private void txt_fdroomNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
