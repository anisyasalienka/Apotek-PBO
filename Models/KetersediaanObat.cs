using System;
using System.Collections.Generic;

#nullable disable

namespace Apotek_PBO.Models
{
    public partial class KetersediaanObat
    {
        public int ReadyId { get; set; }
        public string ReadyNama { get; set; }
        public int? ReadyJumlah { get; set; }
        public string ReadyUkuran { get; set; }
    }
}
