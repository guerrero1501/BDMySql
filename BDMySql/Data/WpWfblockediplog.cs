using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpWfblockediplog
    {
        public byte[] Ip { get; set; }
        public string CountryCode { get; set; }
        public uint BlockCount { get; set; }
        public uint Unixday { get; set; }
        public string BlockType { get; set; }
    }
}
