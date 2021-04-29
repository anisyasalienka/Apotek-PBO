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
            ObatMasuk obatMasuk = new ObatMasuk();
            obatMasuk.MasukNama = tbNamaMasuk.Text;
            obatMasuk.MasukJumlah = int.Parse(tbJumlahMasuk.Text);
            obatMasuk.MasukUkuran = tbUkuranMasuk.Text;
            obatMasuk.MasukTanggal = dtTanggalMasuk.Text;
            obatMasuk.MasukPabrik = tbPabrikMasuk.Text;
            obatMasuk.TambahObat(obatMasuk.MasukNama, obatMasuk.MasukJumlah, obatMasuk.MasukUkuran, obatMasuk.MasukTanggal, obatMasuk.MasukPabrik);
        }

        private void btnTutupMasuk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
