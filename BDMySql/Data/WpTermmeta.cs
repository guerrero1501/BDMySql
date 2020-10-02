using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpTermmeta
    {
        public ulong MetaId { get; set; }
        public ulong TermId { get; set; }
        public string MetaKey { get; set; }
        public string MetaValue { get; set; }
    }
}
