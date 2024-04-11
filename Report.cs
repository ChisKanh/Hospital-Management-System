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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = GetAllAcc().Tables[0];
        }
        DataSet GetAllAcc()
        {
            DataSet data = new DataSet();
            string query = "select * from Doctors";
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                adapter.Fill(data);
                sqlConnection.Close();
            }
            return data;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.DataSource = GetAllPT().Tables[0];
        }
        DataSet GetAllPT()
        {
            DataSet data = new DataSet();
            string query = "select * from Patients";
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);
                adapter.Fill(data);
                sqlConnection.Close();
            }
            return data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.DataSource = GetAllPS().Tables[0];
        }
        DataSet GetAllPS()
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Report successfull!");
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }
    }
}
