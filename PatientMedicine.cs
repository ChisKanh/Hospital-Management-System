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
    public partial class PatientMedicine : Form
    {
        public PatientMedicine()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = GetAllAccount().Tables[0];
        }
        DataSet GetAllAccount()
        {
            DataSet data = new DataSet();
            string query = "select * from PatientMedicine";
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
        Modify modify = new Modify();
        PM PM;

        private void button3_Click(object sender, EventArgs e)
        {
            int PatientID = int.Parse(this.textBox1.Text);
            string FullName = this.textBox2.Text;
            string Address = this.textBox3.Text;
            string NameOfMedicine = this.textBox4.Text;
            string Amount = this.textBox5.Text;
            PM = new PM(PatientID, FullName, Address, NameOfMedicine, Amount);
            if (modify.insert(PM))
            {
                dataGridView1.DataSource = modify.getAllPM();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            if (modify.DeletePM(id))
            {
                dataGridView1.DataSource = modify.getAllPM();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void PatientMedicine_Load(object sender, EventArgs e)
        {

        }
    }
}
