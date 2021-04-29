using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apotek_PBO
{
    class KetersediaanObat
    {
        private int _readyID;
        private string _readyName;
        private int _readyJumlah;
        private string _readyUkuran;

        public int ReadyID
        {
            get { return _readyID; }
        }
        public string ReadyName
        {
            get { return _readyName; }
            set { _readyName = value; }
        }
        public int ReadyJumlah
        {
            get { return _readyJumlah; }
            set { _readyJumlah = value; }
        }
        public string ReadyUkuran
        {
            get { return _readyUkuran; }
            set { _readyUkuran = value; }
        }
        public void TambahObat(string readyName, int readyJumlah, string readyUkuran )
        {
            _readyID = 1;
            ReadyName = readyName;
            ReadyJumlah += readyJumlah;
            ReadyUkuran = readyUkuran;
        }
        public void KurangObat(string readyName, int readyJumlah, string readyUkuran)
        {
            _readyID = 1;
            ReadyName = readyName;
            ReadyJumlah -= readyJumlah;
            ReadyUkuran = readyUkuran;
        }

    }
}
