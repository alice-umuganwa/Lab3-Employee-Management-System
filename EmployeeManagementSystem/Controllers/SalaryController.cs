using System.Data;
using MySql.Data.MySqlClient;
using EmployeeManagementSystem.Database;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Controllers
{
    public class SalaryController
    {
        private DatabaseConnection db = new DatabaseConnection();

        // Add Salary
        public void AddSalary(Salary salary)
        {
            using (MySqlConnection connection = db.GetConnection())
            {
                connection.Open();

                string query = @"INSERT INTO salaries
                    (EmployeeId, BasicSalary, Allowances,
                     Deductions, NetSalary, PaymentDate)
                    VALUES
                    (@EmployeeId, @BasicSalary, @Allowances,
                     @Deductions, @NetSalary, @PaymentDate)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeId", salary.EmployeeId);
                    command.Parameters.AddWithValue("@BasicSalary", salary.BasicSalary);
                    command.Parameters.AddWithValue("@Allowances", salary.Allowances);
                    command.Parameters.AddWithValue("@Deductions", salary.Deductions);
                    command.Parameters.AddWithValue("@NetSalary", salary.NetSalary);
                    command.Parameters.AddWithValue("@PaymentDate", salary.PaymentDate);

                    command.ExecuteNonQuery();
                }
            }
        }

        // View All Salaries
        public DataTable GetAllSalaries()
        {
            DataTable table = new DataTable();

            using (MySqlConnection connection = db.GetConnection())
            {
                connection.Open();

                string query = @"SELECT
                    s.SalaryId,
                    s.EmployeeId,
                    e.FullName,
                    s.BasicSalary,
                    s.Allowances,
                    s.Deductions,
                    s.NetSalary,
                    s.PaymentDate
                    FROM salaries s
                    INNER JOIN employees e
                    ON s.EmployeeId = e.EmployeeId
                    ORDER BY s.PaymentDate DESC";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
            }

            return table;
        }

        // Update Salary
        public void UpdateSalary(Salary salary)
        {
            using (MySqlConnection connection = db.GetConnection())
            {
                connection.Open();

                string query = @"UPDATE salaries SET
                    EmployeeId = @EmployeeId,
                    BasicSalary = @BasicSalary,
                    Allowances = @Allowances,
                    Deductions = @Deductions,
                    NetSalary = @NetSalary,
                    PaymentDate = @PaymentDate
                    WHERE SalaryId = @SalaryId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeId", salary.EmployeeId);
                    command.Parameters.AddWithValue("@BasicSalary", salary.BasicSalary);
                    command.Parameters.AddWithValue("@Allowances", salary.Allowances);
                    command.Parameters.AddWithValue("@Deductions", salary.Deductions);
                    command.Parameters.AddWithValue("@NetSalary", salary.NetSalary);
                    command.Parameters.AddWithValue("@PaymentDate", salary.PaymentDate);
                    command.Parameters.AddWithValue("@SalaryId", salary.SalaryId);

                    command.ExecuteNonQuery();
                }
            }
        }

        // Delete Salary
        public void DeleteSalary(int salaryId)
        {
            using (MySqlConnection connection = db.GetConnection())
            {
                connection.Open();

                string query = "DELETE FROM salaries WHERE SalaryId = @SalaryId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SalaryId", salaryId);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Get Employees for ComboBox
        public DataTable GetEmployees()
        {
            DataTable table = new DataTable();

            using (MySqlConnection connection = db.GetConnection())
            {
                connection.Open();

                string query = "SELECT EmployeeId, FullName FROM employees";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
            }

            return table;
        }
    }
}