namespace HostpitalManagerSystem
{
    partial class schedule_appointment
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
            this.dataGridViewScheduleAppointment = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScheduleAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(192, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Schedule Appointment";
            // 
            // dataGridViewScheduleAppointment
            // 
            this.dataGridViewScheduleAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScheduleAppointment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewScheduleAppointment.Location = new System.Drawing.Point(0, 133);
            this.dataGridViewScheduleAppointment.Name = "dataGridViewScheduleAppointment";
            this.dataGridViewScheduleAppointment.RowTemplate.Height = 24;
            this.dataGridViewScheduleAppointment.Size = new System.Drawing.Size(764, 399);
            this.dataGridViewScheduleAppointment.TabIndex = 16;
            // 
            // schedule_appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 532);
            this.Controls.Add(this.dataGridViewScheduleAppointment);
            this.Controls.Add(this.label1);
            this.Name = "schedule_appointment";
            this.Text = "schedule_appointment";
            this.Load += new System.EventHandler(this.schedule_appointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScheduleAppointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewScheduleAppointment;
    }
}