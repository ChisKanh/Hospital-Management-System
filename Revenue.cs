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
    public partial class Revenue : Form
    {
        private DataTable dataTable;
        public Revenue()
        {
            InitializeComponent();
            // Tạo DataTable với các cột tương ứng
            dataTable = new DataTable();
            dataTable.Columns.Add("No", typeof(int));
            dataTable.Columns.Add("type of medicine", typeof(string));
            
            dataTable.Columns.Add("type of service", typeof(string));
            dataTable.Columns.Add("Quantity", typeof(int));
            dataTable.Columns.Add("Revenue", typeof(int));




            // Giả định có dữ liệu trong DataTable
            // Đây chỉ là dữ liệu mẫu, bạn cần thay thế bằng dữ liệu thực tế
            // Ví dụ:
            dataTable.Rows.Add(1, "cough medicine, pain reliever", 2, 45);
            dataTable.Rows.Add(2, "Boarding fees, medical supplies fees",2,55);
            //dataTable.Rows.Add(3, "Tran Huu Thinh", "Boy", new DateTime(2001, 12, 07), "0163458799", "69 Tran Duy Hung");
            /* dataTable.Rows.Add(2, DateTime.Now.AddDays(-1), "Xét nghiệm B", "Kết quả B", "Kết luận B");
             dataTable.Rows.Add(3, DateTime.Now.AddDays(-2), "Xét nghiệm C", "Kết quả C", "Kết luận C");
             */
            // Gán DataTable làm nguồn dữ liệu cho DataGridView
            dataGridViewRevenue.DataSource = dataTable;
        }

        private void Revenue_Load(object sender, EventArgs e)
        {

        }
    }
}
