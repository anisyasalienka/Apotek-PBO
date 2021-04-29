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
    public partial class FormTambahInfoObat : Form
    {
        public FormTambahInfoObat()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            InformasiObat informasiObat = new InformasiObat();
            informasiObat.ObatName = tbObatName.Text;
            informasiObat.ObatJenis = cbObatJenis.Text;
            informasiObat.ObatKomposisi = rtbObatKomposisi.Text;
            informasiObat.ObatKegunaan = tbObatKegunaan.Text;
            informasiObat.ObatHarga = int.Parse(tbObatHarga.Text);
            informasiObat.tambahInfo(informasiObat.ObatName, informasiObat.ObatJenis, informasiObat.ObatKomposisi, informasiObat.ObatKegunaan, informasiObat.ObatHarga);
        }
    }
}
