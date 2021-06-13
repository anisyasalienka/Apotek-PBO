using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apotek_PBO.Models;

namespace Apotek_PBO
{
    class ObatMasukClass : KetersediaanObatClass
    {
        ObatMasuk model = new ObatMasuk();
        KetersediaanObat ketersediaan = new KetersediaanObat();

        public string MasukNama { get; set; }
        public int MasukJumlah { get; set; }
        public string MasukUkuran { get; set; }
        public DateTime MasukTanggal { get; set; }
        public string MasukPabrik{ get; set; }

        public bool TambahObat()
        {
            bool b = false;
            if( MasukNama != "" && MasukJumlah != 0 && MasukPabrik != "" && MasukUkuran != "")
            {
                model.MasukNama = MasukNama;
                model.MasukJumlah = MasukJumlah;
                model.MasukUkuran = MasukUkuran;
                model.MasukTanggal = MasukTanggal;
                model.MasukPabrik = MasukPabrik;

                using (var db = new DBMedStorageContext())
                {
                    if (MasukNama != "" && MasukJumlah != 0 && MasukUkuran != "" && MasukPabrik != "")
                    {
                        db.ObatMasuks.Add(model);
                        db.SaveChanges();
                        KetersediaanObatClass ketersediaan1 = new KetersediaanObatClass();
                        ketersediaan1.ReadyName = MasukNama;
                        ketersediaan1.ReadyJumlah = MasukJumlah;
                        ketersediaan1.ReadyUkuran = MasukUkuran;
                        ketersediaan1.tambahKetersediaan();
                        b = true;
                    }
                }
            }

            return b;
        }
    }
}
