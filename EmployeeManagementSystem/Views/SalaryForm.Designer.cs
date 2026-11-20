
#nullable enable

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Views
{
    partial class SalaryForm
    {
        private IContainer? components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitle = new Label();
            lblEmployee = new Label();
            cmbEmployee = new ComboBox();
            lblBasicSalary = new Label();
            txtBasicSalary = new TextBox();
            lblAllowances = new Label();
            txtAllowances = new TextBox();
            lblDeductions = new Label();
            txtDeductions = new TextBox();
            lblNetSalary = new Label();
            txtNetSalary = new TextBox();
            lblPaymentDate = new Label();
            dtpPaymentDate = new DateTimePicker();
            btnCalculate = new Button();
            btnAddSalary = new Button();
            btnUpdateSalary = new Button();
            btnDeleteSalary = new Button();
            btnClearSalary = new Button();
            btnBack = new Button();
            dgvSalaries = new DataGridView();
            pnlHeader = new Panel();
            pnlForm = new Panel();
            lblRecordsTitle = new Label();
            ((ISupportInitialize)dgvSalaries).BeginInit();
            pnlHeader.SuspendLayout();
            pnlForm.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.WhiteSmoke;
            lblTitle.Location = new Point(50, 33);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(929, 92);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "💰 Salary Management";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmployee.ForeColor = Color.FromArgb(23, 43, 77);
            lblEmployee.Location = new Point(29, 25);
            lblEmployee.Margin = new Padding(4, 0, 4, 0);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(197, 28);
            lblEmployee.TabIndex = 0;
            lblEmployee.Text = "👤 Select Employee";
            // 
            // cmbEmployee
            // 
            cmbEmployee.BackColor = Color.FromArgb(241, 245, 249);
            cmbEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmployee.Font = new Font("Segoe UI", 10F);
            cmbEmployee.Location = new Point(29, 67);
            cmbEmployee.Margin = new Padding(4, 5, 4, 5);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(555, 36);
            cmbEmployee.TabIndex = 1;
            // 
            // lblBasicSalary
            // 
            lblBasicSalary.AutoSize = true;
            lblBasicSalary.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBasicSalary.ForeColor = Color.FromArgb(23, 43, 77);
            lblBasicSalary.Location = new Point(29, 133);
            lblBasicSalary.Margin = new Padding(4, 0, 4, 0);
            lblBasicSalary.Name = "lblBasicSalary";
            lblBasicSalary.Size = new Size(160, 28);
            lblBasicSalary.TabIndex = 2;
            lblBasicSalary.Text = "💵 Basic Salary";
            // 
            // txtBasicSalary
            // 
            txtBasicSalary.BackColor = Color.FromArgb(241, 245, 249);
            txtBasicSalary.BorderStyle = BorderStyle.FixedSingle;
            txtBasicSalary.Font = new Font("Segoe UI", 10F);
            txtBasicSalary.Location = new Point(29, 175);
            txtBasicSalary.Margin = new Padding(4, 5, 4, 5);
            txtBasicSalary.Name = "txtBasicSalary";
            txtBasicSalary.Size = new Size(556, 34);
            txtBasicSalary.TabIndex = 3;
            // 
            // lblAllowances
            // 
            lblAllowances.AutoSize = true;
            lblAllowances.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAllowances.ForeColor = Color.FromArgb(23, 43, 77);
            lblAllowances.Location = new Point(29, 242);
            lblAllowances.Margin = new Padding(4, 0, 4, 0);
            lblAllowances.Name = "lblAllowances";
            lblAllowances.Size = new Size(153, 28);
            lblAllowances.TabIndex = 4;
            lblAllowances.Text = "➕ Allowances";
            // 
            // txtAllowances
            // 
            txtAllowances.BackColor = Color.FromArgb(241, 245, 249);
            txtAllowances.BorderStyle = BorderStyle.FixedSingle;
            txtAllowances.Font = new Font("Segoe UI", 10F);
            txtAllowances.Location = new Point(29, 283);
            txtAllowances.Margin = new Padding(4, 5, 4, 5);
            txtAllowances.Name = "txtAllowances";
            txtAllowances.Size = new Size(556, 34);
            txtAllowances.TabIndex = 5;
            // 
            // lblDeductions
            // 
            lblDeductions.AutoSize = true;
            lblDeductions.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDeductions.ForeColor = Color.FromArgb(23, 43, 77);
            lblDeductions.Location = new Point(29, 350);
            lblDeductions.Margin = new Padding(4, 0, 4, 0);
            lblDeductions.Name = "lblDeductions";
            lblDeductions.Size = new Size(153, 28);
            lblDeductions.TabIndex = 6;
            lblDeductions.Text = "➖ Deductions";
            // 
            // txtDeductions
            // 
            txtDeductions.BackColor = Color.FromArgb(241, 245, 249);
            txtDeductions.BorderStyle = BorderStyle.FixedSingle;
            txtDeductions.Font = new Font("Segoe UI", 10F);
            txtDeductions.Location = new Point(29, 392);
            txtDeductions.Margin = new Padding(4, 5, 4, 5);
            txtDeductions.Name = "txtDeductions";
            txtDeductions.Size = new Size(556, 34);
            txtDeductions.TabIndex = 7;
            // 
            // lblNetSalary
            // 
            lblNetSalary.AutoSize = true;
            lblNetSalary.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNetSalary.ForeColor = Color.FromArgb(23, 43, 77);
            lblNetSalary.Location = new Point(29, 458);
            lblNetSalary.Margin = new Padding(4, 0, 4, 0);
            lblNetSalary.Name = "lblNetSalary";
            lblNetSalary.Size = new Size(142, 28);
            lblNetSalary.TabIndex = 8;
            lblNetSalary.Text = "💰 Net Salary";
            // 
            // txtNetSalary
            // 
            txtNetSalary.BackColor = Color.FromArgb(241, 245, 249);
            txtNetSalary.BorderStyle = BorderStyle.FixedSingle;
            txtNetSalary.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtNetSalary.Location = new Point(29, 500);
            txtNetSalary.Margin = new Padding(4, 5, 4, 5);
            txtNetSalary.Name = "txtNetSalary";
            txtNetSalary.ReadOnly = true;
            txtNetSalary.Size = new Size(556, 34);
            txtNetSalary.TabIndex = 9;
            // 
            // lblPaymentDate
            // 
            lblPaymentDate.AutoSize = true;
            lblPaymentDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPaymentDate.ForeColor = Color.FromArgb(23, 43, 77);
            lblPaymentDate.Location = new Point(29, 567);
            lblPaymentDate.Margin = new Padding(4, 0, 4, 0);
            lblPaymentDate.Name = "lblPaymentDate";
            lblPaymentDate.Size = new Size(179, 28);
            lblPaymentDate.TabIndex = 10;
            lblPaymentDate.Text = "📅 Payment Date";
            // 
            // dtpPaymentDate
            // 
            dtpPaymentDate.Font = new Font("Segoe UI", 10F);
            dtpPaymentDate.Format = DateTimePickerFormat.Short;
            dtpPaymentDate.Location = new Point(29, 608);
            dtpPaymentDate.Margin = new Padding(4, 5, 4, 5);
            dtpPaymentDate.Name = "dtpPaymentDate";
            dtpPaymentDate.Size = new Size(555, 34);
            dtpPaymentDate.TabIndex = 11;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(0, 0);
            btnCalculate.Margin = new Padding(4, 5, 4, 5);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(107, 38);
            btnCalculate.TabIndex = 4;
            // 
            // btnAddSalary
            // 
            btnAddSalary.Location = new Point(0, 0);
            btnAddSalary.Margin = new Padding(4, 5, 4, 5);
            btnAddSalary.Name = "btnAddSalary";
            btnAddSalary.Size = new Size(107, 38);
            btnAddSalary.TabIndex = 5;
            // 
            // btnUpdateSalary
            // 
            btnUpdateSalary.Location = new Point(0, 0);
            btnUpdateSalary.Margin = new Padding(4, 5, 4, 5);
            btnUpdateSalary.Name = "btnUpdateSalary";
            btnUpdateSalary.Size = new Size(107, 38);
            btnUpdateSalary.TabIndex = 6;
            // 
            // btnDeleteSalary
            // 
            btnDeleteSalary.Location = new Point(0, 0);
            btnDeleteSalary.Margin = new Padding(4, 5, 4, 5);
            btnDeleteSalary.Name = "btnDeleteSalary";
            btnDeleteSalary.Size = new Size(107, 38);
            btnDeleteSalary.TabIndex = 7;
            // 
            // btnClearSalary
            // 
            btnClearSalary.Location = new Point(0, 0);
            btnClearSalary.Margin = new Padding(4, 5, 4, 5);
            btnClearSalary.Name = "btnClearSalary";
            btnClearSalary.Size = new Size(107, 38);
            btnClearSalary.TabIndex = 8;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(0, 0);
            btnBack.Margin = new Padding(4, 5, 4, 5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(107, 38);
            btnBack.TabIndex = 9;
            // 
            // dgvSalaries
            // 
            dgvSalaries.AllowUserToAddRows = false;
            dgvSalaries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSalaries.BackgroundColor = Color.FromArgb(241, 245, 249);
            dgvSalaries.BorderStyle = BorderStyle.None;
            dgvSalaries.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(23, 43, 77);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSalaries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSalaries.ColumnHeadersHeight = 45;
            dgvSalaries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(23, 43, 77);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(245, 158, 11);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(23, 43, 77);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSalaries.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSalaries.EnableHeadersVisualStyles = false;
            dgvSalaries.Location = new Point(714, 283);
            dgvSalaries.Margin = new Padding(4, 5, 4, 5);
            dgvSalaries.MultiSelect = false;
            dgvSalaries.Name = "dgvSalaries";
            dgvSalaries.ReadOnly = true;
            dgvSalaries.RowHeadersWidth = 62;
            dgvSalaries.RowTemplate.Height = 35;
            dgvSalaries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSalaries.Size = new Size(871, 717);
            dgvSalaries.TabIndex = 3;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(23, 43, 77);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4, 5, 4, 5);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1643, 167);
            pnlHeader.TabIndex = 0;
            // 
            // pnlForm
            // 
            pnlForm.BackColor = Color.FromArgb(203, 213, 225);
            pnlForm.Controls.Add(lblEmployee);
            pnlForm.Controls.Add(cmbEmployee);
            pnlForm.Controls.Add(lblBasicSalary);
            pnlForm.Controls.Add(txtBasicSalary);
            pnlForm.Controls.Add(lblAllowances);
            pnlForm.Controls.Add(txtAllowances);
            pnlForm.Controls.Add(lblDeductions);
            pnlForm.Controls.Add(txtDeductions);
            pnlForm.Controls.Add(lblNetSalary);
            pnlForm.Controls.Add(txtNetSalary);
            pnlForm.Controls.Add(lblPaymentDate);
            pnlForm.Controls.Add(dtpPaymentDate);
            pnlForm.Location = new Point(50, 208);
            pnlForm.Margin = new Padding(4, 5, 4, 5);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(614, 828);
            pnlForm.TabIndex = 1;
            // 
            // lblRecordsTitle
            // 
            lblRecordsTitle.AutoSize = true;
            lblRecordsTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblRecordsTitle.ForeColor = Color.FromArgb(23, 43, 77);
            lblRecordsTitle.Location = new Point(714, 208);
            lblRecordsTitle.Margin = new Padding(4, 0, 4, 0);
            lblRecordsTitle.Name = "lblRecordsTitle";
            lblRecordsTitle.Size = new Size(268, 41);
            lblRecordsTitle.TabIndex = 2;
            lblRecordsTitle.Text = "📋 Salary Records";
            // 
            // SalaryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(226, 232, 240);
            ClientSize = new Size(1643, 1050);
            Controls.Add(pnlHeader);
            Controls.Add(pnlForm);
            Controls.Add(lblRecordsTitle);
            Controls.Add(dgvSalaries);
            Controls.Add(btnCalculate);
            Controls.Add(btnAddSalary);
            Controls.Add(btnUpdateSalary);
            Controls.Add(btnDeleteSalary);
            Controls.Add(btnClearSalary);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimumSize = new Size(1656, 1018);
            Name = "SalaryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salary Management";
            ((ISupportInitialize)dgvSalaries).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void ConfigureButton(
            Button button,
            string buttonText,
            Point location,
            Color backgroundColor)
        {
            button.BackColor = backgroundColor;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button.ForeColor = Color.WhiteSmoke;
            button.Location = location;
            button.Size = new Size(190, 40);
            button.Text = buttonText;
            button.UseVisualStyleBackColor = false;
            button.Cursor = Cursors.Hand;
        }

        private Label lblTitle;
        private Label lblEmployee;
        private ComboBox cmbEmployee;
        private Label lblBasicSalary;
        private TextBox txtBasicSalary;
        private Label lblAllowances;
        private TextBox txtAllowances;
        private Label lblDeductions;
        private TextBox txtDeductions;
        private Label lblNetSalary;
        private TextBox txtNetSalary;
        private Label lblPaymentDate;
        private DateTimePicker dtpPaymentDate;

        private Button btnCalculate;
        private Button btnAddSalary;
        private Button btnUpdateSalary;
        private Button btnDeleteSalary;
        private Button btnClearSalary;
        private Button btnBack;

        private DataGridView dgvSalaries;

        private Panel pnlHeader;
        private Panel pnlForm;
        private Label lblRecordsTitle;
    }
}
