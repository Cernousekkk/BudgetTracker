using BudgetTracker.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetTracker
{
    public partial class MainForm : Form
    {
        private UserControl currentPage;
        public MainForm()
        {
            InitializeComponent();
            ShowPage(new UC_Dashboard());
        }

        private void ShowPage(UserControl newPage)
        {
            panelObsah.Controls.Clear();

            newPage.Dock = DockStyle.Fill;

            panelObsah.Controls.Add(newPage);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowPage(new UC_Dashboard());
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            ShowPage(new UC_Transactions());
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            ShowPage(new UC_Categories());
        }

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            ShowPage(new UC_Analysis());
        }
    }
}
