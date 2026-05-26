namespace BudgetTracker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnAnalysis = new Button();
            btnCategories = new Button();
            btnTransactions = new Button();
            btnDashboard = new Button();
            panelObsah = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.MenuHighlight;
            panelMenu.Controls.Add(btnAnalysis);
            panelMenu.Controls.Add(btnCategories);
            panelMenu.Controls.Add(btnTransactions);
            panelMenu.Controls.Add(btnDashboard);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(150, 450);
            panelMenu.TabIndex = 0;
            // 
            // btnAnalysis
            // 
            btnAnalysis.BackColor = Color.Transparent;
            btnAnalysis.Dock = DockStyle.Top;
            btnAnalysis.FlatStyle = FlatStyle.Flat;
            btnAnalysis.ForeColor = Color.White;
            btnAnalysis.Location = new Point(0, 150);
            btnAnalysis.Name = "btnAnalysis";
            btnAnalysis.Size = new Size(150, 50);
            btnAnalysis.TabIndex = 3;
            btnAnalysis.Text = "Analysis";
            btnAnalysis.UseVisualStyleBackColor = false;
            btnAnalysis.Click += btnAnalysis_Click;
            // 
            // btnCategories
            // 
            btnCategories.BackColor = Color.Transparent;
            btnCategories.Dock = DockStyle.Top;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.ForeColor = Color.White;
            btnCategories.Location = new Point(0, 100);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(150, 50);
            btnCategories.TabIndex = 2;
            btnCategories.Text = "Categories";
            btnCategories.UseVisualStyleBackColor = false;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnTransactions
            // 
            btnTransactions.BackColor = Color.Transparent;
            btnTransactions.Dock = DockStyle.Top;
            btnTransactions.FlatStyle = FlatStyle.Flat;
            btnTransactions.ForeColor = Color.White;
            btnTransactions.Location = new Point(0, 50);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new Size(150, 50);
            btnTransactions.TabIndex = 1;
            btnTransactions.Text = "Transactions";
            btnTransactions.UseVisualStyleBackColor = false;
            btnTransactions.Click += btnTransactions_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(150, 50);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panelObsah
            // 
            panelObsah.Dock = DockStyle.Fill;
            panelObsah.Location = new Point(150, 0);
            panelObsah.Name = "panelObsah";
            panelObsah.Size = new Size(650, 450);
            panelObsah.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelObsah);
            Controls.Add(panelMenu);
            Name = "MainForm";
            Text = "MainForm";
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnDashboard;
        private Button btnAnalysis;
        private Button btnCategories;
        private Button btnTransactions;
        private Panel panelObsah;
    }
}