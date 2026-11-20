
using System;
using System.Windows.Forms;
using EmployeeManagementSystem.Views;

namespace EmployeeManagementSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Application.Run(new LoginForm());
        }
    }
}
