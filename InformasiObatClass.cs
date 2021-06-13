using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apotek_PBO.Models;

namespace Apotek_PBO
{
    class InformasiObatClass
    {
        InformasiObat model = new InformasiObat();
        public string ObatName{ get; set; }
        public  string ObatJenis { get; set; }
        public string ObatKomposisi{ get; set; }
        public string ObatKegunaan{ get; set; }
        public string ObatUkuran { get; set;  }
        public int ObatHarga { get; set; }
        public bool tambahInfo()
        {
            bool b = false;
            if(ObatName != "" && ObatJenis != "" && ObatHarga != 0)
            {
                model.ObatNama = ObatName;
                model.ObatJenis = ObatJenis;
                model.ObatKomposisi = ObatKomposisi;
                model.ObatKegunaan = ObatKegunaan;
                model.ObatUkuran = ObatUkuran;
                model.ObatHarga = ObatHarga;
                using (var db = new DBMedStorageContext())
                {
                    db.InformasiObats.Add(model);
                    db.SaveChanges();
                    b = true;
                }
            }

            return b;
        }
        public bool ubahInfo()
        {
            bool b = false;
            using(var db = new DBMedStorageContext())
            {
                var result = db.InformasiObats.SingleOrDefault(info => info.ObatNama == ObatName && info.ObatUkuran == ObatUkuran);
                if(result != null)
                {
                    if(ObatName != "" && ObatJenis != "" && ObatHarga != 0)
                    {
                        result.ObatNama = ObatName;
                        result.ObatJenis = ObatJenis;
                        result.ObatKegunaan = ObatKegunaan;
                        result.ObatKomposisi = ObatKomposisi;
                        result.ObatUkuran = ObatUkuran;
                        result.ObatHarga = ObatHarga;
                        db.SaveChanges();

                        b = true;
                    }

                }
            }
            return b;
        }

    }

}
