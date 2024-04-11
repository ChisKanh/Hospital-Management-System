using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
namespace HosManage
{
    public partial class SignUp : Form
    {


        public SignUp()
        {
            InitializeComponent();
        }
        public bool checkAccount(string ac)
        {
            return Regex.IsMatch(ac, "^[0-9]{3,9}$");
        }


        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        Modify modify = new Modify();
        private void button1_Click(object sender, EventArgs e)
        {
            string Position = textBox5.Text;
            string Name = textBox4.Text;
            string Username = textBox1.Text;
            string Password = textBox2.Text;
            string confirm = textBox3.Text;
            if (!checkAccount(Password)) { MessageBox.Show("Please enter your account name according to the student code from 0 to 9 including 3 to 9 characters!"); return; };
            if (confirm != Password) { MessageBox.Show("Please confirm exactly your password"); return; };
            
            try
            {
                
                string query = "INSERT INTO Account(Name,Username, Password, Position) VALUES ('"+Name+"','"+Username+"','"+Password+"','"+Position+"')";
                modify.Command(query);
                if (MessageBox.Show("Sign Up successful, Do you want to login now?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("This account has been registered, please use another one!"+ "or "+ex.Message);
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
