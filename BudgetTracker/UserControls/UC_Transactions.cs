using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetTracker.UserControls
{
    public partial class UC_Transactions : UserControl
    {
        public UC_Transactions()
        {
            InitializeComponent();
        }

        private void UC_Transactions_Load(object sender, EventArgs e)
        {
            RenewCategories();
            RenewTransactions();
        }

        private void RenewCategories()
        {
            using (var context = new AppDbContext())
            {
                var categories = context.Categories.ToList();
                cbCategories.DataSource = categories;
                cbCategories.DisplayMember = "CategoryName";
                cbCategories.ValueMember = "CategoryID";
                cbCategories.SelectedIndex = -1;
            }
        }

        private void RenewTransactions()
        {
            using (var context = new AppDbContext())
            {
                var transactions = context.Transactions.Select(t => new { t.Amount, t.Date, t.Note, Category = t.Category.CategoryName }).OrderByDescending(t => t.Date).ToList();
                dgvTransactions.DataSource = transactions;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (nudAmount.Value <= 0)
            {
                MessageBox.Show("Please enter a valid amount greater than 0.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbCategories.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal amount = nudAmount.Value;

            if (rbExpence.Checked)
            {
                amount = -amount;
            }

            int selectedCategoryID = Convert.ToInt32(cbCategories.SelectedValue);

            Models.Transaction newTransaction = new(amount, txtBoxNote.Text, 1, selectedCategoryID);

            using (var context = new AppDbContext())
            {
                context.Transactions.Add(newTransaction);
                context.SaveChanges();
            }

            nudAmount.Value = 0;
            txtBoxNote.Clear();
            rbExpence.Checked = false;

            RenewTransactions();

        }
    }
}
