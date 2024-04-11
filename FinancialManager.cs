using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace HosManage
{
    public partial class FinancialManager : Form
    {
        public FinancialManager()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = GetAllAccount().Tables[0];
        }
        DataSet GetAllAccount()
        {
            DataSet data = new DataSet();
            string query = "select * from FinancialManagers";
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                adapter.Fill(data);
                sqlConnection.Close();
            }
            return data;
        }
        Modify modify = new Modify();
        FManage fManage;
        private void button3_Click(object sender, EventArgs e)
        {
            int ManagerID = int.Parse(this.textBox1.Text);
            string FullName = this.textBox2.Text;
            string Address = this.textBox3.Text;
            DateTime DateOfBirth = this.dateTimePicker1.Value;
            string PhoneNumber = this.textBox5.Text;
            fManage = new FManage(ManagerID, FullName, Address, DateOfBirth, PhoneNumber);
            if (modify.insert(fManage))
            {
                dataGridView1.DataSource = modify.getAllFManager();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            if (modify.DeleteDFManage(id))
            {
                dataGridView1.DataSource = modify.getAllFManager();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
