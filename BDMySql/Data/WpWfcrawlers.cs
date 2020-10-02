using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpWfcrawlers
    {
        public byte[] Ip { get; set; }
        public byte[] PatternSig { get; set; }
        public string Status { get; set; }
        public uint LastUpdate { get; set; }
        public string Ptr { get; set; }
    }
}
