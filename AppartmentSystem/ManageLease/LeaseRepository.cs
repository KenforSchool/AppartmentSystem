﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
            double internetBill, double roomPrice, DateTime leaseStart)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                try
                {

                    string insertLeaseQuery = @"
                    DECLARE @lease_start DATE;
                    SET @lease_start = @lease;

                    INSERT INTO lease 
                    (room_id, electricity_bill, water_bill, internet_bill, room_price, lease_start)
                    VALUES 
                    (@room_id, @electricity_bill, @water_bill, @internet_bill, @room_price, @lease_start)";

                    using (SqlCommand updateLeaseCmd = new SqlCommand(insertLeaseQuery, conn))
                    {
                        updateLeaseCmd.Parameters.AddWithValue("@room_id", roomID);
                        updateLeaseCmd.Parameters.AddWithValue("@electricity_bill", electricBill);
                        updateLeaseCmd.Parameters.AddWithValue("@water_bill", waterBill);
                        updateLeaseCmd.Parameters.AddWithValue("@internet_bill", internetBill);
                        updateLeaseCmd.Parameters.AddWithValue("@room_price", roomPrice);
                        updateLeaseCmd.Parameters.AddWithValue("@lease", leaseStart);

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

        public DataTable GetTenantRoomId(string roomID)
        {
            DataTable dataTable = new DataTable();

            string query = @"
            SELECT
            r.room_id AS 'Room Number',
            t.tenant_name AS 'Name',
            r.room_price AS 'Rent',
            l.electricity_bill AS 'Electricity Bill',
            l.water_bill AS 'Water Bill',
            l.internet_bill AS 'Internet Bill'
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
