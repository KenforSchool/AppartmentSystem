using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppartmentSystem
{
    public class DatabaseContext
    {
        private readonly string _dbConnectionString;

        public DatabaseContext(string dbConnectionString)
        {
            _dbConnectionString = dbConnectionString;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_dbConnectionString);
        }
    }
}
