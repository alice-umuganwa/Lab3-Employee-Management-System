using System;

namespace EmployeeManagementSystem.Models
{
    public class Salary
    {
        public int SalaryId { get; set; }

        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; } = "";

        public decimal BasicSalary { get; set; }

        public decimal Allowances { get; set; }

        public decimal Deductions { get; set; }

        public decimal NetSalary { get; set; }

        public DateTime PaymentDate { get; set; }
    }
}