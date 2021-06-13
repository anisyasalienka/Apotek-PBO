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
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
            if (this.rbAdmin.Checked)
            {
                this.rbUser.Checked = false;
            }
            else if (this.rbUser.Checked)
            {
                this.rbAdmin.Checked = false;
            }
        }

        private void btnTutupSignin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if(tbPassword.Text == tbUlangPassword.Text && tbPassword.Text != "" && tbUlangPassword.Text != "" && tbUsername.Text != "")
            {
                if (this.rbAdmin.Checked)
                {
                    User user = new User(tbUsername.Text, tbPassword.Text);
                    if (user.tambahAkun("admin"))
                    {
                        MessageBox.Show("Akun sebagai admin berhasil ditambahkan");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Gagal ditambahkan ! ");
                    }
                }
                else if (this.rbUser.Checked)
                {
                    UserPremium userPremium = new UserPremium(tbUsername.Text, tbPassword.Text);
                    if (userPremium.tambahAkun("user"))
                    {
                        MessageBox.Show("Akun sebagai user berhasil ditambahkan");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Gagal ditambahkan ! ");
                    }
                }
            }
            else
            {
                MessageBox.Show("Gagal ditambahkan !");
            }

        }
    }
}
