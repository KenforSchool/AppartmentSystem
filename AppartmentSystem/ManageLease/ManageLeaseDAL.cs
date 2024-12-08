using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppartmentSystem.ManageLease
{
    public class ManageLeaseDAL
    {
        private readonly string _connectionString;

        public ManageLeaseDAL(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool addLease(string roomID, string tenantName, double electricBill, double waterBill,
            double internetBill, double roomPrice)
        {

            string query = "UPDATE LEASE" +
                    "SET electricity_bill = @electricity_bill, water_bill = @water_bill, " +
                    "internet_bill = @internet_bill, room_price = @room_price" +
                    "WHERE room_id = @room_id";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {           
                conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@room_id", roomID);
                        cmd.Parameters.AddWithValue("@electricity_bill", electricBill);
                        cmd.Parameters.AddWithValue("@water_bill", waterBill);
                        cmd.Parameters.AddWithValue("@internet_bill", internetBill);
                        cmd.Parameters.AddWithValue("@room_price", roomPrice);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
            }
        }
    }
}
