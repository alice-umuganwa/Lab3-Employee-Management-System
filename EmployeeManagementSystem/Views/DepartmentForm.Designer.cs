
#nullable enable

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Views
{
    partial class DepartmentForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblDepartmentTitle = new Label();
            lblDepartmentName = new Label();
            txtDepartmentName = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            btnAddDepartment = new Button();
            btnUpdateDepartment = new Button();
            btnDeleteDepartment = new Button();
            btnClearDepartment = new Button();
            dgvDepartments = new DataGridView();
            btnBack = new Button();

            pnlHeader = new Panel();
            pnlForm = new Panel();
            lblRecordsTitle = new Label();

            ((ISupportInitialize)dgvDepartments).BeginInit();
            SuspendLayout();

            // DepartmentForm
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(226, 232, 240);
            ClientSize = new Size(1150, 760);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Name = "DepartmentForm";
            Text = "Department Management";

            // pnlHeader
            pnlHeader.BackColor = Color.FromArgb(23, 43, 77);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Size = new Size(1150, 105);

            // lblDepartmentTitle
            lblDepartmentTitle.AutoSize = false;
            lblDepartmentTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblDepartmentTitle.ForeColor = Color.WhiteSmoke;
            lblDepartmentTitle.Location = new Point(35, 25);
            lblDepartmentTitle.Size = new Size(600, 50);
            lblDepartmentTitle.Text = "🏢 Department Management";
            lblDepartmentTitle.TextAlign = ContentAlignment.MiddleLeft;

            pnlHeader.Controls.Add(lblDepartmentTitle);

            // pnlForm
            pnlForm.BackColor = Color.FromArgb(203, 213, 225);
            pnlForm.Location = new Point(35, 140);
            pnlForm.Size = new Size(430, 480);

            // Department Name Label
            lblDepartmentName.AutoSize = true;
            lblDepartmentName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDepartmentName.ForeColor = Color.FromArgb(23, 43, 77);
            lblDepartmentName.Location = new Point(25, 35);
            lblDepartmentName.Text = "🏢 Department Name";

            // Department Name TextBox
            txtDepartmentName.BackColor = Color.FromArgb(241, 245, 249);
            txtDepartmentName.BorderStyle = BorderStyle.FixedSingle;
            txtDepartmentName.Font = new Font("Segoe UI", 11F);
            txtDepartmentName.Location = new Point(25, 70);
            txtDepartmentName.Size = new Size(375, 32);
            txtDepartmentName.TabIndex = 0;

            // Description Label
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDescription.ForeColor = Color.FromArgb(23, 43, 77);
            lblDescription.Location = new Point(25, 125);
            lblDescription.Text = "📝 Department Description";

            // Description TextBox
            txtDescription.BackColor = Color.FromArgb(241, 245, 249);
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Segoe UI", 11F);
            txtDescription.Location = new Point(25, 160);
            txtDescription.Multiline = true;
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(375, 95);
            txtDescription.TabIndex = 1;

            // Add Department Button
            btnAddDepartment.BackColor = Color.FromArgb(13, 148, 136);
            btnAddDepartment.FlatStyle = FlatStyle.Flat;
            btnAddDepartment.FlatAppearance.BorderSize = 0;
            btnAddDepartment.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddDepartment.ForeColor = Color.WhiteSmoke;
            btnAddDepartment.Location = new Point(25, 285);
            btnAddDepartment.Size = new Size(175, 48);
            btnAddDepartment.Text = "➕ Add Department";
            btnAddDepartment.UseVisualStyleBackColor = false;
            btnAddDepartment.Cursor = Cursors.Hand;
            btnAddDepartment.TabIndex = 2;

            // Update Department Button
            btnUpdateDepartment.BackColor = Color.FromArgb(13, 148, 136);
            btnUpdateDepartment.FlatStyle = FlatStyle.Flat;
            btnUpdateDepartment.FlatAppearance.BorderSize = 0;
            btnUpdateDepartment.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdateDepartment.ForeColor = Color.WhiteSmoke;
            btnUpdateDepartment.Location = new Point(225, 285);
            btnUpdateDepartment.Size = new Size(175, 48);
            btnUpdateDepartment.Text = "✏️ Update";
            btnUpdateDepartment.UseVisualStyleBackColor = false;
            btnUpdateDepartment.Cursor = Cursors.Hand;
            btnUpdateDepartment.TabIndex = 3;

            // Delete Department Button
            btnDeleteDepartment.BackColor = Color.FromArgb(71, 85, 105);
            btnDeleteDepartment.FlatStyle = FlatStyle.Flat;
            btnDeleteDepartment.FlatAppearance.BorderSize = 0;
            btnDeleteDepartment.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteDepartment.ForeColor = Color.WhiteSmoke;
            btnDeleteDepartment.Location = new Point(25, 350);
            btnDeleteDepartment.Size = new Size(175, 48);
            btnDeleteDepartment.Text = "🗑️ Delete";
            btnDeleteDepartment.UseVisualStyleBackColor = false;
            btnDeleteDepartment.Cursor = Cursors.Hand;
            btnDeleteDepartment.TabIndex = 4;

            // Clear Button
            btnClearDepartment.BackColor = Color.FromArgb(100, 116, 139);
            btnClearDepartment.FlatStyle = FlatStyle.Flat;
            btnClearDepartment.FlatAppearance.BorderSize = 0;
            btnClearDepartment.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClearDepartment.ForeColor = Color.WhiteSmoke;
            btnClearDepartment.Location = new Point(225, 350);
            btnClearDepartment.Size = new Size(175, 48);
            btnClearDepartment.Text = "🧹 Clear";
            btnClearDepartment.UseVisualStyleBackColor = false;
            btnClearDepartment.Cursor = Cursors.Hand;
            btnClearDepartment.TabIndex = 5;

            // Back Button
            btnBack.BackColor = Color.FromArgb(71, 85, 105);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.WhiteSmoke;
            btnBack.Location = new Point(25, 415);
            btnBack.Size = new Size(375, 42);
            btnBack.Text = "⬅ Back to Dashboard";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Cursor = Cursors.Hand;
            btnBack.TabIndex = 6;

            // Add controls to form panel
            pnlForm.Controls.Add(lblDepartmentName);
            pnlForm.Controls.Add(txtDepartmentName);
            pnlForm.Controls.Add(lblDescription);
            pnlForm.Controls.Add(txtDescription);
            pnlForm.Controls.Add(btnAddDepartment);
            pnlForm.Controls.Add(btnUpdateDepartment);
            pnlForm.Controls.Add(btnDeleteDepartment);
            pnlForm.Controls.Add(btnClearDepartment);
            pnlForm.Controls.Add(btnBack);

            // Records Title
            lblRecordsTitle.AutoSize = true;
            lblRecordsTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblRecordsTitle.ForeColor = Color.FromArgb(23, 43, 77);
            lblRecordsTitle.Location = new Point(500, 140);
            lblRecordsTitle.Text = "📋 Department Records";

            // Departments DataGridView
            dgvDepartments.BackgroundColor = Color.FromArgb(241, 245, 249);
            dgvDepartments.BorderStyle = BorderStyle.None;
            dgvDepartments.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDepartments.ColumnHeadersHeight = 45;
            dgvDepartments.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDepartments.EnableHeadersVisualStyles = false;
            dgvDepartments.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(23, 43, 77);
            dgvDepartments.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.WhiteSmoke;
            dgvDepartments.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvDepartments.DefaultCellStyle.Font =
                new Font("Segoe UI", 10F);
            dgvDepartments.DefaultCellStyle.BackColor =
                Color.FromArgb(241, 245, 249);
            dgvDepartments.DefaultCellStyle.ForeColor =
                Color.FromArgb(23, 43, 77);
            dgvDepartments.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(245, 158, 11);
            dgvDepartments.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(23, 43, 77);
            dgvDepartments.RowTemplate.Height = 38;
            dgvDepartments.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvDepartments.AllowUserToAddRows = false;
            dgvDepartments.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvDepartments.MultiSelect = false;
            dgvDepartments.ReadOnly = true;
            dgvDepartments.Location = new Point(500, 185);
            dgvDepartments.Size = new Size(610, 435);
            dgvDepartments.TabIndex = 7;

            // Add controls to DepartmentForm
            Controls.Add(pnlHeader);
            Controls.Add(pnlForm);
            Controls.Add(lblRecordsTitle);
            Controls.Add(dgvDepartments);

            ((ISupportInitialize)dgvDepartments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDepartmentTitle;
        private Label lblDepartmentName;
        private TextBox txtDepartmentName;
        private Label lblDescription;
        private TextBox txtDescription;
        private Button btnAddDepartment;
        private Button btnUpdateDepartment;
        private Button btnDeleteDepartment;
        private Button btnClearDepartment;
        private DataGridView dgvDepartments;
        private Button btnBack;

        private Panel pnlHeader;
        private Panel pnlForm;
        private Label lblRecordsTitle;
    }
}
