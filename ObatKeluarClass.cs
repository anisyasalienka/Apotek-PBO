using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apotek_PBO.Models;

namespace Apotek_PBO
{
    class ObatKeluarClass : KetersediaanObatClass
    {
        ObatKeluar model = new ObatKeluar();
        KetersediaanObat ketersediaan = new KetersediaanObat();

        public string KeluarNama{ get; set; }
        public int KeluarJumlah{ get; set; }
        public string KeluarUkuran { get; set; }
        public DateTime KeluarTanggal { get; set; }
        public string KeluarCustomer { get; set; }

        public bool KurangObat()
        {   if( KeluarNama != "" && KeluarJumlah != 0  && KeluarUkuran != "" && KeluarCustomer != "")
            {
                model.KeluarNama = KeluarNama;
                model.KeluarJumlah = KeluarJumlah;
                model.KeluarUkuran = KeluarUkuran;
                model.KeluarTanggal = KeluarTanggal;
                model.KeluarCustomer = KeluarCustomer;
                using (var db = new DBMedStorageContext())
                {
                    KetersediaanObatClass ketersediaan1 = new KetersediaanObatClass();
                    ketersediaan1.ReadyName = KeluarNama;
                    ketersediaan1.ReadyJumlah = KeluarJumlah;
                    ketersediaan1.ReadyUkuran = KeluarUkuran;

                    if (ketersediaan1.kurangKetersediaan())
                    {
                        db.ObatKeluars.Add(model);
                        db.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            else
            {
                return false;
            }
        }
    }
}
