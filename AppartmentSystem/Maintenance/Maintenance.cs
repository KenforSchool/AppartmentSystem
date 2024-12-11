using AppartmentSystem.Maintenance;
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

namespace AppartmentSystem
{
    public partial class Frm_Maintenance : Form
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

        public Frm_Maintenance()
        {
            InitializeComponent();
            LoadData();
            addButton();
        }

        private void Maintenance_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;

            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

            btn_addMaintenance.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_addMaintenance.Width, btn_addMaintenance.Height, 30, 30));
            btn_deleteMaintenance.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_deleteMaintenance.Width, btn_deleteMaintenance.Height, 30, 30));
            btn_editMaintenance.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_editMaintenance.Width, btn_editMaintenance.Height, 30, 30));
        }

        private void btn_addMaintenance_Click(object sender, EventArgs e)
        {
            frm_addMaintenance Frm_AddMaintenance = new frm_addMaintenance();
            Frm_AddMaintenance.Show();
            this.Hide();

        }

        public void LoadData()
        {
            var data_access = new MaintenanceDAL(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            try
            {
                DataTable table = data_access.getMaintenanceList();

                if(table.Rows.Count > 0)
                {
                    dg_maintenance.DataSource = table;
                }
                else
                {
                    dg_maintenance.DataSource = null;
                }
                               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void addButton()
        {
            DataGridViewButtonColumn full_descpription = new DataGridViewButtonColumn();
            full_descpription.Name = "Description";
            full_descpription.HeaderText = string.Empty;
            full_descpription.Text = "See Description";
            full_descpription.UseColumnTextForButtonValue = true;

            dg_maintenance.Columns.Add(full_descpription);
        }

        private void btn_maintenanceBack_Click(object sender, EventArgs e)
        {

        }

        private void dg_maintenance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
