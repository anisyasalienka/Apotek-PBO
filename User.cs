using System;
using System.Linq;
using Apotek_PBO.Models;

namespace Apotek_PBO
{
    class User
    {
        LogIn model = new LogIn();
        private string _userName;
        private string _password;
        private string _type;

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
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public User() { }
        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
        public Boolean Login()
        {
            bool b = false;
            using (var db = new DBMedStorageContext())
            {
                var query = from LogIn in db.LogIns where LogIn.Username == UserName && LogIn.Password == Password select LogIn;
                if(query != null)
                {
                    foreach(var item in query)
                    {
                        if(item.Type == "user")
                        {
                            b = true;
                        }
                    }
                    
                }
            }
            return b;
        }
        public Boolean tambahAkun(string type)
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

