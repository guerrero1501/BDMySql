using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpWoocommercePaymentTokens
    {
        public ulong TokenId { get; set; }
        public string GatewayId { get; set; }
        public string Token { get; set; }
        public ulong UserId { get; set; }
        public string Type { get; set; }
        public bool IsDefault { get; set; }
    }
}
