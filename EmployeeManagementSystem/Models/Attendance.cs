using System;
namespace EmployeeManagementSystem.Models
{
    public class Attendance
    {
        public int AttendanceId { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; } = "";
        public DateTime AttendanceDate { get; set; }
        public string Status { get; set; } = "";
        public string Remarks { get; set; } = "";
    }
}
