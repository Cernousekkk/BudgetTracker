namespace BudgetTracker
{
    partial class UC_Dashboard
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
            panel1 = new Panel();
            lblBalance = new Label();
            label1 = new Label();
            panel2 = new Panel();
            lblIncomeMonth = new Label();
            label2 = new Label();
            panel3 = new Panel();
            lblExpenses = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblBalance);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 450);
            panel1.TabIndex = 0;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblBalance.Location = new Point(73, 90);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(62, 25);
            lblBalance.TabIndex = 1;
            lblBalance.Text = "10000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(64, 32);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 0;
            label1.Text = "BALANCE";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblIncomeMonth);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(219, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(221, 450);
            panel2.TabIndex = 1;
            // 
            // lblIncomeMonth
            // 
            lblIncomeMonth.AutoSize = true;
            lblIncomeMonth.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblIncomeMonth.ForeColor = Color.LimeGreen;
            lblIncomeMonth.Location = new Point(78, 90);
            lblIncomeMonth.Name = "lblIncomeMonth";
            lblIncomeMonth.Size = new Size(62, 25);
            lblIncomeMonth.TabIndex = 2;
            lblIncomeMonth.Text = "10000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(25, 32);
            label2.Name = "label2";
            label2.Size = new Size(178, 21);
            label2.TabIndex = 1;
            label2.Text = "INCOME THIS MONTH";
            // 
            // panel3
            // 
            panel3.Controls.Add(lblExpenses);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(440, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(210, 450);
            panel3.TabIndex = 2;
            // 
            // lblExpenses
            // 
            lblExpenses.AutoSize = true;
            lblExpenses.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblExpenses.ForeColor = Color.Red;
            lblExpenses.Location = new Point(77, 90);
            lblExpenses.Name = "lblExpenses";
            lblExpenses.Size = new Size(62, 25);
            lblExpenses.TabIndex = 3;
            lblExpenses.Text = "10000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(6, 32);
            label3.Name = "label3";
            label3.Size = new Size(201, 21);
            label3.TabIndex = 2;
            label3.Text = "EXPENSESS THIS MONTH";
            // 
            // UC_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UC_Dashboard";
            Size = new Size(650, 450);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Label lblBalance;
        private Label label2;
        private Label label3;
        private Label lblIncomeMonth;
        private Label lblExpenses;
    }
}
