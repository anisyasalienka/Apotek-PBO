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
    public partial class FormObatKeluar : Form
    {
        public FormObatKeluar()
        {
            InitializeComponent();
        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            ObatKeluar obatKeluar = new ObatKeluar();
            obatKeluar.KeluarNama = tbNamaKeluar.Text;
            obatKeluar.KeluarJumlah = int.Parse(tbJumlahKeluar.Text);
            obatKeluar.KeluarUkuran = tbUkuranKeluar.Text;
            obatKeluar.KeluarTanggal = dtTanggalKeluar.Text;
            obatKeluar.KeluarCustomer = tbCustomer.Text;
            obatKeluar.KurangObat(obatKeluar.KeluarNama, obatKeluar.KeluarJumlah, obatKeluar.KeluarUkuran, obatKeluar.KeluarTanggal, obatKeluar.KeluarCustomer);
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
