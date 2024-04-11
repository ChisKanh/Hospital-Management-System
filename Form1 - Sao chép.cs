using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HostpitalManagerSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your full username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Thực hiện kiểm tra tên đăng nhập và mật khẩu (đây chỉ là ví dụ)
                if (CheckCredentials(username, password))
                {
                    MessageBox.Show("Logged in successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Đóng form sau khi đăng nhập thành công
                    PatientForm form = new PatientForm();
                    this.Hide();
                    form.ShowDialog();
                    /*DoctorForm loginform = new DoctorForm();
                    this.Hide();
                    loginform.ShowDialog();*/
                    /*FinancialManagerForm fican = new FinancialManagerForm(); 
                    this.Hide();
                    fican.ShowDialog();*/
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //DoctorForm loginform = new DoctorForm();
            //this.Hide();
            //loginform.ShowDialog();
           
            //FinancialManagerForm fican = new FinancialManagerForm(); 
            //this.Hide();
            //fican.ShowDialog();

        }
        private bool CheckCredentials(string username, string password)
        {
            // Trong ví dụ này, sẽ thực hiện kiểm tra đơn giản với tên đăng nhập là "admin" và mật khẩu là "password"
            return username == "myngoc@uef.edu.vn" && password == "ngoc123";
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            this.Hide();
            signUp.ShowDialog();    
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text == "User Name")
            {
                txtUserName.Clear();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
            }
            txtPassword.UseSystemPasswordChar = true;
        }
    }
}
