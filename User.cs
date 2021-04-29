using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apotek_PBO
{
    class User
    {
        private int _userID;
        private string _userName;
        private string _password;

        public int UserID
        {
            get { return _userID; }
        }
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public User() { }
        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
        public Boolean Login(string userName, string password)
        {
            if(userName == "Admin1" & password == "Admin001")
            {
                _userID = 1;
                return true;
            }
            else if(userName == "Admin2" & password == "Admin002")
            {
                _userID = 2;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
