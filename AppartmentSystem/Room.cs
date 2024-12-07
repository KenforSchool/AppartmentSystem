using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppartmentSystem
{
    public partial class frm_room : Form
    {
        public frm_room()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_room_Load(object sender, EventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void btn_addRoom_Click(object sender, EventArgs e)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            DatabaseContext conn = new DatabaseContext(connectionString);

            string roomNum = txt_RoomNo.Text;
            //string roomPrice = txt_RoomPrice.Text;

            string tenantName = txt_tenant.Text;


            using (SqlConnection connection = conn.GetConnection())
            {

                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {

                    string roomQuery = "INSERT INTO room (room_id, room_price) VALUES (@room_id, @room_price)";
                    using (SqlCommand command = new SqlCommand(roomQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@room_id", roomNum);
                        //command.Parameters.AddWithValue("@room_price", roomPrice);
                        command.ExecuteNonQuery();
                    }

                    string tenantQuery = "INSERT INTO tenant (room_id, tenant_name, moved_in) VALUES (@room_id, @tenant_name, @moved_in)";
                    using (SqlCommand command = new SqlCommand(tenantQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@room_id", roomNum);
                        command.Parameters.AddWithValue("@tenant_name", tenantName);
                        //command.Parameters.AddWithValue("@moved_in", moved_IN);
                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Room has been added!");

                }
                catch (Exception)
                {

                    transaction.Rollback();
                    MessageBox.Show("Error has occured!, data has not saved");
                }
            }
        }
    }
}
