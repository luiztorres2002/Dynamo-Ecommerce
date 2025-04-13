using Npgsql;

namespace Dynamo_Ecommerce.Data
{
    public sealed class DatabaseConnection
    {
        private static readonly Lazy<DatabaseConnection> _instance =
            new Lazy<DatabaseConnection>(() => new DatabaseConnection());

        private readonly string _connectionString;

        private DatabaseConnection()
        {
            _connectionString = "Host=localhost;Port=5432;Database=mydb;Username=myuser;Password=mypassword;";
        }

        public static DatabaseConnection Instance => _instance.Value;
        public NpgsqlConnection GetOpenConnection()
        {
            var connection = new NpgsqlConnection(_connectionString);
            connection.Open();
            return connection;
        }
    }
}
