using Npgsql;
namespace BlazorApp.Service
{
    public class DBService
    {
        private readonly string _dbConnectionString;

        public DBService(string dbConnectionString)
        {
            _dbConnectionString = dbConnectionString;
        }
        public NpgsqlConnection CreateConnection()
        {   
            var connection = new NpgsqlConnection();
            connection.Open();
            return connection;
        }

    }
}
