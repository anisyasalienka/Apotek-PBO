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
    public partial class FormTambahInfoObat : Form
    {
        InformasiObatClass info;
        public enum Mode { Insert, Edit }
        Mode mode;
        public FormTambahInfoObat()
        {
            InitializeComponent();
            mode = Mode.Insert;
            btnTambahTambahInfoObat.Text = "Tambah";
        }

        public FormTambahInfoObat(string nama, string jenis, string komposisi, string kegunaan, string ukuran, int harga)
        {
            InitializeComponent();
            mode = Mode.Edit;
            info = new InformasiObatClass
            {
                ObatName = nama,
                ObatJenis = jenis,
                ObatKomposisi = komposisi,
                ObatKegunaan = kegunaan,
                ObatUkuran = ukuran,
                ObatHarga = harga
            };
            tbNamaTambahInfoObat.Text = nama;
            cbJenisTambahInfoObat.Text = jenis;
            rtbKomposisiTambahInfoObat.Text = komposisi;
            rtbKegunaanTambahInfoObat.Text = kegunaan;
            tbUkuranTambahInfoObat.Text = ukuran;
            tbHargaTambahInfoObat.Text = Convert.ToString(harga);
            btnTambahTambahInfoObat.Text = "Perbaharui";
        }

        //public void ubahInfo()
        //{
       //     using (var db = new DBMedStorageContext())
       //     {
       //         var result = new InformasiObatClass();
       //         result.ObatName = tbNamaTambahInfoObat.Text;
       //         result.ObatJenis = cbJenisTambahInfoObat.Text;
       //         result.ObatKomposisi = rtbKomposisiTambahInfoObat.Text;
       //         result.ObatKegunaan = rtbKegunaanTambahInfoObat.Text;
       //         result.ObatUkuran = tbUkuranTambahInfoObat.Text;
       //         result.ObatHarga = Convert.ToInt32(tbHargaTambahInfoObat.Text);
       //         db.SaveChanges();
       //         MessageBox.Show("Informasi berhasil diperbaharui");
       //         Close();
       //     }
        //}

        private void btnTambahTambahInfoObat_Click(object sender, EventArgs e)
        {
            if(mode == Mode.Insert)
            {
                InformasiObatClass informasiObat = new InformasiObatClass();
                informasiObat.ObatName = tbNamaTambahInfoObat.Text.Trim();
                informasiObat.ObatJenis = cbJenisTambahInfoObat.Text.Trim();
                informasiObat.ObatKomposisi = rtbKomposisiTambahInfoObat.Text.Trim();
                informasiObat.ObatKegunaan = rtbKegunaanTambahInfoObat.Text.Trim();
                informasiObat.ObatUkuran = tbUkuranTambahInfoObat.Text.Trim();
                if (tbHargaTambahInfoObat.Text == "")
                {
                    informasiObat.ObatHarga = 0;
                }
                else
                {
                    informasiObat.ObatHarga = int.Parse(tbHargaTambahInfoObat.Text.Trim());
                }
                if (informasiObat.tambahInfo())
                {
                    MessageBox.Show("Berhasil ditambahkan!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Gagal ditambahkan, isi kolom Nama Obat, Jenis Obat, dan Harga Obat!");
                }
                
            }
            else if(mode == Mode.Edit)
            {
                InformasiObatClass informasiObat = new InformasiObatClass();
                informasiObat.ObatName = tbNamaTambahInfoObat.Text.Trim();
                informasiObat.ObatJenis = cbJenisTambahInfoObat.Text.Trim();
                informasiObat.ObatKomposisi = rtbKomposisiTambahInfoObat.Text.Trim();
                informasiObat.ObatKegunaan = rtbKegunaanTambahInfoObat.Text.Trim();
                informasiObat.ObatUkuran = tbUkuranTambahInfoObat.Text.Trim();
                if (tbHargaTambahInfoObat.Text == "")
                {
                    informasiObat.ObatHarga = 0;
                }
                else
                {
                    informasiObat.ObatHarga = int.Parse(tbHargaTambahInfoObat.Text.Trim());
                }
                if (informasiObat.ubahInfo())
                {
                    MessageBox.Show("Berhasil diperbaharui!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Gagal diperbaharui, isi kolom Nama Obat, Jenis Obat, dan Harga Obat!");
                }
                
                
            }

        }

        private void btnTutupTambahInfoObat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
