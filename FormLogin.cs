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

        private void btnTutupFormLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(1);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserPremium user = new UserPremium(tbUsername.Text,tbPassword.Text);

            if(user.Login())
            {
                this.Hide();
                FormMainMenu formMain = new FormMainMenu();
                formMain.Akun("admin");
                formMain.Show();
            }
            else
            {
                User user1 = new User(tbUsername.Text, tbPassword.Text);
                if(user1.Login())
                {
                    this.Hide();
                    FormMainMenu formMain = new FormMainMenu();
                    formMain.Akun("user");
                    formMain.Show();

                }
                else
                {
                    MessageBox.Show("Login Gagal");
                }
            }
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            FormSignUp formSignUp = new FormSignUp();
            formSignUp.Show();
        }
    }
}
