using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apotek_PBO
{
    class ObatKeluar : KetersediaanObat
    {
        private int _keluarID;
        private string _keluarNama;
        private int _keluarJumlah;
        private string _keluarUkuran;
        private string _keluarTanggal;
        private string _keluarCustomer;

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
        public string KeluarCustomer
        {
            get { return _keluarCustomer; }
            set { _keluarCustomer = value; }
        }

        public void KurangObat(string keluarNama, int keluarJumlah, string keluarUkuran, string keluarTanggal, string keluarCustomer)
        {
            _keluarID = 1;
            KeluarNama = keluarNama;
            KeluarJumlah = keluarJumlah;
            KeluarUkuran = keluarUkuran;
            KeluarTanggal = keluarTanggal;
            KeluarCustomer = keluarCustomer;
        }
    }
}
