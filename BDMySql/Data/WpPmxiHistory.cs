using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpPmxiHistory
    {
        public ulong Id { get; set; }
        public ulong ImportId { get; set; }
        public string Type { get; set; }
        public string TimeRun { get; set; }
        public DateTime Date { get; set; }
        public string Summary { get; set; }
    }
}
