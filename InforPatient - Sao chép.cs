using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostpitalManagerSystem
{
    public partial class InforPatient : Form
    {
        private DataTable dataTable;
        public InforPatient()
        {
            InitializeComponent();
            // Tạo DataTable với các cột tương ứng
            dataTable = new DataTable();
            dataTable.Columns.Add("No", typeof(int));
            dataTable.Columns.Add("Full Name", typeof(string));
            dataTable.Columns.Add("Gender", typeof(string));
            dataTable.Columns.Add("Date", typeof(DateTime));
            dataTable.Columns.Add("Phone", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));


            // Giả định có dữ liệu trong DataTable
            // Đây chỉ là dữ liệu mẫu, bạn cần thay thế bằng dữ liệu thực tế
            // Ví dụ:
            dataTable.Rows.Add(1, "My Ngoc", "Male", new DateTime(2003,04,10), "0123456789", "Quan 8");
            //dataTable.Rows.Add(2, "Ly Gia Kiet", "Boy", new DateTime(1998, 09, 03), "0223457897", "123 Dang Thuy Tram");
            //dataTable.Rows.Add(3, "Tran Huu Thinh", "Boy", new DateTime(2001, 12, 07), "0163458799", "69 Tran Duy Hung");
            
            // Gán DataTable làm nguồn dữ liệu cho DataGridView
            dataGridViewIfnor.DataSource = dataTable;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
