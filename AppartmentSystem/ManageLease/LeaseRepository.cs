using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace AppartmentSystem
{
    public class LeaseRepository
    {
        private readonly string _connectionString;

        public LeaseRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        //Renewal ng tenant
        public bool RenewLease(string roomNumber, DateTime LeaseEndDate)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = @"
                UPDATE LeaseDetails
                SET 
                Status = 'Renewed',
                LeaseStartDate = LeaseEndDate,
                LeaseEndDate = DATEADD(MONTH, 1, LeaseEndDate)
                WHERE room_id = (SELECT room_id FROM room WHERE room_id = @RoomNumber)";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RoomNumber", roomNumber);
                    command.Parameters.AddWithValue("@leaseEndDate", LeaseEndDate);

                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool TenantLeft(string roomNumbr)
        {
            using (var connection = new SqlConnection(_connectionString))
            {

                string query = @"
                UPDATE LeaseDetails
                SET 
                Status = 'Left'
                WHERE room_id = (SELECT room_id FROM room WHERE room_id = @RoomNumber)";

                using (var command = new SqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue("@RoomNumber", roomNumbr);

                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
        
        //Function kapag umalis tenant
        public bool MoveOutTenant(string roomNumber)
        {
            using(var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string leftQuery = @"
                DELETE LeaseDetails
                WHERE
                room_id = @roomId";

                using(var command = new SqlCommand(leftQuery, connection))
                {
                    command.Parameters.AddWithValue("@roomId", roomNumber);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool AddToHistory(string roomNumber, string tenantName, string _process, DateTime tenantLeft)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();

                try
                {

                    string query = @"
                    INSERT INTO history 
                    (room_id, tenant_name, action_date, process)
                    VALUES
                    (@roomId, @tenantName, @actionDate, @process)";

                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@roomId", roomNumber);
                        command.Parameters.AddWithValue("@tenantName", tenantName);
                        command.Parameters.AddWithValue("@actionDate", tenantLeft);
                        command.Parameters.AddWithValue("@process", _process);
                        command.ExecuteNonQuery();

                        return true;
                    }
                }
                catch (SqlException ex)
                {

                    MessageBox.Show("Error :" + ex.Message);
                    return false;
                }
                
            }
        }

        public bool CanPerformActionToday(string roomNumber)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = @"
            SELECT COUNT(*) 
            FROM history 
            WHERE room_id = @RoomNumber AND CAST(action_date AS DATE) = CAST(GETDATE() AS DATE)";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RoomNumber", roomNumber);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count == 0;
                }
            }
        }

        public bool DeleteRoom(string roomId)
        {
            string query = "DELETE FROM LeaseDetails WHERE room_id = @room_id";
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
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

        public bool ArchiveLeaseData(string roomID, double roomPrice, DateTime leaseStart, DateTime leaseEnd)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                try
                {
                 string insertArchiveQuery = @"
                INSERT INTO lease_archive
                (room_id, electricity_bill, water_bill, internet_bill, room_price, lease_start, lease_end)
                VALUES
                (@room_id, @electricity_bill, @water_bill, @internet_bill, @room_price, @lease_start, @lease_end)
                 ";

                    using (SqlCommand command = new SqlCommand(insertArchiveQuery, connection))
                    {
                        command.Parameters.AddWithValue("@room_id", roomID);
                        command.Parameters.AddWithValue("@room_price", roomPrice);
                        command.Parameters.AddWithValue("@lease_start", leaseStart);
                        command.Parameters.AddWithValue("@lease_end", leaseEnd);

                        command.ExecuteNonQuery();
                    }

                    return true;
                }
                catch (SqlException sql)
                {
                    MessageBox.Show("Error: " + sql.Message);
                    return false;
                }
            }
        }

        public bool editRoom(string roomId, DateTime leaseStart, DateTime leaseEnd)
        {
            string query = @"
            UPDATE lease
            set lease_start = @lease_start, lease_end = @lease_end WHERE 
            room_id = @room_id";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@room_id", roomId);
                        command.Parameters.AddWithValue("@lease_start", leaseStart);
                        command.Parameters.AddWithValue("@lease_end", leaseEnd);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("No record found with the given room_id.");
                            return false;
                        }
                    }
                }
                catch (SqlException ex)
                {

                    MessageBox.Show("SQL Error: " + ex.Message);
                    return false;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public DataTable GetTenantRoomId(string roomID)
        {
            DataTable dataTable = new DataTable();

            string query = @"
            SELECT
            r.room_id AS 'Room Number',
            r.tenant_name AS 'Name',
            o.room_price AS 'Rent',
            r.LeaseStartDate AS 'Lease Start',
            r.LeaseEndDate AS 'Lease Due',
            r.Status
            FROM LeaseDetails r
            LEFT JOIN room o
            ON o.room_id = r.room_id";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@room_id", roomID);
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
