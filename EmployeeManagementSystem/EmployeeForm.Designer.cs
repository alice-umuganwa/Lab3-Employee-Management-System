
#nullable enable

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    partial class EmployeeForm
    {
        private IContainer? components = null;

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
            btnTestConnection = new Button();
            lblFormTitle = new Label();

            label1 = new Label();
            txtFullName = new TextBox();

            label2 = new Label();
            cmbGender = new ComboBox();

            label3 = new Label();
            txtPhone = new TextBox();

            label4 = new Label();
            txtEmail = new TextBox();

            label5 = new Label();
            txtDepartment = new TextBox();

            label6 = new Label();
            txtPosition = new TextBox();

            label7 = new Label();
            txtSalary = new TextBox();

            label8 = new Label();
            dtpHireDate = new DateTimePicker();

            btnAddEmployee = new Button();
            btnClear = new Button();
            dgvEmployees = new DataGridView();
            btnUpdateEmployee = new Button();
            btnDeleteEmployee = new Button();
            btnBack = new Button();

            ((ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();

            // Employee Form
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(226, 232, 240);
            ClientSize = new Size(1150, 800);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Text = "Employee Management";

            // Title
            lblFormTitle.AutoSize = false;
            lblFormTitle.Location = new Point(0, 0);
            lblFormTitle.Size = new Size(1150, 80);
            lblFormTitle.Text = "👥  EMPLOYEE MANAGEMENT";
            lblFormTitle.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblFormTitle.BackColor = Color.FromArgb(23, 43, 77);
            lblFormTitle.ForeColor = Color.FromArgb(245, 158, 11);
            lblFormTitle.TextAlign = ContentAlignment.MiddleCenter;

            // Full Name
            label1.AutoSize = true;
            label1.Location = new Point(75, 125);
            label1.Text = "👤  Full Name";
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(23, 43, 77);

            txtFullName.Location = new Point(240, 120);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(300, 35);
            txtFullName.Font = new Font("Segoe UI", 11F);
            txtFullName.BackColor = Color.FromArgb(241, 245, 249);
            txtFullName.BorderStyle = BorderStyle.FixedSingle;

            // Gender
            label2.AutoSize = true;
            label2.Location = new Point(75, 185);
            label2.Text = "⚧  Gender";
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(23, 43, 77);

            cmbGender.Location = new Point(240, 180);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(300, 35);
            cmbGender.Font = new Font("Segoe UI", 11F);
            cmbGender.BackColor = Color.FromArgb(241, 245, 249);
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });

            // Phone
            label3.AutoSize = true;
            label3.Location = new Point(75, 245);
            label3.Text = "☎  Phone";
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(23, 43, 77);

            txtPhone.Location = new Point(240, 240);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(300, 35);
            txtPhone.Font = new Font("Segoe UI", 11F);
            txtPhone.BackColor = Color.FromArgb(241, 245, 249);
            txtPhone.BorderStyle = BorderStyle.FixedSingle;

            // Email
            label4.AutoSize = true;
            label4.Location = new Point(75, 305);
            label4.Text = "✉  Email";
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(23, 43, 77);

            txtEmail.Location = new Point(240, 300);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 35);
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.BackColor = Color.FromArgb(241, 245, 249);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;

            // Department
            label5.AutoSize = true;
            label5.Location = new Point(620, 125);
            label5.Text = "🏢  Department";
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(23, 43, 77);

            txtDepartment.Location = new Point(790, 120);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(290, 35);
            txtDepartment.Font = new Font("Segoe UI", 11F);
            txtDepartment.BackColor = Color.FromArgb(241, 245, 249);
            txtDepartment.BorderStyle = BorderStyle.FixedSingle;

            // Position
            label6.AutoSize = true;
            label6.Location = new Point(620, 185);
            label6.Text = "💼  Position";
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(23, 43, 77);

            txtPosition.Location = new Point(790, 180);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(290, 35);
            txtPosition.Font = new Font("Segoe UI", 11F);
            txtPosition.BackColor = Color.FromArgb(241, 245, 249);
            txtPosition.BorderStyle = BorderStyle.FixedSingle;

            // Salary
            label7.AutoSize = true;
            label7.Location = new Point(620, 245);
            label7.Text = "💰  Salary";
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(23, 43, 77);

            txtSalary.Location = new Point(790, 240);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(290, 35);
            txtSalary.Font = new Font("Segoe UI", 11F);
            txtSalary.BackColor = Color.FromArgb(241, 245, 249);
            txtSalary.BorderStyle = BorderStyle.FixedSingle;

            // Hire Date
            label8.AutoSize = true;
            label8.Location = new Point(620, 305);
            label8.Text = "📅  Hire Date";
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(23, 43, 77);

            dtpHireDate.Location = new Point(790, 300);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(290, 35);
            dtpHireDate.Font = new Font("Segoe UI", 10F);
            dtpHireDate.Format = DateTimePickerFormat.Short;

            // Add Employee
            btnAddEmployee.Location = new Point(75, 370);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(220, 50);
            btnAddEmployee.Text = "➕  Add Employee";
            btnAddEmployee.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAddEmployee.BackColor = Color.FromArgb(13, 148, 136);
            btnAddEmployee.ForeColor = Color.WhiteSmoke;
            btnAddEmployee.FlatStyle = FlatStyle.Flat;
            btnAddEmployee.FlatAppearance.BorderSize = 0;
            btnAddEmployee.Cursor = Cursors.Hand;
            btnAddEmployee.UseVisualStyleBackColor = false;
            btnAddEmployee.Click += btnAddEmployee_Click;

            // Update Employee
            btnUpdateEmployee.Location = new Point(315, 370);
            btnUpdateEmployee.Name = "btnUpdateEmployee";
            btnUpdateEmployee.Size = new Size(220, 50);
            btnUpdateEmployee.Text = "✏  Update Employee";
            btnUpdateEmployee.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnUpdateEmployee.BackColor = Color.FromArgb(13, 148, 136);
            btnUpdateEmployee.ForeColor = Color.WhiteSmoke;
            btnUpdateEmployee.FlatStyle = FlatStyle.Flat;
            btnUpdateEmployee.FlatAppearance.BorderSize = 0;
            btnUpdateEmployee.Cursor = Cursors.Hand;
            btnUpdateEmployee.UseVisualStyleBackColor = false;

            // Delete Employee
            btnDeleteEmployee.Location = new Point(555, 370);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(220, 50);
            btnDeleteEmployee.Text = "🗑  Delete Employee";
            btnDeleteEmployee.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDeleteEmployee.BackColor = Color.FromArgb(71, 85, 105);
            btnDeleteEmployee.ForeColor = Color.WhiteSmoke;
            btnDeleteEmployee.FlatStyle = FlatStyle.Flat;
            btnDeleteEmployee.FlatAppearance.BorderSize = 0;
            btnDeleteEmployee.Cursor = Cursors.Hand;
            btnDeleteEmployee.UseVisualStyleBackColor = false;

            // Clear
            btnClear.Location = new Point(795, 370);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 50);
            btnClear.Text = "🧹  Clear";
            btnClear.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnClear.BackColor = Color.FromArgb(100, 116, 139);
            btnClear.ForeColor = Color.WhiteSmoke;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.Cursor = Cursors.Hand;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;

            // Back
            btnBack.Location = new Point(945, 370);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(135, 50);
            btnBack.Text = "⬅  Back";
            btnBack.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBack.BackColor = Color.FromArgb(71, 85, 105);
            btnBack.ForeColor = Color.WhiteSmoke;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.Cursor = Cursors.Hand;

            // Employee Records Heading
            Label lblRecords = new Label();
            lblRecords.AutoSize = false;
            lblRecords.Location = new Point(75, 445);
            lblRecords.Size = new Size(1000, 40);
            lblRecords.Text = "📋  EMPLOYEE RECORDS";
            lblRecords.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblRecords.ForeColor = Color.FromArgb(23, 43, 77);
            lblRecords.TextAlign = ContentAlignment.MiddleLeft;

            // Employee Data Grid
            dgvEmployees.Location = new Point(75, 490);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.Size = new Size(1000, 250);
            dgvEmployees.ReadOnly = true;
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.MultiSelect = false;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.BackgroundColor = Color.FromArgb(241, 245, 249);
            dgvEmployees.BorderStyle = BorderStyle.None;
            dgvEmployees.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEmployees.RowHeadersVisible = false;
            dgvEmployees.EnableHeadersVisualStyles = false;
            dgvEmployees.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(23, 43, 77);
            dgvEmployees.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;
            dgvEmployees.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvEmployees.DefaultCellStyle.Font =
                new Font("Segoe UI", 10F);
            dgvEmployees.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(245, 158, 11);
            dgvEmployees.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(23, 43, 77);
            dgvEmployees.RowTemplate.Height = 35;

            // Keep test connection control available but hidden.
            btnTestConnection.Visible = false;

            // Add Controls
            Controls.Add(lblFormTitle);
            Controls.Add(label1);
            Controls.Add(txtFullName);
            Controls.Add(label2);
            Controls.Add(cmbGender);
            Controls.Add(label3);
            Controls.Add(txtPhone);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(txtDepartment);
            Controls.Add(label6);
            Controls.Add(txtPosition);
            Controls.Add(label7);
            Controls.Add(txtSalary);
            Controls.Add(label8);
            Controls.Add(dtpHireDate);

            Controls.Add(btnAddEmployee);
            Controls.Add(btnUpdateEmployee);
            Controls.Add(btnDeleteEmployee);
            Controls.Add(btnClear);
            Controls.Add(btnBack);

            Controls.Add(lblRecords);
            Controls.Add(dgvEmployees);

            ((ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnTestConnection = null!;
        private Label lblFormTitle = null!;
        private Label label1 = null!;
        private TextBox txtFullName = null!;
        private Label label2 = null!;
        private ComboBox cmbGender = null!;
        private Label label3 = null!;
        private TextBox txtPhone = null!;
        private Label label4 = null!;
        private TextBox txtEmail = null!;
        private Label label5 = null!;
        private TextBox txtDepartment = null!;
        private Label label6 = null!;
        private TextBox txtPosition = null!;
        private Label label7 = null!;
        private TextBox txtSalary = null!;
        private Label label8 = null!;
        private DateTimePicker dtpHireDate = null!;
        private Button btnAddEmployee = null!;
        private Button btnClear = null!;
        private DataGridView dgvEmployees = null!;
        private Button btnUpdateEmployee = null!;
        private Button btnDeleteEmployee = null!;
        private Button btnBack = null!;
    }
}
