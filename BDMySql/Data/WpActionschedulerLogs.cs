using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpActionschedulerLogs
    {
        public ulong LogId { get; set; }
        public ulong ActionId { get; set; }
        public string Message { get; set; }
        public DateTime LogDateGmt { get; set; }
        public DateTime LogDateLocal { get; set; }
    }
}
