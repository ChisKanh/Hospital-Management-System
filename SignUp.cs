using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HostpitalManagerSystem
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Mail")
            {
                txtEmail.Clear();
            }
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            if (txtFullName.Text == "Full Name")
            {
                txtFullName.Clear();
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtAddress.Text == "Address")
            {
                txtAddress.Clear();
            }
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtPhoneNumber.Text == "Phone Number")
            {
                txtPhoneNumber.Clear();
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

        private void txtPasswordAgain_TextChanged(object sender, EventArgs e)
        {
            if (txtPasswordAgain.Text == "Re-enter password")
            {
                txtPasswordAgain.Clear();
            }
            txtPasswordAgain.UseSystemPasswordChar = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            /*
            // Kiểm tra xem tất cả các ô textbox có được điền đầy đủ không
            if (string.IsNullOrWhiteSpace( txtFullName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin đăng nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Kiểm tra thông tin đăng nhập
                if (CheckLogin(txtFullName.Text, txtPassword.Text))
                {
                    MessageBox.Show("Sign Up Success!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Reset các ô textbox sau khi đăng nhập thành công
                    txtFullName.Clear();
                    txtPhoneNumber.Clear();
                    txtEmail.Clear();
                    txtAddress.Clear();
                    txtPasswordAgain.Clear();
                    txtPassword.Clear();
                    // Ẩn form đăng ký
                    this.Hide();

                    // Hiện lại form đăng nhập
                    Form1 loginForm = new Form1();
                    loginForm.Show();
                }
                else
                {
                    MessageBox.Show("Please enter complete information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
            // Kiểm tra xem tất cả các ô textbox có được điền đầy đủ không
            if (string.IsNullOrWhiteSpace(txtFullName.Text) &&
                string.IsNullOrWhiteSpace(txtAddress.Text) &&
                string.IsNullOrWhiteSpace(txtPhoneNumber.Text) &&
                string.IsNullOrWhiteSpace(txtEmail.Text) &&
                string.IsNullOrWhiteSpace(txtPassword.Text) &&
                string.IsNullOrWhiteSpace(txtPasswordAgain.Text))
            {
                MessageBox.Show("Please enter complete information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text != txtPasswordAgain.Text)
            {
                MessageBox.Show("Password and re-enter password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Xử lý đăng ký ở đây (có thể là lưu thông tin vào cơ sở dữ liệu hoặc bất kỳ hành động nào khác)
                MessageBox.Show("Sign Up Success!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Sau khi đăng ký thành công, mở form đăng nhập
                Form1 loginForm = new Form1();
                loginForm.Show();

                // Đóng form đăng ký
                this.Close();

            }
        }
        private bool CheckLogin(string username, string password)
        {
            // Thực hiện kiểm tra tên đăng nhập và mật khẩu ở đây
            // Đây là nơi bạn sẽ kiểm tra thông tin đăng nhập từ cơ sở dữ liệu hoặc bất kỳ nguồn nào khác
            // Trong ví dụ này, tôi sẽ sử dụng giả định đơn giản, nơi tên đăng nhập và mật khẩu là "admin"
            return username == "admin" && password == "admin";
        }



    }
}
  
