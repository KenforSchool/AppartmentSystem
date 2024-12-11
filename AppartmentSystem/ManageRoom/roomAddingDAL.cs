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

        public bool AddRoomAndTenant( string roomNum, string tenantName, double roomPrice, DateTime moved_IN, DateTime moved_OUT)
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

                    string tenantQuery = @"
                    DECLARE @move_in DATE;
                    SET @move_in = @move_in_param;

                    DECLARE @moved_out DATE;
                    SET @moved_out = @moved_out_param;

                    INSERT INTO tenant (room_id, tenant_name, move_in, moved_out)
                    VALUES (@room_id, @tenant_name, @move_in, @moved_out)

                    INSERT INTO LeaseDetails (room_id, tenant_name, LeaseStartDate, LeaseEndDate)
                    VALUES (@room_id, @tenant_name, @move_in, @moved_out)";

                    using (SqlCommand command = new SqlCommand(tenantQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@room_id", roomNum);
                        command.Parameters.AddWithValue("@tenant_name", tenantName);
                        command.Parameters.AddWithValue("@move_in_param", moved_IN);
                        command.Parameters.AddWithValue("@moved_out_param", moved_OUT);
                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch (SqlException sqlEx)
                {
                    transaction.Rollback();
                    MessageBox.Show($"SQL Error: {sqlEx.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public bool EditRoom(string roomId, string tenantName, double room_price, DateTime movedIN)
        {
            string roomQuery = "UPDATE room SET room_price = @room_price WHERE room_id = @room_id";
            string tenantQuery = @"
            UPDATE tenant
            SET tenant_name = @tenantName, move_in = @moveIN
            WHERE room_id IN (SELECT room_id FROM room WHERE room_id = @room_id)";

            using (SqlConnection connection = new SqlConnection(connectionString))
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
                        tenantCommand.Parameters.AddWithValue("@room_id",roomId);
                        tenantCommand.Parameters.AddWithValue("@tenantName",tenantName);
                        tenantCommand.Parameters.AddWithValue("@moveIN", movedIN);
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
                     r.room_id as 'Room Number',
                     r.room_price as 'Rent',
                     t.tenant_name as 'Name',
                     t.move_in as 'Moved in date'
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
