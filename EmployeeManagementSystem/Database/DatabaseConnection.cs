
using MySql.Data.MySqlClient;

namespace EmployeeManagementSystem.Database
{
    public class DatabaseConnection
    {
        private string connectionString =
            "server=localhost;port=3307;database=employee_management_db;uid=root;password=;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
