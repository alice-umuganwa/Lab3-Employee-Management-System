
using System;
using System.Data;
using MySql.Data.MySqlClient;
using EmployeeManagementSystem.Database;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Controllers
{
    public class AttendanceController
    {
        private DatabaseConnection db = new DatabaseConnection();

        // Add attendance
        public void AddAttendance(Attendance attendance)
        {
            using (MySqlConnection connection = db.GetConnection())
            {
                connection.Open();

                string query = @"INSERT INTO attendance
                    (EmployeeId, AttendanceDate, Status, Remarks)
                    VALUES (@EmployeeId, @AttendanceDate, @Status, @Remarks)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeId", attendance.EmployeeId);
                    command.Parameters.AddWithValue("@AttendanceDate", attendance.AttendanceDate);
                    command.Parameters.AddWithValue("@Status", attendance.Status);
                    command.Parameters.AddWithValue("@Remarks", attendance.Remarks);

                    command.ExecuteNonQuery();
                }
            }
        }

        // View all attendance records
        public DataTable GetAllAttendance()
        {
            DataTable table = new DataTable();

            using (MySqlConnection connection = db.GetConnection())
            {
                connection.Open();

                string query = @"SELECT a.AttendanceId, a.EmployeeId,
                    e.FullName, a.AttendanceDate, a.Status, a.Remarks
                    FROM attendance a
                    INNER JOIN employees e ON a.EmployeeId = e.EmployeeId
                    ORDER BY a.AttendanceDate DESC";

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

        // Update attendance
        public void UpdateAttendance(Attendance attendance)
        {
            using (MySqlConnection connection = db.GetConnection())
            {
                connection.Open();

                string query = @"UPDATE attendance SET
                    EmployeeId = @EmployeeId,
                    AttendanceDate = @AttendanceDate,
                    Status = @Status,
                    Remarks = @Remarks
                    WHERE AttendanceId = @AttendanceId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeId", attendance.EmployeeId);
                    command.Parameters.AddWithValue("@AttendanceDate", attendance.AttendanceDate);
                    command.Parameters.AddWithValue("@Status", attendance.Status);
                    command.Parameters.AddWithValue("@Remarks", attendance.Remarks);
                    command.Parameters.AddWithValue("@AttendanceId", attendance.AttendanceId);

                    command.ExecuteNonQuery();
                }
            }
        }

        // Delete attendance
        public void DeleteAttendance(int attendanceId)
        {
            using (MySqlConnection connection = db.GetConnection())
            {
                connection.Open();

                string query = "DELETE FROM attendance WHERE AttendanceId = @AttendanceId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AttendanceId", attendanceId);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Load employees into the attendance form
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
