
using System;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Views
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();

            btnEmployees.Click += btnEmployees_Click;
            btnDepartments.Click += btnDepartments_Click;
            btnAttendance.Click += btnAttendance_Click;
            btnSalary.Click += btnSalary_Click;
            btnLogout.Click += btnLogout_Click;
        }

        // Open Employee Management
        private void btnEmployees_Click(object? sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.Show();
            this.Hide();
        }

        // Open Department Management
        private void btnDepartments_Click(object? sender, EventArgs e)
        {
            DepartmentForm departmentForm = new DepartmentForm();
            departmentForm.Show();
            this.Hide();
        }

        // Open Attendance Management
        private void btnAttendance_Click(object? sender, EventArgs e)
        {
            AttendanceForm attendanceForm = new AttendanceForm();
            attendanceForm.Show();
            this.Hide();
        }

        // Open Salary Management
        private void btnSalary_Click(object? sender, EventArgs e)
        {
            SalaryForm salaryForm = new SalaryForm();
            salaryForm.Show();
            this.Hide();
        }

        // Logout
        private void btnLogout_Click(object? sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}
