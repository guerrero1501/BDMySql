using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpTerms
    {
        public ulong TermId { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public long TermGroup { get; set; }
    }
}
