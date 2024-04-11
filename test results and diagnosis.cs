using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostpitalManagerSystem
{
    public partial class test_results_and_diagnosis : Form
    {
        private DataTable dataTable;
        public test_results_and_diagnosis()
        {
            InitializeComponent();
            // Tạo DataTable với các cột tương ứng
            dataTable = new DataTable();
            dataTable.Columns.Add("No", typeof(int));
            dataTable.Columns.Add("Full Name", typeof(string));
            dataTable.Columns.Add("Gender", typeof(string));
            dataTable.Columns.Add("Date", typeof(DateTime));
            dataTable.Columns.Add("Test Name", typeof(string));
            dataTable.Columns.Add("Result", typeof(string));
            dataTable.Columns.Add("Conclude", typeof(string));





            // Giả định có dữ liệu trong DataTable
            // Đây chỉ là dữ liệu mẫu, bạn cần thay thế bằng dữ liệu thực tế
            // Ví dụ:
            dataTable.Rows.Add(1, "My Ngoc", "Male", new DateTime(2003, 04, 10), "HIVAIDS","Postive", "You are infected with hiv");
            //dataTable.Rows.Add(2, "Ly Gia Kiet", "Boy", new DateTime(1998, 09, 03), "Lung cancer", "Positive", new DateTime(2024, 04, 10), 4);
            //dataTable.Rows.Add(3, "Tran Huu Thinh", "Boy", new DateTime(2001, 12, 07), "0163458799", "69 Tran Duy Hung");
            /* dataTable.Rows.Add(2, DateTime.Now.AddDays(-1), "Xét nghiệm B", "Kết quả B", "Kết luận B");
             dataTable.Rows.Add(3, DateTime.Now.AddDays(-2), "Xét nghiệm C", "Kết quả C", "Kết luận C");
             */
            // Gán DataTable làm nguồn dữ liệu cho DataGridView
            dataGridViewTestResultsAndDiagnosis.DataSource = dataTable;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
