using System;
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
            double internetBill, double roomPrice)
        {

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                SqlTransaction tran = conn.BeginTransaction();
                try
                {
                   
                    string insertQuery = @"INSERT INTO lease (room_id,  electricity_bill, water_bill, internet_bill, room_price) " +
                                                "VALUES (@room_id, @electricity_bill, @water_bill, @internet_bill, @room_price)";
                   
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
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("An error occured while saving the lease: " + ex.Message);
                    return false;
                }

            }
        }

        public DataTable GetTenantRoomId(string roomID)
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT tenant_name FROM tenant WHERE room_id = @room_id";

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
