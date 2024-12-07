using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppartmentSystem.ManageRoom
{
    public class roomAddingDAL
    {
        private readonly string connectionString;

        public roomAddingDAL(string connString)
        {
              connectionString = connString;
        }

        public bool AddRoomAndTenant(string roomNum, string tenantName, int roomPrice, DateTime moved_IN)
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string roomQuery = "INSERT INTO room (room_id, room_price) VALUES (@room_id, @room_price)";
                    using (SqlCommand command = new SqlCommand(roomQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@room_id", roomNum);
                        command.Parameters.AddWithValue("@room_price", roomPrice);
                        command.ExecuteNonQuery();
                    }

                    string tenantQuery = "INSERT INTO tenant (room_id, tenant_name, moved_in) VALUES (@room_id, @tenant_name, @moved_in)";
                    using (SqlCommand command = new SqlCommand(tenantQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@room_id", roomNum);
                        command.Parameters.AddWithValue("@tenant_name", tenantName);
                        command.Parameters.AddWithValue("@moved_in", moved_IN);
                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;               
                }
                catch(SqlException) 
                {
                   transaction.Rollback();
                    MessageBox.Show("Encountered an error when adding a tenant in the room!");
                    return false;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
                
            }
        }
    }
}
