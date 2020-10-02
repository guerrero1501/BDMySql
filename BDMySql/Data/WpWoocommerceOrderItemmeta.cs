using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpWoocommerceOrderItemmeta
    {
        public ulong MetaId { get; set; }
        public ulong OrderItemId { get; set; }
        public string MetaKey { get; set; }
        public string MetaValue { get; set; }
    }
}
