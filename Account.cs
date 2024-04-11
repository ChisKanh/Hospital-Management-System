using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HosManage
{
    class Account
    {
        private string Username;
        private string Password;

        public Account()
        {
        }

        public Account(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
        public string username{get => Username; set => Username = value; }
        public string password { get => Password; set => Password = value; }

    }
}
