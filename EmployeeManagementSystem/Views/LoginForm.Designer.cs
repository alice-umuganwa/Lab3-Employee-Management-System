
#nullable enable

using System.Drawing;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Views
{
    partial class LoginForm
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
            lblTitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();

            SuspendLayout();

            // Login Form
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(226, 232, 240);
            ClientSize = new Size(900, 600);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Text = "Employee Management System - Login";

            // Title
            lblTitle.AutoSize = false;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Size = new Size(900, 120);
            lblTitle.Text = "🔐  EMPLOYEE MANAGEMENT SYSTEM";
            lblTitle.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblTitle.BackColor = Color.FromArgb(23, 43, 77);
            lblTitle.ForeColor = Color.FromArgb(245, 158, 11);
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // Username Label
            lblUsername.AutoSize = false;
            lblUsername.Location = new Point(250, 190);
            lblUsername.Size = new Size(400, 35);
            lblUsername.Text = "👤  Username";
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(23, 43, 77);

            // Username TextBox
            txtUsername.Location = new Point(250, 230);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(400, 40);
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.BackColor = Color.FromArgb(241, 245, 249);
            txtUsername.ForeColor = Color.FromArgb(23, 43, 77);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.TabIndex = 0;

            // Password Label
            lblPassword.AutoSize = false;
            lblPassword.Location = new Point(250, 295);
            lblPassword.Size = new Size(400, 35);
            lblPassword.Text = "🔒  Password";
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(23, 43, 77);

            // Password TextBox
            txtPassword.Location = new Point(250, 335);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(400, 40);
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.BackColor = Color.FromArgb(241, 245, 249);
            txtPassword.ForeColor = Color.FromArgb(23, 43, 77);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.TabIndex = 1;

            // Login Button
            btnLogin.Location = new Point(250, 415);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(190, 55);
            btnLogin.Text = "🔑  Login";
            btnLogin.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnLogin.BackColor = Color.FromArgb(13, 148, 136);
            btnLogin.ForeColor = Color.WhiteSmoke;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.TabIndex = 2;
            btnLogin.Click += btnLogin_Click;

            // Register Button
            btnRegister.Location = new Point(460, 415);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(190, 55);
            btnRegister.Text = "👤  Register";
            btnRegister.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnRegister.BackColor = Color.FromArgb(71, 85, 105);
            btnRegister.ForeColor = Color.WhiteSmoke;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.TabIndex = 3;

            // Add Controls
            Controls.Add(lblTitle);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);

            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle = null!;
        private Label lblUsername = null!;
        private TextBox txtUsername = null!;
        private Label lblPassword = null!;
        private TextBox txtPassword = null!;
        private Button btnLogin = null!;
        private Button btnRegister = null!;
    }
}
