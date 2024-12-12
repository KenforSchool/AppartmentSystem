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


        public frm_EditRoom()
        {
            InitializeComponent();
        }

        private void frm_EditRoom_Load(object sender, EventArgs e)
        {
            btn_editRoomSave.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_editRoomSave.Width, btn_editRoomSave.Height, 30, 30));
            
            btn_editRoomCancel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_editRoomCancel.Width, btn_editRoomCancel.Height, 30, 30));
        }
    }
}
