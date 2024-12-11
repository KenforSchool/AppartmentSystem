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
    public class MaintenanceDAL
    {
        private readonly string _ConnectionString;

        public MaintenanceDAL(string connectionString)
        {
            _ConnectionString = connectionString;
        }

        public bool addMaintenanceBill(string roomId, int amount, string expenseType, 
            string description, DateTime expenseDate)
        {
            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try
                {

                    string addQuery = @"
                    DECLARE @ExpenseDate DATE;
                    SET @_ExpenseDate = @ExpensseDate_param;

                    INSERT INTO
                    Expenses
                    (room_id, ExpenseDate, ExpenseType, Amount, Description)
                    VALUES
                    (@roomId, @_ExpenseDate, @_ExpenseType, @_Amount, @Description)";

                    using (SqlCommand command = new SqlCommand(addQuery, connection, transaction))
                    {

                        command.Parameters.AddWithValue("@roomId", roomId);
                        command.Parameters.AddWithValue("@ExpensseDate_param", expenseDate);
                        command.Parameters.AddWithValue("@_ExpenseType", expenseType);
                        command.Parameters.AddWithValue("@_Amount", amount);
                        command.Parameters.AddWithValue("@Description", description);
                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch (SqlException ex)
                {

                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }


        public DataTable getMaintenanceList()
        {
            DataTable table = new DataTable();

            string query = @"
            SELECT 
                ExpenseID AS 'ID',
                room_id AS 'Room Number',
                ExpenseType AS 'Expense Type'
                Amount,
                Description
            FROM Description";

            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
            }

            return table;
        }
    }
}
