
#nullable enable

using System;
using System.Windows.Forms;
using EmployeeManagementSystem.Controllers;
using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.Views;

namespace EmployeeManagementSystem
{
    public partial class EmployeeForm : Form
    {
        private int selectedEmployeeId = 0;

        private EmployeeController controller = new EmployeeController();

        public EmployeeForm()
        {
            InitializeComponent();

            dgvEmployees!.CellClick += dgvEmployees_CellClick;
            btnUpdateEmployee!.Click += btnUpdateEmployee_Click;
            btnDeleteEmployee!.Click += btnDeleteEmployee_Click;
            btnBack!.Click += btnBack_Click;

            LoadEmployees();
        }

        private void LoadEmployees()
        {
            try
            {
                dgvEmployees.DataSource = null;
                dgvEmployees.DataSource = controller.GetAllEmployees();
                dgvEmployees.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employees: " + ex.Message);
            }
        }

        private void btnAddEmployee_Click(object? sender, EventArgs e)
        {
            if (txtFullName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter employee name.");
                return;
            }

            if (txtDepartment.Text.Trim() == "")
            {
                MessageBox.Show("Please enter department.");
                return;
            }

            if (!decimal.TryParse(txtSalary.Text, out decimal salary))
            {
                MessageBox.Show("Please enter a valid salary.");
                return;
            }

            Employee employee = new Employee
            {
                FullName = txtFullName.Text.Trim(),
                Gender = cmbGender.Text,
                Phone = txtPhone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Department = txtDepartment.Text.Trim(),
                Position = txtPosition.Text.Trim(),
                Salary = salary,
                HireDate = dtpHireDate.Value
            };

            try
            {
                string result = controller.AddEmployee(employee);

                MessageBox.Show(result);

                LoadEmployees();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding employee: " + ex.Message);
            }
        }

        private void dgvEmployees_CellClick(
            object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Employee? employee =
                    dgvEmployees.Rows[e.RowIndex].DataBoundItem as Employee;

                if (employee != null)
                {
                    selectedEmployeeId = employee.EmployeeId;

                    txtFullName.Text = employee.FullName;
                    cmbGender.Text = employee.Gender;
                    txtPhone.Text = employee.Phone;
                    txtEmail.Text = employee.Email;
                    txtDepartment.Text = employee.Department;
                    txtPosition.Text = employee.Position;
                    txtSalary.Text = employee.Salary.ToString();
                    dtpHireDate.Value = employee.HireDate;
                }
            }
        }

        private void btnUpdateEmployee_Click(
            object? sender, EventArgs e)
        {
            if (selectedEmployeeId == 0)
            {
                MessageBox.Show("Please select an employee first.");
                return;
            }

            if (txtFullName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter employee name.");
                return;
            }

            if (!decimal.TryParse(txtSalary.Text, out decimal salary))
            {
                MessageBox.Show("Please enter a valid salary.");
                return;
            }

            Employee employee = new Employee
            {
                EmployeeId = selectedEmployeeId,
                FullName = txtFullName.Text.Trim(),
                Gender = cmbGender.Text,
                Phone = txtPhone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Department = txtDepartment.Text.Trim(),
                Position = txtPosition.Text.Trim(),
                Salary = salary,
                HireDate = dtpHireDate.Value
            };

            try
            {
                string result = controller.UpdateEmployee(employee);

                MessageBox.Show(result);

                LoadEmployees();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating employee: " + ex.Message);
            }
        }

        private void btnDeleteEmployee_Click(
            object? sender, EventArgs e)
        {
            if (selectedEmployeeId == 0)
            {
                MessageBox.Show("Please select an employee first.");
                return;
            }

            DialogResult answer = MessageBox.Show(
                "Are you sure you want to delete this employee?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (answer == DialogResult.Yes)
            {
                try
                {
                    string result =
                        controller.DeleteEmployee(selectedEmployeeId);

                    MessageBox.Show(result);

                    LoadEmployees();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting employee: " + ex.Message);
                }
            }
        }

        private void btnClear_Click(object? sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtFullName.Clear();
            cmbGender.SelectedIndex = -1;
            txtPhone.Clear();
            txtEmail.Clear();
            txtDepartment.Clear();
            txtPosition.Clear();
            txtSalary.Clear();

            dtpHireDate.Value = DateTime.Today;

            selectedEmployeeId = 0;
            dgvEmployees.ClearSelection();
        }

        private void btnBack_Click(object? sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();

            dashboard.Show();

            this.Close();
        }
    }
}
