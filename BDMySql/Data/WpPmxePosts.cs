using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpPmxePosts
    {
        public ulong Id { get; set; }
        public ulong PostId { get; set; }
        public ulong ExportId { get; set; }
        public long Iteration { get; set; }
    }
}
