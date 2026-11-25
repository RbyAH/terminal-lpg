using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TAS.API.Infrastructure.Data
{
    public class DbConnectionFactory
    {
        private readonly string _connectionString;

        public DbConnectionFactory()
        {
            _connectionString =
                ConfigurationManager
                    .ConnectionStrings["TASConnection"]
                    .ConnectionString;
        }

        public IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}