using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharepoint.Dao
{
    public class DatabaseHelperBase
    {
        private readonly String connectionString;
        public DatabaseHelperBase(IConfiguration configuration)
        {
            this.connectionString = configuration.GetConnectionString("Test");
        }

        protected async Task<SqlConnection> GetSqlConnectionAsync()
        {
            var connection = new SqlConnection(connectionString);
            await connection.OpenAsync();
            return connection;
        }
    }
}
