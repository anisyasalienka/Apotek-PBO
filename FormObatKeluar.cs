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
            DialogResult result = MessageBox.Show("Apakah anda yakin dengan data yang dimasukkan?","", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                ObatKeluarClass obatKeluar = new ObatKeluarClass();
                obatKeluar.KeluarNama = tbNamaKeluar.Text.Trim();
                obatKeluar.KeluarUkuran = tbUkuranKeluar.Text.Trim();
                obatKeluar.KeluarTanggal = dtTanggalKeluar.Value;
                obatKeluar.KeluarCustomer = tbCustomer.Text.Trim();
                if (tbJumlahKeluar.Text == "")
                {
                    obatKeluar.KeluarJumlah = 0;
                }
                else
                {
                    obatKeluar.KeluarJumlah = int.Parse(tbJumlahKeluar.Text.Trim());
                }
                if (obatKeluar.KurangObat())
                {
                    MessageBox.Show("Berhasil Dikurangkan ! ");
                    Close();
                }
                else
                {
                    MessageBox.Show("Gagal dikurangkan ! ");
                }
            }
            else
            {
                MessageBox.Show("Batal mengurangi data");
            }
            

        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
