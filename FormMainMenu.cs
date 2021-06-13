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
    public partial class FormMainMenu : Form
    {
        public enum Mode {Admin, User}
        Mode mode;

        public FormMainMenu()
        {
            InitializeComponent();
            mode = Mode.Admin;
        }

        private void btnObatMasuk_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FormObatMasuk formObatMasuk = new FormObatMasuk();
            formObatMasuk.TopLevel = false;
            panel1.Controls.Add(formObatMasuk);
            formObatMasuk.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formObatMasuk.Dock = DockStyle.Fill;
            formObatMasuk.Show();
        }

        private void btnObatKeluar_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FormObatKeluar formObatKeluar = new FormObatKeluar();
            formObatKeluar.TopLevel = false;
            panel1.Controls.Add(formObatKeluar);
            formObatKeluar.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formObatKeluar.Dock = DockStyle.Fill;
            formObatKeluar.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Close();
        }

        private void btnTambahInfoObat_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FormTambahInfoObat formTambahInfoObat = new FormTambahInfoObat();
            formTambahInfoObat.TopLevel = false;
            panel1.Controls.Add(formTambahInfoObat);
            formTambahInfoObat.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formTambahInfoObat.Dock = DockStyle.Fill;
            formTambahInfoObat.Show();

        }

        private void btnInformasiObat_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FormInformasiObat formInformasiObat = new FormInformasiObat();
            //formInformasiObat.
            formInformasiObat.TopLevel = false;
            panel1.Controls.Add(formInformasiObat);
            formInformasiObat.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formInformasiObat.Dock = DockStyle.Fill;
            formInformasiObat.Show();
            if (mode == Mode.User)
            {
                formInformasiObat.Akun();
            }

        }

        private void btnDataObatMasuk_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FormDataObatMasuk formDataObatMasuk = new FormDataObatMasuk();
            formDataObatMasuk.TopLevel = false;
            panel1.Controls.Add(formDataObatMasuk);
            formDataObatMasuk.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formDataObatMasuk.Dock = DockStyle.Fill;
            formDataObatMasuk.Show();
        }

        private void btnDataObatKeluar_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FormDataObatKeluar formDataObatKeluar = new FormDataObatKeluar();
            formDataObatKeluar.TopLevel = false;
            panel1.Controls.Add(formDataObatKeluar);
            formDataObatKeluar.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formDataObatKeluar.Dock = DockStyle.Fill;
            formDataObatKeluar.Show();
        }

        private void btnKetersediaanObat_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FormKetersediaanObat formKetersediaanObat = new FormKetersediaanObat();
            formKetersediaanObat.TopLevel = false;
            panel1.Controls.Add(formKetersediaanObat);
            formKetersediaanObat.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formKetersediaanObat.Dock = DockStyle.Fill;
            formKetersediaanObat.Show();
            if (mode == Mode.User)
            {
                formKetersediaanObat.Akun();
            }
        }
        public void Akun(string type)
        {
            if(type == "user")
            {
                btnDataObatKeluar.Enabled = false;
                btnDataObatMasuk.Enabled = false;
                btnTambahInfoObat.Enabled = false;
                btnObatMasuk.Enabled = false;
                btnObatKeluar.Enabled = false;
                mode = Mode.User;
            }
        }
    }
}
