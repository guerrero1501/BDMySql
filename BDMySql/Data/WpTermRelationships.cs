using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpTermRelationships
    {
        public ulong ObjectId { get; set; }
        public ulong TermTaxonomyId { get; set; }
        public int TermOrder { get; set; }
    }
}
