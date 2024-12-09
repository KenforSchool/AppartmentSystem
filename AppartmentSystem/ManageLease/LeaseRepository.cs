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

namespace AppartmentSystem
{
    public class LeaseRepository
    {
        private readonly string _connectionString;

        public LeaseRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool addLease(string roomID, double electricBill, double waterBill,
            double internetBill, double roomPrice, DateTime leaseStart, DateTime leaseEnd)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                try
                {

                    string insertLeaseQuery = @"
                    DECLARE @lease_start DATE;
                    SET @lease_start = @lease;
                    
                    DECLARE @lease_end DATE;
                    SET @lease_end = @leaseEnd;

                    INSERT INTO lease 
                    (room_id, electricity_bill, water_bill, internet_bill, room_price, lease_start, lease_end)
                    VALUES 
                    (@room_id, @electricity_bill, @water_bill, @internet_bill, @room_price, @lease_start, @lease_end)";

                    using (SqlCommand updateLeaseCmd = new SqlCommand(insertLeaseQuery, conn))
                    {
                        updateLeaseCmd.Parameters.AddWithValue("@room_id", roomID);
                        updateLeaseCmd.Parameters.AddWithValue("@electricity_bill", electricBill);
                        updateLeaseCmd.Parameters.AddWithValue("@water_bill", waterBill);
                        updateLeaseCmd.Parameters.AddWithValue("@internet_bill", internetBill);
                        updateLeaseCmd.Parameters.AddWithValue("@room_price", roomPrice);
                        updateLeaseCmd.Parameters.AddWithValue("@lease", leaseStart);
                        updateLeaseCmd.Parameters.AddWithValue("@leaseEnd", leaseEnd);

                        updateLeaseCmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Lease record updated successfully.");
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating the lease: " + ex.Message);
                    return false;
                }
            }
        }

        public bool DeleteRoom(string roomId)
        {
            string query = "DELETE FROM lease WHERE room_id = @room_id";
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

        public bool ArchiveLeaseData(string roomID, double electricityBill, double waterBill,
        double internetBill, double roomPrice, DateTime leaseStart, DateTime leaseEnd)
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
                        command.Parameters.AddWithValue("@electricity_bill", electricityBill);
                        command.Parameters.AddWithValue("@water_bill", waterBill);
                        command.Parameters.AddWithValue("@internet_bill", internetBill);
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

        public bool editRoom(string roomId, double electricBill, double waterBill,
            double interntBill, DateTime leaseStart, DateTime leaseEnd)
        {
            string query = @"UPDATE lease
            set electricity_bill = @electricity_bill, water_bill = @water_bill, internet_bill = @internet_bill 
            , lease_start = @lease_start, lease_end = @lease_end WHERE 
            room_id = @room_id";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@room_id", roomId);
                        command.Parameters.AddWithValue("@electricity_bill", electricBill);
                        command.Parameters.AddWithValue("@water_bill", waterBill);
                        command.Parameters.AddWithValue("@internet_bill", interntBill);
                        command.Parameters.AddWithValue("@lease_start", leaseStart);
                        command.Parameters.AddWithValue("@@lease_end", leaseEnd);

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
            l.lease_id AS 'Lease ID',
            r.room_id AS 'Room Number',
            t.tenant_name AS 'Name',
            r.room_price AS 'Rent',
            l.electricity_bill AS 'Electricity Bill',
            l.water_bill AS 'Water Bill',
            l.internet_bill AS 'Internet Bill',
            l.lease_start AS 'Lease Start',
            l.lease_end AS 'Lease End'
            FROM room r
            LEFT JOIN tenant t
            ON r.room_id = t.room_id
            LEFT JOIN lease l
            ON r.room_id = l.room_id";

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
