using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpWflivetraffichuman
    {
        public byte[] Ip { get; set; }
        public byte[] Identifier { get; set; }
        public uint Expiration { get; set; }
    }
}
