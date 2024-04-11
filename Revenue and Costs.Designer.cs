namespace HostpitalManagerSystem
{
    partial class Revenue_and_Costs
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
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewCost = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCost)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(294, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Revenue and Costs";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(58, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 2;
            this.button2.Text = "Confirm";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCost
            // 
            this.dataGridViewCost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCost.Location = new System.Drawing.Point(33, 85);
            this.dataGridViewCost.Name = "dataGridViewCost";
            this.dataGridViewCost.RowTemplate.Height = 24;
            this.dataGridViewCost.Size = new System.Drawing.Size(736, 308);
            this.dataGridViewCost.TabIndex = 4;
            // 
            // Revenue_and_Costs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewCost);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Name = "Revenue_and_Costs";
            this.Text = "Revenue_and_Costs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewCost;
    }
}