using Microsoft.EntityFrameworkCore;
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
    public partial class UC_Dashboard : UserControl
    {
        public UC_Dashboard()
        {
            InitializeComponent();
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            UpdateDashboard();
        }

        public void UpdateDashboard()
        {
            using (var context = new AppDbContext())
            {
                decimal totalBalance = context.Transactions.Sum(t => t.Amount);

                DateTime today = DateTime.Now;
                int currentMonth = today.Month;
                int currentYear = today.Year;

                decimal monthIncome = context.Transactions
                    .Where(t => t.Date.Month == currentMonth && t.Date.Year == currentYear && t.Amount > 0).Sum(t => t.Amount);

                decimal monthExpenses = context.Transactions
                    .Where(t => t.Date.Month == currentMonth && t.Date.Year == currentYear && t.Amount < 0).Sum(t => t.Amount);

                lblBalance.Text = $"{totalBalance} Kč";
                lblIncomeMonth.Text = $"{monthIncome} Kč";
                lblExpenses.Text = $"{Math.Abs(monthExpenses)} Kč";

                var lastTransactions = context.Transactions
                    .OrderByDescending(t => t.Date)
                    .Take(7)
                    .Select(t => new { t.Amount, t.Date, t.Note, Category = t.Category.CategoryName })
                    .ToList();

                dgRecentTransactions.DataSource = lastTransactions;
            }
        }
    }
}
