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
    public partial class frm_financialData : Form
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

            btn_fdAdd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_fdAdd.Width, btn_fdAdd.Height, 30, 30));
            btn_fdDelete.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_fdDelete.Width, btn_fdDelete.Height, 30, 30));
            btn_fdPaid.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_fdPaid.Width, btn_fdPaid.Height, 30, 30));

        }

        private void txt_fdroomNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_fdAdd_Click(object sender, EventArgs e)
        {

        }

        private void btn_fdEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
