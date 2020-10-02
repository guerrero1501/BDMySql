using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpWfsnipcache
    {
        public uint Id { get; set; }
        public string Ip { get; set; }
        public DateTime Expiration { get; set; }
        public string Body { get; set; }
        public uint Count { get; set; }
        public uint Type { get; set; }
    }
}
