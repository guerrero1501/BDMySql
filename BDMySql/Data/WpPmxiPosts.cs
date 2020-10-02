using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpPmxiPosts
    {
        public ulong Id { get; set; }
        public ulong PostId { get; set; }
        public ulong ImportId { get; set; }
        public string UniqueKey { get; set; }
        public string ProductKey { get; set; }
        public long Iteration { get; set; }
        public bool Specified { get; set; }
    }
}
