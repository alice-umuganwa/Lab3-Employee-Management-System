
#nullable enable

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Views
{
    partial class AttendanceForm
    {
        private IContainer? components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblEmployee = new Label();
            cmbEmployee = new ComboBox();
            lblDate = new Label();
            dtpAttendanceDate = new DateTimePicker();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            lblRemarks = new Label();
            txtRemarks = new TextBox();

            btnAddAttendance = new Button();
            btnUpdateAttendance = new Button();
            btnDeleteAttendance = new Button();
            btnClearAttendance = new Button();
            btnBack = new Button();

            dgvAttendance = new DataGridView();

            pnlHeader = new Panel();
            pnlForm = new Panel();
            lblRecordsTitle = new Label();

            ((ISupportInitialize)dgvAttendance).BeginInit();
            SuspendLayout();

            // Form
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(226, 232, 240);
            ClientSize = new Size(1150, 760);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Name = "AttendanceForm";
            Text = "Attendance Management";

            // Header
            pnlHeader.BackColor = Color.FromArgb(23, 43, 77);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Size = new Size(1150, 105);

            lblTitle.AutoSize = false;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.WhiteSmoke;
            lblTitle.Location = new Point(35, 25);
            lblTitle.Size = new Size(650, 50);
            lblTitle.Text = "📅 Attendance Management";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;

            pnlHeader.Controls.Add(lblTitle);

            // Form Panel
            pnlForm.BackColor = Color.FromArgb(203, 213, 225);
            pnlForm.Location = new Point(35, 140);
            pnlForm.Size = new Size(430, 555);

            // Employee
            lblEmployee.AutoSize = true;
            lblEmployee.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblEmployee.ForeColor = Color.FromArgb(23, 43, 77);
            lblEmployee.Location = new Point(25, 20);
            lblEmployee.Text = "👤 Select Employee";

            cmbEmployee.BackColor = Color.FromArgb(241, 245, 249);
            cmbEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmployee.Font = new Font("Segoe UI", 11F);
            cmbEmployee.Location = new Point(25, 50);
            cmbEmployee.Size = new Size(375, 33);

            // Date
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDate.ForeColor = Color.FromArgb(23, 43, 77);
            lblDate.Location = new Point(25, 95);
            lblDate.Text = "📆 Attendance Date";

            dtpAttendanceDate.Font = new Font("Segoe UI", 10F);
            dtpAttendanceDate.Format = DateTimePickerFormat.Short;
            dtpAttendanceDate.Location = new Point(25, 125);
            dtpAttendanceDate.Size = new Size(375, 30);

            // Status
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(23, 43, 77);
            lblStatus.Location = new Point(25, 170);
            lblStatus.Text = "📌 Attendance Status";

            cmbStatus.BackColor = Color.FromArgb(241, 245, 249);
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 11F);
            cmbStatus.Location = new Point(25, 200);
            cmbStatus.Size = new Size(375, 33);

            // Remarks
            lblRemarks.AutoSize = true;
            lblRemarks.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblRemarks.ForeColor = Color.FromArgb(23, 43, 77);
            lblRemarks.Location = new Point(25, 245);
            lblRemarks.Text = "📝 Remarks";

            txtRemarks.BackColor = Color.FromArgb(241, 245, 249);
            txtRemarks.BorderStyle = BorderStyle.FixedSingle;
            txtRemarks.Font = new Font("Segoe UI", 10F);
            txtRemarks.Location = new Point(25, 275);
            txtRemarks.Multiline = true;
            txtRemarks.ScrollBars = ScrollBars.Vertical;
            txtRemarks.Size = new Size(375, 55);

            // Add Button
            btnAddAttendance.BackColor = Color.FromArgb(13, 148, 136);
            btnAddAttendance.FlatStyle = FlatStyle.Flat;
            btnAddAttendance.FlatAppearance.BorderSize = 0;
            btnAddAttendance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddAttendance.ForeColor = Color.WhiteSmoke;
            btnAddAttendance.Location = new Point(25, 350);
            btnAddAttendance.Size = new Size(175, 42);
            btnAddAttendance.Text = "➕ Add Attendance";
            btnAddAttendance.UseVisualStyleBackColor = false;
            btnAddAttendance.Cursor = Cursors.Hand;

            // Update Button
            btnUpdateAttendance.BackColor = Color.FromArgb(13, 148, 136);
            btnUpdateAttendance.FlatStyle = FlatStyle.Flat;
            btnUpdateAttendance.FlatAppearance.BorderSize = 0;
            btnUpdateAttendance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdateAttendance.ForeColor = Color.WhiteSmoke;
            btnUpdateAttendance.Location = new Point(225, 350);
            btnUpdateAttendance.Size = new Size(175, 42);
            btnUpdateAttendance.Text = "✏️ Update";
            btnUpdateAttendance.UseVisualStyleBackColor = false;
            btnUpdateAttendance.Cursor = Cursors.Hand;

            // Delete Button
            btnDeleteAttendance.BackColor = Color.FromArgb(71, 85, 105);
            btnDeleteAttendance.FlatStyle = FlatStyle.Flat;
            btnDeleteAttendance.FlatAppearance.BorderSize = 0;
            btnDeleteAttendance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeleteAttendance.ForeColor = Color.WhiteSmoke;
            btnDeleteAttendance.Location = new Point(25, 410);
            btnDeleteAttendance.Size = new Size(175, 42);
            btnDeleteAttendance.Text = "🗑️ Delete";
            btnDeleteAttendance.UseVisualStyleBackColor = false;
            btnDeleteAttendance.Cursor = Cursors.Hand;

            // Clear Button
            btnClearAttendance.BackColor = Color.FromArgb(100, 116, 139);
            btnClearAttendance.FlatStyle = FlatStyle.Flat;
            btnClearAttendance.FlatAppearance.BorderSize = 0;
            btnClearAttendance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClearAttendance.ForeColor = Color.WhiteSmoke;
            btnClearAttendance.Location = new Point(225, 410);
            btnClearAttendance.Size = new Size(175, 42);
            btnClearAttendance.Text = "🧹 Clear";
            btnClearAttendance.UseVisualStyleBackColor = false;
            btnClearAttendance.Cursor = Cursors.Hand;

            // Back Button - outside the form panel
            btnBack.BackColor = Color.FromArgb(71, 85, 105);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.WhiteSmoke;
            btnBack.Location = new Point(500, 650);
            btnBack.Size = new Size(250, 45);
            btnBack.Text = "⬅ Back to Dashboard";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Cursor = Cursors.Hand;

            // Add controls to left panel
            pnlForm.Controls.Add(lblEmployee);
            pnlForm.Controls.Add(cmbEmployee);
            pnlForm.Controls.Add(lblDate);
            pnlForm.Controls.Add(dtpAttendanceDate);
            pnlForm.Controls.Add(lblStatus);
            pnlForm.Controls.Add(cmbStatus);
            pnlForm.Controls.Add(lblRemarks);
            pnlForm.Controls.Add(txtRemarks);
            pnlForm.Controls.Add(btnAddAttendance);
            pnlForm.Controls.Add(btnUpdateAttendance);
            pnlForm.Controls.Add(btnDeleteAttendance);
            pnlForm.Controls.Add(btnClearAttendance);

            // Records Title
            lblRecordsTitle.AutoSize = true;
            lblRecordsTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblRecordsTitle.ForeColor = Color.FromArgb(23, 43, 77);
            lblRecordsTitle.Location = new Point(500, 140);
            lblRecordsTitle.Text = "📋 Attendance Records";

            // Attendance Table
            dgvAttendance.BackgroundColor = Color.FromArgb(241, 245, 249);
            dgvAttendance.BorderStyle = BorderStyle.None;
            dgvAttendance.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAttendance.ColumnHeadersHeight = 45;
            dgvAttendance.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAttendance.EnableHeadersVisualStyles = false;

            dgvAttendance.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(23, 43, 77);
            dgvAttendance.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.WhiteSmoke;
            dgvAttendance.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);

            dgvAttendance.DefaultCellStyle.Font =
                new Font("Segoe UI", 10F);
            dgvAttendance.DefaultCellStyle.BackColor =
                Color.FromArgb(241, 245, 249);
            dgvAttendance.DefaultCellStyle.ForeColor =
                Color.FromArgb(23, 43, 77);
            dgvAttendance.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(245, 158, 11);
            dgvAttendance.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(23, 43, 77);

            dgvAttendance.RowTemplate.Height = 38;
            dgvAttendance.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendance.AllowUserToAddRows = false;
            dgvAttendance.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvAttendance.MultiSelect = false;
            dgvAttendance.ReadOnly = true;
            dgvAttendance.Location = new Point(500, 185);
            dgvAttendance.Size = new Size(610, 435);

            // Add controls to main form
            Controls.Add(pnlHeader);
            Controls.Add(pnlForm);
            Controls.Add(lblRecordsTitle);
            Controls.Add(dgvAttendance);
            Controls.Add(btnBack);

            ((ISupportInitialize)dgvAttendance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private Label lblEmployee;
        private ComboBox cmbEmployee;
        private Label lblDate;
        private DateTimePicker dtpAttendanceDate;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Label lblRemarks;
        private TextBox txtRemarks;

        private Button btnAddAttendance;
        private Button btnUpdateAttendance;
        private Button btnDeleteAttendance;
        private Button btnClearAttendance;
        private Button btnBack;

        private DataGridView dgvAttendance;

        private Panel pnlHeader;
        private Panel pnlForm;
        private Label lblRecordsTitle;
    }
}
