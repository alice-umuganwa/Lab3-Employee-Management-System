
#nullable enable

using System;
using System.Data;
using System.Windows.Forms;
using EmployeeManagementSystem.Controllers;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Views
{
    public partial class AttendanceForm : Form
    {
        private AttendanceController controller = new AttendanceController();
        private int selectedAttendanceId = 0;

        public AttendanceForm()
        {
            InitializeComponent();

            // Back button settings
            btnBack.Visible = true;
            btnBack.BringToFront();
            btnBack.Text = "⬅ Back to Dashboard";
            btnBack.BackColor = System.Drawing.Color.FromArgb(71, 85, 105);
            btnBack.ForeColor = System.Drawing.Color.WhiteSmoke;
            btnBack.Location = new System.Drawing.Point(500, 650);
            btnBack.Size = new System.Drawing.Size(250, 45);

            // Button events
            btnAddAttendance.Click += btnAddAttendance_Click;
            btnUpdateAttendance.Click += btnUpdateAttendance_Click;
            btnDeleteAttendance.Click += btnDeleteAttendance_Click;
            btnClearAttendance.Click += btnClearAttendance_Click;
            btnBack.Click += btnBack_Click;

            dgvAttendance.CellClick += dgvAttendance_CellClick;

            // Attendance status options
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Present");
            cmbStatus.Items.Add("Absent");
            cmbStatus.Items.Add("Late");

            cmbStatus.SelectedIndex = -1;

            LoadEmployees();
            LoadAttendance();
        }

        private void lblDate_Click(object? sender, EventArgs e)
        {
        }

        private void LoadEmployees()
        {
            try
            {
                DataTable employees = controller.GetEmployees();

                cmbEmployee.DataSource = employees;
                cmbEmployee.DisplayMember = "FullName";
                cmbEmployee.ValueMember = "EmployeeId";
                cmbEmployee.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employees: " + ex.Message);
            }
        }

        private void LoadAttendance()
        {
            try
            {
                dgvAttendance.DataSource = controller.GetAllAttendance();

                dgvAttendance.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dgvAttendance.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dgvAttendance.MultiSelect = false;
                dgvAttendance.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading attendance: " + ex.Message);
            }
        }

        private void btnAddAttendance_Click(object? sender, EventArgs e)
        {
            if (cmbEmployee.SelectedValue == null ||
                cmbStatus.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please select an employee and attendance status.");
                return;
            }

            try
            {
                Attendance attendance = new Attendance
                {
                    EmployeeId = Convert.ToInt32(cmbEmployee.SelectedValue),
                    AttendanceDate = dtpAttendanceDate.Value.Date,
                    Status = Convert.ToString(cmbStatus.SelectedItem) ?? "",
                    Remarks = txtRemarks.Text.Trim()
                };

                controller.AddAttendance(attendance);

                MessageBox.Show("Attendance added successfully!");

                LoadAttendance();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding attendance: " + ex.Message);
            }
        }

        private void dgvAttendance_CellClick(
            object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvAttendance.Rows[e.RowIndex];

            selectedAttendanceId =
                Convert.ToInt32(row.Cells["AttendanceId"].Value);

            cmbEmployee.SelectedValue =
                Convert.ToInt32(row.Cells["EmployeeId"].Value);

            dtpAttendanceDate.Value =
                Convert.ToDateTime(row.Cells["AttendanceDate"].Value);

            cmbStatus.SelectedItem =
                Convert.ToString(row.Cells["Status"].Value);

            txtRemarks.Text =
                Convert.ToString(row.Cells["Remarks"].Value) ?? "";
        }

        private void btnUpdateAttendance_Click(
            object? sender, EventArgs e)
        {
            if (selectedAttendanceId == 0)
            {
                MessageBox.Show(
                    "Please select an attendance record first.");
                return;
            }

            if (cmbEmployee.SelectedValue == null ||
                cmbStatus.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please select an employee and attendance status.");
                return;
            }

            try
            {
                Attendance attendance = new Attendance
                {
                    AttendanceId = selectedAttendanceId,
                    EmployeeId = Convert.ToInt32(cmbEmployee.SelectedValue),
                    AttendanceDate = dtpAttendanceDate.Value.Date,
                    Status = Convert.ToString(cmbStatus.SelectedItem) ?? "",
                    Remarks = txtRemarks.Text.Trim()
                };

                controller.UpdateAttendance(attendance);

                MessageBox.Show("Attendance updated successfully!");

                LoadAttendance();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating attendance: " + ex.Message);
            }
        }

        private void btnDeleteAttendance_Click(
            object? sender, EventArgs e)
        {
            if (selectedAttendanceId == 0)
            {
                MessageBox.Show(
                    "Please select an attendance record first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this attendance record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    controller.DeleteAttendance(selectedAttendanceId);

                    MessageBox.Show("Attendance deleted successfully!");

                    LoadAttendance();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error deleting attendance: " + ex.Message);
                }
            }
        }

        private void btnClearAttendance_Click(
            object? sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            selectedAttendanceId = 0;

            cmbEmployee.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            dtpAttendanceDate.Value = DateTime.Today;
            txtRemarks.Clear();

            dgvAttendance.ClearSelection();
        }

        private void btnBack_Click(object? sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();

            dashboard.Show();

            this.Close();
        }
    }
}
