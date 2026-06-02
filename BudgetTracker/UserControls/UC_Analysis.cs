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
using System.Windows.Forms.DataVisualization.Charting;

namespace BudgetTracker
{
    public partial class UC_Analysis : UserControl
    {
        public UC_Analysis()
        {
            InitializeComponent();
            LoadAnalysis();
        }

        public void LoadAnalysis()
        {
            using (var context = new AppDbContext())
            {
                if (context.Transactions.Count() == 0)
                {
                    MessageBox.Show("No transactions available for analysis.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var expenses = context.Transactions.Where(t => t.Amount < 0);
                if (expenses.Count() != 0)
                {
                    decimal avgExpense = expenses.Average(t => t.Amount);
                    decimal maxExpense = expenses.Min(t => t.Amount);

                    lblAvgExpense.Text = $"Average Expense: {Math.Abs(avgExpense)} Kč";
                    lblMaxExpense.Text = $"Maximum Expense: {Math.Abs(maxExpense)} Kč";
                }

                var incomes = context.Transactions.Where(t => t.Amount > 0);
                if (incomes.Count() != 0)
                {
                    decimal maxIncome = incomes.Max(t => t.Amount);
                    lblMaxIncome.Text = $"Maximum Income: {maxIncome} Kč";
                }

                var graphData = context.Transactions
                    .Where(t => t.Amount < 0)
                    .Include(t => t.Category)
                    .GroupBy(t => t.Category.CategoryName)
                    .Select(g => new
                    {
                        Kategorie = g.Key ?? "Bez kategorie",
                        Celkem = Math.Abs(g.Sum(t => t.Amount))
                    }).ToList();

                chartExpenses.Series.Clear();
                chartExpenses.Legends.Clear();
                chartExpenses.ChartAreas.Clear();

                chartExpenses.ChartAreas.Add(new ChartArea("MainArea"));
                chartExpenses.Legends.Add(new Legend("MainLegend"));

                Series row = new Series
                {
                    Name = "Expenses",
                    ChartType = SeriesChartType.Pie,
                    XValueType = ChartValueType.String,
                    YValueType = ChartValueType.Double
                };

                foreach (var cat in graphData)
                {
                    int index = row.Points.AddXY(cat.Kategorie, (double)cat.Celkem);

                    row.Points[index].Label = "#PERCENT{P1}";
                    row.Points[index].LegendText = cat.Kategorie;
                }

                chartExpenses.Series.Add(row);

                chartExpenses.ChartAreas["MainArea"].Area3DStyle.Enable3D = true;
            }
        }
    }
}
