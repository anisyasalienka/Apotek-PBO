using System;
using System.Collections.Generic;

#nullable disable

namespace Apotek_PBO.Models
{
    public partial class ObatKeluar
    {
        public int KeluarId { get; set; }
        public string KeluarNama { get; set; }
        public int KeluarJumlah { get; set; }
        public string KeluarUkuran { get; set; }
        public DateTime KeluarTanggal { get; set; }
        public string KeluarCustomer { get; set; }
    }
}
