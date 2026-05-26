using System;
using System.Linq;
using System.Windows.Forms;

namespace BudgetTracker
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.UserName == txtBoxUserName.Text && u.Password == txtBoxPassword.Text);

                if (user != null)
                {
                    MessageBox.Show($"Welcome, {user.FullName}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    MainForm mainPanel = new MainForm();
                    mainPanel.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}