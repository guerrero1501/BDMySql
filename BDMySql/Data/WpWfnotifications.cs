using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpWfnotifications
    {
        public string Id { get; set; }
        public byte New { get; set; }
        public string Category { get; set; }
        public int Priority { get; set; }
        public uint Ctime { get; set; }
        public string Html { get; set; }
        public string Links { get; set; }
    }
}
