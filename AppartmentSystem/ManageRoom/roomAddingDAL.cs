using System;
using System.Collections.Generic;
using System.Data;
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

        public bool AddRoomAndTenant(string roomNum, string tenantName, double roomPrice, string moved_IN)
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

        public bool DeleteRoom(string roomId)
        {
            string query = "DELETE FROM room WHERE room_id = @room_id";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@room_id", roomId);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
                return false;
            }
        }

        public bool EditRoom(string roomId, string tenantName, double room_price, string movedIN)
        {
            string roomQuery = "UPDATE room SET room_price = @room_price WHERE room room_id = @room_id";
            string tenantQuery = "UPDATE room SET tenant_name = @tenantName, moved_in = @movedIN WHERE room_id = @room_id";

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    using(SqlCommand roomCommand = new SqlCommand(roomQuery, connection, transaction))
                    {
                        roomCommand.Parameters.AddWithValue("@room_id",roomId);
                        roomCommand.Parameters.AddWithValue("@room_price", room_price);
                        roomCommand.ExecuteNonQuery();
                    }

                    using (SqlCommand tenantCommand = new SqlCommand(tenantQuery, connection, transaction))
                    {
                        tenantCommand.Parameters.AddWithValue("@room_id", roomId);
                        tenantCommand.Parameters.AddWithValue("@tenantName", tenantName);
                        tenantCommand.Parameters.AddWithValue("@moved_IN", movedIN);
                        tenantCommand.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch (SqlException sql)
                {
                    transaction.Rollback();
                    MessageBox.Show("SQL encountered error: " + sql.Message);
                    return false;
                }
            }

        }

        public DataTable GetRoomTable()
        {
            DataTable dataTable = new DataTable();

            string query = @"
                SELECT
                     r.room_id,
                     t.tenant_name,
                     t.moved_in
                FROM room r
                LEFT JOIN tenant t
                ON r.room_id = t.room_id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }
    }
}
