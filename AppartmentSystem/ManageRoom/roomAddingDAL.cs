using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics.Tracing;
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

        public bool addTenant(string fullName, string roomNum, DateTime moved_IN)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string tenantUpdateQuery = @"
                UPDATE tenant
                SET room_id = @room_id,
                move_in = @move_in
                WHERE CONCAT(last_name, ' ', first_name, ' ', middle_name) = @full_name;";

                try
                {
                    using (SqlCommand command = new SqlCommand(tenantUpdateQuery, connection))
                    {

                        command.Parameters.AddWithValue("@room_id", roomNum);
                        command.Parameters.AddWithValue("@move_in", moved_IN);
                        command.Parameters.AddWithValue("@full_name", fullName);

                        int rowsAffected = command.ExecuteNonQuery();


                        return rowsAffected > 0;
                    }
                }
                catch (SqlException ex)
                {
                    return false;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public bool AddRoom( string roomNum, double roomPrice)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string roomQuery = @"
                    INSERT INTO room (room_id, room_price)
                    VALUES (@room_id, @room_price)";

                    using (SqlCommand command = new SqlCommand(roomQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@room_id", roomNum);
                        command.Parameters.AddWithValue("@room_price", roomPrice);
                        command.ExecuteNonQuery();
                    }                                  
                    transaction.Commit();
                    return true;
                }
                catch (SqlException ex)
                {
                    transaction.Rollback();
                    return false;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
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
            catch (SqlException)
            {
                return false;
            }
        }

        public bool EditRoom(string roomId, string tenantName, double room_price)
        {
            string roomQuery = "UPDATE room SET room_price = @room_price WHERE room_id = @room_id";
            

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

                    

                    transaction.Commit();
                    return true;
                }
                catch (SqlException)
                {
                    transaction.Rollback();
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
            CONCAT(t.first_name, ' ', ISNULL(t.middle_name, ''), ' ', t.last_name) AS FullName,
            r.room_price as 'Rent',
            t.move_in as 'Move in'
            FROM room r
            LEFT JOIN tenant t ON r.room_id = t.room_id";

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

        public bool SaveLog(string action, string roomId, DateTime saveTime)
        {

            string query = @"
            INSERT INTO
            logs
            (action, room_id, timestamp)
            VALUES
            (@action, @roomId, @timeStamp)";

            
            using(SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@action", action);
                    command.Parameters.AddWithValue("@roomId", roomId);
                    command.Parameters.AddWithValue("@timeStamp", saveTime);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool EditLog(string roomId, int roomPrice, string tenantName)
        {
            string tenantQuery = @"
            UPDATE tenant
            SET tenant_name = @tenantName
            WHERE room_id = @roomId";

            string roomQuery = @"
            UPDATE room
            SET room_price = @roomPrice
            WHERE room_id = @roomId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand tenantCommand = new SqlCommand(tenantQuery, conn, transaction))
                        {
                            tenantCommand.Parameters.AddWithValue("@roomId", roomId);
                            tenantCommand.Parameters.AddWithValue("@tenantName", tenantName);
                            tenantCommand.ExecuteNonQuery();
                        }

                        using (SqlCommand roomCommand = new SqlCommand(roomQuery, conn, transaction))
                        {
                            roomCommand.Parameters.AddWithValue("@roomId", roomId);
                            roomCommand.Parameters.AddWithValue("@roomPrice", roomPrice);
                            roomCommand.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        public DataTable GetEditLogs()
        {
            DataTable editLogs = new DataTable();

            string query = @"
            SELECT *
            FROM logs";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(editLogs);
                    }
                }
            }

            return editLogs;
        }
    }
}
