namespace HostpitalManagerSystem
{
    partial class clinicandequipment
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewClinic = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClinic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(321, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clinic \r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(628, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClinic
            // 
            this.dataGridViewClinic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClinic.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewClinic.Location = new System.Drawing.Point(0, 150);
            this.dataGridViewClinic.Name = "dataGridViewClinic";
            this.dataGridViewClinic.RowTemplate.Height = 24;
            this.dataGridViewClinic.Size = new System.Drawing.Size(764, 382);
            this.dataGridViewClinic.TabIndex = 4;
            // 
            // clinicandequipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 532);
            this.Controls.Add(this.dataGridViewClinic);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "clinicandequipment";
            this.Text = "clinicandequipment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClinic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewClinic;
    }
}