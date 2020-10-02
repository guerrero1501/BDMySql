using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpWoocommerceApiKeys
    {
        public ulong KeyId { get; set; }
        public ulong UserId { get; set; }
        public string Description { get; set; }
        public string Permissions { get; set; }
        public string ConsumerKey { get; set; }
        public string ConsumerSecret { get; set; }
        public string Nonces { get; set; }
        public string TruncatedKey { get; set; }
        public DateTime? LastAccess { get; set; }
    }
}
