﻿namespace HostpitalManagerSystem
{
    partial class test_results_and_diagnosis
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTestResultsAndDiagnosis = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTestResultsAndDiagnosis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(197, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test Results and Diagnosis";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewTestResultsAndDiagnosis
            // 
            this.dataGridViewTestResultsAndDiagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTestResultsAndDiagnosis.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewTestResultsAndDiagnosis.Location = new System.Drawing.Point(0, 125);
            this.dataGridViewTestResultsAndDiagnosis.Name = "dataGridViewTestResultsAndDiagnosis";
            this.dataGridViewTestResultsAndDiagnosis.RowTemplate.Height = 24;
            this.dataGridViewTestResultsAndDiagnosis.Size = new System.Drawing.Size(800, 325);
            this.dataGridViewTestResultsAndDiagnosis.TabIndex = 3;
            // 
            // test_results_and_diagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewTestResultsAndDiagnosis);
            this.Controls.Add(this.label1);
            this.Name = "test_results_and_diagnosis";
            this.Text = "test_results_and_diagnosis";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTestResultsAndDiagnosis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewTestResultsAndDiagnosis;
    }
}