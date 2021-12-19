using Microsoft.Data.SqlClient;
using System.Data;

namespace webtest2.Context
{
    public class DapperContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("EFConnectoin");
        }
        public IDbConnection CreateConnection()
            => new SqlConnection(_connectionString);
    }
}
