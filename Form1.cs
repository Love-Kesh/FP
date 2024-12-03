using System;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            FormStyling.ApplyFormStyling(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            var user = Database.Authenticate(username, password);

            if (user != null)
            {
                MessageBox.Show($"Welcome, {user.Name}!");
                var dashboard = new MainDashboardForm(user);
                dashboard.Show();
                this.Hide();  // Hide the login form
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }
    }
}
