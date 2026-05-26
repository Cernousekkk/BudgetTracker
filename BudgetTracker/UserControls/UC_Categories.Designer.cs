namespace BudgetTracker
{
    partial class UC_Categories
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
            panelNewCategory = new Panel();
            panelCategoryList = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtBoxName = new TextBox();
            nudLimit = new NumericUpDown();
            btnConfirm = new Button();
            label4 = new Label();
            dgvTransactions = new DataGridView();
            panelNewCategory.SuspendLayout();
            panelCategoryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudLimit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();
            // 
            // panelNewCategory
            // 
            panelNewCategory.Controls.Add(btnConfirm);
            panelNewCategory.Controls.Add(nudLimit);
            panelNewCategory.Controls.Add(txtBoxName);
            panelNewCategory.Controls.Add(label3);
            panelNewCategory.Controls.Add(label2);
            panelNewCategory.Controls.Add(label1);
            panelNewCategory.Dock = DockStyle.Left;
            panelNewCategory.Location = new Point(0, 0);
            panelNewCategory.Name = "panelNewCategory";
            panelNewCategory.Size = new Size(240, 450);
            panelNewCategory.TabIndex = 0;
            // 
            // panelCategoryList
            // 
            panelCategoryList.Controls.Add(dgvTransactions);
            panelCategoryList.Controls.Add(label4);
            panelCategoryList.Dock = DockStyle.Right;
            panelCategoryList.Location = new Point(240, 0);
            panelCategoryList.Name = "panelCategoryList";
            panelCategoryList.Size = new Size(410, 450);
            panelCategoryList.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(55, 16);
            label1.Name = "label1";
            label1.Size = new Size(133, 21);
            label1.TabIndex = 0;
            label1.Text = "NEW CATEGORY";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 67);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 124);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "Limit:";
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(55, 64);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(149, 23);
            txtBoxName.TabIndex = 10;
            // 
            // nudLimit
            // 
            nudLimit.Location = new Point(55, 122);
            nudLimit.Name = "nudLimit";
            nudLimit.Size = new Size(149, 23);
            nudLimit.TabIndex = 11;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(19, 387);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(203, 42);
            btnConfirm.TabIndex = 12;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.Location = new Point(139, 16);
            label4.Name = "label4";
            label4.Size = new Size(133, 21);
            label4.TabIndex = 1;
            label4.Text = "MY CATEGORIES";
            // 
            // dgvTransactions
            // 
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Location = new Point(3, 49);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.Size = new Size(404, 398);
            dgvTransactions.TabIndex = 3;
            // 
            // UC_Categories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelCategoryList);
            Controls.Add(panelNewCategory);
            Name = "UC_Categories";
            Size = new Size(650, 450);
            panelNewCategory.ResumeLayout(false);
            panelNewCategory.PerformLayout();
            panelCategoryList.ResumeLayout(false);
            panelCategoryList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudLimit).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNewCategory;
        private Panel panelCategoryList;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtBoxName;
        private NumericUpDown nudLimit;
        private Button btnConfirm;
        private Label label4;
        private DataGridView dgvTransactions;
    }
}
