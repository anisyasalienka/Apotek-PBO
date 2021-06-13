using System;
using System.Collections.Generic;

#nullable disable

namespace Apotek_PBO.Models
{
    public partial class LogIn
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
    }
}
