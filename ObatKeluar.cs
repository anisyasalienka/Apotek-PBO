using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apotek_PBO
{
    class ObatKeluar
    {
        private int _keluarID;
        private string _keluarNama;
        private int _keluarJumlah;
        private string _keluarUkuran;
        private string _keluarTanggal;
        private string _keluarPabrik;

        public int KeluarID
        {
            get { return _keluarID; }
        }
        public string KeluarNama
        {
            get { return _keluarNama; }
            set { _keluarNama = value; }
        }
        public int KeluarJumlah
        {
            get { return _keluarJumlah; }
            set { _keluarJumlah = value; }
        }
        public string KeluarUkuran
        {
            get { return _keluarUkuran; }
            set { _keluarUkuran = value; }
        }
        public string KeluarTanggal
        {
            get { return _keluarTanggal; }
            set { _keluarTanggal = value; }
        }
        public string KeluarPabrik
        {
            get { return _keluarPabrik; }
            set { _keluarPabrik = value; }
        }

        public void obatKeluar(string keluarNama, int keluarJumlah, string keluarUkuran, string keluarTanggal, string keluarPabrik)
        {
            _keluarID = 1;
            KeluarNama = keluarNama;
            KeluarJumlah = keluarJumlah;
            KeluarUkuran = keluarUkuran;
            KeluarTanggal = keluarTanggal;
            KeluarPabrik = keluarPabrik;
        }
    }
}
