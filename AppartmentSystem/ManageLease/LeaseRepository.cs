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
        public bool RenewLease(int leaseNumber, DateTime LeaseEndDate)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = @"
                UPDATE LeaseDetails
                SET 
                Status = 'Renewed',
                LeaseStartDate = LeaseEndDate,
                LeaseEndDate = DATEADD(MONTH, 1, LeaseEndDate)
                WHERE lease_id = (SELECT lease_id FROM LeaseDetails WHERE lease_id = @leaseNumber)";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@leaseNumber", leaseNumber);
                    command.Parameters.AddWithValue("@leaseEndDate", LeaseEndDate);

                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool TenantLeft(int leaseNumber)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // Begin by updating the LeaseDetails table to mark the tenant as 'Left'
                string updateLeaseQuery = @"
                UPDATE LeaseDetails
                SET Status = 'Left'
                WHERE lease_id = @leaseNumber";

                using (var command = new SqlCommand(updateLeaseQuery, connection))
                {
                    command.Parameters.AddWithValue("@leaseNumber", leaseNumber);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        // If no rows were affected, return false (tenant not found or update failed)
                        return false;
                    }
                }

                // Now, remove the tenant's name from the corresponding room
                string updateRoomQuery = @"
                UPDATE room
                SET tenant_name = NULL
        W       HERE room_id = (SELECT room_id FROM LeaseDetails WHERE lease_id = @leaseNumber)";

                using (var command = new SqlCommand(updateRoomQuery, connection))
                {
                    command.Parameters.AddWithValue("@leaseNumber", leaseNumber);
                    int rowsAffected = command.ExecuteNonQuery();

                    // If rows were affected, the tenant's name has been successfully removed from the room
                    return rowsAffected > 0;
                }
            }
        }

        //Function kapag umalis tenant
        public bool MoveOutTenant(int leaseNumber, string roomNumber)
        {
            using(var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string leftQuery = @"
                DELETE LeaseDetails
                WHERE
                lease_id = @lease_id;
                DELETE tenant
                WHERE
                room_id = @roomId";

                using(var command = new SqlCommand(leftQuery, connection))
                {
                    command.Parameters.AddWithValue("@lease_id", leaseNumber);
                    command.Parameters.AddWithValue("@roomId", roomNumber);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool AddToHistory(int leaseId, string tenantName, string _process, DateTime tenantLeft)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();

                try
                {

                    string query = @"
                    INSERT INTO history 
                    (lease_id, tenant_name, action_date, process)
                    VALUES
                    (@lease_id, @tenantName, @actionDate, @process)";

                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@lease_id", leaseId);
                        command.Parameters.AddWithValue("@tenantName", tenantName);
                        command.Parameters.AddWithValue("@actionDate", tenantLeft);
                        command.Parameters.AddWithValue("@process", _process);
                        command.ExecuteNonQuery();

                        return true;
                    }
                }
                catch (SqlException)
                {

                    return false;
                }
                
            }
        }

        public bool CanPerformActionToday(int leaseNumber)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = @"
                SELECT COUNT(*) 
                FROM history 
                WHERE lease_id = @leaseNumber AND CAST(action_date AS DATE) = CAST(GETDATE() AS DATE)";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@leaseNumber", leaseNumber);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count == 0;
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
                            MessageBox.Show("No record found with the given Room Number.");
                            return false;
                        }
                    }
                }
                catch (SqlException)
                {
                    return false;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public DataTable GetTenantRoomId(string roomID)
        {
            DataTable dataTable = new DataTable();

            string query = @"
            SELECT
            r.lease_id AS 'ID',
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
