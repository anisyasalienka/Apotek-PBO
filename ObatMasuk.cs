using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apotek_PBO
{
    class ObatMasuk
    {
        private int _masukID;
        private string _masukNama;
        private int _masukJumlah;
        private string _masukUkuran;
        private string _masukTanggal;
        private string _masukPabrik;

        public int MasukID
        {
            get { return _masukID; }
        }
        public string MasukNama
        {
            get { return _masukNama; }
            set { _masukNama = value; }
        }
        public int MasukJumlah
        {
            get { return _masukJumlah; }
            set { _masukJumlah = value; }
        }
        public string MasukUkuran
        {
            get { return _masukUkuran; }
            set { _masukUkuran = value; }
        }
        public string MasukTanggal
        {
            get { return _masukTanggal; }
            set { _masukTanggal = value; }
        }
        public string MasukPabrik
        {
            get { return _masukPabrik; }
            set { _masukPabrik = value; }
        }

        public void obatMasuk(string masukNama, int masukJumlah, string masukUkuran, string masukTanggal, string masukPabrik)
        { 
            _masukID = 1;
            MasukNama = masukNama;
            MasukJumlah = masukJumlah;
            MasukUkuran = masukUkuran;
            MasukTanggal = masukTanggal;
            MasukPabrik = masukPabrik;
        }
    }
}
