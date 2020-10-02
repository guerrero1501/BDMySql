using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpYoastSeoLinks
    {
        public ulong Id { get; set; }
        public string Url { get; set; }
        public ulong PostId { get; set; }
        public ulong TargetPostId { get; set; }
        public string Type { get; set; }
    }
}
