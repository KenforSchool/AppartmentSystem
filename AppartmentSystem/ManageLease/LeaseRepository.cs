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

                string removeTenant = @"
                DELETE LeaseDetails
                WHERE lease_id  = @leaseNumber";

                using (var _command = new SqlCommand(removeTenant, connection))
                {
                    _command.Parameters.AddWithValue("@leaseNumber", leaseNumber);
                }

                string query = @"
                UPDATE LeaseDetails
                SET 
                Status = 'Left'
                WHERE lease_id = (SELECT lease_id FROM LeaseDetails WHERE lease_id = @leaseNumber)";

                using (var command = new SqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue("@leaseNumber", leaseNumber);
                }

                return true;
            }
        }
        
        //Function kapag umalis tenant
        public bool MoveOutTenant(int leaseNumber)
        {
            using(var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string leftQuery = @"
                DELETE LeaseDetails
                WHERE
                lease_id = @lease_id";

                using(var command = new SqlCommand(leftQuery, connection))
                {
                    command.Parameters.AddWithValue("@lease_id", leaseNumber);
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
                catch (SqlException ex)
                {

                    MessageBox.Show("Error :" + ex.Message);
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
