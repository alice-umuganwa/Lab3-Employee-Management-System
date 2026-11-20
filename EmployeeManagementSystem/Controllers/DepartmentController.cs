
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using EmployeeManagementSystem.Database;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Controllers
{
    public class DepartmentController
    {
        private DatabaseConnection db = new DatabaseConnection();

        // Add department
        public string AddDepartment(Department department)
        {
            try
            {
                using (MySqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    string query = @"INSERT INTO departments
                        (DepartmentName, Description)
                        VALUES (@DepartmentName, @Description)";

                    using (MySqlCommand command =
                           new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@DepartmentName", department.DepartmentName);

                        command.Parameters.AddWithValue(
                            "@Description", department.Description);

                        command.ExecuteNonQuery();
                    }
                }

                return "Department added successfully!";
            }
            catch (Exception ex)
            {
                return "Error adding department: " + ex.Message;
            }
        }

        // View all departments
        public List<Department> GetAllDepartments()
        {
            List<Department> departments = new List<Department>();

            using (MySqlConnection connection = db.GetConnection())
            {
                connection.Open();

                string query = "SELECT * FROM departments";

                using (MySqlCommand command =
                       new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader =
                           command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Department department = new Department();

                            department.DepartmentId =
                                Convert.ToInt32(reader["DepartmentId"]);

                            department.DepartmentName =
                                Convert.ToString(reader["DepartmentName"]) ?? "";

                            department.Description =
                                Convert.ToString(reader["Description"]) ?? "";

                            departments.Add(department);
                        }
                    }
                }
            }

            return departments;
        }

        // Update department
        public string UpdateDepartment(Department department)
        {
            try
            {
                using (MySqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    string query = @"UPDATE departments SET
                        DepartmentName = @DepartmentName,
                        Description = @Description
                        WHERE DepartmentId = @DepartmentId";

                    using (MySqlCommand command =
                           new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@DepartmentId", department.DepartmentId);

                        command.Parameters.AddWithValue(
                            "@DepartmentName", department.DepartmentName);

                        command.Parameters.AddWithValue(
                            "@Description", department.Description);

                        int rows = command.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            return "Department updated successfully!";
                        }

                        return "No department was updated.";
                    }
                }
            }
            catch (Exception ex)
            {
                return "Error updating department: " + ex.Message;
            }
        }

        // Delete department
        public string DeleteDepartment(int departmentId)
        {
            try
            {
                using (MySqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    string query = @"DELETE FROM departments
                        WHERE DepartmentId = @DepartmentId";

                    using (MySqlCommand command =
                           new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@DepartmentId", departmentId);

                        int rows = command.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            return "Department deleted successfully!";
                        }

                        return "No department found with this ID.";
                    }
                }
            }
            catch (Exception ex)
            {
                return "Error deleting department: " + ex.Message;
            }
        }
    }
}
