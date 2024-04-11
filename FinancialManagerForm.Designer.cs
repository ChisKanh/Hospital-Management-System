namespace HostpitalManagerSystem
{
    partial class FinancialManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinancialManagerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMenuFinancialManagement = new System.Windows.Forms.Panel();
            this.btnExpenses = new System.Windows.Forms.Button();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.btnFinancialmanagement = new System.Windows.Forms.Button();
            this.panelMenuMedicinesAndMedicalSupplies = new System.Windows.Forms.Panel();
            this.btnMedicalsupplies = new System.Windows.Forms.Button();
            this.btnMedicine = new System.Windows.Forms.Button();
            this.btnMedicineandmedicalsupplies = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pictureBoxMedicine = new System.Windows.Forms.PictureBox();
            this.pictureBoxRevenue = new System.Windows.Forms.PictureBox();
            this.panelDashBoard = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelMenuFinancialManagement.SuspendLayout();
            this.panelMenuMedicinesAndMedicalSupplies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRevenue)).BeginInit();
            this.panelDashBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.HotPink;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 82);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.HotPink;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(288, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hospital Managemt System";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.HotPink;
            this.panel2.Controls.Add(this.panelMenuFinancialManagement);
            this.panel2.Controls.Add(this.btnFinancialmanagement);
            this.panel2.Controls.Add(this.panelMenuMedicinesAndMedicalSupplies);
            this.panel2.Controls.Add(this.btnMedicineandmedicalsupplies);
            this.panel2.Controls.Add(this.btnDashboard);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 579);
            this.panel2.TabIndex = 4;
            // 
            // panelMenuFinancialManagement
            // 
            this.panelMenuFinancialManagement.Controls.Add(this.btnExpenses);
            this.panelMenuFinancialManagement.Controls.Add(this.btnRevenue);
            this.panelMenuFinancialManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuFinancialManagement.Location = new System.Drawing.Point(0, 236);
            this.panelMenuFinancialManagement.Name = "panelMenuFinancialManagement";
            this.panelMenuFinancialManagement.Size = new System.Drawing.Size(296, 99);
            this.panelMenuFinancialManagement.TabIndex = 8;
            // 
            // btnExpenses
            // 
            this.btnExpenses.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnExpenses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExpenses.FlatAppearance.BorderSize = 0;
            this.btnExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExpenses.Location = new System.Drawing.Point(0, 45);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Size = new System.Drawing.Size(296, 45);
            this.btnExpenses.TabIndex = 5;
            this.btnExpenses.Text = "EXPENSES";
            this.btnExpenses.UseVisualStyleBackColor = false;
            this.btnExpenses.Click += new System.EventHandler(this.btnExpenses_Click);
            // 
            // btnRevenue
            // 
            this.btnRevenue.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnRevenue.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRevenue.FlatAppearance.BorderSize = 0;
            this.btnRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRevenue.Location = new System.Drawing.Point(0, 0);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(296, 45);
            this.btnRevenue.TabIndex = 4;
            this.btnRevenue.Text = "REVENUE";
            this.btnRevenue.UseVisualStyleBackColor = false;
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // btnFinancialmanagement
            // 
            this.btnFinancialmanagement.BackColor = System.Drawing.Color.DeepPink;
            this.btnFinancialmanagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFinancialmanagement.FlatAppearance.BorderSize = 0;
            this.btnFinancialmanagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinancialmanagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFinancialmanagement.Location = new System.Drawing.Point(0, 186);
            this.btnFinancialmanagement.Name = "btnFinancialmanagement";
            this.btnFinancialmanagement.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnFinancialmanagement.Size = new System.Drawing.Size(296, 50);
            this.btnFinancialmanagement.TabIndex = 7;
            this.btnFinancialmanagement.Text = "FINANCIAL MANAGEMENT";
            this.btnFinancialmanagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinancialmanagement.UseVisualStyleBackColor = false;
            this.btnFinancialmanagement.Click += new System.EventHandler(this.btnFinancialmanagement_Click);
            // 
            // panelMenuMedicinesAndMedicalSupplies
            // 
            this.panelMenuMedicinesAndMedicalSupplies.AutoScroll = true;
            this.panelMenuMedicinesAndMedicalSupplies.Controls.Add(this.btnMedicalsupplies);
            this.panelMenuMedicinesAndMedicalSupplies.Controls.Add(this.btnMedicine);
            this.panelMenuMedicinesAndMedicalSupplies.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuMedicinesAndMedicalSupplies.Location = new System.Drawing.Point(0, 95);
            this.panelMenuMedicinesAndMedicalSupplies.Name = "panelMenuMedicinesAndMedicalSupplies";
            this.panelMenuMedicinesAndMedicalSupplies.Size = new System.Drawing.Size(296, 91);
            this.panelMenuMedicinesAndMedicalSupplies.TabIndex = 6;
            // 
            // btnMedicalsupplies
            // 
            this.btnMedicalsupplies.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnMedicalsupplies.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedicalsupplies.FlatAppearance.BorderSize = 0;
            this.btnMedicalsupplies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicalsupplies.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMedicalsupplies.Location = new System.Drawing.Point(0, 45);
            this.btnMedicalsupplies.Name = "btnMedicalsupplies";
            this.btnMedicalsupplies.Size = new System.Drawing.Size(296, 45);
            this.btnMedicalsupplies.TabIndex = 4;
            this.btnMedicalsupplies.Text = "MEDICAL SUPPLIES";
            this.btnMedicalsupplies.UseVisualStyleBackColor = false;
            this.btnMedicalsupplies.Click += new System.EventHandler(this.btnMedicalsupplies_Click);
            // 
            // btnMedicine
            // 
            this.btnMedicine.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnMedicine.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedicine.FlatAppearance.BorderSize = 0;
            this.btnMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMedicine.Location = new System.Drawing.Point(0, 0);
            this.btnMedicine.Name = "btnMedicine";
            this.btnMedicine.Size = new System.Drawing.Size(296, 45);
            this.btnMedicine.TabIndex = 3;
            this.btnMedicine.Text = "MEDICINE";
            this.btnMedicine.UseVisualStyleBackColor = false;
            this.btnMedicine.Click += new System.EventHandler(this.btnMedicine_Click);
            // 
            // btnMedicineandmedicalsupplies
            // 
            this.btnMedicineandmedicalsupplies.BackColor = System.Drawing.Color.DeepPink;
            this.btnMedicineandmedicalsupplies.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedicineandmedicalsupplies.FlatAppearance.BorderSize = 0;
            this.btnMedicineandmedicalsupplies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicineandmedicalsupplies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMedicineandmedicalsupplies.Location = new System.Drawing.Point(0, 45);
            this.btnMedicineandmedicalsupplies.Name = "btnMedicineandmedicalsupplies";
            this.btnMedicineandmedicalsupplies.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMedicineandmedicalsupplies.Size = new System.Drawing.Size(296, 50);
            this.btnMedicineandmedicalsupplies.TabIndex = 5;
            this.btnMedicineandmedicalsupplies.Text = "MEDICINES AND MEDICAL SUPPLIES";
            this.btnMedicineandmedicalsupplies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicineandmedicalsupplies.UseVisualStyleBackColor = false;
            this.btnMedicineandmedicalsupplies.Click += new System.EventHandler(this.btnMedicineandmedicalsupplies_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.DeepPink;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(296, 45);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // pictureBoxMedicine
            // 
            this.pictureBoxMedicine.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMedicine.Image")));
            this.pictureBoxMedicine.Location = new System.Drawing.Point(140, 140);
            this.pictureBoxMedicine.Name = "pictureBoxMedicine";
            this.pictureBoxMedicine.Size = new System.Drawing.Size(228, 203);
            this.pictureBoxMedicine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMedicine.TabIndex = 5;
            this.pictureBoxMedicine.TabStop = false;
            this.pictureBoxMedicine.Click += new System.EventHandler(this.pictureBoxMedicine_Click);
            // 
            // pictureBoxRevenue
            // 
            this.pictureBoxRevenue.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRevenue.Image")));
            this.pictureBoxRevenue.Location = new System.Drawing.Point(509, 140);
            this.pictureBoxRevenue.Name = "pictureBoxRevenue";
            this.pictureBoxRevenue.Size = new System.Drawing.Size(228, 203);
            this.pictureBoxRevenue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRevenue.TabIndex = 6;
            this.pictureBoxRevenue.TabStop = false;
            this.pictureBoxRevenue.Click += new System.EventHandler(this.pictureBoxRevenue_Click);
            // 
            // panelDashBoard
            // 
            this.panelDashBoard.Controls.Add(this.pictureBoxRevenue);
            this.panelDashBoard.Controls.Add(this.pictureBoxMedicine);
            this.panelDashBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashBoard.Location = new System.Drawing.Point(296, 82);
            this.panelDashBoard.Name = "panelDashBoard";
            this.panelDashBoard.Size = new System.Drawing.Size(830, 579);
            this.panelDashBoard.TabIndex = 5;
            // 
            // FinancialManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1126, 661);
            this.Controls.Add(this.panelDashBoard);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FinancialManagerForm";
            this.Text = "FinancialManagerForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelMenuFinancialManagement.ResumeLayout(false);
            this.panelMenuMedicinesAndMedicalSupplies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRevenue)).EndInit();
            this.panelDashBoard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelMenuFinancialManagement;
        private System.Windows.Forms.Button btnExpenses;
        private System.Windows.Forms.Button btnFinancialmanagement;
        private System.Windows.Forms.Panel panelMenuMedicinesAndMedicalSupplies;
        private System.Windows.Forms.Button btnMedicalsupplies;
        private System.Windows.Forms.Button btnMedicine;
        private System.Windows.Forms.Button btnMedicineandmedicalsupplies;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.PictureBox pictureBoxMedicine;
        private System.Windows.Forms.PictureBox pictureBoxRevenue;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.Panel panelDashBoard;
    }
}