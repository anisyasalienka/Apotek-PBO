using System;
using System.Collections.Generic;

#nullable disable

namespace Apotek_PBO.Models
{
    public partial class InformasiObat
    {
        public int ObatId { get; set; }
        public string ObatNama { get; set; }
        public string ObatJenis { get; set; }
        public string ObatKomposisi { get; set; }
        public string ObatKegunaan { get; set; }
        public string ObatUkuran { get; set; }
        public int ObatHarga { get; set; }
    }
}
