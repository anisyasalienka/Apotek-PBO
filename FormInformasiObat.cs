using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Apotek_PBO.Models;

namespace Apotek_PBO
{

    public partial class FormInformasiObat : Form
    {
        public enum Mode { Admin, User }
        Mode mode;
        public FormInformasiObat()
        {
            InitializeComponent();
            btnUbahInformasiObat.Enabled = false;
            btnHapusInformasiObat.Enabled = false;
            mode = Mode.Admin;
        }


        private void FormInformasiObat_Load(object sender, EventArgs e)
        {
            using var db = new DBMedStorageContext();

            var informasiObatData = from c in db.InformasiObats select c; 

            if(informasiObatData != null)
            {
                if (informasiObatData.Count() > 0)
                {
                    dgInformasiObat.DataSource = informasiObatData.ToList();
                }
                else
                {
                    MessageBox.Show("Tidak ada data yang ditemukan");
                    dgInformasiObat.DataSource = null;
                }
            }
        }

        void btnCariInformasiObat_Click(object sender, EventArgs e)
        {
            lblNamaObatInfoObat.Text = "-";
            lblJenisObatInfoObat.Text = "-";
            lblKomposisiObatInfoObat.Text = "-";
            lblKegunaanObatInfoObat.Text = "-";
            lblUkuranObatInfoObat.Text = "-";
            lblHargaObatInfoObat.Text = "-";
            btnUbahInformasiObat.Enabled = false;
            btnHapusInformasiObat.Enabled = false;
            using (var db = new DBMedStorageContext())
            {
                var query = from InformasiObat in db.InformasiObats where InformasiObat.ObatNama == tbCariInformasiObat.Text.Trim() && InformasiObat.ObatUkuran == tbCariUkuranInfo.Text.Trim() select InformasiObat;
                foreach (var item in query)
                {
                    lblNamaObatInfoObat.Text = item.ObatNama;
                    lblJenisObatInfoObat.Text = item.ObatJenis;
                    lblKomposisiObatInfoObat.Text = item.ObatKomposisi;
                    lblKegunaanObatInfoObat.Text = item.ObatKegunaan;
                    lblUkuranObatInfoObat.Text = item.ObatUkuran;
                    lblHargaObatInfoObat.Text = item.ObatHarga.ToString();
                    if(mode == Mode.Admin)
                    {
                        btnUbahInformasiObat.Enabled = true;
                        btnHapusInformasiObat.Enabled = true;
                    }

                }

            }
        }

        private void btnUbahInformasiObat_Click(object sender, EventArgs e)
        {
 
            FormTambahInfoObat InfoObatForm = new FormTambahInfoObat(lblNamaObatInfoObat.Text, lblJenisObatInfoObat.Text, 
                lblKomposisiObatInfoObat.Text, lblKegunaanObatInfoObat.Text, lblUkuranObatInfoObat.Text, Convert.ToInt32(lblHargaObatInfoObat.Text));
            InfoObatForm.ShowDialog();
        }

        private void btnHapusInformasiObat_Click(object sender, EventArgs e)
        {
            using (var db = new DBMedStorageContext())
            {
                db.InformasiObats.RemoveRange(db.InformasiObats.Where(item => item.ObatNama == lblNamaObatInfoObat.Text && item.ObatUkuran == lblUkuranObatInfoObat.Text));
                db.SaveChanges();
                lblNamaObatInfoObat.Text = "-";
                lblJenisObatInfoObat.Text = "-";
                lblKomposisiObatInfoObat.Text = "-";
                lblKegunaanObatInfoObat.Text = "-";
                lblHargaObatInfoObat.Text = "-";
                lblUkuranObatInfoObat.Text = "-";
                btnUbahInformasiObat.Enabled = false;
                btnHapusInformasiObat.Enabled = false;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //FormInformasiObat form = new FormInformasiObat();
            //form.FormInformasiObat_Load(sender, e);
        }
        public void Akun()
        {
            mode = Mode.User;
        }
    }
}
