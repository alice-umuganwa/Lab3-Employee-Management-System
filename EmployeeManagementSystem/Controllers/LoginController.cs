
using System;
using MySql.Data.MySqlClient;
using EmployeeManagementSystem.Database;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Controllers
{
    public class LoginController
    {
        private DatabaseConnection db = new DatabaseConnection();

        public bool Login(User user)
        {
            using (MySqlConnection connection = db.GetConnection())
            {
                connection.Open();

                string query = @"SELECT COUNT(*) FROM users
                                 WHERE Username = @Username
                                 AND Password = @Password";

                using (MySqlCommand command =
                       new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@Username", user.Username);

                    command.Parameters.AddWithValue(
                        "@Password", user.Password);

                    int result = Convert.ToInt32(
                        command.ExecuteScalar());

                    return result > 0;
                }
            }
        }

        public bool Register(User user)
        {
            using (MySqlConnection connection = db.GetConnection())
            {
                connection.Open();

                string checkQuery =
                    "SELECT COUNT(*) FROM users WHERE Username = @Username";

                using (MySqlCommand checkCommand =
                       new MySqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue(
                        "@Username", user.Username);

                    int existingUser = Convert.ToInt32(
                        checkCommand.ExecuteScalar());

                    if (existingUser > 0)
                    {
                        return false;
                    }
                }

                string insertQuery =
                    @"INSERT INTO users (Username, Password, Role)
                      VALUES (@Username, @Password, @Role)";

                using (MySqlCommand command =
                       new MySqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue(
                        "@Username", user.Username);

                    command.Parameters.AddWithValue(
                        "@Password", user.Password);

                    command.Parameters.AddWithValue(
                        "@Role", "Admin");

                    command.ExecuteNonQuery();

                    return true;
                }
            }
        }
    }
}
