using System;
using System.Linq;
using Apotek_PBO.Models;

namespace Apotek_PBO
{
    class KetersediaanObatClass
    {
        KetersediaanObat model = new KetersediaanObat();

   
        private string _readyName;
        private int _readyJumlah;
        private string _readyUkuran;

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

        public void tambahKetersediaan()
        {
            using (var db = new DBMedStorageContext())
            {
                var result = db.KetersediaanObats.SingleOrDefault(k => k.ReadyNama == ReadyName && k.ReadyUkuran == ReadyUkuran);
                if(result != null)
                {
                    result.ReadyJumlah += ReadyJumlah;
                    db.SaveChanges();
                }
                else
                {
                        model.ReadyNama = ReadyName;
                        model.ReadyJumlah = ReadyJumlah;
                        model.ReadyUkuran = ReadyUkuran;
                        
                        db.KetersediaanObats.Add(model);
                        db.SaveChanges();
                }

            }
        }
        public bool kurangKetersediaan()
        {
            bool b = false;
            using(var db = new DBMedStorageContext())
            {
                var result = db.KetersediaanObats.SingleOrDefault(k => k.ReadyNama == ReadyName && k.ReadyUkuran == ReadyUkuran);
                if (result != null)
                {
                    if (result.ReadyJumlah >= ReadyJumlah)
                    {
                        result.ReadyJumlah -= ReadyJumlah;
                        db.SaveChanges();
                        b = true;
                    }

                }
            }

            return b;
        }

    }

}
