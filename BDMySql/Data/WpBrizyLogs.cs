using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpBrizyLogs
    {
        public long Id { get; set; }
        public string Type { get; set; }
        public string Message { get; set; }
        public string Context { get; set; }
        public string SessionId { get; set; }
        public DateTime Date { get; set; }
    }
}
