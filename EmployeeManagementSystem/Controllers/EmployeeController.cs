
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using EmployeeManagementSystem.Database;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Controllers
{
    public class EmployeeController
    {
        private DatabaseConnection db = new DatabaseConnection();

        // Test database connection
        public string TestDatabaseConnection()
        {
            try
            {
                using (MySqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    return "Database connected successfully!";
                }
            }
            catch (Exception ex)
            {
                return "Database connection failed: " + ex.Message;
            }
        }

        // Add employee
        public string AddEmployee(Employee employee)
        {
            try
            {
                using (MySqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    string query = @"INSERT INTO employees
                    (FullName, Gender, Phone, Email, Department,
                    Position, Salary, HireDate)
                    VALUES
                    (@FullName, @Gender, @Phone, @Email, @Department,
                    @Position, @Salary, @HireDate)";

                    using (MySqlCommand command =
                           new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FullName", employee.FullName);
                        command.Parameters.AddWithValue("@Gender", employee.Gender);
                        command.Parameters.AddWithValue("@Phone", employee.Phone);
                        command.Parameters.AddWithValue("@Email", employee.Email);
                        command.Parameters.AddWithValue("@Department", employee.Department);
                        command.Parameters.AddWithValue("@Position", employee.Position);
                        command.Parameters.AddWithValue("@Salary", employee.Salary);
                        command.Parameters.AddWithValue("@HireDate", employee.HireDate);

                        command.ExecuteNonQuery();
                    }
                }

                return "Employee added successfully!";
            }
            catch (Exception ex)
            {
                return "Error adding employee: " + ex.Message;
            }
        }

        // View all employees
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            using (MySqlConnection connection = db.GetConnection())
            {
                connection.Open();

                string query = "SELECT * FROM employees";

                using (MySqlCommand command =
                       new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader =
                           command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee employee = new Employee();

                            employee.EmployeeId =
                                Convert.ToInt32(reader["EmployeeId"]);

                            employee.FullName =
                                Convert.ToString(reader["FullName"]) ?? "";

                            employee.Gender =
                                Convert.ToString(reader["Gender"]) ?? "";

                            employee.Phone =
                                Convert.ToString(reader["Phone"]) ?? "";

                            employee.Email =
                                Convert.ToString(reader["Email"]) ?? "";

                            employee.Department =
                                Convert.ToString(reader["Department"]) ?? "";

                            employee.Position =
                                Convert.ToString(reader["Position"]) ?? "";

                            employee.Salary =
                                Convert.ToDecimal(reader["Salary"]);

                            employee.HireDate =
                                Convert.ToDateTime(reader["HireDate"]);

                            employees.Add(employee);
                        }
                    }
                }
            }

            return employees;
        }

        // Update employee
        public string UpdateEmployee(Employee employee)
        {
            try
            {
                using (MySqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    string query = @"UPDATE employees SET
                        FullName = @FullName,
                        Gender = @Gender,
                        Phone = @Phone,
                        Email = @Email,
                        Department = @Department,
                        Position = @Position,
                        Salary = @Salary,
                        HireDate = @HireDate
                        WHERE EmployeeId = @EmployeeId";

                    using (MySqlCommand command =
                           new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@EmployeeId", employee.EmployeeId);

                        command.Parameters.AddWithValue(
                            "@FullName", employee.FullName);

                        command.Parameters.AddWithValue(
                            "@Gender", employee.Gender);

                        command.Parameters.AddWithValue(
                            "@Phone", employee.Phone);

                        command.Parameters.AddWithValue(
                            "@Email", employee.Email);

                        command.Parameters.AddWithValue(
                            "@Department", employee.Department);

                        command.Parameters.AddWithValue(
                            "@Position", employee.Position);

                        command.Parameters.AddWithValue(
                            "@Salary", employee.Salary);

                        command.Parameters.AddWithValue(
                            "@HireDate", employee.HireDate);

                        int rows = command.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            return "Employee updated successfully!";
                        }

                        return "No employee was updated. Check the Employee ID.";
                    }
                }
            }
            catch (Exception ex)
            {
                return "Error updating employee: " + ex.Message;
            }
        }

        // Delete employee
        public string DeleteEmployee(int employeeId)
        {
            try
            {
                using (MySqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    string query = @"DELETE FROM employees
                                     WHERE EmployeeId = @EmployeeId";

                    using (MySqlCommand command =
                           new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@EmployeeId", employeeId);

                        int rows = command.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            return "Employee deleted successfully!";
                        }

                        return "No employee found with this ID.";
                    }
                }
            }
            catch (Exception ex)
            {
                return "Error deleting employee: " + ex.Message;
            }
        }
    }
}
