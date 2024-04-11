using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HostpitalManagerSystem
{
    public partial class MakeAnAppointmentForm : Form
    {
        public MakeAnAppointmentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && dateTimePicker1.Value != null)
            {
                string selectedOption = comboBox1.SelectedItem.ToString();
                DateTime selectedDateTime = dateTimePicker1.Value;

                // Thực hiện lưu lịch hẹn và các hành động liên quan ở đây

                MessageBox.Show("Schedule appointment successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Sau khi lưu thành công, có thể làm sạch hoặc reset các điều khiển nếu cần thiết
                comboBox1.SelectedIndex = -1;
                dateTimePicker1.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Please select complete information before making an appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
