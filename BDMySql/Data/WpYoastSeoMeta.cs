using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpYoastSeoMeta
    {
        public ulong ObjectId { get; set; }
        public uint? InternalLinkCount { get; set; }
        public uint? IncomingLinkCount { get; set; }
    }
}
