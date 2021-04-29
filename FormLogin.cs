using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apotek_PBO
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User(tbUsername.Text,tbPassword.Text);

            if(user.Login(user.UserName, user.Password))
            {
                //MessageBox.Show("Login Berhasil, ID anda adalah " + user.UserID.ToString());
                FormInformasiObat form3 = new FormInformasiObat();
                form3.Show();
            }
            else
            {
                MessageBox.Show("Login Gagal");
            }
        }
    }
}
