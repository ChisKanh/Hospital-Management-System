using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HosManage
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Notification", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        Modify modify = new Modify();

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = textBox1.Text;
            string Password = textBox2.Text;
            if (Username.Trim() == "") { MessageBox.Show("Please fill your account!"); return; }
            else if (Password.Trim() == "") { MessageBox.Show("Please fill your password!"); return; }
            else
            {
                string query = "Select * from Account where Username = '" + Username + "' and Password = '" + Password + "'";
                if (modify.Accounts(query).Count != 0)
                {
                    MessageBox.Show("Login success!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ManagerForm m = new ManagerForm();
                    this.Hide();
                    m.ShowDialog();
                    this.Show();

                }
                else
                {
                    MessageBox.Show("login failed! Your password is incorrect!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SignUp s = new SignUp();
            this.Hide();
            s.ShowDialog();
            this.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedRole = comboBox1.SelectedItem.ToString();
            switch (selectedRole)
            {
                case "Patient":
                    
                    MessageBox.Show("Welcome to Hospital!");
                    break;
                case "Doctor":
                    
                    MessageBox.Show("Welcome, Doctor!");
                    break;
                case "Financial Manager":
                    
                    MessageBox.Show("Welcome, Financial Manager!");
                    break;
                case "Manager":

                    MessageBox.Show("Welcome,Manager!");
                    break;
                default:
                    // Hiển thị thông báo nếu không chọn quyền
                    MessageBox.Show("Please select a role!");
                    break;
            }
        }
    }
}
