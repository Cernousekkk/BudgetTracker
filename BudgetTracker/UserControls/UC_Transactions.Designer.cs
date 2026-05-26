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
            btnConfirm = new Button();
            label5 = new Label();
            txtBoxNote = new TextBox();
            label4 = new Label();
            dtpDate = new DateTimePicker();
            cbCategories = new ComboBox();
            label3 = new Label();
            rbExpence = new RadioButton();
            rbIncome = new RadioButton();
            nudAmount = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            panelTransactionsHistory = new Panel();
            dgvTransactions = new DataGridView();
            label6 = new Label();
            panelAddTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAmount).BeginInit();
            panelTransactionsHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();
            // 
            // panelAddTransactions
            // 
            panelAddTransactions.Controls.Add(btnConfirm);
            panelAddTransactions.Controls.Add(label5);
            panelAddTransactions.Controls.Add(txtBoxNote);
            panelAddTransactions.Controls.Add(label4);
            panelAddTransactions.Controls.Add(dtpDate);
            panelAddTransactions.Controls.Add(cbCategories);
            panelAddTransactions.Controls.Add(label3);
            panelAddTransactions.Controls.Add(rbExpence);
            panelAddTransactions.Controls.Add(rbIncome);
            panelAddTransactions.Controls.Add(nudAmount);
            panelAddTransactions.Controls.Add(label2);
            panelAddTransactions.Controls.Add(label1);
            panelAddTransactions.Dock = DockStyle.Left;
            panelAddTransactions.Location = new Point(0, 0);
            panelAddTransactions.Name = "panelAddTransactions";
            panelAddTransactions.Size = new Size(240, 450);
            panelAddTransactions.TabIndex = 0;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(16, 383);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(203, 42);
            btnConfirm.TabIndex = 11;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 320);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 10;
            label5.Text = "Note:";
            // 
            // txtBoxNote
            // 
            txtBoxNote.Location = new Point(63, 317);
            txtBoxNote.Name = "txtBoxNote";
            txtBoxNote.Size = new Size(149, 23);
            txtBoxNote.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 250);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 8;
            label4.Text = "Date:";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(63, 244);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(149, 23);
            dtpDate.TabIndex = 7;
            // 
            // cbCategories
            // 
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(64, 179);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(149, 23);
            cbCategories.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 182);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 5;
            label3.Text = "Category:";
            // 
            // rbExpence
            // 
            rbExpence.AutoSize = true;
            rbExpence.Location = new Point(135, 132);
            rbExpence.Name = "rbExpence";
            rbExpence.Size = new Size(68, 19);
            rbExpence.TabIndex = 4;
            rbExpence.TabStop = true;
            rbExpence.Text = "Expence";
            rbExpence.UseVisualStyleBackColor = true;
            // 
            // rbIncome
            // 
            rbIncome.AutoSize = true;
            rbIncome.Location = new Point(64, 132);
            rbIncome.Name = "rbIncome";
            rbIncome.Size = new Size(65, 19);
            rbIncome.TabIndex = 3;
            rbIncome.TabStop = true;
            rbIncome.Text = "Income";
            rbIncome.UseVisualStyleBackColor = true;
            // 
            // nudAmount
            // 
            nudAmount.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            nudAmount.Location = new Point(64, 78);
            nudAmount.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            nudAmount.Name = "nudAmount";
            nudAmount.Size = new Size(149, 23);
            nudAmount.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 80);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Amount:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(49, 17);
            label1.Name = "label1";
            label1.Size = new Size(164, 21);
            label1.TabIndex = 0;
            label1.Text = "NEW TRANSACTION";
            // 
            // panelTransactionsHistory
            // 
            panelTransactionsHistory.Controls.Add(dgvTransactions);
            panelTransactionsHistory.Controls.Add(label6);
            panelTransactionsHistory.Dock = DockStyle.Right;
            panelTransactionsHistory.Location = new Point(240, 0);
            panelTransactionsHistory.Name = "panelTransactionsHistory";
            panelTransactionsHistory.Size = new Size(410, 450);
            panelTransactionsHistory.TabIndex = 1;
            // 
            // dgvTransactions
            // 
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Location = new Point(3, 50);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.Size = new Size(404, 397);
            dgvTransactions.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.Location = new Point(102, 17);
            label6.Name = "label6";
            label6.Size = new Size(201, 21);
            label6.TabIndex = 1;
            label6.Text = "TRANSACTIONS HISTORY";
            // 
            // UC_Transactions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelTransactionsHistory);
            Controls.Add(panelAddTransactions);
            Name = "UC_Transactions";
            Size = new Size(650, 450);
            Load += UC_Transactions_Load;
            panelAddTransactions.ResumeLayout(false);
            panelAddTransactions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudAmount).EndInit();
            panelTransactionsHistory.ResumeLayout(false);
            panelTransactionsHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAddTransactions;
        private Label label2;
        private Label label1;
        private Panel panelTransactionsHistory;
        private NumericUpDown nudAmount;
        private RadioButton rbExpence;
        private RadioButton rbIncome;
        private Label label4;
        private DateTimePicker dtpDate;
        private ComboBox cbCategories;
        private Label label3;
        private Button btnConfirm;
        private Label label5;
        private TextBox txtBoxNote;
        private DataGridView dgvTransactions;
        private Label label6;
    }
}
