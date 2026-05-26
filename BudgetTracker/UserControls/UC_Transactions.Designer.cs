namespace BudgetTracker.UserControls
{
    partial class UC_Transactions
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
            panelAddTransactions = new Panel();
            panelTransactionsHistory = new Panel();
            label1 = new Label();
            label2 = new Label();
            nudAmount = new NumericUpDown();
            rbIncome = new RadioButton();
            rb = new RadioButton();
            label3 = new Label();
            cbCategories = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            btnConfirm = new Button();
            label6 = new Label();
            dgvTransactions = new DataGridView();
            panelAddTransactions.SuspendLayout();
            panelTransactionsHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();
            // 
            // panelAddTransactions
            // 
            panelAddTransactions.Controls.Add(btnConfirm);
            panelAddTransactions.Controls.Add(label5);
            panelAddTransactions.Controls.Add(textBox1);
            panelAddTransactions.Controls.Add(label4);
            panelAddTransactions.Controls.Add(dateTimePicker1);
            panelAddTransactions.Controls.Add(cbCategories);
            panelAddTransactions.Controls.Add(label3);
            panelAddTransactions.Controls.Add(rb);
            panelAddTransactions.Controls.Add(rbIncome);
            panelAddTransactions.Controls.Add(nudAmount);
            panelAddTransactions.Controls.Add(label2);
            panelAddTransactions.Controls.Add(label1);
            panelAddTransactions.Dock = DockStyle.Left;
            panelAddTransactions.Location = new Point(0, 0);
            panelAddTransactions.Name = "panelAddTransactions";
            panelAddTransactions.Size = new Size(325, 450);
            panelAddTransactions.TabIndex = 0;
            // 
            // panelTransactionsHistory
            // 
            panelTransactionsHistory.Controls.Add(dgvTransactions);
            panelTransactionsHistory.Controls.Add(label6);
            panelTransactionsHistory.Dock = DockStyle.Right;
            panelTransactionsHistory.Location = new Point(325, 0);
            panelTransactionsHistory.Name = "panelTransactionsHistory";
            panelTransactionsHistory.Size = new Size(325, 450);
            panelTransactionsHistory.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(78, 28);
            label1.Name = "label1";
            label1.Size = new Size(164, 21);
            label1.TabIndex = 0;
            label1.Text = "NEW TRANSACTION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 80);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Amount:";
            // 
            // nudAmount
            // 
            nudAmount.Location = new Point(78, 78);
            nudAmount.Name = "nudAmount";
            nudAmount.Size = new Size(200, 23);
            nudAmount.TabIndex = 2;
            // 
            // rbIncome
            // 
            rbIncome.AutoSize = true;
            rbIncome.Location = new Point(78, 132);
            rbIncome.Name = "rbIncome";
            rbIncome.Size = new Size(65, 19);
            rbIncome.TabIndex = 3;
            rbIncome.TabStop = true;
            rbIncome.Text = "Income";
            rbIncome.UseVisualStyleBackColor = true;
            // 
            // rb
            // 
            rb.AutoSize = true;
            rb.Location = new Point(159, 132);
            rb.Name = "rb";
            rb.Size = new Size(68, 19);
            rb.TabIndex = 4;
            rb.TabStop = true;
            rb.Text = "Expence";
            rb.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 182);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 5;
            label3.Text = "Category:";
            // 
            // cbCategories
            // 
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(78, 179);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(200, 23);
            cbCategories.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(78, 250);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 250);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 8;
            label4.Text = "Date:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(78, 334);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 337);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 10;
            label5.Text = "Note:";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(65, 394);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(200, 42);
            btnConfirm.TabIndex = 11;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.Location = new Point(67, 28);
            label6.Name = "label6";
            label6.Size = new Size(201, 21);
            label6.TabIndex = 1;
            label6.Text = "TRANSACTIONS HISTORY";
            // 
            // dgvTransactions
            // 
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Location = new Point(3, 78);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.Size = new Size(319, 358);
            dgvTransactions.TabIndex = 2;
            // 
            // UC_Transactions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelTransactionsHistory);
            Controls.Add(panelAddTransactions);
            Name = "UC_Transactions";
            Size = new Size(650, 450);
            panelAddTransactions.ResumeLayout(false);
            panelAddTransactions.PerformLayout();
            panelTransactionsHistory.ResumeLayout(false);
            panelTransactionsHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAddTransactions;
        private Label label2;
        private Label label1;
        private Panel panelTransactionsHistory;
        private NumericUpDown nudAmount;
        private RadioButton rb;
        private RadioButton rbIncome;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbCategories;
        private Label label3;
        private Button btnConfirm;
        private Label label5;
        private TextBox textBox1;
        private DataGridView dgvTransactions;
        private Label label6;
    }
}
