using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpWoocommerceSessions
    {
        public ulong SessionId { get; set; }
        public string SessionKey { get; set; }
        public string SessionValue { get; set; }
        public ulong SessionExpiry { get; set; }
    }
}
