using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apotek_PBO
{
    class InformasiObat
    {
        private int _obatID;
        private string _obatName;
        private string _obatJenis;
        private string _obatKomposisi;
        private string _obatKegunaan;
        private int _obatHarga;

        public int ObatID
        {
            get { return _obatID; }
        }
        public string ObatName
        {
            get { return _obatName; }
            set { _obatName = value; }
        }
        public  string ObatJenis
        {
            get { return _obatJenis; }
            set { _obatJenis = value; }
        }
        public string ObatKomposisi
        {
            get { return _obatKomposisi; }
            set { _obatKomposisi = value; }
        }
        public string ObatKegunaan
        {
            get { return _obatKegunaan; }
            set { _obatKegunaan = value; }
        }
        public int ObatHarga
        {
            get { return _obatHarga; }
            set { _obatHarga = value; }
        }
        public void tambahInfo(string obatName, string obatJenis, string obatKomposisi, string obatKegunaan, int obatHarga)
        {
            _obatID = 1;
            ObatName = obatName;
            ObatJenis = obatJenis;
            ObatKomposisi = obatKomposisi;
            ObatKegunaan = obatKegunaan;
            ObatHarga = obatHarga;
        }
        public void lihatInfo() { }

    }

}
