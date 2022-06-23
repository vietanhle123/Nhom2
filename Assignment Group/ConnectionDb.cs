using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Demo.Coffee
{
    public class ConnectionDb
    {
        public SqlConnection GetConnection()
        {
            string connectionString2 = "Data source = localhost; Initial Catalog = DbTest; Integrated Security = SSPI";

            SqlConnection sqlConnection = new SqlConnection(connectionString2);

            return sqlConnection;
        }
    }
}
