using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apotek_PBO.Models;

namespace Apotek_PBO
{
    class UserPremium : User
    {
        LogIn model = new LogIn();
        private string _userName;
        private string _password;

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
        public new Boolean Login()
        {
            bool b = false;
            using (var db =new DBMedStorageContext())
            {
                var query = from LogIn in db.LogIns where LogIn.Username == UserName && LogIn.Password == Password select LogIn;
                if (query != null)
                {
                    foreach (var item in query)
                    {
                        if (item.Type == "admin")
                        {
                            b = true;
                        }
                    }

                }
            }
            return b;
        }
        public new Boolean tambahAkun(string type)
        {
            bool b = false;
            if (UserName != "" && Password != "")
            {
                model.Username = UserName;
                model.Password = Password;
                model.Type = type;
                using (var db = new DBMedStorageContext())
                {
                    db.LogIns.Add(model);
                    db.SaveChanges();
                    b = true;
                }
            }
            return b;
        }
    }
}
