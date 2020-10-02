using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpContacticNotices
    {
        public uint Id { get; set; }
        public string Type { get; set; }
        public string Message { get; set; }
        public byte Dismissed { get; set; }
    }
}
