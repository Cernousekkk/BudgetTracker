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
    public partial class UC_Categories : UserControl
    {
        public UC_Categories()
        {
            InitializeComponent();
        }

        private void UC_Categories_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            using (var context = new AppDbContext())
            {
                dgvCategories.DataSource = context.Categories.Select(c => new { c.CategoryName, c.Limit }).ToList();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxName.Text))
            {
                MessageBox.Show("Please enter a category name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (nudLimit == null || nudLimit.Value <= 0)
            {
                MessageBox.Show("Please enter a valid limit greater than 0.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Models.Category newCategory = new(txtBoxName.Text, nudLimit.Value);

            using (var context = new AppDbContext())
            {
                context.Categories.Add(newCategory);
                context.SaveChanges();
            }

            txtBoxName.Clear();
            nudLimit.Value = 0;
            LoadCategories();
        }
    }
}
