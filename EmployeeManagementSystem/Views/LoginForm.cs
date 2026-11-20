
using System;
using System.Windows.Forms;
using EmployeeManagementSystem.Controllers;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            btnRegister.Click += btnRegister_Click;
        }

        private void lblUsername_Click(object? sender, EventArgs e)
        {
        }

        private void lblTitle_Click(object? sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object? sender, EventArgs e)
        {
            User user = new User();

            user.Username = txtUsername.Text.Trim();
            user.Password = txtPassword.Text;

            if (user.Username == "" || user.Password == "")
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            LoginController controller = new LoginController();

            try
            {
                if (controller.Login(user))
                {
                    MessageBox.Show("Login successful!");

                    DashboardForm dashboard = new DashboardForm();
                    dashboard.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnRegister_Click(object? sender, EventArgs e)
        {
            User user = new User();

            user.Username = txtUsername.Text.Trim();
            user.Password = txtPassword.Text;

            if (user.Username == "" || user.Password == "")
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            if (user.Password.Length < 6)
            {
                MessageBox.Show("Password must contain at least 6 characters.");
                return;
            }

            LoginController controller = new LoginController();

            try
            {
                bool registered = controller.Register(user);

                if (registered)
                {
                    MessageBox.Show("Registration successful! You can now login.");
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
                else
                {
                    MessageBox.Show("This username already exists. Please choose another.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registration error: " + ex.Message);
            }
        }
    }
}
