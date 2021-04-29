using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apotek_PBO
{
    class UserPremium : User
    {
        private int _userID;
        private string _userName;
        private string _password;

        public int newUserID
        {
            get { return _userID; }
        }
        public string newUserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        public string newPassword
        {
            get { return _password; }
            set { _password = value; }
        }
        public UserPremium() { }
        public UserPremium(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
        public new Boolean Login(string userName, string password)
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
