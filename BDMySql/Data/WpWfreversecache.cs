using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpWfreversecache
    {
        public byte[] Ip { get; set; }
        public string Host { get; set; }
        public uint LastUpdate { get; set; }
    }
}
