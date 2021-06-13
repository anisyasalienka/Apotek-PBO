using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Apotek_PBO.Models;

namespace Apotek_PBO
{
    public partial class FormKetersediaanObat : Form
    {
        public enum Mode { Admin, User }
        Mode mode;

        public FormKetersediaanObat()
        {
            InitializeComponent();
            btnHapusKetersediaanObat.Enabled = false;
            mode = Mode.Admin;
        }

        private void FormKetersediaanObat_Load(object sender, EventArgs e)
        {
            using var db = new DBMedStorageContext();

            var ketersediaanObatData = from c in db.KetersediaanObats select c;

            if (ketersediaanObatData != null)
            {
                if (ketersediaanObatData.Count() > 0)
                {
                    dgKetersediaanObat.DataSource = ketersediaanObatData.ToList();
                }
                else
                {
                    MessageBox.Show("Tidak ada data yang ditemukan");
                    dgKetersediaanObat.DataSource = null;
                }
            }
        }

        private void btnCariKetersediaanObat_Click(object sender, EventArgs e)
        {
            lblNamaObatKetersediaanObat.Text = "-";
            lblJumlahObatKetersediaanObat.Text = "-";
            lblUkuranObatKetersediaanObat.Text = "-";
            btnHapusKetersediaanObat.Enabled = false;
            using (var db = new DBMedStorageContext())
            {
                var query = from KetersediaanObat in db.KetersediaanObats where KetersediaanObat.ReadyNama == tbCariKetersediaanObat.Text.Trim() && KetersediaanObat.ReadyUkuran == tbCariUkuran.Text.Trim() select KetersediaanObat;
                foreach (var item in query)
                {
                    lblNamaObatKetersediaanObat.Text = item.ReadyNama;
                    lblJumlahObatKetersediaanObat.Text = item.ReadyJumlah.ToString();
                    lblUkuranObatKetersediaanObat.Text = item.ReadyUkuran;
                    if(mode == Mode.Admin)
                    {
                        btnHapusKetersediaanObat.Enabled = true;
                    }
              
                }
            }
        }

        private void btnHapusKetersediaanObat_Click(object sender, EventArgs e)
        {
            using (var db = new DBMedStorageContext())
            {
                db.KetersediaanObats.RemoveRange(db.KetersediaanObats.Where(item => item.ReadyNama == lblNamaObatKetersediaanObat.Text));
                db.SaveChanges();
                lblNamaObatKetersediaanObat.Text = "-";
                lblJumlahObatKetersediaanObat.Text = "-";
                lblUkuranObatKetersediaanObat.Text = "-";
                btnHapusKetersediaanObat.Enabled = false;
            }
        }
        public void Akun()
        {
            mode = Mode.User;
        }

    }
}
