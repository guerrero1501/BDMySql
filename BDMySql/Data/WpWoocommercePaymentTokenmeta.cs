using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpWoocommercePaymentTokenmeta
    {
        public ulong MetaId { get; set; }
        public ulong PaymentTokenId { get; set; }
        public string MetaKey { get; set; }
        public string MetaValue { get; set; }
    }
}
