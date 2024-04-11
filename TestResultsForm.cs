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
    public partial class TestResultsForm : Form
    {
        private DataTable dataTable;
        public TestResultsForm()
        {
            InitializeComponent();
            // Tạo DataTable với các cột tương ứng
            dataTable = new DataTable();
            dataTable.Columns.Add("No", typeof(int));
            dataTable.Columns.Add("Test Date", typeof(DateTime));
            dataTable.Columns.Add("Test Name", typeof(string));
            dataTable.Columns.Add("Result", typeof(string));
            dataTable.Columns.Add("Conclude", typeof(string));

            // Giả định có dữ liệu trong DataTable
            // Đây chỉ là dữ liệu mẫu, bạn cần thay thế bằng dữ liệu thực tế
            // Ví dụ:
            dataTable.Rows.Add(1, DateTime.Now, "HIV antibodies", "Positive", "You have the disease of the century");
            /* dataTable.Rows.Add(2, DateTime.Now.AddDays(-1), "Xét nghiệm B", "Kết quả B", "Kết luận B");
             dataTable.Rows.Add(3, DateTime.Now.AddDays(-2), "Xét nghiệm C", "Kết quả C", "Kết luận C");
             */
            // Gán DataTable làm nguồn dữ liệu cho DataGridView
            dataGridView1.DataSource = dataTable;
        }
    }
}
