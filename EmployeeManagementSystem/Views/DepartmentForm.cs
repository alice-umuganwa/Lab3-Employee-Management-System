
using System;
using System.Windows.Forms;
using EmployeeManagementSystem.Controllers;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Views
{
    public partial class DepartmentForm : Form
    {
        private DepartmentController controller = new DepartmentController();

        private int selectedDepartmentId = 0;

        public DepartmentForm()
        {
            InitializeComponent();

            LoadDepartments();

            // Connect button events
            btnAddDepartment.Click += btnAddDepartment_Click;
            btnUpdateDepartment.Click += btnUpdateDepartment_Click;
            btnDeleteDepartment.Click += btnDeleteDepartment_Click;
            btnClearDepartment.Click += btnClearDepartment_Click;
            btnBack.Click += btnBack_Click;

            // Connect DataGridView event
            dgvDepartments.CellClick += dgvDepartments_CellClick;
        }

        private void LoadDepartments()
        {
            try
            {
                dgvDepartments.DataSource = null;
                dgvDepartments.DataSource = controller.GetAllDepartments();
                dgvDepartments.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading departments: " + ex.Message);
            }
        }

        private void btnAddDepartment_Click(object? sender, EventArgs e)
        {
            if (txtDepartmentName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter department name.");
                return;
            }

            Department department = new Department();
            department.DepartmentName = txtDepartmentName.Text.Trim();
            department.Description = txtDescription.Text.Trim();

            string result = controller.AddDepartment(department);

            MessageBox.Show(result);

            LoadDepartments();
            ClearFields();
        }

        private void btnUpdateDepartment_Click(object? sender, EventArgs e)
        {
            if (selectedDepartmentId == 0)
            {
                MessageBox.Show("Please select a department first.");
                return;
            }

            if (txtDepartmentName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter department name.");
                return;
            }

            Department department = new Department();
            department.DepartmentId = selectedDepartmentId;
            department.DepartmentName = txtDepartmentName.Text.Trim();
            department.Description = txtDescription.Text.Trim();

            string result = controller.UpdateDepartment(department);

            MessageBox.Show(result);

            LoadDepartments();
            ClearFields();
        }

        private void btnDeleteDepartment_Click(object? sender, EventArgs e)
        {
            if (selectedDepartmentId == 0)
            {
                MessageBox.Show("Please select a department first.");
                return;
            }

            DialogResult answer = MessageBox.Show(
                "Are you sure you want to delete this department?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (answer == DialogResult.Yes)
            {
                string result = controller.DeleteDepartment(selectedDepartmentId);

                MessageBox.Show(result);

                LoadDepartments();
                ClearFields();
            }
        }

        private void dgvDepartments_CellClick(
            object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedDepartmentId = Convert.ToInt32(
                    dgvDepartments.Rows[e.RowIndex]
                    .Cells["DepartmentId"].Value);

                txtDepartmentName.Text =
                    Convert.ToString(
                        dgvDepartments.Rows[e.RowIndex]
                        .Cells["DepartmentName"].Value) ?? "";

                txtDescription.Text =
                    Convert.ToString(
                        dgvDepartments.Rows[e.RowIndex]
                        .Cells["Description"].Value) ?? "";
            }
        }

        private void btnClearDepartment_Click(object? sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtDepartmentName.Clear();
            txtDescription.Clear();

            selectedDepartmentId = 0;

            dgvDepartments.ClearSelection();
        }

        private void btnBack_Click(object? sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Hide();
        }
    }
}
