using System;
using System.Collections.Generic;
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

        public bool addLease(string roomID, string tenantName, double electricBill, double waterBill,
            double internetBill, double roomPrice)
        {

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();
                try
                {
                    string checkQuery = "SELECT COUNT(1) FROM lease WHERE room_id = @roomid";

                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, conn, tran))
                    {
                        checkCommand.Parameters.AddWithValue("@room_id", roomID);
                        int roomExists = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (roomExists == 0)
                        {
                            throw new Exception("Room ID does not exist in the room table.");
                        }
                    }
                    string insertQuery = @"INSERT INTO lease (room_id,  electricity_bill, water_bill, internet_bill, room_price) " +
                                                "VALUES (@room_id, @electricity_bill, @water_bill, @internet_bill, @room_price)";

                    using (SqlCommand cmd = new SqlCommand(checkQuery, conn, tran))
                    {
                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, conn, tran))
                        {
                            insertCommand.Parameters.AddWithValue("@room_id", roomID);
                            insertCommand.Parameters.AddWithValue("@electricity_bill", electricBill);
                            insertCommand.Parameters.AddWithValue("@water_bill", waterBill);
                            insertCommand.Parameters.AddWithValue("@internet_bill", internetBill);
                            insertCommand.Parameters.AddWithValue("@room_price", roomPrice);

                            insertCommand.ExecuteNonQuery();
                        }                        

                        tran.Commit();
                        MessageBox.Show("Least saved successfully");
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("An error occured while saving the lease: " + ex.Message);
                    return false;
                }

            }
        }
    }
}
