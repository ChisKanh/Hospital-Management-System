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
    public partial class Patients : Form
    {
        public Patients()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        Modify modify = new Modify();
        patient patient;

        private void Patients_Load(object sender, EventArgs e)
        {

 

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        
      

        private void button3_Click(object sender, EventArgs e)
        {
            int PatientID = int.Parse(this.textBox1.Text);
            string FullName = this.textBox2.Text;
            string Address = this.textBox3.Text;
            DateTime DateOfBirth = this.dateTimePicker1.Value;
            string PhoneNumber = this.textBox5.Text;
            patient = new patient(PatientID, FullName, Address, DateOfBirth, PhoneNumber);
            if(modify.insert(patient))
            {
                dataGridView1.DataSource = modify.getAllPatients();
            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        
            if (modify.DeletePatients(id))
            {
                dataGridView1.DataSource = modify.getAllPatients();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PatientMedicine pt = new PatientMedicine();
            this.Hide();
            pt.ShowDialog();
            this.Show();

        }
    }
}
