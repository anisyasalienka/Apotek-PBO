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
    public partial class FormObatMasuk : Form
    {
        public FormObatMasuk()
        {
            InitializeComponent();
        }

        private void btnTambahMasuk_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda yakin dengan data yang dimasukkan?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if( result == DialogResult.Yes)
            {
                ObatMasukClass obatMasuk = new ObatMasukClass();
                obatMasuk.MasukNama = tbNamaMasuk.Text.Trim();
                obatMasuk.MasukUkuran = tbUkuranMasuk.Text.Trim();
                obatMasuk.MasukTanggal = dtTanggalMasuk.Value;
                obatMasuk.MasukPabrik = tbPabrikMasuk.Text;
                if(tbJumlahMasuk.Text == "")
                {
                    obatMasuk.MasukJumlah = 0;
                }
                else
                {
                    obatMasuk.MasukJumlah = int.Parse(tbJumlahMasuk.Text.Trim());
                }

                if (obatMasuk.TambahObat())
                {
                    MessageBox.Show("Berhasil Ditambahkan ! ");
                    Close();
                }
                else
                {
                    MessageBox.Show("Gagal ditambahkan ! ");
                }
            }
            else
            {
                MessageBox.Show("Batal menambahkan data");
            }


        }

        private void btnTutupMasuk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
