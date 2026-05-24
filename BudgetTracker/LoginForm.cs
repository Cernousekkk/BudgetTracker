namespace BudgetTracker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.UserName == txtBoxUserName.Text && u.Password == txtBoxPassword.Text);

            }
        }
    }
}
