using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpYoastPrimaryTerm
    {
        public uint Id { get; set; }
        public uint PostId { get; set; }
        public uint TermId { get; set; }
        public string Taxonomy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public long BlogId { get; set; }
    }
}
