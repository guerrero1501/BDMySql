using System;
using System.Collections.Generic;

namespace BDMySql.Data
{
    public partial class WpWfstatus
    {
        public ulong Id { get; set; }
        public double Ctime { get; set; }
        public byte Level { get; set; }
        public string Type { get; set; }
        public string Msg { get; set; }
    }
}
