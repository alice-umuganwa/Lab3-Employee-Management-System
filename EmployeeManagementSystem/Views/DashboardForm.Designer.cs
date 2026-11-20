#nullable enable
using System.Drawing;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Views
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer? components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblDashboardTitle = new Label();
            lblTotalEmployees = new Label();
            lblTotalDepartments = new Label();
            lblTotalSalary = new Label();
            lblTotalAttendance = new Label();

            btnEmployees = new Button();
            btnDepartments = new Button();
            btnAttendance = new Button();
            btnSalary = new Button();
            btnLogout = new Button();

            SuspendLayout();

            // Dashboard Form
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(226, 232, 240);
            ClientSize = new Size(1000, 650);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Management System";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            // Dashboard Title
            lblDashboardTitle.AutoSize = false;
            lblDashboardTitle.Location = new Point(0, 0);
            lblDashboardTitle.Size = new Size(1000, 85);
            lblDashboardTitle.Text = "EMPLOYEE MANAGEMENT DASHBOARD";
            lblDashboardTitle.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblDashboardTitle.BackColor = Color.FromArgb(23, 43, 77);
            lblDashboardTitle.ForeColor = Color.FromArgb(245, 158, 11);
            lblDashboardTitle.TextAlign = ContentAlignment.MiddleCenter;

            // Total Employees Card
            lblTotalEmployees.AutoSize = false;
            lblTotalEmployees.Location = new Point(90, 115);
            lblTotalEmployees.Size = new Size(390, 75);
            lblTotalEmployees.Text = "👥  Total Employees: 0";
            lblTotalEmployees.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTotalEmployees.BackColor = Color.FromArgb(23, 43, 77);
            lblTotalEmployees.ForeColor = Color.WhiteSmoke;
            lblTotalEmployees.TextAlign = ContentAlignment.MiddleCenter;

            // Total Departments Card
            lblTotalDepartments.AutoSize = false;
            lblTotalDepartments.Location = new Point(520, 115);
            lblTotalDepartments.Size = new Size(390, 75);
            lblTotalDepartments.Text = "🏢  Total Departments: 0";
            lblTotalDepartments.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTotalDepartments.BackColor = Color.FromArgb(13, 148, 136);
            lblTotalDepartments.ForeColor = Color.WhiteSmoke;
            lblTotalDepartments.TextAlign = ContentAlignment.MiddleCenter;

            // Total Attendance Card
            lblTotalAttendance.AutoSize = false;
            lblTotalAttendance.Location = new Point(90, 210);
            lblTotalAttendance.Size = new Size(390, 75);
            lblTotalAttendance.Text = "📅  Total Attendance: 0";
            lblTotalAttendance.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTotalAttendance.BackColor = Color.FromArgb(100, 116, 139);
            lblTotalAttendance.ForeColor = Color.WhiteSmoke;
            lblTotalAttendance.TextAlign = ContentAlignment.MiddleCenter;

            // Total Salary Card
            lblTotalSalary.AutoSize = false;
            lblTotalSalary.Location = new Point(520, 210);
            lblTotalSalary.Size = new Size(390, 75);
            lblTotalSalary.Text = "💰  Total Salary: 0";
            lblTotalSalary.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTotalSalary.BackColor = Color.FromArgb(109, 91, 208);
            lblTotalSalary.ForeColor = Color.WhiteSmoke;
            lblTotalSalary.TextAlign = ContentAlignment.MiddleCenter;

            // Manage Employees Button
            btnEmployees.Location = new Point(90, 340);
            btnEmployees.Size = new Size(390, 65);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Text = "👥   Manage Employees";
            btnEmployees.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnEmployees.BackColor = Color.FromArgb(13, 148, 136);
            btnEmployees.ForeColor = Color.WhiteSmoke;
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.FlatAppearance.BorderSize = 0;
            btnEmployees.Cursor = Cursors.Hand;
            btnEmployees.UseVisualStyleBackColor = false;

            // Manage Departments Button
            btnDepartments.Location = new Point(520, 340);
            btnDepartments.Size = new Size(390, 65);
            btnDepartments.Name = "btnDepartments";
            btnDepartments.Text = "🏢   Manage Departments";
            btnDepartments.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnDepartments.BackColor = Color.FromArgb(13, 148, 136);
            btnDepartments.ForeColor = Color.WhiteSmoke;
            btnDepartments.FlatStyle = FlatStyle.Flat;
            btnDepartments.FlatAppearance.BorderSize = 0;
            btnDepartments.Cursor = Cursors.Hand;
            btnDepartments.UseVisualStyleBackColor = false;

            // Manage Attendance Button
            btnAttendance.Location = new Point(90, 430);
            btnAttendance.Size = new Size(390, 65);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Text = "📅   Manage Attendance";
            btnAttendance.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAttendance.BackColor = Color.FromArgb(13, 148, 136);
            btnAttendance.ForeColor = Color.WhiteSmoke;
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnAttendance.Cursor = Cursors.Hand;
            btnAttendance.UseVisualStyleBackColor = false;

            // Manage Salaries Button
            btnSalary.Location = new Point(520, 430);
            btnSalary.Size = new Size(390, 65);
            btnSalary.Name = "btnSalary";
            btnSalary.Text = "💰   Manage Salaries";
            btnSalary.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnSalary.BackColor = Color.FromArgb(13, 148, 136);
            btnSalary.ForeColor = Color.WhiteSmoke;
            btnSalary.FlatStyle = FlatStyle.Flat;
            btnSalary.FlatAppearance.BorderSize = 0;
            btnSalary.Cursor = Cursors.Hand;
            btnSalary.UseVisualStyleBackColor = false;

            // Logout Button
            btnLogout.Location = new Point(350, 540);
            btnLogout.Size = new Size(300, 55);
            btnLogout.Name = "btnLogout";
            btnLogout.Text = "↩   Logout";
            btnLogout.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnLogout.BackColor = Color.FromArgb(71, 85, 105);
            btnLogout.ForeColor = Color.WhiteSmoke;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.UseVisualStyleBackColor = false;

            // Add Controls
            Controls.Add(lblDashboardTitle);
            Controls.Add(lblTotalEmployees);
            Controls.Add(lblTotalDepartments);
            Controls.Add(lblTotalAttendance);
            Controls.Add(lblTotalSalary);

            Controls.Add(btnEmployees);
            Controls.Add(btnDepartments);
            Controls.Add(btnAttendance);
            Controls.Add(btnSalary);
            Controls.Add(btnLogout);

            ResumeLayout(false);
        }

        private Label lblDashboardTitle = null!;
        private Label lblTotalEmployees = null!;
        private Label lblTotalDepartments = null!;
        private Label lblTotalSalary = null!;
        private Label lblTotalAttendance = null!;

        private Button btnEmployees = null!;
        private Button btnDepartments = null!;
        private Button btnAttendance = null!;
        private Button btnSalary = null!;
        private Button btnLogout = null!;
    }
}
