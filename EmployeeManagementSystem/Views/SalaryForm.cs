
#nullable enable

using System;
using System.Drawing;
using System.Windows.Forms;
using EmployeeManagementSystem.Controllers;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Views
{
    public partial class SalaryForm : Form
    {
        private SalaryController controller = new SalaryController();

        private int selectedSalaryId = 0;

        public SalaryForm()
        {
            InitializeComponent();

            // Increase form height to provide space for buttons
            this.ClientSize = new Size(1150, 790);

            // Configure buttons
            ConfigureButtons();

            // Button events
            btnCalculate.Click += btnCalculate_Click;
            btnAddSalary.Click += btnAddSalary_Click;
            btnUpdateSalary.Click += btnUpdateSalary_Click;
            btnDeleteSalary.Click += btnDeleteSalary_Click;
            btnClearSalary.Click += btnClearSalary_Click;
            btnBack.Click += btnBack_Click;

            // Table event
            dgvSalaries.CellClick += dgvSalaries_CellClick;

            LoadEmployees();
            LoadSalaries();
        }

        // Configure all buttons
        private void ConfigureButtons()
        {
            // Add buttons to the main form
            Controls.Add(btnCalculate);
            Controls.Add(btnAddSalary);
            Controls.Add(btnUpdateSalary);
            Controls.Add(btnDeleteSalary);
            Controls.Add(btnClearSalary);
            Controls.Add(btnBack);

            // First row
            SetButton(
                btnCalculate,
                "🧮 Calculate",
                new Point(500, 615),
                Color.FromArgb(13, 148, 136));

            SetButton(
                btnAddSalary,
                "➕ Add Salary",
                new Point(810, 615),
                Color.FromArgb(13, 148, 136));

            // Second row
            SetButton(
                btnUpdateSalary,
                "✏️ Update Salary",
                new Point(500, 665),
                Color.FromArgb(13, 148, 136));

            SetButton(
                btnDeleteSalary,
                "🗑️ Delete Salary",
                new Point(810, 665),
                Color.FromArgb(71, 85, 105));

            // Third row
            SetButton(
                btnClearSalary,
                "🧹 Clear",
                new Point(500, 715),
                Color.FromArgb(100, 116, 139));

            SetButton(
                btnBack,
                "⬅ Back",
                new Point(810, 715),
                Color.FromArgb(71, 85, 105));

            // Bring buttons to the front
            btnCalculate.BringToFront();
            btnAddSalary.BringToFront();
            btnUpdateSalary.BringToFront();
            btnDeleteSalary.BringToFront();
            btnClearSalary.BringToFront();
            btnBack.BringToFront();
        }

        // Set button appearance
        private void SetButton(
            Button button,
            string buttonText,
            Point location,
            Color backgroundColor)
        {
            button.Visible = true;
            button.Enabled = true;

            button.Location = location;
            button.Size = new Size(260, 40);

            button.BackColor = backgroundColor;
            button.ForeColor = Color.WhiteSmoke;

            button.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Bold);

            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;

            button.UseVisualStyleBackColor = false;
            button.Text = buttonText;
            button.Cursor = Cursors.Hand;
        }

        // Load employees into ComboBox
        private void LoadEmployees()
        {
            cmbEmployee.DataSource = controller.GetEmployees();
            cmbEmployee.DisplayMember = "FullName";
            cmbEmployee.ValueMember = "EmployeeId";
            cmbEmployee.SelectedIndex = -1;
        }

        // Load salary records
        private void LoadSalaries()
        {
            dgvSalaries.DataSource = controller.GetAllSalaries();
        }

        // Calculate Net Salary
        private void btnCalculate_Click(object? sender, EventArgs e)
        {
            if (!decimal.TryParse(txtBasicSalary.Text, out decimal basic) ||
                !decimal.TryParse(txtAllowances.Text, out decimal allowances) ||
                !decimal.TryParse(txtDeductions.Text, out decimal deductions))
            {
                MessageBox.Show("Please enter valid salary amounts.");
                return;
            }

            if (basic < 0 || allowances < 0 || deductions < 0)
            {
                MessageBox.Show("Salary amounts cannot be negative.");
                return;
            }

            decimal net = basic + allowances - deductions;

            if (net < 0)
            {
                MessageBox.Show(
                    "Deductions cannot be greater than basic salary plus allowances.");
                return;
            }

            txtNetSalary.Text = net.ToString("0.00");
        }

        // Add Salary
        private void btnAddSalary_Click(object? sender, EventArgs e)
        {
            if (cmbEmployee.SelectedValue == null)
            {
                MessageBox.Show("Please select an employee.");
                return;
            }

            if (!decimal.TryParse(txtBasicSalary.Text, out decimal basic) ||
                !decimal.TryParse(txtAllowances.Text, out decimal allowances) ||
                !decimal.TryParse(txtDeductions.Text, out decimal deductions))
            {
                MessageBox.Show("Please enter valid salary amounts.");
                return;
            }

            if (basic < 0 || allowances < 0 || deductions < 0)
            {
                MessageBox.Show("Salary amounts cannot be negative.");
                return;
            }

            decimal net = basic + allowances - deductions;

            if (net < 0)
            {
                MessageBox.Show(
                    "Deductions cannot be greater than basic salary plus allowances.");
                return;
            }

            Salary salary = new Salary
            {
                EmployeeId = Convert.ToInt32(cmbEmployee.SelectedValue),
                BasicSalary = basic,
                Allowances = allowances,
                Deductions = deductions,
                NetSalary = net,
                PaymentDate = dtpPaymentDate.Value
            };

            try
            {
                controller.AddSalary(salary);

                MessageBox.Show("Salary added successfully!");

                LoadSalaries();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding salary: " + ex.Message);
            }
        }

        // Select salary record from table
        private void dgvSalaries_CellClick(
            object? sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvSalaries.Rows[e.RowIndex];

            if (row.Cells["SalaryId"].Value == null ||
                row.Cells["EmployeeId"].Value == null ||
                row.Cells["PaymentDate"].Value == null)
            {
                MessageBox.Show(
                    "The selected salary record contains missing information.");
                return;
            }

            selectedSalaryId =
                Convert.ToInt32(row.Cells["SalaryId"].Value);

            cmbEmployee.SelectedValue =
                Convert.ToInt32(row.Cells["EmployeeId"].Value);

            txtBasicSalary.Text =
                Convert.ToString(row.Cells["BasicSalary"].Value) ?? "";

            txtAllowances.Text =
                Convert.ToString(row.Cells["Allowances"].Value) ?? "";

            txtDeductions.Text =
                Convert.ToString(row.Cells["Deductions"].Value) ?? "";

            txtNetSalary.Text =
                Convert.ToString(row.Cells["NetSalary"].Value) ?? "";

            dtpPaymentDate.Value =
                Convert.ToDateTime(row.Cells["PaymentDate"].Value);
        }

        // Update Salary
        private void btnUpdateSalary_Click(object? sender, EventArgs e)
        {
            if (selectedSalaryId == 0)
            {
                MessageBox.Show(
                    "Please select a salary record to update.");
                return;
            }

            if (cmbEmployee.SelectedValue == null)
            {
                MessageBox.Show("Please select an employee.");
                return;
            }

            if (!decimal.TryParse(txtBasicSalary.Text, out decimal basic) ||
                !decimal.TryParse(txtAllowances.Text, out decimal allowances) ||
                !decimal.TryParse(txtDeductions.Text, out decimal deductions))
            {
                MessageBox.Show("Please enter valid salary amounts.");
                return;
            }

            if (basic < 0 || allowances < 0 || deductions < 0)
            {
                MessageBox.Show("Salary amounts cannot be negative.");
                return;
            }

            decimal net = basic + allowances - deductions;

            if (net < 0)
            {
                MessageBox.Show(
                    "Deductions cannot be greater than basic salary plus allowances.");
                return;
            }

            Salary salary = new Salary
            {
                SalaryId = selectedSalaryId,
                EmployeeId = Convert.ToInt32(cmbEmployee.SelectedValue),
                BasicSalary = basic,
                Allowances = allowances,
                Deductions = deductions,
                NetSalary = net,
                PaymentDate = dtpPaymentDate.Value
            };

            try
            {
                controller.UpdateSalary(salary);

                MessageBox.Show("Salary updated successfully!");

                LoadSalaries();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating salary: " + ex.Message);
            }
        }

        // Delete Salary
        private void btnDeleteSalary_Click(object? sender, EventArgs e)
        {
            if (selectedSalaryId == 0)
            {
                MessageBox.Show(
                    "Please select a salary record to delete.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this salary record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    controller.DeleteSalary(selectedSalaryId);

                    MessageBox.Show("Salary deleted successfully!");

                    LoadSalaries();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting salary: " + ex.Message);
                }
            }
        }

        // Clear fields
        private void btnClearSalary_Click(object? sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            selectedSalaryId = 0;

            cmbEmployee.SelectedIndex = -1;

            txtBasicSalary.Clear();
            txtAllowances.Text = "0";
            txtDeductions.Text = "0";
            txtNetSalary.Clear();

            dtpPaymentDate.Value = DateTime.Today;
        }

        // Return to Dashboard
        private void btnBack_Click(object? sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Close();
        }
    }
}
