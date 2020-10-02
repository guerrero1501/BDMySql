using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpWfissues
    {
        public uint Id { get; set; }
        public uint Time { get; set; }
        public uint LastUpdated { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public byte Severity { get; set; }
        public string IgnoreP { get; set; }
        public string IgnoreC { get; set; }
        public string ShortMsg { get; set; }
        public string LongMsg { get; set; }
        public string Data { get; set; }
    }
}
