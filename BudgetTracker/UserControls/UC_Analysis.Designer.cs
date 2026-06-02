namespace BudgetTracker
{
    partial class UC_Analysis
    {
        /// <summary> 
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            lblAvgExpense = new Label();
            lblMaxExpense = new Label();
            lblMaxIncome = new Label();
            chartExpenses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)chartExpenses).BeginInit();
            SuspendLayout();
            // 
            // lblAvgExpense
            // 
            lblAvgExpense.AutoSize = true;
            lblAvgExpense.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblAvgExpense.Location = new Point(13, 32);
            lblAvgExpense.Name = "lblAvgExpense";
            lblAvgExpense.Size = new Size(132, 20);
            lblAvgExpense.TabIndex = 0;
            lblAvgExpense.Text = "Average expense:";
            // 
            // lblMaxExpense
            // 
            lblMaxExpense.AutoSize = true;
            lblMaxExpense.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblMaxExpense.Location = new Point(13, 97);
            lblMaxExpense.Name = "lblMaxExpense";
            lblMaxExpense.Size = new Size(145, 20);
            lblMaxExpense.TabIndex = 1;
            lblMaxExpense.Text = "Maximum expense:";
            // 
            // lblMaxIncome
            // 
            lblMaxIncome.AutoSize = true;
            lblMaxIncome.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblMaxIncome.Location = new Point(13, 158);
            lblMaxIncome.Name = "lblMaxIncome";
            lblMaxIncome.Size = new Size(139, 20);
            lblMaxIncome.TabIndex = 2;
            lblMaxIncome.Text = "Maximum income:";
            // 
            // chartExpenses
            // 
            chartExpenses.BackColor = SystemColors.Control;
            chartExpenses.BackSecondaryColor = SystemColors.Control;
            chartExpenses.BorderlineColor = SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            chartExpenses.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartExpenses.Legends.Add(legend1);
            chartExpenses.Location = new Point(284, 56);
            chartExpenses.Name = "chartExpenses";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartExpenses.Series.Add(series1);
            chartExpenses.Size = new Size(353, 394);
            chartExpenses.TabIndex = 3;
            chartExpenses.Text = "chart1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(403, 27);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 4;
            label1.Text = "Expense chart";
            // 
            // UC_Analysis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(chartExpenses);
            Controls.Add(lblMaxIncome);
            Controls.Add(lblMaxExpense);
            Controls.Add(lblAvgExpense);
            Name = "UC_Analysis";
            Size = new Size(650, 450);
            ((System.ComponentModel.ISupportInitialize)chartExpenses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAvgExpense;
        private Label lblMaxExpense;
        private Label lblMaxIncome;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartExpenses;
        private Label label1;
    }
}
