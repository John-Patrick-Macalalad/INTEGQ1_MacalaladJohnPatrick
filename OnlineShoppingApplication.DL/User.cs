using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShoppingApplication.DL
{
    public class User
    {
        private string username;
        private string password;
        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string UserName
        {
            get { return username; }
            set { username = value; }
        }

        public string PassWord
        {
            get { return password; }
            set { password = value; }
        }
    }
}
