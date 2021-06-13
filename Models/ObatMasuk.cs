using System;
using System.Collections.Generic;

#nullable disable

namespace Apotek_PBO.Models
{
    public partial class ObatMasuk
    {
        public int MasukId { get; set; }
        public string MasukNama { get; set; }
        public int MasukJumlah { get; set; }
        public string MasukUkuran { get; set; }
        public DateTime MasukTanggal { get; set; }
        public string MasukPabrik { get; set; }
    }
}
