using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpUsermeta
    {
        public ulong UmetaId { get; set; }
        public ulong UserId { get; set; }
        public string MetaKey { get; set; }
        public string MetaValue { get; set; }
    }
}
