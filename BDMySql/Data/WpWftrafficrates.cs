using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpWftrafficrates
    {
        public uint EMin { get; set; }
        public byte[] Ip { get; set; }
        public string HitType { get; set; }
        public uint Hits { get; set; }
    }
}
